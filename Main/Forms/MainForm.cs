﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FactorioLoader.Main.Helpers;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace FactorioLoader.Main.Forms
{
    public partial class MainForm : ModLoaderForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string[] Args { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
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
            if (comboBox.SelectedItem.ToString() == "Add New Profile")
            {
                comboBox.SelectedIndex = 0;
                AddNewProfile();
            }
            App.FactorioLoader.Profiles.ChangeProfile(comboBox.Text);
            ShowProfileData();
        }

        public void AddNewProfile()
        {
            var form = new CreateProfileForm();
            form.Closed += (sender, args) =>
            {
                if (form.NewProfile != null)
                {
                    App.FactorioLoader.Profiles.ChangeProfile(form.NewProfile.Name);
                    UpdateAllModDisplays();
                    ShowChildForm(new ProfileEditForm());
                }
            }; 
            ShowChildForm(form);
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
        /// Display all the mods of the Current profile
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
            profileComboBox.Items.Add(@"Add New Profile");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            var exePath = App.FactorioLoader.Config.ExecutablePath;
            if (exePath == null || exePath.Length <= 0)
            {
                MetroMessageBox.Show(this, "Factorio.exe path is missing :(.\nPlease set the path before continuing.",
                    "Executable Path Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            App.FactorioLoader.Mods.PrepareCurrentProfileMods();
            try
            {
                Process.Start(App.FactorioLoader.Config.ExecutablePath);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, 
                    "Could not start factorio.exe, please check the executable path.",
                    "Could Not Start Factorio",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            Application.Exit();
        }

        /// <summary>
        /// Open the edit profile form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editProfileTile_Click(object sender, EventArgs e)
        {
            var profileEditForm = new ProfileEditForm();
            profileEditForm.Closing += ProfileEditForm_Closing1;
            ShowChildForm(profileEditForm); 
        }

        private void ProfileEditForm_Closing1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UpdateAllModDisplays();
        }

        private void newProfileTile_Click(object sender, EventArgs e)
        {
            AddNewProfile();
        }

        private void settingsTile_Click(object sender, EventArgs e)
        {
            ShowChildForm(new SettingsForm());
        }


    }
}
