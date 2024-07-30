using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TML143xSoundFixer
{
    public partial class SetupForm : Form
    {
        public SetupForm(string tMLPath, FolderBrowserDialog tMLFolderBrowserDialog, string fAudioPath)
        {
            InitializeComponent();
            // prevButton.Click += ResetPage;
            // nextButton.Click += ResetPage;

            _tMLPath = tMLPath;
            _tMLFolderBrowserDialog = tMLFolderBrowserDialog;
            _fAudioPath = fAudioPath;

            _dynamicControls = new List<Control>();
            CreatePage_Start(SetupType.TML);
        }

        private enum SetupType
        {
            TML,
            GitHub,
            Local
        }

        private string _tMLPath;
        private string _fAudioPath;
        private FolderBrowserDialog _tMLFolderBrowserDialog;
        private SetupType _setupType;
        private readonly List<Control> _dynamicControls;

        private void ResetPage(object? sender, EventArgs e)
        {
            for (var i = 0; i < _dynamicControls.Count; i++)
            {
                Controls.Remove(_dynamicControls[i]);
            }
            _dynamicControls.Clear();
        }


        private void CreatePage_Start(SetupType setupType)
        {
            prevButton.Text = "キャンセル";
            prevButton.Click += StartPage_OnClickPrevButton;
            nextButton.Text = "次へ";
            nextButton.Click += StartPage_OnClickNextButton;

            Label description = new Label();
            GroupBox fAudioRadioGroup = new GroupBox();
            RadioButton fAudio_getFromTML = new RadioButton();
            RadioButton fAudio_getFromGitHub = new RadioButton();
            RadioButton fAudio_getFromLocal = new RadioButton();
            // buttonContainer.SuspendLayout();
            fAudioRadioGroup.SuspendLayout();
            // SuspendLayout();

            fAudioRadioGroup.Controls.Add(fAudio_getFromLocal);
            fAudioRadioGroup.Controls.Add(fAudio_getFromGitHub);
            fAudioRadioGroup.Controls.Add(fAudio_getFromTML);
            fAudioRadioGroup.Location = new Point(16, 112);
            fAudioRadioGroup.Name = "fAudioRadioGroup";
            fAudioRadioGroup.Size = new Size(512, 134);
            fAudioRadioGroup.TabIndex = 1;
            fAudioRadioGroup.TabStop = false;
            fAudioRadioGroup.Text = "FAudio.dllを取得する方法を選んでください。";

            description.AutoSize = true;
            description.Location = new Point(16, 16);
            description.Name = "description";
            description.Size = new Size(358, 69);
            description.TabIndex = 2;
            description.Text = "このソフトウェアを使用するためのセットアップをします。\n\nまず、v1.4.4のFAudio.dllを取得します。";

            fAudio_getFromTML.AutoSize = true;
            fAudio_getFromTML.Checked = (setupType == SetupType.TML);
            fAudio_getFromTML.Location = new Point(16, 32);
            fAudio_getFromTML.Name = "fAudio_getFromTML";
            fAudio_getFromTML.Size = new Size(211, 27);
            fAudio_getFromTML.TabIndex = 0;
            fAudio_getFromTML.TabStop = true;
            fAudio_getFromTML.Text = "tModLoaderから取得する";
            fAudio_getFromTML.UseVisualStyleBackColor = true;
            fAudio_getFromTML.CheckedChanged += (object? sender, EventArgs e) =>
            {
                if (sender is RadioButton radioButton && radioButton.Checked)
                {
                    _setupType = SetupType.TML;
                }
            };

            fAudio_getFromGitHub.AutoSize = true;
            fAudio_getFromGitHub.Enabled = false;
            fAudio_getFromGitHub.Location = new Point(16, 64);
            fAudio_getFromGitHub.Name = "fAudio_getFromGitHub";
            fAudio_getFromGitHub.Size = new Size(172, 27);
            fAudio_getFromGitHub.TabIndex = 1;
            fAudio_getFromGitHub.TabStop = true;
            fAudio_getFromGitHub.Text = "GitHubから取得する";
            fAudio_getFromGitHub.UseVisualStyleBackColor = true;

            fAudio_getFromLocal.AutoSize = true;
            fAudio_getFromLocal.Checked = (setupType == SetupType.Local);
            fAudio_getFromLocal.Location = new Point(16, 96);
            fAudio_getFromLocal.Name = "fAudio_getFromLocal";
            fAudio_getFromLocal.Size = new Size(257, 27);
            fAudio_getFromLocal.TabIndex = 2;
            fAudio_getFromLocal.TabStop = true;
            fAudio_getFromLocal.Text = "ローカル(その他場所)からコピーする";
            fAudio_getFromLocal.UseVisualStyleBackColor = true;
            fAudio_getFromLocal.CheckedChanged += (object? sender, EventArgs e) =>
            {
                if (sender is RadioButton radioButton && radioButton.Checked)
                {
                    _setupType = SetupType.Local;
                }
            };

            _dynamicControls.Add(description);
            _dynamicControls.Add(fAudioRadioGroup);
            Controls.Add(description);
            Controls.Add(fAudioRadioGroup);

            // buttonContainer.ResumeLayout(false);
            fAudioRadioGroup.ResumeLayout(false);
            fAudioRadioGroup.PerformLayout();
            // ResumeLayout(false);
            // PerformLayout();

            _setupType = setupType;
        }
        private void StartPage_OnClickPrevButton(object? sender, EventArgs e)
        {
            Close();
        }
        private void StartPage_OnClickNextButton(object? sender, EventArgs e)
        {
            prevButton.Click -= StartPage_OnClickPrevButton;
            nextButton.Click -= StartPage_OnClickNextButton;
            ResetPage(sender, e);
            switch (_setupType)
            {
                case SetupType.TML:
                    CreatePage_tMLPage0();
                    return;
                case SetupType.Local:
                    CreatePage_LocalPage1();
                    return;
            }
            Close();
        }


        private void CreatePage_tMLPage0()
        {
            prevButton.Text = "戻る";
            prevButton.Click += TMLPage0_OnClickPrevButton;
            nextButton.Text = "次へ";
            nextButton.Click += TMLPage0_OnClickNextButton;

            Label title = new Label();
            Label noteHeader = new Label();
            Label noteText = new Label();
            Button openTMLSaveFolderButton = new Button();

            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(16, 16);
            title.Name = "title";
            title.Size = new Size(358, 23);
            title.TabIndex = 1;
            title.Text = "tModLoader v1.4.4からFAudio.dllを取得する 0/3";

            noteHeader.AutoSize = true;
            noteHeader.ForeColor = Color.Red;
            noteHeader.Location = new Point(16, 64);
            noteHeader.Name = "noteHeader";
            noteHeader.Size = new Size(48, 23);
            noteHeader.TabIndex = 2;
            noteHeader.Text = "注意:";

            noteText.AutoSize = true;
            noteText.ForeColor = Color.Red;
            noteText.Location = new Point(64, 64);
            noteText.Name = "noteText";
            noteText.Size = new Size(456, 69);
            noteText.TabIndex = 3;
            noteText.Text = "このセットアップでtModLoaderのバージョンの切り替えを行います。\n今までに一度もtModLoaderのバージョンを切り替えていない場合、\n一度セーブデータのバックアップを取ることを推奨します。";

            openTMLSaveFolderButton.Location = new Point(180, 160);
            openTMLSaveFolderButton.Name = "openTMLSaveFolderButton";
            openTMLSaveFolderButton.Size = new Size(256, 30);
            openTMLSaveFolderButton.TabIndex = 4;
            openTMLSaveFolderButton.Text = "セーブデータのあるフォルダを開く";
            openTMLSaveFolderButton.UseVisualStyleBackColor = true;
            string tMLSaveFolderPath = $"C:\\Users\\{Environment.UserName}\\Documents\\My Games\\Terraria";
            if (Directory.Exists(tMLSaveFolderPath))
            {
                openTMLSaveFolderButton.Click += (_, _) => Process.Start("EXPLORER.EXE", tMLSaveFolderPath);
            }
            else
            {
                openTMLSaveFolderButton.Enabled = false;
            }

            _dynamicControls.Add(title);
            _dynamicControls.Add(noteHeader);
            _dynamicControls.Add(noteText);
            _dynamicControls.Add(openTMLSaveFolderButton);
            Controls.Add(openTMLSaveFolderButton);
            Controls.Add(noteText);
            Controls.Add(noteHeader);
            Controls.Add(title);
        }
        private void TMLPage0_OnClickPrevButton(object? sender, EventArgs e)
        {
            prevButton.Click -= TMLPage0_OnClickPrevButton;
            nextButton.Click -= TMLPage0_OnClickNextButton;
            ResetPage(sender, e);
            CreatePage_Start(SetupType.TML);
        }
        private void TMLPage0_OnClickNextButton(object? sender, EventArgs e)
        {
            prevButton.Click -= TMLPage0_OnClickPrevButton;
            nextButton.Click -= TMLPage0_OnClickNextButton;
            ResetPage(sender, e);
            CreatePage_tMLPage1();
        }

        private void CreatePage_tMLPage1()
        {
            prevButton.Text = "戻る";
            prevButton.Click += TMLPage1_OnClickPrevButton;
            nextButton.Text = "次へ";
            nextButton.Click += TMLPage1_OnClickNextButton;

            Label title = new Label();
            Label description = new Label();
            Label howto = new Label();

            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(16, 16);
            title.Name = "title";
            title.Size = new Size(356, 23);
            title.TabIndex = 1;
            title.Text = "tModLoader v1.4.4からFAudio.dllを取得する 1/3";

            description.AutoSize = true;
            description.Location = new Point(16, 64);
            description.Name = "description";
            description.Size = new Size(473, 46);
            description.TabIndex = 2;
            description.Text = "tModLoaderのバージョンをv1.4.4に切り替えます。\n切り替えたら、起動せずに「次へ」を押してセットアップを進めてください。";

            howto.AutoSize = true;
            howto.ForeColor = SystemColors.ControlDarkDark;
            howto.Location = new Point(16, 128);
            howto.Name = "howto";
            howto.Size = new Size(538, 138);
            howto.TabIndex = 3;
            howto.Text = "(tModLoader v1.4.4への切り替え方)\n1. SteamのライブラリにあるtModLoaderを右クリックします\n2. 「プロパティ...」を選択します (新しくウインドウが開きます)\n3. ウインドウの左側にあるタブの「ベータ」を選択します\n4. ベータへの参加で「なし」を選択します\n5. ライブラリに戻ってインストールボタンを押します (基本的に自動的に始まります)";

            _dynamicControls.Add(title);
            _dynamicControls.Add(description);
            _dynamicControls.Add(howto);
            Controls.Add(howto);
            Controls.Add(description);
            Controls.Add(title);
        }
        private void TMLPage1_OnClickPrevButton(object? sender, EventArgs e)
        {
            prevButton.Click -= TMLPage1_OnClickPrevButton;
            nextButton.Click -= TMLPage1_OnClickNextButton;
            ResetPage(sender, e);
            CreatePage_tMLPage0();
        }
        private void TMLPage1_OnClickNextButton(object? sender, EventArgs e)
        {
            prevButton.Click -= TMLPage1_OnClickPrevButton;
            nextButton.Click -= TMLPage1_OnClickNextButton;
            ResetPage(sender, e);
            CreatePage_tMLPage2();
        }

        private void CreatePage_tMLPage2()
        {
            prevButton.Text = "戻る";
            prevButton.Click += TMLPage2_OnClickPrevButton;
            nextButton.Text = "取得する";
            nextButton.Click += TMLPage2_OnClickNextButton;

            Label title = new Label();
            Label description = new Label();
            TextBox tMLPathTextBox = new TextBox();
            Button tMLPathRefButton = new Button();

            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(16, 16);
            title.Name = "title";
            title.Size = new Size(358, 23);
            title.TabIndex = 1;
            title.Text = "tModLoader v1.4.4からFAudio.dllを取得する 2/3";

            description.AutoSize = true;
            description.Location = new Point(16, 64);
            description.Name = "description";
            description.Size = new Size(440, 46);
            description.TabIndex = 2;
            description.Text = "tModLoaderからFAudio.dllを取得します。\ntModLoaderのインストールされているフォルダを指定してください。";

            tMLPathTextBox.Location = new Point(16, 120);
            tMLPathTextBox.Name = "tMLPathTextBox";
            tMLPathTextBox.Size = new Size(520, 30);
            tMLPathTextBox.TabIndex = 3;
            tMLPathTextBox.Text = _tMLPath;
            tMLPathTextBox.TextChanged += (object? sender, EventArgs e) =>
            {
                if (sender is TextBox textBox)
                {
                    _tMLPath = textBox.Text;
                }
            };

            tMLPathRefButton.Location = new Point(544, 120);
            tMLPathRefButton.Name = "tMLPathRefButton";
            tMLPathRefButton.Size = new Size(64, 30);
            tMLPathRefButton.TabIndex = 4;
            tMLPathRefButton.Text = "参照";
            tMLPathRefButton.UseVisualStyleBackColor = true;
            tMLPathRefButton.Click += (_, _) =>
            {
                DialogResult result = _tMLFolderBrowserDialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                tMLPathTextBox.Text = _tMLFolderBrowserDialog.SelectedPath;
                _tMLPath = tMLPathTextBox.Text;
            };

            _dynamicControls.Add(title);
            _dynamicControls.Add(description);
            _dynamicControls.Add(tMLPathTextBox);
            _dynamicControls.Add(tMLPathRefButton);
            Controls.Add(tMLPathRefButton);
            Controls.Add(tMLPathTextBox);
            Controls.Add(description);
            Controls.Add(title);
        }
        private void TMLPage2_OnClickPrevButton(object? sender, EventArgs e)
        {
            prevButton.Click -= TMLPage2_OnClickPrevButton;
            nextButton.Click -= TMLPage2_OnClickNextButton;
            // nextButton.Enabled = true;
            ResetPage(sender, e);
            CreatePage_tMLPage1();
        }
        private void TMLPage2_OnClickNextButton(object? sender, EventArgs e)
        {
            if (!Directory.Exists(_tMLPath))
            {
                MessageBox.Show("指定されたフォルダが見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tMLFAudioPath = Pathes.GetTMLFAudioPathFromTMLPath(_tMLPath);
            if (!File.Exists(tMLFAudioPath))
            {
                MessageBox.Show("指定されたフォルダからFAudio.dllが見つかりませんでした。\n指定したフォルダはtModLoaderではない可能性があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                File.Copy(tMLFAudioPath, Pathes.GetGetApplicationFAudio144Path(), true);
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
            prevButton.Click -= TMLPage2_OnClickPrevButton;
            nextButton.Click -= TMLPage2_OnClickNextButton;
            ResetPage(sender, e);
            CreatePage_Finish();
        }
        /*
        private void CheckTMLDirectoryPath(string path)
        {
            nextButton.Enabled = (Directory.Exists(path));
        }
        */


        private void CreatePage_LocalPage1()
        {
            prevButton.Text = "戻る";
            prevButton.Click += LocalPage1_OnClickPrevButton;
            nextButton.Text = "取得する";
            nextButton.Click += LocalPage1_OnClickNextButton;

            Label title = new Label();
            Label description = new Label();
            TextBox fAudioPathTextBox = new TextBox();
            Button fAudioPathRefButton = new Button();

            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(16, 16);
            title.Name = "title";
            title.Size = new Size(236, 23);
            title.TabIndex = 1;
            title.Text = "ローカルからFAudio.dllを取得する";

            description.AutoSize = true;
            description.Location = new Point(16, 64);
            description.Name = "description";
            description.Size = new Size(301, 23);
            description.TabIndex = 2;
            description.Text = "ファイルを指定してFAudio.dllを取得します。";

            fAudioPathTextBox.Location = new Point(16, 96);
            fAudioPathTextBox.Name = "fAudioPathTextBox";
            fAudioPathTextBox.Size = new Size(520, 30);
            fAudioPathTextBox.TabIndex = 3;
            fAudioPathTextBox.Text = _fAudioPath;
            fAudioPathTextBox.TextChanged += (object? sender, EventArgs e) =>
            {
                if (sender is TextBox textBox)
                {
                    _fAudioPath = textBox.Text;
                }
            };

            fAudioPathRefButton.Location = new Point(544, 96);
            fAudioPathRefButton.Name = "fAudioPathRefButton";
            fAudioPathRefButton.Size = new Size(64, 30);
            fAudioPathRefButton.TabIndex = 4;
            fAudioPathRefButton.Text = "参照";
            fAudioPathRefButton.UseVisualStyleBackColor = true;
            fAudioPathRefButton.Click += (_, _) =>
            {
                DialogResult result = openFAudioDialog.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
                fAudioPathTextBox.Text = openFAudioDialog.FileName;
                _fAudioPath = fAudioPathTextBox.Text;
            };

            _dynamicControls.Add(title);
            _dynamicControls.Add(description);
            _dynamicControls.Add(fAudioPathTextBox);
            _dynamicControls.Add(fAudioPathRefButton);
            Controls.Add(fAudioPathRefButton);
            Controls.Add(fAudioPathTextBox);
            Controls.Add(description);
            Controls.Add(title);
        }
        private void LocalPage1_OnClickPrevButton(object? sender, EventArgs e)
        {
            prevButton.Click -= LocalPage1_OnClickPrevButton;
            nextButton.Click -= LocalPage1_OnClickNextButton;
            ResetPage(sender, e);
            CreatePage_Start(SetupType.Local);
        }
        private void LocalPage1_OnClickNextButton(object? sender, EventArgs e)
        {
            if (!File.Exists(_fAudioPath))
            {
                MessageBox.Show("指定したフォルダが見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                File.Copy(_fAudioPath, Pathes.GetGetApplicationFAudio144Path(), true);
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
            prevButton.Click -= LocalPage1_OnClickPrevButton;
            nextButton.Click -= LocalPage1_OnClickNextButton;
            ResetPage(sender, e);
            CreatePage_Finish();
        }


        private void CreatePage_Finish()
        {
            prevButton.Text = "戻る";
            prevButton.Enabled = false;
            nextButton.Text = "完了";
            nextButton.Click += FinishPage_OnClickNextButton;

            Label description = new Label();
            Label howto = new Label();

            description.AutoSize = true;
            description.Location = new Point(16, 16);
            description.Name = "description";
            description.Size = new Size(586, 92);
            description.TabIndex = 2;
            description.Text = "FAudio.dllの取得が完了しました。\nセットアップは終了しました。「完了」を押してこのダイアログを閉じることができます。\ntModLoaderのバージョンをv1.4.3に切り替えて、「FAudio.dllの入れ替えを実行する」を\n押すと、FAudio.dllを入れ替えることができます。";

            howto.AutoSize = true;
            howto.ForeColor = SystemColors.ControlDarkDark;
            howto.Location = new Point(16, 128);
            howto.Name = "howto";
            howto.Size = new Size(538, 138);
            howto.TabIndex = 3;
            howto.Text = "(tModLoader v1.4.3への切り替え方)\n1. SteamのライブラリにあるtModLoaderを右クリックします\n2. 「プロパティ...」を選択します (新しくウインドウが開きます)\n3. ウインドウの左側にあるタブの「ベータ」を選択します\n4. ベータへの参加で「1.4.3-legacy」から始まる選択肢を選択します\n5. ライブラリに戻ってインストールボタンを押します (基本的に自動的に始まります)";

            _dynamicControls.Add(description);
            _dynamicControls.Add(howto);
            Controls.Add(howto);
            Controls.Add(description);
        }
        private void FinishPage_OnClickNextButton(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
