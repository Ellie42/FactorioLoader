namespace FactorioLoader.Main.Forms
{
    partial class CreateProfileForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.nameInput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.descriptionInput = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroTextButton2 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel1.Controls.Add(this.descriptionInput);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.nameInput);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(347, 208);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // nameInput
            // 
            this.nameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.nameInput.CustomButton.Image = null;
            this.nameInput.CustomButton.Location = new System.Drawing.Point(318, 1);
            this.nameInput.CustomButton.Name = "";
            this.nameInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameInput.CustomButton.TabIndex = 1;
            this.nameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameInput.CustomButton.UseSelectable = true;
            this.nameInput.CustomButton.Visible = false;
            this.nameInput.Lines = new string[0];
            this.nameInput.Location = new System.Drawing.Point(4, 26);
            this.nameInput.MaxLength = 32767;
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameInput.SelectedText = "";
            this.nameInput.SelectionLength = 0;
            this.nameInput.SelectionStart = 0;
            this.nameInput.Size = new System.Drawing.Size(340, 23);
            this.nameInput.TabIndex = 2;
            this.nameInput.UseSelectable = true;
            this.nameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Description";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.descriptionInput.CustomButton.Image = null;
            this.descriptionInput.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.descriptionInput.CustomButton.Name = "";
            this.descriptionInput.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.descriptionInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionInput.CustomButton.TabIndex = 1;
            this.descriptionInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionInput.CustomButton.UseSelectable = true;
            this.descriptionInput.CustomButton.Visible = false;
            this.descriptionInput.Lines = new string[] {
        "Absolutely amazing profile"};
            this.descriptionInput.Location = new System.Drawing.Point(4, 75);
            this.descriptionInput.MaxLength = 32767;
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.PasswordChar = '\0';
            this.descriptionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionInput.SelectedText = "";
            this.descriptionInput.SelectionLength = 0;
            this.descriptionInput.SelectionStart = 0;
            this.descriptionInput.Size = new System.Drawing.Size(340, 94);
            this.descriptionInput.TabIndex = 5;
            this.descriptionInput.Text = "Absolutely amazing profile";
            this.descriptionInput.UseSelectable = true;
            this.descriptionInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroTextButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroTextButton2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 36);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // metroTextButton2
            // 
            this.metroTextButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextButton2.Image = null;
            this.metroTextButton2.Location = new System.Drawing.Point(3, 3);
            this.metroTextButton2.Name = "metroTextButton2";
            this.metroTextButton2.Size = new System.Drawing.Size(167, 30);
            this.metroTextButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextButton2.TabIndex = 9;
            this.metroTextButton2.Text = "Create Profile";
            this.metroTextButton2.UseSelectable = true;
            this.metroTextButton2.UseStyleColors = true;
            this.metroTextButton2.UseVisualStyleBackColor = true;
            this.metroTextButton2.Click += new System.EventHandler(this.metroTextButton2_Click);
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(176, 3);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(168, 30);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextButton1.TabIndex = 10;
            this.metroTextButton1.Text = "Cancel";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseStyleColors = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // CreateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 288);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CreateProfileForm";
            this.Text = "Create a profile";
            this.Load += new System.EventHandler(this.CreateProfileForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox nameInput;
        private MetroFramework.Controls.MetroTextBox descriptionInput;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton2;
    }
}