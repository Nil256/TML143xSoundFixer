namespace TML143xSoundFixer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tMLPathLabel = new Label();
            tMLPathTextBox = new TextBox();
            tMLPathRefButton = new Button();
            tMLFAudioPathLabel = new Label();
            tMLFAudioPathTextBox = new TextBox();
            tMLFAudioPathRefButton = new Button();
            tMLPathRefDialog = new FolderBrowserDialog();
            tMLFAudioPathRefDialog = new OpenFileDialog();
            noteLabel = new Label();
            buttonContainer = new Panel();
            setupButton = new Button();
            runButton = new Button();
            buttonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tMLPathLabel
            // 
            tMLPathLabel.AutoSize = true;
            tMLPathLabel.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tMLPathLabel.Location = new Point(16, 16);
            tMLPathLabel.Name = "tMLPathLabel";
            tMLPathLabel.Size = new Size(384, 23);
            tMLPathLabel.TabIndex = 0;
            tMLPathLabel.Text = "tModLoaderがインストールされているフォルダの絶対パス";
            // 
            // tMLPathTextBox
            // 
            tMLPathTextBox.Location = new Point(32, 48);
            tMLPathTextBox.Name = "tMLPathTextBox";
            tMLPathTextBox.Size = new Size(800, 30);
            tMLPathTextBox.TabIndex = 2;
            tMLPathTextBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\tModLoader";
            // 
            // tMLPathRefButton
            // 
            tMLPathRefButton.Location = new Point(840, 48);
            tMLPathRefButton.Name = "tMLPathRefButton";
            tMLPathRefButton.Size = new Size(64, 30);
            tMLPathRefButton.TabIndex = 3;
            tMLPathRefButton.Text = "参照";
            tMLPathRefButton.UseVisualStyleBackColor = true;
            tMLPathRefButton.Click += tMLPathRefButton_Click;
            // 
            // tMLFAudioPathLabel
            // 
            tMLFAudioPathLabel.AutoSize = true;
            tMLFAudioPathLabel.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tMLFAudioPathLabel.Location = new Point(16, 96);
            tMLFAudioPathLabel.Name = "tMLFAudioPathLabel";
            tMLFAudioPathLabel.Size = new Size(283, 23);
            tMLFAudioPathLabel.TabIndex = 3;
            tMLFAudioPathLabel.Text = "tModLoader内のFAudio.dllの絶対パス";
            // 
            // tMLFAudioPathTextBox
            // 
            tMLFAudioPathTextBox.Location = new Point(32, 128);
            tMLFAudioPathTextBox.Name = "tMLFAudioPathTextBox";
            tMLFAudioPathTextBox.Size = new Size(800, 30);
            tMLFAudioPathTextBox.TabIndex = 4;
            tMLFAudioPathTextBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\tModLoader\\Libraries\\Native\\Windows\\FAudio.dll";
            // 
            // tMLFAudioPathRefButton
            // 
            tMLFAudioPathRefButton.Location = new Point(840, 128);
            tMLFAudioPathRefButton.Name = "tMLFAudioPathRefButton";
            tMLFAudioPathRefButton.Size = new Size(64, 30);
            tMLFAudioPathRefButton.TabIndex = 5;
            tMLFAudioPathRefButton.Text = "参照";
            tMLFAudioPathRefButton.UseVisualStyleBackColor = true;
            tMLFAudioPathRefButton.Click += tMLFAudioPathRefButton_Click;
            // 
            // tMLPathRefDialog
            // 
            tMLPathRefDialog.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common";
            tMLPathRefDialog.RootFolder = Environment.SpecialFolder.CommonProgramFilesX86;
            tMLPathRefDialog.SelectedPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\tModLoader";
            tMLPathRefDialog.ShowNewFolderButton = false;
            // 
            // tMLFAudioPathRefDialog
            // 
            tMLFAudioPathRefDialog.DefaultExt = "dll";
            tMLFAudioPathRefDialog.FileName = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\tModLoader\\Libraries\\Native\\Windows\\FAudio.dll";
            tMLFAudioPathRefDialog.Filter = "ダイナミックリンクライブラリ|*.dll";
            tMLFAudioPathRefDialog.InitialDirectory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\tModLoader\\Libraries\\Native\\Windows";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(16, 188);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(803, 161);
            noteLabel.TabIndex = 6;
            noteLabel.Text = resources.GetString("noteLabel.Text");
            // 
            // buttonContainer
            // 
            buttonContainer.BackColor = Color.FromArgb(224, 224, 224);
            buttonContainer.Controls.Add(setupButton);
            buttonContainer.Controls.Add(runButton);
            buttonContainer.Location = new Point(0, 370);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Size = new Size(942, 64);
            buttonContainer.TabIndex = 0;
            // 
            // setupButton
            // 
            setupButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            setupButton.Location = new Point(528, 14);
            setupButton.Name = "setupButton";
            setupButton.Size = new Size(128, 40);
            setupButton.TabIndex = 1;
            setupButton.Text = "セットアップする";
            setupButton.UseVisualStyleBackColor = true;
            setupButton.Click += setupButton_Click;
            // 
            // runButton
            // 
            runButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            runButton.Location = new Point(672, 14);
            runButton.Name = "runButton";
            runButton.Size = new Size(256, 40);
            runButton.TabIndex = 0;
            runButton.Text = "FAudio.dllの入れ替えを実行する";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 433);
            Controls.Add(buttonContainer);
            Controls.Add(noteLabel);
            Controls.Add(tMLFAudioPathRefButton);
            Controls.Add(tMLFAudioPathTextBox);
            Controls.Add(tMLFAudioPathLabel);
            Controls.Add(tMLPathRefButton);
            Controls.Add(tMLPathTextBox);
            Controls.Add(tMLPathLabel);
            Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "tModLoader v1.4.3 音質改善ソフトウェア";
            HelpButtonClicked += Form1_HelpButtonClicked;
            buttonContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tMLPathLabel;
        private TextBox tMLPathTextBox;
        private Button tMLPathRefButton;
        private Label tMLFAudioPathLabel;
        private TextBox tMLFAudioPathTextBox;
        private Button tMLFAudioPathRefButton;
        private FolderBrowserDialog tMLPathRefDialog;
        private OpenFileDialog tMLFAudioPathRefDialog;
        private Label noteLabel;
        private Panel buttonContainer;
        private Button runButton;
        private Button setupButton;
    }
}
