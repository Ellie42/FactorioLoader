using System;
using System.Collections.Generic;
using FactorioLoader.Main.Helpers;
using FactorioLoader.Main.Models.Mods;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace FactorioLoader.Main.Forms
{
    public partial class ProfileEditForm : MetroForm
    {
        protected List<MetroGrid> AllGrids = new List<MetroGrid>(); 

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
        }

        /// <summary>
        /// Update all mod data displays
        /// </summary>
        private void UpdateAllModData()
        {
            UpdateAvailableModsGrid();
            UpdateProfileModsGrid();
            UpdateTitle();
        }

        private void UpdateAvailableModsGrid()
        {
            FormControlHelper.PopulateGridWithMods
                (availableModsGrid,
                App.FactorioLoader.Mods.GetPresentMods());
        }

        private void UpdateTitle()
        {
            Text = $"Editing Profile {App.FactorioLoader.Profiles.CurrentProfile.Name}";
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
        /// Add mod to profile
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
        /// Also update the current mod data
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
                return;
            }

            var modCount = mods.Count;

            if (modCount > 1)
            {
                curModName.Text = @"Various Mods...";
                curModDesc.Text = @"...";
                return;
            }

            curModName.Text = mods[0].Name;
            curModDesc.Text = mods[0].Description;
        }
    }
}
