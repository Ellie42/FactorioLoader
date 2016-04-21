using System;
using System.IO;
using System.IO.Compression;
using System.IO.Packaging;
using System.Linq.Expressions;
using System.Net;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Services;
using MetroFramework.Controls;

namespace FactorioLoader.Main.Models.Mods
{
    public partial class Mod : IEquatable<Mod>
    {
        public string Name;
        public string Title;
        public string Description;
        public string Version;
        public string Author;
        //ID/URL are the version specific DownloadURL and ID
        public string Url;
        public string Mirror;
        public string Id;
        //General ID/URL are the factoriomods ID/URL for the base project
        public string GeneralId;
        public string GeneralUrl;
        public string DependencyString;
        public string FolderName;
        public string HomePage;
        public string ArchivePath;
        public bool InReserve = false;
        public bool HaveFiles = false;
        public bool HaveData = true;
        public bool HaveArchive; 

        public bool Equals(Mod other)
        {
            return other.Name == Name && other.Version == Version;
        }

        protected string GetMainPath()
        {
            return App.FactorioLoader.Config.ModFolder + "\\" + FolderName;
        }

        protected string GetReservePath()
        {
            return App.FactorioLoader.Config.ReserveFolder + "\\" +
                FolderName;
        }

        /// <summary>
        /// Move the Mod to the reserve folder
        /// </summary>
        public void MoveToReserve()
        {
            if (InReserve) return;

            MoveFolderToFolder(GetMainPath(),GetReservePath());
            
            InReserve = true;
        }

        /// <summary>
        /// Move the Mod into the main mods folder
        /// </summary>
        public void MoveToMain()
        {
            if (!InReserve) return;

            MoveFolderToFolder(GetReservePath(), GetMainPath());

            InReserve = false;
        }

        /// <summary>
        /// Move a folder to another folder overwriting any conflicting folder
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        private void MoveFolderToFolder(string source, string dest)
        {
            if (Directory.Exists(dest))
            {
                Directory.Delete(source,true);
                return;
            }
            var moved = false;

            while (!moved)
            {
                try
                {
                    Directory.Move(source, dest);
                }
                catch (IOException)
                {
                    continue;
                }
                moved = true;
            }
        }

        public void Merge(Mod mod)
        {
            var type = mod.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var modProperty = property.GetValue(mod);
                if (property.GetValue(this) == null && modProperty != null)
                {
                    property.SetValue(this, modProperty);
                }
            }
        }




        /// <summary>
        /// TODO check if archive exists
        /// Download the Mod archive into the archives folder
        /// </summary>
        /// <param name="modDownloadProgress"></param>
        public void Download(ProgressBar modDownloadProgress,Action<object,DownloadProgressChangedEventArgs> callback = null)
        {
            var modDownloader = new ModDownloader(this);
            modDownloader.DownloadMod(modDownloadProgress,callback);
        }
        
        

        public void Extract(ProgressBar modDownloadProgress)
        {
            if (!HaveArchive) throw new Exception("Mod archive not found");

            var done = false;

            while (!done)
            {
                try
                {
                    ZipFile.ExtractToDirectory(ArchivePath, App.FactorioLoader.Config.ReserveFolder);
                    done = true;
                }
                catch (IOException){}
            }
        }
    }
}