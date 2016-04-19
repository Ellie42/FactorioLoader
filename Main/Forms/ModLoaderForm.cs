using System.Windows.Forms;
using MetroFramework.Forms;

namespace FactorioLoader.Main.Forms
{
    public class ModLoaderForm : MetroForm
    {
        protected Form ActiveChildForm;

        /// <summary>
        /// Show a form if no other child form is open, and set parent to this form
        /// </summary>
        /// <param name="form"></param>
        protected void ShowChildForm(Form form)
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
        }
    }
}