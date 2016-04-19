using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using FactorioLoader.Main.Database;

namespace FactorioLoader.Main.Models.Config
{
    public class LoaderConfig : Saveable
    {
        protected DatabaseFacade Db;
        public string ModFolder;
        public string ReserveFolder => ModFolder + "\\000-FL-Available-Mods";
        public string ExecutablePath;
        public string DefaultProfile;
        private bool changed = false;

        /// <summary>
        /// Load the loader configuration from the DB
        /// </summary>
        public void Load()
        {
            Db = App.FactorioLoader.Db;

            GetConfigFromDb();
        }

        /// <summary>
        /// Set the config properties using DB
        /// </summary>
        /// <returns></returns>
        private void GetConfigFromDb()
        {
            var sql = "SELECT * FROM config";
            using (var connection = new SQLiteConnection(Db.DbString))
            {
                using (var getConfigSql = new SQLiteCommand(sql, connection))
                {
                    connection.Open();
                    var reader = getConfigSql.ExecuteReader(CommandBehavior.SingleRow);
                    SetConfig(reader);
                    reader.Close();
                    connection.Dispose();
                }
            }
        }

        /// <summary>
        /// Set this object's config properties using SQLite results
        /// </summary>
        /// <param name="reader"></param>
        private void SetConfig(SQLiteDataReader reader)
        {
            while (reader.Read())
            {
                DefaultProfile = reader.GetString(1);
                //Allows the field to be null... probably a better way
                ModFolder = reader[2] as string;
                ExecutablePath = reader[3] as string;
            }
        }

        /// <summary>
        /// Check for unset path properties, if found then show a prompt for the 
        /// user to locate the path
        /// </summary>
        public void RequestUnsetPaths()
        {
            if (ModFolder==null||ModFolder.Length <= 0)
            {
                RequestModFolder();
            }
            if (ModFolder==null)
            {
                Application.Exit();
            }
            if (ExecutablePath==null||ExecutablePath.Length <= 0)
            {
                RequestExecutableFolder();
            }
        }

        /// <summary>
        /// Show the file browser dialog for factorio.exe
        /// </summary>
        public void RequestExecutableFolder()
        {
            var filePrompt = new OpenFileDialog();
            filePrompt.Multiselect = false;
            filePrompt.Title = @"Select factorio.exe";
            if (filePrompt.ShowDialog(App.FactorioLoader.MainForm) == DialogResult.OK)
            {
                ExecutablePath = filePrompt.FileName;
                changed = true;
            }
        }

        /// <summary>
        /// Show the folder browser dialog for the mod folder
        /// </summary>
        public void RequestModFolder()
        {
            var folderPrompt = new FolderBrowserDialog();
            folderPrompt.Description = @"Select the folder where Factorio stores mods";
            folderPrompt.ShowNewFolderButton = false;

            if (folderPrompt.ShowDialog(App.FactorioLoader.MainForm) == DialogResult.OK)
            {
                ModFolder = folderPrompt.SelectedPath;
                changed = true;
            }
        }

        /// <summary>
        /// If the config has changed since last saved then save to the DB
        /// </summary>
        public void SaveChanges()
        {
            if (changed)
            {
                Save();
            }

            changed = false;
        }

        /// <summary>
        /// Save all config data to DB
        /// </summary>
        public void Save()
        {
            var sql = "UPDATE config " +
                      "SET mod_folder=@mod_folder, " +
                      "executable_path=@exe, " +
                      "default_profile=@profile WHERE config_id=0";

            using (var connection = new SQLiteConnection(Db.DbString))
            {
                connection.Open();
                using (var saveAllSql = new SQLiteCommand(sql, connection))
                {
                    saveAllSql.Parameters.Add(new SQLiteParameter("@mod_folder") { Value = ModFolder });
                    saveAllSql.Parameters.Add(new SQLiteParameter("@exe") { Value = ExecutablePath });
                    saveAllSql.Parameters.Add(new SQLiteParameter("@profile") { Value = DefaultProfile });
                    saveAllSql.Prepare();

                    saveAllSql.ExecuteNonQuery();
                    connection.Dispose();
                }
            }
        }
    }
}