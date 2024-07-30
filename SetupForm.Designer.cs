namespace TML143xSoundFixer
{
    partial class SetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonContainer = new Panel();
            prevButton = new Button();
            nextButton = new Button();
            openFAudioDialog = new OpenFileDialog();
            buttonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // buttonContainer
            // 
            buttonContainer.BackColor = Color.FromArgb(224, 224, 224);
            buttonContainer.Controls.Add(prevButton);
            buttonContainer.Controls.Add(nextButton);
            buttonContainer.Dock = DockStyle.Bottom;
            buttonContainer.Location = new Point(0, 284);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Size = new Size(622, 53);
            buttonContainer.TabIndex = 0;
            // 
            // prevButton
            // 
            prevButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            prevButton.Location = new Point(400, 11);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(100, 30);
            prevButton.TabIndex = 1;
            prevButton.Text = "戻る";
            prevButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextButton.Location = new Point(512, 11);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(100, 30);
            nextButton.TabIndex = 0;
            nextButton.Text = "次へ";
            nextButton.UseVisualStyleBackColor = true;
            // 
            // openFAudioDialog
            // 
            openFAudioDialog.Filter = "ダイナミックリンクライブラリ|*.dll";
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 337);
            Controls.Add(buttonContainer);
            Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetupForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "セットアップ";
            buttonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonContainer;
        private Button nextButton;
        private Button prevButton;
        private OpenFileDialog openFAudioDialog;
    }
}