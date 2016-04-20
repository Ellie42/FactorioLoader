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

        private void downloadButton_Click(object sender, EventArgs e)
        {
            Mod.Download(modDownloadProgress);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
