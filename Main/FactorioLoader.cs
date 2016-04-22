using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FactorioLoader.Main.Database;
using FactorioLoader.Main.Forms;
using FactorioLoader.Main.Models.Config;
using FactorioLoader.Main.Models.Mods;
using FactorioLoader.Main.Services;
using MetroFramework;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
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
        public bool IsProtocolHandler;

        public FactorioLoader()
        {
            Profiles = new ModProfileService();
            Mods = new ModService();
            Config = new LoaderConfig();
        }

        /// <summary>
        /// Add the protocol handler key to the registry using ProtocolHandler.exe
        /// </summary>
        public void TryAddProtocolHandler()
        {
            using (var key = Registry.ClassesRoot.OpenSubKey("factoriomods"))
            {
                IsProtocolHandler = IsProtocolHandlerThis(key);
                if (key != null && IsProtocolHandler) return;

                RequestProtocolAccess();
            }
        }

        /// <summary>
        /// If there is a protocol handler for factoriomods already in place then
        /// check if it's for this application and return bool
        /// </summary>
        /// <param name="topKey"></param>
        /// <returns></returns>
        protected static bool IsProtocolHandlerThis(RegistryKey topKey)
        {
            var commandKey = topKey?.OpenSubKey("shell\\open\\command");
            if (commandKey != null)
            {
                var commandString = commandKey.GetValue("");

                //TODO make this a little more specific maybe
                return Regex.IsMatch(commandString.ToString(), "FactorioLoader.exe");
            }

            return false;
        }

        /// <summary>
        /// Ask the user if they want to associate this app with factoriomods protocol
        /// </summary>
        /// <returns></returns>
        private void RequestProtocolAccess()
        {
            var res = MetroMessageBox.Show(MainForm, @"Would you like to use Factorio Loader with factoriomods.com? You can change this setting at any time.",
                     "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.Verb = "runas";
                processInfo.FileName = "ProtocolHandler.exe";
                processInfo.CreateNoWindow = true;
                processInfo.Arguments = $"create \"{System.Reflection.Assembly.GetEntryAssembly().Location}\"";
                var process = Process.Start(processInfo);

                while (process != null && !process.HasExited)
                {
                    
                }
                IsProtocolHandler = true;
            }
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
            var codebase = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;

            var directoryName = Path.GetDirectoryName(codebase);

            if (directoryName != null)
            {
                var workingDir = directoryName.Substring(6);

                Directory.SetCurrentDirectory(workingDir);
            }

            SetupDb();
            SetupFolders();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm {Args = Environment.GetCommandLineArgs()};

            var controller = new ApplicationController(MainForm);
            controller.StartupNextInstance += NewInstanceOpened;

            var args = Environment.GetCommandLineArgs();

            controller.Run(args);
        }

        /// <summary>
        /// Set up all the required folders if they do not exist
        /// </summary>
        private void SetupFolders()
        {
            if (!Directory.Exists(Config.ArchiveFolder)) Directory.CreateDirectory(Config.ArchiveFolder);
        }

        private void NewInstanceOpened(object sender, StartupNextInstanceEventArgs e)
        {
//            var controller = sender as ApplicationController;
            var args = e.CommandLine;

            if (args.Count > 1)
            {
                ImportFromArgs(args);
            }
        }

        /// <summary>
        /// Import a Mod from cli arguments
        /// </summary>
        /// <param name="args"></param>
        private void ImportFromArgs(ReadOnlyCollection<string> args)
        {
            if (args.Count <= 1) return;

            var factorioBase64 = Regex.Match(args[1], @"factoriomods:\/\/(.*)");
            
            if (factorioBase64.Groups.Count <= 1) return;

            var base64String = factorioBase64.Groups[1].ToString().TrimEnd('/');

            byte[] jsonBytes;

            //If jsonstring is invalid base64 then ignore it.
            try
            {
                jsonBytes = Convert.FromBase64String(base64String);
            }
            catch (Exception)
            {
                return;
            }

            var jsonString = System.Text.Encoding.Default.GetString(jsonBytes);
            var json = JsonConvert.DeserializeObject<JObject>(jsonString);
            var mod = new Mod(json);

            if (Mods.FindModInAvailable(mod.Name, mod.Version) != null)
            {
                MainForm.ShowMessage($"{mod.Title??mod.Name} has already been added");
                return;
            }

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

            //Load and prepare all Mod data
            Mods.Init();

            //Load and prepare profile data
            Profiles.Init();
            ImportFromArgs(Array.AsReadOnly(MainForm.Args));

            TryAddProtocolHandler();
        }
    }
    public class ApplicationController : WindowsFormsApplicationBase
    {
        private readonly Form mainForm;
        public ApplicationController(Form form)
        {
            //We keep a reference to main form 
            //To run and also use it when we need to bring to front
            mainForm = form;
            IsSingleInstance = true;
            StartupNextInstance += this_StartupNextInstance;
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
            MainForm = mainForm;
            if (CommandLineArgs.Count <= 1) return; 
            CommandLineArgs.CopyTo(((MainForm)MainForm).Args, 0);
        }
    }
}