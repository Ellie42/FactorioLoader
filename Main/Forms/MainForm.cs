using System;
using System.Windows.Forms;
using FactorioLoader.Main.Helpers;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace FactorioLoader.Main.Forms
{
    public partial class MainForm : MetroForm
    {
        protected Form ActiveChildForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            App.FactorioLoader.RunApp();
            UpdateAllModDisplays();
        }

        /// <summary>
        /// When selecting a new profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetroComboBox comboBox = (MetroComboBox) sender;
            App.FactorioLoader.Profiles.ChangeProfile(comboBox.Text);
            ShowProfileData();
        }

        /// <summary>
        /// Update all controls with profile data
        /// </summary>
        private void ShowProfileData()
        {
            UpdateProfileModsGrid();
        }

        private void UpdateAllModDisplays()
        {
            UpdateProfileComboBox();
            UpdateProfileModsGrid();
        }

        /// <summary>
        /// Display all the mods of the current profile
        /// </summary>
        private void UpdateProfileModsGrid()
        {
            var modCountString = App.FactorioLoader.Profiles.CurrentProfile.Mods.Count.ToString();
            currentProfileModCount.Text = $"Mods: {modCountString}";
            FormControlHelper.PopulateGridWithMods(profileModsGrid,App.FactorioLoader.Profiles.CurrentProfile.Mods);
        }

        /// <summary>
        /// Update the profile combo box
        /// </summary>
        private void UpdateProfileComboBox()
        {
            FormControlHelper.PopulateProfileComboBox(profileComboBox);
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Open the edit profile form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editProfileTile_Click(object sender, EventArgs e)
        {
            var profileEditForm = new ProfileEditForm();
            ShowChildForm(profileEditForm);
        }

        /// <summary>
        /// Show a form if no other child form is open, and set parent to this form
        /// </summary>
        /// <param name="form"></param>
        private void ShowChildForm(Form form)
        {
            if (ActiveChildForm != null) return;

            Enabled = false;

            ActiveChildForm = form;
            form.FormClosing += ClosingChildForm;
            form.Show(this);
        }

        /// <summary>
        /// When child form closes make sure to clear the activeChildForm variable so new
        /// forms can be opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="formClosingEventArgs"></param>
        private void ClosingChildForm(object sender, FormClosingEventArgs formClosingEventArgs)
        {
            Enabled = true;
            ActiveChildForm = null;
            Focus();
            UpdateAllModDisplays();
        }
    }
}
