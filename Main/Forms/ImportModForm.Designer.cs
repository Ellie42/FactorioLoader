namespace FactorioLoader.Main.Forms
{
    partial class ImportModForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.modUrl = new MetroFramework.Controls.MetroLink();
            this.modTitle = new MetroFramework.Controls.MetroLabel();
            this.downloadStatus = new MetroFramework.Controls.MetroLabel();
            this.downloadButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.cancelButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.modDownloadProgress = new MetroFramework.Controls.MetroProgressBar();
            this.modVersion = new MetroFramework.Controls.MetroLabel();
            this.modName = new MetroFramework.Controls.MetroLabel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.modUrl);
            this.mainPanel.Controls.Add(this.modTitle);
            this.mainPanel.Controls.Add(this.downloadStatus);
            this.mainPanel.Controls.Add(this.downloadButton);
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Controls.Add(this.modDownloadProgress);
            this.mainPanel.Controls.Add(this.modVersion);
            this.mainPanel.Controls.Add(this.modName);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(478, 174);
            this.mainPanel.TabIndex = 0;
            // 
            // modUrl
            // 
            this.modUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modUrl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modUrl.Location = new System.Drawing.Point(3, 110);
            this.modUrl.Name = "modUrl";
            this.modUrl.Size = new System.Drawing.Size(472, 23);
            this.modUrl.TabIndex = 11;
            this.modUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modUrl.UseSelectable = true;
            // 
            // modTitle
            // 
            this.modTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.modTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.modTitle.Location = new System.Drawing.Point(4, 9);
            this.modTitle.Name = "modTitle";
            this.modTitle.Size = new System.Drawing.Size(308, 25);
            this.modTitle.TabIndex = 10;
            this.modTitle.Text = "metroLabel3";
            this.modTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downloadStatus
            // 
            this.downloadStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadStatus.AutoSize = true;
            this.downloadStatus.FontSize = MetroFramework.MetroLabelSize.Small;
            this.downloadStatus.Location = new System.Drawing.Point(0, 92);
            this.downloadStatus.Name = "downloadStatus";
            this.downloadStatus.Size = new System.Drawing.Size(98, 15);
            this.downloadStatus.TabIndex = 9;
            this.downloadStatus.Text = "Waiting for input...";
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadButton.Image = null;
            this.downloadButton.Location = new System.Drawing.Point(261, 142);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(104, 29);
            this.downloadButton.TabIndex = 8;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseSelectable = true;
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Image = null;
            this.cancelButton.Location = new System.Drawing.Point(371, 142);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 29);
            this.cancelButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseSelectable = true;
            this.cancelButton.UseStyleColors = true;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // modDownloadProgress
            // 
            this.modDownloadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modDownloadProgress.Location = new System.Drawing.Point(3, 62);
            this.modDownloadProgress.Name = "modDownloadProgress";
            this.modDownloadProgress.Size = new System.Drawing.Size(472, 23);
            this.modDownloadProgress.TabIndex = 4;
            // 
            // modVersion
            // 
            this.modVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modVersion.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.modVersion.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.modVersion.Location = new System.Drawing.Point(318, 9);
            this.modVersion.Name = "modVersion";
            this.modVersion.Size = new System.Drawing.Size(157, 25);
            this.modVersion.TabIndex = 3;
            this.modVersion.Text = "awdawdwaffesf";
            this.modVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // modName
            // 
            this.modName.AutoSize = true;
            this.modName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.modName.Location = new System.Drawing.Point(4, 34);
            this.modName.Name = "modName";
            this.modName.Size = new System.Drawing.Size(86, 19);
            this.modName.TabIndex = 2;
            this.modName.Text = "metroLabel3";
            this.modName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImportModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 254);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(465, 248);
            this.Name = "ImportModForm";
            this.Text = "Adding new Mod";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportModForm_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private MetroFramework.Controls.MetroLabel modVersion;
        private MetroFramework.Controls.MetroLabel modName;
        private MetroFramework.Controls.MetroProgressBar modDownloadProgress;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton downloadButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton cancelButton;
        private MetroFramework.Controls.MetroLabel downloadStatus;
        private MetroFramework.Controls.MetroLabel modTitle;
        private MetroFramework.Controls.MetroLink modUrl;
    }
}