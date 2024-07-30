using System.Text;

namespace TML143xSoundFixer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            SetupDirectory();
            InitializeComponent();
            CheckToExistFAudio144();
        }


        private void SetupDirectory()
        {
            if (!Directory.Exists(Pathes.GetApplicationFAudio144DirectoryPath()))
            {
                Directory.CreateDirectory(Pathes.GetApplicationFAudio144DirectoryPath());
            }
        }

        private void CheckToExistFAudio144()
        {
            bool exist = File.Exists(Pathes.GetGetApplicationFAudio144Path());
            runButton.Enabled = exist;
        }


        private void Form1_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void tMLPathRefButton_Click(object sender, EventArgs e)
        {
            DialogResult result = tMLPathRefDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            tMLPathTextBox.Text = tMLPathRefDialog.SelectedPath;
            tMLFAudioPathTextBox.Text = Pathes.GetTMLFAudioPathFromTMLPath(tMLPathTextBox.Text);
        }

        private void tMLFAudioPathRefButton_Click(object sender, EventArgs e)
        {
            DialogResult result = tMLFAudioPathRefDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            tMLFAudioPathTextBox.Text = tMLFAudioPathRefDialog.FileName;
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            new SetupForm(tMLPathTextBox.Text, tMLPathRefDialog, tMLFAudioPathTextBox.Text).ShowDialog();
            CheckToExistFAudio144();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string fAudioPath = Pathes.GetGetApplicationFAudio144Path();
            string tMLFAudioPath = tMLFAudioPathTextBox.Text;

            if (!File.Exists(fAudioPath))
            {
                StringBuilder mbText = new StringBuilder();
                mbText.Append("このソフトにFAudio.dllがコピーされていません。\nセットアップでAudio.dllを取得してください。");
                MessageBox.Show(mbText.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(Path.GetDirectoryName(tMLFAudioPath)))
            {
                StringBuilder mbText = new StringBuilder();
                mbText.Append("tModLoader内のFAudio.dllのパスが無効です。");
                MessageBox.Show(mbText.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                File.Copy(fAudioPath, tMLFAudioPath, true);
            }
            catch (Exception ex)
            {
                StringBuilder mbText = new StringBuilder();
                mbText.Append("ファイルのコピー中にエラーが発生しました。");
                mbText.Append($"\n{ex.Message}");
                mbText.Append($"\n以下スタックトレース");
                mbText.Append($"\n{ex.StackTrace}");
                MessageBox.Show(mbText.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("FAudio.dllの入れ替えに成功しました。", "実行結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
