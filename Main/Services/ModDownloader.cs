using System;
using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Models.Download;
using FactorioLoader.Main.Models.Mods;

namespace FactorioLoader.Main.Services
{
    public class ModDownloader
    {   
        public Mod Mod;
        public ModUrlList Urls;

        public ModDownloader(Mod mod)
        {
            Mod = mod;
            Urls = GetValidUrls(mod);
        }

        //TODO make better
        private ModUrlList GetValidUrls(Mod mod)
        {
            return new ModUrlList(mod);
        }

//        /// <summary>
//        /// Download file data from a URL and grab the filename from it
//        /// TODO loop through all urls
//        /// </summary>
//        /// <param name="webClient"></param>
//        /// <param name="url"></param>
//        /// <returns></returns>
//        protected string GetFileNameFromUrl(WebClient webClient, string url)
//        {
//            var data = webClient.DownloadData(url);
//            if (!string.IsNullOrEmpty(webClient.ResponseHeaders["Content-Disposition"]))
//            {
//                var contentString = webClient.ResponseHeaders["Content-Disposition"];
//                var fileName = Regex.Match(contentString, @"filename.*'(.*)").Groups[1].ToString();
//                return fileName;
//            }
//
//            var name = Mod.FolderName ?? $"{Mod.Name}_{Mod.Version}";
//            Mod.FolderName = name;
//            return UrlType==ModFileHelper.ModFileType.Zip?$"{name}.zip":name;
//        }

        public void DownloadMod(ProgressBar modDownloadProgress,Action<object,DownloadProgressChangedEventArgs> callback )
        {
            foreach (var url in Urls)
            {
                
            }

//            if (Url == null)
//            {
//                throw new Exception($"Cannot download mod from {Mod.Url} or {Mod.Mirror}");
//            }

//            if (UrlType != ModFileHelper.ModFileType.Zip) throw new Exception($"Cannot download mod from {Mod.Url} or {Mod.Mirror}"); ;

//            using (var client = new WebClient())
//            {
//                client.DownloadProgressChanged += (obj, e) => { if (e.ProgressPercentage >= 100) Mod.HaveArchive = true; };

//                var archive = App.FactorioLoader.Config.ArchiveFolder;

//                var fileName = GetFileNameFromUrl(client, Url);
//                var fileDownloadPath = archive + "\\" + fileName;
//                Mod.ArchivePath = fileDownloadPath;
//                client.DownloadProgressChanged += (s, e) => modDownloadProgressChanged(s, e, modDownloadProgress);
//                Add the callback after the modDownloadProgressChanged action so that you can reset
//                the progress bar in the callback
//                if (callback != null)
//                {
//                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(callback);
//                }
//                client.DownloadFileAsync(new Uri(Url), fileDownloadPath);
//            }
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