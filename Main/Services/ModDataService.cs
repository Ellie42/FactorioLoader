using System.Collections.Generic;
using System.Data.SQLite;
using FactorioLoader.Main.Models.Mods;

namespace FactorioLoader.Main.Services
{
    public class ModDataService
    {
        /// <summary>
        /// Return a list of all mods stored in the DB
        /// </summary>
        /// <returns></returns>
        public List<Mod> GetModsFromDb()
        {
            List<Mod> mods;
            var sql = "SELECT * FROM mod_data";

            using (var connection = App.FactorioLoader.Db.Connection)
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    connection.Open();
                    var modsReader = command.ExecuteReader();
                    mods = GetModsFromReader(modsReader);
                    modsReader.Close();
                    connection.Dispose();
                }
            }

            return mods;
        }

        /// <summary>
        /// Return a list of mods from SqliteCommand Reader
        /// </summary>
        /// <param name="modsReader"></param>
        /// <returns></returns>
        private List<Mod> GetModsFromReader(SQLiteDataReader modsReader)
        {
            var mods = new List<Mod>();

            while (modsReader.Read())
            {
                if (modsReader[1] as string == "base") continue;

               mods.Add(new Mod()
               {
                   Name = modsReader[1] as string,
                   Description = modsReader[2] as string,
                   Version = modsReader[3] as string,
                   Author = modsReader[4] as string,
                   Url = modsReader[5] as string,
                   DependencyString = modsReader[6] as string,
                   FolderName = modsReader[7] as string
               });
            }

            return mods;
        }
    }
}