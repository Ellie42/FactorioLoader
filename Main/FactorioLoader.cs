using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using FactorioLoader.Main.Database;
using FactorioLoader.Main.Forms;
using FactorioLoader.Main.Models.Config;
using FactorioLoader.Main.Models.Mods;
using FactorioLoader.Main.Models.Profile;
using FactorioLoader.Main.Services;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FactorioLoader.Main
{
    public class FactorioLoader
    {
        public ModProfileService Profiles;
        public LoaderConfig Config;
        public ModService Mods;
        public DatabaseFacade Db;
        public MainForm MainForm;

        public FactorioLoader()
        {
            SetupDb();

            Profiles = new ModProfileService();
            Mods = new ModService();
            Config = new LoaderConfig();
        }

        /// <summary>
        /// Run the initial Migrations if the DB does not exist
        /// </summary>
        private void SetupDb()
        {
            Db = new DatabaseFacade("./Db/fml-Db.sqlite");

            if (!File.Exists("./Db/fml-Db.sqlite"))
            {
                Db.Setup(new ModDatabaseSetup());
            }
        }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();

            var controller = new ApplicationController(MainForm);
            controller.StartupNextInstance += NewInstanceOpened;

            var args = Environment.GetCommandLineArgs();

            controller.Run(args);
        }

        private void NewInstanceOpened(object sender, StartupNextInstanceEventArgs e)
        {
            var controller = sender as ApplicationController;
            var args = e.CommandLine;

            if (args.Count > 1)
            {
                ImportFromArgs(args);
            }
        }

        /// <summary>
        /// Import a mod from cli arguments
        /// </summary>
        /// <param name="args"></param>
        private void ImportFromArgs(ReadOnlyCollection<string> args)
        {
            var factorioBase64 = Regex.Match(args[1], @"factoriomods:\/*?([a-zA-Z0-9=]+)");
            if (factorioBase64.Groups.Count <= 1) return;

            var jsonBytes = Convert.FromBase64String(factorioBase64.Groups[1].ToString());
            var jsonString = System.Text.Encoding.Default.GetString(jsonBytes);
            var json = JsonConvert.DeserializeObject<JObject>(jsonString);

            var mod = new Mod(json);
            if (!mod.HaveFiles)
            {
                MainForm.ShowForm(new ImportModForm(mod));
            }
        }

        public void RunApp()
        {
            Config.Load();

            //Check if the directories are set and request them if they are not
            Config.RequestUnsetPaths();
            Config.SaveChanges();

            //Load and prepare all mod data
            Mods.Init();

            //Load and prepare profile data
            Profiles.Init();
        }
    }
    public class ApplicationController : WindowsFormsApplicationBase
    {
        private Form mainForm;
        public ApplicationController(Form form)
        {
            //We keep a reference to main form 
            //To run and also use it when we need to bring to front
            mainForm = form;
            this.IsSingleInstance = true;
            this.StartupNextInstance += this_StartupNextInstance;
        }

        void this_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            // Copy the arguments to a string array
            string[] args = new string[e.CommandLine.Count];
            e.CommandLine.CopyTo(args, 0);

            //Here we bring application to front
            e.BringToForeground = true;
            mainForm.ShowInTaskbar = true;
            mainForm.WindowState = FormWindowState.Minimized;
            mainForm.Show();
            mainForm.WindowState = FormWindowState.Normal;

        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = mainForm;
            if (CommandLineArgs.Count <= 1) return; 
            this.CommandLineArgs.CopyTo(((MainForm)this.MainForm).Args, 0);
        }
    }
}