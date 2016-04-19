namespace FactorioLoader.Main.Forms
{
    partial class ProfileEditForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.availableModsGrid = new MetroFramework.Controls.MetroGrid();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.profileComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.profileModsGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.curModName = new MetroFramework.Controls.MetroLabel();
            this.curModDesc = new MetroFramework.Controls.MetroTextBox();
            this.addModButton = new MetroFramework.Controls.MetroButton();
            this.removeModButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableModsGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileModsGrid)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.availableModsGrid);
            this.metroPanel2.Controls.Add(this.metroComboBox1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(297, 318);
            this.metroPanel2.TabIndex = 16;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Available Mods";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // availableModsGrid
            // 
            this.availableModsGrid.AllowUserToAddRows = false;
            this.availableModsGrid.AllowUserToDeleteRows = false;
            this.availableModsGrid.AllowUserToResizeColumns = false;
            this.availableModsGrid.AllowUserToResizeRows = false;
            this.availableModsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableModsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availableModsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableModsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.availableModsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availableModsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.availableModsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableModsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modName,
            this.modVersion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availableModsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.availableModsGrid.EnableHeadersVisualStyles = false;
            this.availableModsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.availableModsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availableModsGrid.Location = new System.Drawing.Point(3, 60);
            this.availableModsGrid.Name = "availableModsGrid";
            this.availableModsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availableModsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.availableModsGrid.RowHeadersVisible = false;
            this.availableModsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.availableModsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableModsGrid.Size = new System.Drawing.Size(291, 252);
            this.availableModsGrid.TabIndex = 17;
            this.availableModsGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.availableModsGrid.SelectionChanged += new System.EventHandler(this.ChangeGridSelection);
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
            // metroComboBox1
            // 
            this.metroComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(3, 25);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(291, 29);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.UseSelectable = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(317, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.01458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.98542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 318);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.removeModButton);
            this.metroPanel1.Controls.Add(this.addModButton);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(274, 200);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.profileComboBox);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.profileModsGrid);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(34, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(240, 200);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // profileComboBox
            // 
            this.profileComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileComboBox.FormattingEnabled = true;
            this.profileComboBox.ItemHeight = 23;
            this.profileComboBox.Items.AddRange(new object[] {
            "Default"});
            this.profileComboBox.Location = new System.Drawing.Point(3, 21);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(237, 29);
            this.profileComboBox.TabIndex = 27;
            this.profileComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.profileComboBox.UseSelectable = true;
            this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.profileComboBox_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(156, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Profile Mods";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // profileModsGrid
            // 
            this.profileModsGrid.AllowUserToAddRows = false;
            this.profileModsGrid.AllowUserToDeleteRows = false;
            this.profileModsGrid.AllowUserToResizeColumns = false;
            this.profileModsGrid.AllowUserToResizeRows = false;
            this.profileModsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileModsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileModsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profileModsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.profileModsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileModsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.profileModsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileModsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profileModsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.profileModsGrid.EnableHeadersVisualStyles = false;
            this.profileModsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.profileModsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileModsGrid.Location = new System.Drawing.Point(3, 56);
            this.profileModsGrid.Name = "profileModsGrid";
            this.profileModsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileModsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.profileModsGrid.RowHeadersVisible = false;
            this.profileModsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.profileModsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profileModsGrid.Size = new System.Drawing.Size(237, 143);
            this.profileModsGrid.TabIndex = 25;
            this.profileModsGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.profileModsGrid.SelectionChanged += new System.EventHandler(this.ChangeGridSelection);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Version";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 68;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.curModDesc);
            this.metroPanel4.Controls.Add(this.curModName);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 209);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(274, 106);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // curModName
            // 
            this.curModName.AutoSize = true;
            this.curModName.Location = new System.Drawing.Point(0, 0);
            this.curModName.Name = "curModName";
            this.curModName.Size = new System.Drawing.Size(125, 19);
            this.curModName.TabIndex = 28;
            this.curModName.Text = "Current Mod Name";
            this.curModName.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // curModDesc
            // 
            this.curModDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.curModDesc.CustomButton.Image = null;
            this.curModDesc.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.curModDesc.CustomButton.Name = "";
            this.curModDesc.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.curModDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.curModDesc.CustomButton.TabIndex = 1;
            this.curModDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.curModDesc.CustomButton.UseSelectable = true;
            this.curModDesc.CustomButton.Visible = false;
            this.curModDesc.Lines = new string[] {
        "Mod Description"};
            this.curModDesc.Location = new System.Drawing.Point(4, 23);
            this.curModDesc.MaxLength = 32767;
            this.curModDesc.Multiline = true;
            this.curModDesc.Name = "curModDesc";
            this.curModDesc.PasswordChar = '\0';
            this.curModDesc.ReadOnly = true;
            this.curModDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.curModDesc.SelectedText = "";
            this.curModDesc.SelectionLength = 0;
            this.curModDesc.SelectionStart = 0;
            this.curModDesc.Size = new System.Drawing.Size(267, 80);
            this.curModDesc.TabIndex = 29;
            this.curModDesc.Text = "Mod Description";
            this.curModDesc.UseSelectable = true;
            this.curModDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.curModDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addModButton
            // 
            this.addModButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addModButton.Location = new System.Drawing.Point(3, 57);
            this.addModButton.Name = "addModButton";
            this.addModButton.Size = new System.Drawing.Size(28, 66);
            this.addModButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addModButton.TabIndex = 3;
            this.addModButton.Text = ">";
            this.addModButton.UseSelectable = true;
            this.addModButton.UseStyleColors = true;
            this.addModButton.Click += new System.EventHandler(this.addModButton_Click);
            // 
            // removeModButton
            // 
            this.removeModButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.removeModButton.Location = new System.Drawing.Point(3, 129);
            this.removeModButton.Name = "removeModButton";
            this.removeModButton.Size = new System.Drawing.Size(28, 66);
            this.removeModButton.Style = MetroFramework.MetroColorStyle.Red;
            this.removeModButton.TabIndex = 4;
            this.removeModButton.Text = "<";
            this.removeModButton.UseSelectable = true;
            this.removeModButton.UseStyleColors = true;
            this.removeModButton.Click += new System.EventHandler(this.removeModButton_Click);
            // 
            // ProfileEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 398);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.metroPanel2);
            this.MinimumSize = new System.Drawing.Size(616, 398);
            this.Name = "ProfileEditForm";
            this.Text = "Editing Profile";
            this.Load += new System.EventHandler(this.ProfileEditForm_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableModsGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileModsGrid)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid availableModsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modVersion;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox profileComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid profileModsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTextBox curModDesc;
        private MetroFramework.Controls.MetroLabel curModName;
        private MetroFramework.Controls.MetroButton addModButton;
        private MetroFramework.Controls.MetroButton removeModButton;
    }
}