using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactorioLoader.Main.Models.Profile;
using MetroFramework.Forms;

namespace FactorioLoader.Main.Forms
{
    public partial class CreateProfileForm : MetroForm
    {
        public ModProfile NewProfile;

        public CreateProfileForm()
        {
            InitializeComponent();
        }

        private void CreateProfileForm_Load(object sender, EventArgs e)
        {
            nameInput.Text = $"Mod Profile {App.FactorioLoader.Profiles.Profiles.Count}";
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            var name = nameInput.Text.Trim();
            var desc = descriptionInput.Text.Trim();

            if (App.FactorioLoader.Profiles.Profiles.Exists(
                (search) => search.Name== name))
            {
                return;
            }
            NewProfile = App.FactorioLoader.Profiles.CreateProfileAndSave(name, desc);
            Close();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
