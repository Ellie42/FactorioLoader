using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Ink;
using FactorioLoader.Main.Models.Mods;

namespace FactorioLoader.Main.Models.Profile
{
    public class ModProfile : IEquatable<ModProfile>
    {
        public string Name;
        public string Description;
        public int? Id;
        public List<Mod> Mods = new List<Mod>();

        /// <summary>
        /// Add a list of mods from DB results
        /// </summary>
        /// <param name="names"></param>
        /// <param name="versions"></param>
        public void SetModsFromDbResult(string names,string versions)
        {
            if (names == null) return;

            var splitNames = names.Split(',');
            var splitVersions = versions.Split(',');

            for (var i = 0; i < splitNames.Length; i++)
            {
                var curName = splitNames[i];
                var curVersion = splitVersions[i];

                var foundMod = App.FactorioLoader.Mods.FindModInAvailable(curName, curVersion) 
                    ?? new Mod()
                    {
                        Name = curName,
                        Version = curVersion,
                        HaveData = false
                    };

                AddMod(foundMod);
            }
        }

        public void RemoveMod(Mod mod)
        {
            var foundMod = Mods.Find((search) => search.Equals(mod));
            if (foundMod == null) return;
            Mods.Remove(foundMod);
        }

        public void RemoveMods(List<Mod> mods)
        {
            foreach (var mod in mods)
            {
                RemoveMod(mod);
            }
        }

        public void AddMods(List<Mod> mods)
        {
            foreach (var mod in mods)
            {
                AddMod(mod);
            }
        }

        public void AddMod(Mod mod)
        {
            if (Mods.Contains(mod)) return;
            if (mod.HaveData)
            {
                Mods.Add(
                    App.FactorioLoader.Mods.FindModInAvailable(
                        mod.Name,mod.Version));
                return;
            }

            Mods.Add(mod);
        }

        /// <summary>
        /// Save all profile Mod data to the DB
        /// </summary>
        public void Save()
        {
            //If there is no ID then this is a new profile not from the DB
            //Add the basic profile data to the DB
            if (Id == null) SaveProfileData();

            //Basic delete SQL always needed
            var sql = 
                "DELETE FROM mod_profiles_mods "+
                "WHERE mod_profile_id=@profileId;";

            using (var connection = App.FactorioLoader.Db.Connection)
            {
                using (var command = new SQLiteCommand(connection))
                {
                    //If the new profile mods list has mods then we can insert the data
                    if (Mods.Count > 0)
                    {
                        sql += "INSERT INTO mod_profiles_mods " +
                        "(mod_profile_id,name,version)" +
                        "VALUES ";
                        sql += GetModInsertQueryValues();
                    }

                    //Add all Mod params OR just the @profileId if there are no mods
                    command.Parameters.AddRange(GetModInsertParameters());
                    command.CommandText = sql;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Dispose();
                }
            }
        }

        /// <summary>
        /// Set the current profile Id to the last inserted Id
        /// </summary>
        /// <param name="connection"></param>
        private void SetInsertId(SQLiteConnection connection)
        {
            Id = (int)connection.LastInsertRowId;
        }

        private void SaveProfileData()
        {
            var sql = "INSERT INTO mod_profiles (name,description)" +
                      "VALUES (@name,@description)";

            using (var connection = App.FactorioLoader.Db.Connection)
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.Add(new SQLiteParameter("@name") {Value = Name});
                    command.Parameters.Add(new SQLiteParameter("@description") {Value = Description});
                    command.Prepare();

                    connection.Open();
                    command.ExecuteNonQuery();
                    SetInsertId(connection);
                    connection.Dispose();
                }
            }
        }

        /// <summary>
        /// Returns the SQLite params needed for the Mod insertion,
        /// if there are no mods to insert then just return the profile id param
        /// </summary>
        /// <returns></returns>
        private SQLiteParameter[] GetModInsertParameters()
        {
            var sqlParams = new List<SQLiteParameter>();
            //Set the first param to the profile ID
            sqlParams.Add(new SQLiteParameter("@profileId") {Value = Id});

            if (Mods.Count <= 0) return sqlParams.ToArray();

            var i = 0;
            foreach (var mod in Mods)
            {
                sqlParams.Add(new SQLiteParameter($"@modName{i}") {Value = mod.Name});
                sqlParams.Add(new SQLiteParameter($"@modVersion{i}") {Value = mod.Version});
                i++;
            }

            return sqlParams.ToArray();
        }

        /// <summary>
        /// Create the values string for DB insertion
        /// </summary>
        /// <returns></returns>
        private string GetModInsertQueryValues()
        {
            var values = "";

            for (var i = 0;i<Mods.Count;i++)
            {
                if (i > 0) values += ", ";

                values += $@"(@profileId,@modName{i},@modVersion{i})";
            }

            return values;
        }

        /// <summary>
        /// Return a diff of mods that exist in presentMods but not in Profile.Mods
        /// </summary>
        /// <param name="presentMods"></param>
        /// <returns></returns>
        public List<Mod> GetModsNotInProfile(List<Mod> presentMods)
        {
            return presentMods.FindAll((search => !Mods.Contains(search)));
        }

        public void Delete()
        {
            var sql = "PRAGMA foreign_keys=ON;DELETE FROM mod_profiles " +
                      "WHERE mod_profile_id=@id";

            using (var connection = App.FactorioLoader.Db.Connection)
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add(new SQLiteParameter("@id")
                    {
                        Value = Id
                    });
                    command.ExecuteNonQuery();
                    connection.Dispose();
                }
            }
        }

        public bool Equals(ModProfile other)
        {
            return other.Name == Name;
        }
    }
}