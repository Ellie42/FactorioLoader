using System;
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactorioLoader.Main.Exceptions;
using FactorioLoader.Main.Forms;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Models.Download;
using FactorioLoader.Main.Models.Mods;
using MetroFramework.Controls;
using MimeSharp;
using SevenZip;

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

        private ModUrlList GetValidUrls(Mod mod)
        {
            return new ModUrlList(mod);
        }

        //TODO Refactor everything in this class
        protected string GetDownloadPath(Mod mod)
        {
            return $"{App.FactorioLoader.Config.ArchiveFolder}\\{mod.Name}_{mod.Version}";
        }

        /// <summary>
        /// Download a mod
        /// </summary>
        /// <param name="modDownloadProgress"></param>
        /// <param name="status"></param>
        /// <param name="callback"></param>
        public void DownloadMod(
            DownloadStatus status,
            Action<object, DownloadProgressChangedEventArgs> callback)
        {
            Exception exception = null;
            foreach (ModUrl url in Urls)
            {
                var downloaded = false;
                var downloading = false;
                try
                {
                    var client = TryDownload(url,status);
                    client.DownloadProgressChanged += (s, e) =>
                    {
                        downloading = true;
                        if (e.ProgressPercentage >= 100)
                        {
                            downloaded = true;
                        }
                    };
                }
                catch (Exception)
                {
                    continue;
                }
                
                var wait = new WaitFor().OrError(new TimeSpan(0,0,15));
                try
                {
                    while (wait.Variable(downloading).IsFalse) { }
                }
                catch (Exceptions.TimeoutException ex)
                {
                    exception = ex;
                    continue;
                }

                while (!downloaded) { }

                var path = GetDownloadPath(Mod);

                SevenZipExtractor extractor;

                if (ModFileHelper.IsArchive(path, out extractor))
                {
                    TryExtractMod(path,extractor, status);

                    status.CancelButton.Invoke((MethodInvoker) (
                        () =>
                        {
                            status.CancelButton.Text = @"Done";
                            status.Label.Text = @"Mod added successfully!";
                        }));

                    return;
                }
//                 File.Delete(path);
            }

            if (exception != null) throw exception;

            if (Urls.Urls.Count >= 1)
            {
                throw new ModFileUnavailableException(Urls.Urls[0]);
            }

            throw new Exception("Could not download mod");
        }

        private void TryExtractMod(string path, SevenZipExtractor extractor, DownloadStatus status)
        {
            status.Label.Invoke(
                (MethodInvoker)(() =>
                {
                    status.Label.Text = @"Extracting Files...";
                    status.ProgressBar.Step = -100;
                    status.ProgressBar.PerformStep();
                }));

            extractor.Extracting += (sender, e) => Extractor_Extracting(sender, e, status);
            Mod.ArchivePath = path;
            var folderPath = App.FactorioLoader.Config.ReserveFolder + "\\" + Mod.FolderName;
            ModFileHelper.Extract(extractor, folderPath);
        }

        /// <summary>
        /// Attempt to download whatever the url points to
        /// </summary>
        /// <param name="url"></param>
        /// <param name="status"></param>
        /// <param name="modDownloadProgress"></param>
        private WebClient TryDownload(ModUrl url, DownloadStatus status)
        {
            status.Label.Invoke(
                (MethodInvoker)(() =>
                {
                    status.Label.Text = @"Downloading Mod...";
                    status.ProgressBar.Value = 0;
                }));

            var downloadPath = GetDownloadPath(Mod);
            var client = new WebClient();

            client.DownloadProgressChanged += (s,e)=> ModDownloadProgressChanged(s,e,status);

            client.DownloadFileAsync(new Uri(url.Url), downloadPath);
            return client;
        }

        /// <summary>
        /// Update the progress bar while downloading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <param name="status"></param>
        private void ModDownloadProgressChanged(object sender,
            DownloadProgressChangedEventArgs args,
            DownloadStatus status)
        {   
            status.Label.Invoke(
                (MethodInvoker)(() =>
                {
                    status.ProgressBar.Step = args.ProgressPercentage;
                    status.ProgressBar.PerformStep();
                }));
        }

        private void Extractor_Extracting(object sender, ProgressEventArgs e, DownloadStatus status)
        {
//            progress.Value = e.PercentDone;
            status.Label.Invoke(
                (MethodInvoker)(() =>
                {
                    status.ProgressBar.Step = e.PercentDelta;
                    status.ProgressBar.PerformStep();
                }));
        }
    }
}