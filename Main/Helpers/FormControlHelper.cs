using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FactorioLoader.Main.Models.Mods;
using MetroFramework.Controls;

namespace FactorioLoader.Main.Helpers
{
    public class FormControlHelper
    {
        public static List<Mod> GetModsFromGridSelection(MetroGrid grid)
        {
            var mods = new List<Mod>();
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                var name = row.Cells[0].Value as string;
                var version = row.Cells[1].Value as string;
                if (name==null || version==null) continue;
                var foundMod = App.FactorioLoader.Mods.FindModInAvailable(name, version)
                    ?? new Mod()
                    {
                        Name = name,
                        Version = version
                    };

                mods.Add(foundMod);
            }

            return mods;
        }

        public static void PopulateGridWithMods(MetroGrid grid, List<Mod> mods)
        {
            var scrollIndex = grid.FirstDisplayedScrollingRowIndex;
            var sortOrder = grid.SortOrder;
            var sortColumn = grid.SortedColumn;

            var listSortOrder = GetListSortDirectionFromSortOrder(sortOrder);

            grid.Rows.Clear();
            if (mods.Count <= 0)
            {
                grid.Rows.Add();
                return;
            };

            foreach (var mod in mods)
            {
                grid.Rows.Add(mod.Title ?? mod.Name, mod.Version);
            }

            if (scrollIndex > grid.RowCount - 1 || scrollIndex < 0)
            {
                return;
            }
            
            if (sortColumn != null) grid.Sort(sortColumn, listSortOrder);

            grid.FirstDisplayedScrollingRowIndex = scrollIndex;
        }

        private static ListSortDirection GetListSortDirectionFromSortOrder(SortOrder sortOrder)
        {
            switch (sortOrder)
            {
                case SortOrder.Ascending:
                    return ListSortDirection.Ascending;
                case SortOrder.Descending:
                    return ListSortDirection.Descending;
            }

            return ListSortDirection.Ascending;
        }

        public static void PopulateProfileComboBox(MetroComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach (var profile in App.FactorioLoader.Profiles.Profiles)
            {
                comboBox.Items.Add(profile.Name);
            }

            comboBox.SelectedItem = App.FactorioLoader.Profiles.CurrentProfile.Name;
        }
    }
}