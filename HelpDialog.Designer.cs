namespace TML143xSoundFixer
{
    partial class HelpDialog
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
            howToUseHeader = new Label();
            howToUse = new Label();
            gitHubLinkHeader = new Label();
            gitHubLink = new LinkLabel();
            closeButton = new Button();
            SuspendLayout();
            // 
            // howToUseHeader
            // 
            howToUseHeader.AutoSize = true;
            howToUseHeader.Location = new Point(16, 16);
            howToUseHeader.Name = "howToUseHeader";
            howToUseHeader.Size = new Size(62, 23);
            howToUseHeader.TabIndex = 0;
            howToUseHeader.Text = "使い方:";
            // 
            // howToUse
            // 
            howToUse.AutoSize = true;
            howToUse.Location = new Point(80, 16);
            howToUse.Name = "howToUse";
            howToUse.Size = new Size(365, 115);
            howToUse.TabIndex = 1;
            howToUse.Text = "「セットアップする」ボタンでソフトウェアを使うための\r\nセットアップをします。\r\nセットアップが完了したら、tModLoaderを v1.4.3に\r\n切り替えた後、「FAudio.dllの入れ替えを実行する」を\r\n押すだけです。";
            // 
            // gitHubLinkHeader
            // 
            gitHubLinkHeader.AutoSize = true;
            gitHubLinkHeader.Location = new Point(16, 160);
            gitHubLinkHeader.Name = "gitHubLinkHeader";
            gitHubLinkHeader.Size = new Size(73, 23);
            gitHubLinkHeader.TabIndex = 2;
            gitHubLinkHeader.Text = "GitHub: ";
            // 
            // gitHubLink
            // 
            gitHubLink.AutoSize = true;
            gitHubLink.Location = new Point(88, 160);
            gitHubLink.Name = "gitHubLink";
            gitHubLink.Size = new Size(367, 23);
            gitHubLink.TabIndex = 3;
            gitHubLink.TabStop = true;
            gitHubLink.Text = "https://github.com/Nil256/TML143xSoundFixer";
            gitHubLink.LinkClicked += gitHubLink_LinkClicked;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(191, 224);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(80, 32);
            closeButton.TabIndex = 5;
            closeButton.Text = "閉じる";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // HelpDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = closeButton;
            ClientSize = new Size(462, 273);
            Controls.Add(closeButton);
            Controls.Add(gitHubLink);
            Controls.Add(gitHubLinkHeader);
            Controls.Add(howToUse);
            Controls.Add(howToUseHeader);
            Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HelpDialog";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "tSoundFixerについて";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label howToUseHeader;
        private Label howToUse;
        private Label gitHubLinkHeader;
        private LinkLabel gitHubLink;
        private Button closeButton;
    }
}