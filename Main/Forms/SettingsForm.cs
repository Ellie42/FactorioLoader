using System;
using MetroFramework.Forms;

namespace FactorioLoader.Main.Forms
{
    public partial class SettingsForm : ModLoaderForm
    {
        protected bool PathChanged = false;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, System.EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            modFolder.Text = App.FactorioLoader.Config.ModFolder;
            exeFolder.Text = App.FactorioLoader.Config.ExecutablePath;
            handleProtocolCheckbox.Checked = App.FactorioLoader.IsProtocolHandler;
        }

        private void setModFolderButton_Click(object sender, System.EventArgs e)
        {
            App.FactorioLoader.Config.RequestModFolder();
            App.FactorioLoader.Config.SaveChanges();
            UpdateForm();
            PathChanged = true;
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            App.FactorioLoader.Config.RequestExecutableFolder();
            App.FactorioLoader.Config.SaveChanges();
            UpdateForm();
            PathChanged = true;
        }

        private void SettingsForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if(PathChanged) App.FactorioLoader.Mods.Init();
        }

        private void doneButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        //TODO Implement
        private void handleProtocolCheckbox_CheckedChanged(object sender, System.EventArgs e)
        {
        }
    }
}
