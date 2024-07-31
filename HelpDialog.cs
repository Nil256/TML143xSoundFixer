using System.Diagnostics;

namespace TML143xSoundFixer
{
    public partial class HelpDialog : Form
    {
        public HelpDialog()
        {
            InitializeComponent();
        }

        private void gitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "https://github.com/Nil256/TML143xSoundFixer",
                UseShellExecute = true
            });
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
