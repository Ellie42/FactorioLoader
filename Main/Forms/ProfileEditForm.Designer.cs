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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeModButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.addModButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profileComboBox = new MetroFramework.Controls.MetroComboBox();
            this.deleteProfileButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.profileModsGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.availableModsGrid = new MetroFramework.Controls.MetroGrid();
            this.modName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableModsSections = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.curModAuthor = new MetroFramework.Controls.MetroLabel();
            this.curModName = new MetroFramework.Controls.MetroLabel();
            this.doneButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.curModDesc = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileModsGrid)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableModsGrid)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74306F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.25694F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(604, 443);
            this.tableLayoutPanel2.TabIndex = 19;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(291, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 371F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 371);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(310, 371);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeModButton);
            this.panel1.Controls.Add(this.addModButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 371);
            this.panel1.TabIndex = 4;
            // 
            // removeModButton
            // 
            this.removeModButton.Image = null;
            this.removeModButton.Location = new System.Drawing.Point(0, 131);
            this.removeModButton.Name = "removeModButton";
            this.removeModButton.Size = new System.Drawing.Size(30, 66);
            this.removeModButton.Style = MetroFramework.MetroColorStyle.Red;
            this.removeModButton.TabIndex = 10;
            this.removeModButton.Text = "<";
            this.removeModButton.UseSelectable = true;
            this.removeModButton.UseStyleColors = true;
            this.removeModButton.UseVisualStyleBackColor = true;
            this.removeModButton.Click += new System.EventHandler(this.removeModButton_Click);
            // 
            // addModButton
            // 
            this.addModButton.Image = null;
            this.addModButton.Location = new System.Drawing.Point(0, 59);
            this.addModButton.Name = "addModButton";
            this.addModButton.Size = new System.Drawing.Size(30, 66);
            this.addModButton.Style = MetroFramework.MetroColorStyle.Green;
            this.addModButton.TabIndex = 9;
            this.addModButton.Text = ">";
            this.addModButton.UseSelectable = true;
            this.addModButton.UseStyleColors = true;
            this.addModButton.UseVisualStyleBackColor = true;
            this.addModButton.Click += new System.EventHandler(this.addModButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.profileComboBox);
            this.panel2.Controls.Add(this.deleteProfileButton);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.profileModsGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(33, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 365);
            this.panel2.TabIndex = 5;
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
            this.profileComboBox.Location = new System.Drawing.Point(3, 23);
            this.profileComboBox.Name = "profileComboBox";
            this.profileComboBox.Size = new System.Drawing.Size(268, 29);
            this.profileComboBox.TabIndex = 30;
            this.profileComboBox.Theme = MetroFramework.MetroThemeStyle.Light;
            this.profileComboBox.UseSelectable = true;
            this.profileComboBox.SelectedIndexChanged += new System.EventHandler(this.profileComboBox_SelectedIndexChanged);
            // 
            // deleteProfileButton
            // 
            this.deleteProfileButton.Image = null;
            this.deleteProfileButton.Location = new System.Drawing.Point(3, 0);
            this.deleteProfileButton.Name = "deleteProfileButton";
            this.deleteProfileButton.Size = new System.Drawing.Size(89, 19);
            this.deleteProfileButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteProfileButton.TabIndex = 19;
            this.deleteProfileButton.Text = "Delete Profile";
            this.deleteProfileButton.UseCustomBackColor = true;
            this.deleteProfileButton.UseCustomForeColor = true;
            this.deleteProfileButton.UseSelectable = true;
            this.deleteProfileButton.UseStyleColors = true;
            this.deleteProfileButton.UseVisualStyleBackColor = true;
            this.deleteProfileButton.Click += new System.EventHandler(this.deleteProfileButton_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(187, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 29;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileModsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.profileModsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileModsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.profileModsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.profileModsGrid.EnableHeadersVisualStyles = false;
            this.profileModsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.profileModsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileModsGrid.Location = new System.Drawing.Point(3, 57);
            this.profileModsGrid.Name = "profileModsGrid";
            this.profileModsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.profileModsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.profileModsGrid.RowHeadersVisible = false;
            this.profileModsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.profileModsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profileModsGrid.Size = new System.Drawing.Size(268, 305);
            this.profileModsGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this.profileModsGrid.TabIndex = 28;
            this.profileModsGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.profileModsGrid.UseStyleColors = true;
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.availableModsGrid);
            this.metroPanel2.Controls.Add(this.availableModsSections);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(282, 371);
            this.metroPanel2.TabIndex = 17;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availableModsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.availableModsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableModsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modName,
            this.modVersion});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.availableModsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.availableModsGrid.EnableHeadersVisualStyles = false;
            this.availableModsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.availableModsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.availableModsGrid.Location = new System.Drawing.Point(3, 59);
            this.availableModsGrid.Name = "availableModsGrid";
            this.availableModsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.availableModsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.availableModsGrid.RowHeadersVisible = false;
            this.availableModsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.availableModsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableModsGrid.Size = new System.Drawing.Size(279, 312);
            this.availableModsGrid.Style = MetroFramework.MetroColorStyle.Blue;
            this.availableModsGrid.TabIndex = 17;
            this.availableModsGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.availableModsGrid.UseStyleColors = true;
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
            // availableModsSections
            // 
            this.availableModsSections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableModsSections.FormattingEnabled = true;
            this.availableModsSections.ItemHeight = 23;
            this.availableModsSections.Location = new System.Drawing.Point(3, 25);
            this.availableModsSections.Name = "availableModsSections";
            this.availableModsSections.Size = new System.Drawing.Size(279, 29);
            this.availableModsSections.TabIndex = 15;
            this.availableModsSections.Theme = MetroFramework.MetroThemeStyle.Light;
            this.availableModsSections.UseSelectable = true;
            this.availableModsSections.SelectedIndexChanged += new System.EventHandler(this.ChangeAvailableModsSection);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.4485F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.55149F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.doneButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(288, 377);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(316, 66);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.curModAuthor);
            this.panel4.Controls.Add(this.curModName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 60);
            this.panel4.TabIndex = 31;
            // 
            // curModAuthor
            // 
            this.curModAuthor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.curModAuthor.FontSize = MetroFramework.MetroLabelSize.Small;
            this.curModAuthor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.curModAuthor.Location = new System.Drawing.Point(0, 41);
            this.curModAuthor.Name = "curModAuthor";
            this.curModAuthor.Size = new System.Drawing.Size(200, 19);
            this.curModAuthor.TabIndex = 30;
            this.curModAuthor.Text = "Current Mod Author";
            this.curModAuthor.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // curModName
            // 
            this.curModName.Dock = System.Windows.Forms.DockStyle.Top;
            this.curModName.Location = new System.Drawing.Point(0, 0);
            this.curModName.Name = "curModName";
            this.curModName.Size = new System.Drawing.Size(200, 41);
            this.curModName.TabIndex = 29;
            this.curModName.Text = "Current Mod Name";
            this.curModName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.curModName.WrapToLine = true;
            // 
            // doneButton
            // 
            this.doneButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doneButton.Image = null;
            this.doneButton.Location = new System.Drawing.Point(209, 34);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(104, 29);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseSelectable = true;
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.curModDesc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 60);
            this.panel3.TabIndex = 19;
            // 
            // curModDesc
            // 
            // 
            // 
            // 
            this.curModDesc.CustomButton.Image = null;
            this.curModDesc.CustomButton.Location = new System.Drawing.Point(224, 2);
            this.curModDesc.CustomButton.Name = "";
            this.curModDesc.CustomButton.Size = new System.Drawing.Size(55, 55);
            this.curModDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.curModDesc.CustomButton.TabIndex = 1;
            this.curModDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.curModDesc.CustomButton.UseSelectable = true;
            this.curModDesc.CustomButton.Visible = false;
            this.curModDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curModDesc.Lines = new string[] {
        "Mod Description"};
            this.curModDesc.Location = new System.Drawing.Point(0, 0);
            this.curModDesc.MaxLength = 32767;
            this.curModDesc.Multiline = true;
            this.curModDesc.Name = "curModDesc";
            this.curModDesc.PasswordChar = '\0';
            this.curModDesc.ReadOnly = true;
            this.curModDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.curModDesc.SelectedText = "";
            this.curModDesc.SelectionLength = 0;
            this.curModDesc.SelectionStart = 0;
            this.curModDesc.Size = new System.Drawing.Size(282, 60);
            this.curModDesc.TabIndex = 29;
            this.curModDesc.Text = "Mod Description";
            this.curModDesc.UseSelectable = true;
            this.curModDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.curModDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProfileEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 523);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(616, 398);
            this.Name = "ProfileEditForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Editing Profile";
            this.Load += new System.EventHandler(this.ProfileEditForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileModsGrid)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableModsGrid)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid availableModsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn modName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modVersion;
        private MetroFramework.Controls.MetroComboBox availableModsSections;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroTextBox curModDesc;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton doneButton;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton removeModButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton addModButton;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton deleteProfileButton;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox profileComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid profileModsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel curModAuthor;
        private MetroFramework.Controls.MetroLabel curModName;
    }
}