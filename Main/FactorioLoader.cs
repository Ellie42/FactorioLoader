using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using FactorioLoader.Main.Database;
using FactorioLoader.Main.Forms;
using FactorioLoader.Main.Models.Config;
using FactorioLoader.Main.Models.Profile;
using FactorioLoader.Main.Services;
using Application = System.Windows.Forms.Application;

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
            MainForm = new MainForm();

            Application.Run(MainForm);
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
}