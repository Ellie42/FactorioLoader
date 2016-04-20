using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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
        public string Id;
        //General ID/URL are the factoriomods ID/URL for the base project
        public string GeneralId;
        public string GeneralUrl;
        public string DependencyString;
        public string FolderName;
        public string HomePage;
        public bool InReserve = false;
        public bool HaveFiles = false;
        public bool HaveData = true;
         
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

        public void MoveToReserve()
        {
            if (InReserve) return;

            if (Directory.Exists(GetReservePath()))
            {
                Directory.Delete(GetMainPath());
            }
            var moved = false;

            while (!moved)
            {
                try
                {
                    Directory.Move(GetMainPath(),GetReservePath());
                }
                catch (IOException)
                {
                    continue;
                }
                moved = true;
            }
            InReserve = true;
        }

        public void MoveToMain()
        {
            if (!InReserve) return;

            if (Directory.Exists(GetMainPath()))
            {
                Directory.Delete(GetReservePath());
            }
            var moved = false;

            while (!moved)
            {
                try
                {
                    Directory.Move(GetReservePath(), GetMainPath());
                }
                catch (IOException)
                {
                    continue;
                }
                moved = true;
            }
            InReserve = false;
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
        /// Download file data from a URL and grab the filename from it
        /// </summary>
        /// <param name="webClient"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        protected string GetFileNameFromUrl(WebClient webClient, string url)
        {
            var data = webClient.DownloadData(url);
            if (!string.IsNullOrEmpty(webClient.ResponseHeaders["Content-Disposition"]))
            {
                var contentString = webClient.ResponseHeaders["Content-Disposition"];
                var fileName = Regex.Match(contentString, @"filename.*'(.*)").Groups[1].ToString();
                return fileName;
            }

            var name = FolderName ?? $"{Name}_{Version}";
            return $"{name}.zip";
        }


        /// <summary>
        /// TODO check if archive exists
        /// Download the mod archive into the archives folder
        /// </summary>
        /// <param name="modDownloadProgress"></param>
        public void Download(ProgressBar modDownloadProgress)
        {
            using (var client = new WebClient())
            {
                var archivePath = App.FactorioLoader.Config.ArchiveFolder;
                //TODO move this
                if(!Directory.Exists(archivePath)) Directory.CreateDirectory(archivePath);

                var fileName = GetFileNameFromUrl(client, Url);
                var fileDownloadPath = archivePath + "\\"+fileName;
                client.DownloadProgressChanged += (s,e)=> modDownloadProgressChanged(s,e,modDownloadProgress);
                client.DownloadFileAsync(new Uri(Url), fileDownloadPath);
            }
        }

        private void modDownloadProgressChanged(
            object sender, 
            DownloadProgressChangedEventArgs e,
            ProgressBar progressBar)
        {
            progressBar.Step = e.ProgressPercentage;
            progressBar.PerformStep();
        }
    }
}