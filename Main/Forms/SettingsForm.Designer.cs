namespace FactorioLoader.Main.Forms
{
    partial class SettingsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.handleProtocolCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.doneButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.exeFolder = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.modFolder = new MetroFramework.Controls.MetroTextBox();
            this.setModFolderButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.handleProtocolCheckbox);
            this.panel1.Controls.Add(this.doneButton);
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 149);
            this.panel1.TabIndex = 0;
            // 
            // handleProtocolCheckbox
            // 
            this.handleProtocolCheckbox.AutoSize = true;
            this.handleProtocolCheckbox.Location = new System.Drawing.Point(3, 131);
            this.handleProtocolCheckbox.Name = "handleProtocolCheckbox";
            this.handleProtocolCheckbox.Size = new System.Drawing.Size(267, 15);
            this.handleProtocolCheckbox.TabIndex = 7;
            this.handleProtocolCheckbox.Text = "Use Factorlo Loader with factoriomods:// links";
            this.handleProtocolCheckbox.UseSelectable = true;
            this.handleProtocolCheckbox.CheckedChanged += new System.EventHandler(this.handleProtocolCheckbox_CheckedChanged);
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.Image = null;
            this.doneButton.Location = new System.Drawing.Point(429, 117);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(104, 29);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.UseSelectable = true;
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(3, 69);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.exeFolder);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.metroButton1);
            this.splitContainer2.Size = new System.Drawing.Size(530, 22);
            this.splitContainer2.SplitterDistance = 418;
            this.splitContainer2.TabIndex = 4;
            // 
            // exeFolder
            // 
            // 
            // 
            // 
            this.exeFolder.CustomButton.Image = null;
            this.exeFolder.CustomButton.Location = new System.Drawing.Point(398, 2);
            this.exeFolder.CustomButton.Name = "";
            this.exeFolder.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.exeFolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.exeFolder.CustomButton.TabIndex = 1;
            this.exeFolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.exeFolder.CustomButton.UseSelectable = true;
            this.exeFolder.CustomButton.Visible = false;
            this.exeFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exeFolder.Lines = new string[] {
        "metroTextBox2"};
            this.exeFolder.Location = new System.Drawing.Point(0, 0);
            this.exeFolder.MaxLength = 32767;
            this.exeFolder.Name = "exeFolder";
            this.exeFolder.PasswordChar = '\0';
            this.exeFolder.ReadOnly = true;
            this.exeFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.exeFolder.SelectedText = "";
            this.exeFolder.SelectionLength = 0;
            this.exeFolder.SelectionStart = 0;
            this.exeFolder.Size = new System.Drawing.Size(418, 22);
            this.exeFolder.TabIndex = 1;
            this.exeFolder.Text = "metroTextBox2";
            this.exeFolder.UseSelectable = true;
            this.exeFolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.exeFolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 22);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Browse";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Factorio.exe Path";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 22);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.modFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.setModFolderButton);
            this.splitContainer1.Size = new System.Drawing.Size(530, 22);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 2;
            // 
            // modFolder
            // 
            // 
            // 
            // 
            this.modFolder.CustomButton.Image = null;
            this.modFolder.CustomButton.Location = new System.Drawing.Point(398, 2);
            this.modFolder.CustomButton.Name = "";
            this.modFolder.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.modFolder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.modFolder.CustomButton.TabIndex = 1;
            this.modFolder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.modFolder.CustomButton.UseSelectable = true;
            this.modFolder.CustomButton.Visible = false;
            this.modFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modFolder.Lines = new string[] {
        "metroTextBox1"};
            this.modFolder.Location = new System.Drawing.Point(0, 0);
            this.modFolder.MaxLength = 32767;
            this.modFolder.Name = "modFolder";
            this.modFolder.PasswordChar = '\0';
            this.modFolder.ReadOnly = true;
            this.modFolder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.modFolder.SelectedText = "";
            this.modFolder.SelectionLength = 0;
            this.modFolder.SelectionStart = 0;
            this.modFolder.Size = new System.Drawing.Size(418, 22);
            this.modFolder.TabIndex = 1;
            this.modFolder.Text = "metroTextBox1";
            this.modFolder.UseSelectable = true;
            this.modFolder.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.modFolder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // setModFolderButton
            // 
            this.setModFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setModFolderButton.Location = new System.Drawing.Point(0, 0);
            this.setModFolderButton.Name = "setModFolderButton";
            this.setModFolderButton.Size = new System.Drawing.Size(108, 22);
            this.setModFolderButton.TabIndex = 0;
            this.setModFolderButton.Text = "Browse";
            this.setModFolderButton.UseSelectable = true;
            this.setModFolderButton.Click += new System.EventHandler(this.setModFolderButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Mod Folder";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 229);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(575, 229);
            this.Name = "SettingsForm";
            this.Text = "Factorio Loader Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox modFolder;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private MetroFramework.Controls.MetroTextBox exeFolder;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton setModFolderButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton doneButton;
        private MetroFramework.Controls.MetroCheckBox handleProtocolCheckbox;
    }
}