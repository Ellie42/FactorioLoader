using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactorioLoader.Main.Exceptions;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Models.Mods;
using FactorioLoader.Main.Services;
using MetroFramework.Controls;

namespace FactorioLoader.Main.Forms
{
    public partial class ImportModForm : ModLoaderForm
    {
        protected Mod Mod;

        public ImportModForm(Mod mod)
        {
            Mod = mod;
            InitializeComponent();
            modName.Text = $"({mod.Name})";
            modVersion.Text = mod.Version;
            modTitle.Text = mod.Title ?? "";
        }

        /// <summary>
        /// Download and extract the Mod
        /// TODO clean this mess up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void downloadButton_Click(object sender, EventArgs e)
        {
            var statusObjects = new DownloadStatus()
            {
                ProgressBar = modDownloadProgress,
                Label = downloadStatus,
                DonwloadButton = downloadButton,
                CancelButton = cancelButton,
                UrlLabel = modUrl
            };
            var modDownloader = new ModDownloader(Mod);
            downloadButton.Enabled = false;

           var task = Task.Run(() => {
                try
                {
                    modDownloader.DownloadMod(statusObjects, (obj, args) => { });
                }
                catch (ModFileUnavailableException ex)
                {
                    statusObjects.Label.Invoke((MethodInvoker) (
                        () =>
                        {
                            statusObjects.UrlLabel.Text = ex.Message;
                            statusObjects.UrlLabel.Cursor = Cursors.Hand;
                            statusObjects.UrlLabel.Click +=
                                (send, arg) => System.Diagnostics.Process.Start(ex.Message);

                            statusObjects.Label.Text =
                                @"Couldn't download mod, maybe try manual download.";
                        }));
                }
                catch (Exceptions.TimeoutException)
                {
                   statusObjects.Label.Invoke((MethodInvoker)(
                        () =>
                        {
                          statusObjects.Label.Text = @"Couldn't download mod, connection timed out :(";
                        }));
               }   
                catch (Exception)
                {
                    statusObjects.Label.Invoke((MethodInvoker) (
                        () =>
                        {
                            statusObjects.Label.Text = @"Couldn't download mod :(";
                        }));
                }

            });
           await task;

            App.FactorioLoader.Mods.Init();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImportModForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm?.Activate();
        }
    }
}
