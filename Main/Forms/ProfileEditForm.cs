using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Models.Mods;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace FactorioLoader.Main.Forms
{
    ///TODO if profile has a Mod that does not exist in available mods add it
    ///When a profile has mods that we do not have the data for then we should save it as an available Mod
    /// in the DB so that you can add it in the future anyway.
    /// Probably should section off the mods without data in the grid

    public partial class ProfileEditForm : MetroForm
    {
        protected List<MetroGrid> AllGrids = new List<MetroGrid>();
        protected Section CurrentSection = Section.HaveFiles;

        protected enum Section
        {
            HaveFiles,All,NoFiles,NoData,HaveData
        }

        public ProfileEditForm()
        {
            InitializeComponent();
            //Add all grids to the AllGrids list so we can easily manage selections
            //such as only allowing one grid to have selections at a time
            AllGrids.Add(availableModsGrid);
            AllGrids.Add(profileModsGrid);
        }

        private void ProfileEditForm_Load(object sender, EventArgs e)
        {
            FormControlHelper.PopulateProfileComboBox(profileComboBox);
            UpdateAllModData();
            UpdateAvailableModsSections();
        }

        private void UpdateAvailableModsSections()
        {
            availableModsSections.Items.Add(@"Downloaded");
            availableModsSections.Items.Add(@"Not Downloaded");
            availableModsSections.Items.Add(@"All Mods");
            availableModsSections.SelectedIndex = 0;
        }

        /// <summary>
        /// Update all Mod data displays
        /// </summary>
        private void UpdateAllModData()
        {
            deleteProfileButton.Enabled = true;
            UpdateAvailableModsGrid();
            availableModsGrid.Refresh();
            UpdateProfileModsGrid();
            profileModsGrid.Refresh();
            UpdateTitle();
            if (App.FactorioLoader.Profiles.CurrentProfile.Name == "Default")
            {
                deleteProfileButton.Enabled = false;
            }
        }

        private void UpdateAvailableModsGrid()
        {
            FormControlHelper.PopulateGridWithMods
                (availableModsGrid,
                GetModsInCurrentSection());
        }

        private void UpdateTitle()
        {
            Text = $"Editing Profile {App.FactorioLoader.Profiles.CurrentProfile.Name}";
            Refresh();
        }

        private void UpdateProfileModsGrid()
        {
            FormControlHelper.PopulateGridWithMods(
                profileModsGrid,
                App.FactorioLoader.Profiles.CurrentProfile.Mods);
        }

        private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (MetroComboBox) sender;
            App.FactorioLoader.Profiles.ChangeProfile(comboBox.Text);
            UpdateAllModData();
        }

        /// <summary>
        /// Add Mod to profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addModButton_Click(object sender, EventArgs e)
        {
            var grid = availableModsGrid;
            App.FactorioLoader.Profiles.CurrentProfile.AddMods(
                FormControlHelper.GetModsFromGridSelection(grid));
            App.FactorioLoader.Profiles.CurrentProfile.Save();
            UpdateAllModData();
        }

        /// <summary>
        /// Remove mods from profile 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeModButton_Click(object sender, EventArgs e)
        {
            var grid = profileModsGrid;
            App.FactorioLoader.Profiles.CurrentProfile.RemoveMods(
                FormControlHelper.GetModsFromGridSelection(grid));
            App.FactorioLoader.Profiles.CurrentProfile.Save();
            UpdateAllModData();
        }

        /// <summary>
        /// When a grid selection changes then deselect all the other grids so 
        /// only a single grid has selections.
        /// Also update the current Mod data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeGridSelection(object sender, EventArgs e)
        {
            var grid = (MetroGrid)sender;
            if (grid.SelectedRows.Count <= 0)
            {
                UpdateCurrentModDescription();
                return;
            };

            //Clear all other grid selections
            foreach (var g in AllGrids)
            {
                if (grid.Equals(g)) continue;

                g.ClearSelection();
            }
            UpdateCurrentModDescription(FormControlHelper.GetModsFromGridSelection(grid));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mods"></param>
        private void UpdateCurrentModDescription(List<Mod> mods = null)
        {
            if (mods == null || mods.Count <= 0)
            {
                curModName.Text = "";
                curModDesc.Text = "";
                curModAuthor.Text = "";
                return;
            }

            var modCount = mods.Count;

            if (modCount > 1)
            {
                curModName.Text = @"Various Mods...";
                curModAuthor.Text = @"Various Authors...";
                curModDesc.Text = mods.Aggregate("",(prev,next)=> prev+(next.Title ?? next.Name)+", ");
                return;
            }

            curModAuthor.Text = mods[0].Author ?? "";
            curModName.Text = mods[0].Title ?? mods[0].Name;
            curModDesc.Text = mods[0].Description ?? "";
        }

        protected List<Mod> GetModsInCurrentSection()
        {
            switch (CurrentSection)
            {
                case Section.HaveFiles:
                    return App.FactorioLoader.Mods.GetPresentModsNotInProfile();
                case Section.NoFiles:
                    return App.FactorioLoader.Mods.GetUndownloadedModsNotInProfile();
                case Section.All:
                    return App.FactorioLoader.Mods.AvailableMods;
            }

            return new List<Mod>();
        } 

        private void ChangeAvailableModsSection(object sender, EventArgs e)
        {
            var comboBox = (MetroComboBox) sender;

            switch (comboBox.SelectedItem.ToString())
            {
                case "Downloaded":
                    CurrentSection = Section.HaveFiles;
                    break;
                case "All Mods":
                    CurrentSection = Section.All;
                    break;
                case "Not Downloaded":
                    CurrentSection = Section.NoFiles;
                    break;
                default:
                    return;
            }

            UpdateAvailableModsGrid();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {

            var message = $"Are you sure you wish to delete profile {App.FactorioLoader.Profiles.CurrentProfile.Name}?";
            if (MetroMessageBox.Show(this, message,"Deleting Profile",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
                != DialogResult.Yes)
            {
                return;
            }

            App.FactorioLoader.Profiles.CurrentProfile.Delete();
            App.FactorioLoader.Profiles.RemoveCurrentProfile();
            FormControlHelper.PopulateProfileComboBox(profileComboBox);
            UpdateAllModData();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
