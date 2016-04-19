using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using FactorioLoader.Main.Models.Mods;

namespace FactorioLoader.Main.Services
{
    public class ModService : ModFileService
    {
        protected ModDataService Data;
        public List<Mod> AvailableMods = new List<Mod>();
        
        public ModService()
        {   
            Data = new ModDataService();
        }
        
        /// <summary>
        /// Load all of the mod data, get available mods from the 
        /// reserve folder, add new mods found in the mods folder.
        /// Also grab all stored mod data in the DB
        /// </summary>
        public void Init()
        {
            //Get mods from DB first
            AvailableMods.AddRange(Data.GetModsFromDb());
            //Get mods in the mod directory
            var modFolderMods = ScanDirForMods(App.FactorioLoader.Config.ModFolder);
            MergeModsWithDataFromScanDir(modFolderMods);
            //Get mods in the reserve directory
            var reserveFolderMods = ScanDirForMods(App.FactorioLoader.Config.ReserveFolder, true);
            MergeModsWithDataFromScanDir(reserveFolderMods);
        }

        public List<Mod> GetPresentMods()
        {
            return AvailableMods.FindAll((searchMod) => searchMod.HaveFiles);
        }

        public Mod FindModInAvailable(string name,string version)
        {
            Predicate<Mod> findMod = searchMod => name == searchMod.Name && version == searchMod.Version;

            return AvailableMods.Find(findMod);
        }

        /// <summary>
        /// Merge a list of mods found in folders with the current available mods from DB
        /// and adds to the availableMods list
        /// </summary>
        /// <param name="mods"></param>
        private void MergeModsWithDataFromScanDir(List<Mod> mods)
        {
            foreach (var mod in mods)
            {
                Predicate<Mod> findMod = searchMod => mod.Name==searchMod.Name&&mod.Version==searchMod.Version;
                var savedMod = AvailableMods.Find(findMod);

                if (savedMod == null)
                {
                    mod.HaveFiles = true;
                    AvailableMods.Add(mod);
                    continue;
                }

                savedMod.HaveFiles = true;
            }
        }
    }
}