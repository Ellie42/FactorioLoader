using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactorioLoader.Main.Models.Mods;

namespace FactorioLoader.Main.Forms
{
    public partial class ImportModForm : ModLoaderForm
    {
        protected Mod Mod;

        public ImportModForm(Mod mod)
        {
            Mod = mod;
            InitializeComponent();
            modName.Text = mod.Name;
            modVersion.Text = mod.Version;
        }

        /// <summary>
        /// Download and extract the Mod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downloadButton_Click(object sender, EventArgs e)
        {
            var extracted = false;
            downloadButton.Enabled = false;
            downloadStatus.Text = @"Downloading Files";
            Mod.Download(modDownloadProgress, (obj,args) =>
            {
                if (args.ProgressPercentage < 100 || extracted) return;

                modDownloadProgress.Value = 0;

                downloadStatus.Text = @"Extracting Files";
                Mod.Extract(modDownloadProgress);
                downloadStatus.Text = @"Done!";
                cancelButton.Text = @"Close";
                App.FactorioLoader.Mods.Init();
                extracted = true;
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
