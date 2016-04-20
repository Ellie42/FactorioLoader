using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using System.Windows.Forms;
using FactorioLoader.Main.Exceptions;
using FactorioLoader.Main.Models.Mods;
using MetroFramework;
using Newtonsoft.Json.Linq;
using MessageBox = System.Windows.MessageBox;

namespace FactorioLoader.Main.Services
{
    public class ModService : ModFileService
    {
        protected ModDataService Data;
        public List<Mod> AvailableMods;
        
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
            AvailableMods = new List<Mod>();
            //Get mods from DB first
            AvailableMods.AddRange(Data.GetModsFromDb());
            //Get mods in the mod directory
            try
            {
                var modFolderMods = ScanDirForMods(App.FactorioLoader.Config.ModFolder);
                MergeModsWithDataFromScanDir(modFolderMods);
            }
            catch(PathMissingException)
            {
                MessageBox.Show("Mod folder doesn't exist :(\nPlease set the mod folder before continuing");
                App.FactorioLoader.Config.RequestModFolder();
            }

            //If no reserve dir then create it
            if (!Directory.Exists(App.FactorioLoader.Config.ReserveFolder))
                Directory.CreateDirectory(App.FactorioLoader.Config.ReserveFolder);

            //Get mods in the reserve directory
            var reserveFolderMods = ScanDirForMods(App.FactorioLoader.Config.ReserveFolder, true);
            MergeModsWithDataFromScanDir(reserveFolderMods);
        }

        /// <summary>
        /// Get all mods that we have the files for
        /// </summary>
        /// <returns></returns>
        public List<Mod> GetPresentMods()
        {
            return AvailableMods.FindAll((searchMod) => searchMod.HaveFiles);
        }

        /// <summary>
        /// Get all mods that we have the files for that are not added to the current profile
        /// </summary>
        /// <returns></returns>
        /// 
        public List<Mod> GetPresentModsNotInProfile()
        {
            var presentMods = GetPresentMods();
            return App.FactorioLoader.Profiles.CurrentProfile.GetModsNotInProfile(presentMods);
        }
        public List<Mod> GetUndownloadedModsNotInProfile()
        {
            var undownloadedMods = GetUndownloadedMods();
            return App.FactorioLoader.Profiles.CurrentProfile.GetModsNotInProfile(undownloadedMods);
        }

        private List<Mod> GetUndownloadedMods()
        {
            return AvailableMods.FindAll((search) => !search.HaveFiles);
        }

        /// <summary>
        /// Find a mod in all available mods
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public Mod FindModInAvailable(string name,string version)
        {
            Predicate<Mod> findMod = searchMod => 
            (name == searchMod.Name||name==searchMod.Title) && version == searchMod.Version;

            return AvailableMods.Find(findMod);
        }

        /// <summary>
        /// Merge a list of mods found in folders with the current available mods from DB
        /// and adds to the availableMods list
        /// </summary>
        /// <param name="mods"></param>
        private void MergeModsWithDataFromScanDir(IEnumerable<Mod> mods)
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


        /// <summary>
        /// Move all mods in the profile to the main mod folder
        /// </summary>
        public void PrepareCurrentProfileMods()
        {
            var notInProfileMods = GetPresentModsNotInProfile();

            foreach (var mod in notInProfileMods)
            {
                if (!mod.InReserve) mod.MoveToReserve();
            }

            var profileMods = App.FactorioLoader.Profiles.CurrentProfile.Mods;

            foreach (var mod in profileMods)
            {
                if (mod.InReserve) mod.MoveToMain();
            }
        }
    }
}