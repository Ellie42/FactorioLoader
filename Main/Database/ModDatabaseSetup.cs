using System;
using System.Data.SQLite;
using System.IO;

namespace FactorioLoader.Main.Database
{
    public class ModDatabaseSetup : DatabaseSetup
    {
        private SQLiteConnection connection;

        public override void Up()
        {
            connection = new SQLiteConnection(ConnectionString);
            Directory.CreateDirectory("./Db");
            SQLiteConnection.CreateFile(DbFile);
            SetupDb();
        }

        public override void Down()
        {
            if (File.Exists(DbFile))
            {
                File.Delete(DbFile);
            }
        }

        private void SetupDb()
        {
            connection.Open();

            //Main mod_data Table
            var modDataTableSql = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS mod_data " +
                "(" +
                "mod_data_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "name TEXT NOT NULL, " +
                "title TEXT, " +
                "description TEXT, " +
                "version TEXT, " +
                "author TEXT, " +
                "url TEXT, " +
                "dependency_string TEXT, " +
                "folder_name TEXT " +
                "); INSERT INTO mod_data (name,description) VALUES ('base','The base game');" +
                " CREATE UNIQUE INDEX i1 ON mod_data(name,version);",
                connection);

            modDataTableSql.ExecuteNonQuery();

            //Mod Dependencies
            var modDependenciesTableSql = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS mod_data_dependencies (" +
                "mod_data_dependencies_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "mod_data_id INTEGER NOT NULL, " +
                "name TEXT, version TEXT, " +
                "FOREIGN KEY(mod_data_id) REFERENCES mod_data(mod_data_id)" +
                ");",
                connection);

            modDependenciesTableSql.ExecuteNonQuery();

            //Mod Profiles
            var modProfileTableSql = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS mod_profiles (" +
                "mod_profile_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "name TEXT NOT NULL, " +
                "description TEXT DEFAULT 'Indescribably amazing mod profile.'" +
                "); CREATE UNIQUE INDEX unique_profile_name ON mod_profiles(name);" +
                "INSERT INTO mod_profiles (name,description) VALUES ('Default','The default mod profile.')"
                ,connection);

            modProfileTableSql.ExecuteNonQuery();

            //Mod Profiles To Mods
            var modProfileModsTableSql = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS mod_profiles_mods (" +
                "mod_profile_mod_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "mod_profile_id INTEGER NOT NULL, " +
                "name TEXT NOT NULL, " +
                "version TEXT NOT NULL, " +
                "mod_data_id INTEGER, " +
                "FOREIGN KEY(mod_data_id) REFERENCES mod_data(mod_data_id), " +
                "FOREIGN KEY(mod_profile_id) REFERENCES mod_profiles(mod_profile_id) ON DELETE CASCADE" +
                "); CREATE UNIQUE INDEX unique_profile_mods ON mod_profiles_mods(name,version,mod_profile_id)"
                ,connection);

            modProfileModsTableSql.ExecuteNonQuery();

            CreateConfigTables();

            connection.Close();
        }

        private void CreateConfigTables()
        {
            var loaderConfigTableSql = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS config (" +
                "config_id INTEGER PRIMARY KEY CHECK (config_id = 0), " +
                "default_profile TEXT DEFAULT 'Default', " +
                "mod_folder TEXT, " +
                "executable_path TEXT " +
                "); INSERT INTO config (config_id) VALUES (0) ",connection
                );

            loaderConfigTableSql.ExecuteNonQuery();
        }
    }
}