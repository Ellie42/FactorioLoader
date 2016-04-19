using System;
using System.Collections.Generic;
using System.Data.SQLite;
using FactorioLoader.Main.Models.Mods;
using FactorioLoader.Main.Models.Profile;

namespace FactorioLoader.Main.Services
{
    public class ModProfileService
    {
        public ModProfile CurrentProfile;
        public List<ModProfile> Profiles;

        public void Init()
        {
            Profiles = GetAllProfiles();
            var defaultProfile = App.FactorioLoader.Config.DefaultProfile;

            CurrentProfile = Profiles.Find((profile) => profile.Name==defaultProfile);
        }

        /// <summary>
        /// Return all the profiles in the DB
        /// </summary>
        /// <returns></returns>
        private List<ModProfile> GetAllProfiles()
        {
            var sql = @"SELECT profile.name,profile.description,profile.mod_profile_id,
                        group_concat(mods.name) as mod_names,
                        group_concat(mods.version) as mod_versions
                        FROM mod_profiles as profile 
                        LEFT JOIN mod_profiles_mods as mods
                        ON mods.mod_profile_id=profile.mod_profile_id
                        GROUP BY profile.mod_profile_id";

            List<ModProfile> profiles;

            using (var connection = App.FactorioLoader.Db.Connection)
            {
                using (var command = new SQLiteCommand(sql,connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    profiles = GetProfilesFromReader(reader);
                    reader.Close();
                    connection.Dispose();
                }
            }

            return profiles;
        }

        /// <summary>
        /// Return a list of profiles from Sqlite reader
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private List<ModProfile> GetProfilesFromReader(SQLiteDataReader reader)
        {
            var profiles = new List<ModProfile>();

            while (reader.Read())
            {
                var newProfile = new ModProfile()
                {
                    Name = reader[0] as string,
                    Description = reader[1] as string,
                    Id = Convert.ToInt32(reader[2])
                };
                newProfile.SetModsFromDbResult(reader[3] as string, reader[4] as string);
                profiles.Add(newProfile);
            }

            return profiles;
        }

        public void ChangeProfile(string name)
        {
            CurrentProfile = Profiles.Find((searchProfile) => searchProfile.Name == name);
        }
    }
}