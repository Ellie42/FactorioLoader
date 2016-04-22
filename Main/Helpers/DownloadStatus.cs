using System;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace FactorioLoader.Main.Helpers
{
    public class DownloadStatus
    {
        public ProgressBar ProgressBar;
        public MetroLabel Label;
        public Button DonwloadButton;
        public Button CancelButton;
        public MetroLink UrlLabel;

        public void Invoke(Delegate action)
        {
            Label.Invoke((MethodInvoker) action);
        }
    }
}