﻿namespace FactorioLoader.Main.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.topPanel = new MetroFramework.Controls.MetroPanel();
            this.currentProfileModCount = new MetroFramework.Controls.MetroLabel();
            this.profileModsGrid = new MetroFramework.Controls.MetroGrid();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editProfileTile = new MetroFramework.Controls.MetroTile();
            this.profileComboBox = new MetroFramework.Controls.MetroComboBox();
            this.settingsTile = new MetroFramework.Controls.MetroTile();
            this.startButton = new MetroFramework.Controls.MetroTile();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileModsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(20, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(552, 233);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.currentProfileModCount);
            this.topPanel.Controls.Add(this.profileModsGrid);
            this.topPanel.Controls.Add(this.editProfileTile);
            this.topPanel.Controls.Add(this.profileComboBox);
            this.topPanel.Controls.Add(this.settingsTile);
            this.topPanel.Controls.Add(this.startButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.HorizontalScrollbarBarColor = true;
            this.topPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.topPanel.HorizontalScrollbarSize = 10;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(552, 233);
            this.topPanel.TabIndex = 3;
            this.topPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.topPanel.VerticalScrollbarBarColor = true;
            this.topPanel.VerticalScrollbarHighlightOnWheel = false;
            this.topPanel.VerticalScrollbarSize = 10;
            // 
            // currentProfileModCount
            // 
            this.currentProfileModCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentProfileModCount.AutoSize = true;
            this.currentProfileModCount.FontSize = MetroFramework.MetroLabelSize.Small;
            this.currentProfileModCount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.currentProfileModCount.Location = new System.Drawing.Point(494, 211);
            this.currentProfileModCount.Name = "currentProfileModCount";
            this.currentProfileModCount.Size = new System.Drawing.Size(55, 15);
            this.currentProfileModCount.TabIndex = 14;
            this.currentProfileModCount.Text = "Mods: 17";
            this.currentProfileModCount.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // profileModsGrid
            // 
            this.profileModsGrid.AllowUserToAddRows = false;
            this.profileModsGrid.AllowUserToDeleteRows = false;
            this.profileModsGrid.AllowUserToResizeColumns = false;
            this.profileModsGrid.AllowUserToResizeRows = false;
            this.profileModsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileModsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileModsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profileModsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.profileModsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileModsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.profileModsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileModsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modName,
            this.modVersion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profileModsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.profileModsGrid.EnableHeadersVisualStyles = false;
            this.profileModsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.profileModsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileModsGrid.Location = new System.Drawing.Point(348, 38);
            this.profileModsGrid.Name = "profileModsGrid";
            this.profileModsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileModsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.profileModsGrid.RowHeadersVisible = false;
            this.profileModsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.profileModsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profileModsGrid.Size = new System.Drawing.Size(201, 170);
            this.profileModsGrid.TabIndex = 13;
            this.profileModsGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // modName
            // 
            this.modName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modName.HeaderText = "Name";
            this.modName.Name = "modName";
            this.modName.ReadOnly = true;
            // 
            // modVersion
            // 
            this.modVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.modVersion.HeaderText = "Version";
            this.modVersion.Name = "modVersion";
            this.modVersion.ReadOnly = true;
            this.modVersion.Width = 68;
            // 
            // editProfileTile
            // 
            this.editProfileTile.ActiveControl = null;
            this.editProfileTile.Location = new System.Drawing.Point(262, 3);
            this.editProfileTile.Name = "editProfileTile";
            this.editProfileTile.Size = new System.Drawing.Size(80, 80);
            this.editProfileTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.editProfileTile.TabIndex = 12;
            this.editProfileTile.Text = "Edit Profile";
            this.editProfileTile.UseSelectable = true;
            this.editProfileTile.UseStyleColors = true;
            this.editProfileTile.Click += new System.EventHandler(this.editProfileTile_Click);
            // 
            // profileComboBox
            // 
            this.profileComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.ItemHeight = 23;
            this.profileComboBox.Items.AddRange(new object[] {
            "Default"});
            this.profileComboBox.Location = new System.Drawing.Point(348, 3);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(201, 29);
            this.profileComboBox.TabIndex = 7;
            this.profileComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.profileComboBox.UseSelectable = true;
            this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.profileComboBox_SelectedIndexChanged);
            // 
            // settingsTile
            // 
            this.settingsTile.ActiveControl = null;
            this.settingsTile.Location = new System.Drawing.Point(176, 3);
            this.settingsTile.Name = "settingsTile";
            this.settingsTile.Size = new System.Drawing.Size(80, 80);
            this.settingsTile.TabIndex = 3;
            this.settingsTile.Text = "Settings";
            this.settingsTile.UseSelectable = true;
            // 
            // startButton
            // 
            this.startButton.ActiveControl = null;
            this.startButton.Location = new System.Drawing.Point(3, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(167, 167);
            this.startButton.Style = MetroFramework.MetroColorStyle.Green;
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Play Factorio";
            this.startButton.TileImage = global::FactorioLoader.Properties.Resources.factorio13;
            this.startButton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startButton.UseSelectable = true;
            this.startButton.UseStyleColors = true;
            this.startButton.UseTileImage = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(592, 313);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Factorio Loader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileModsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroPanel topPanel;
        private MetroFramework.Controls.MetroTile startButton;
        private MetroFramework.Controls.MetroTile settingsTile;
        private MetroFramework.Controls.MetroComboBox profileComboBox;
        private MetroFramework.Controls.MetroTile editProfileTile;
        private MetroFramework.Controls.MetroGrid profileModsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modVersion;
        private MetroFramework.Controls.MetroLabel currentProfileModCount;
    }
}