namespace PSTUPharmacy
{
    partial class AddSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSeller));
            this.Title = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MedicineIdLabel = new MetroFramework.Controls.MetroLabel();
            this.MedicineNameLabel = new MetroFramework.Controls.MetroLabel();
            this.CatagoryLabel = new MetroFramework.Controls.MetroLabel();
            this.ManufacturerLabel = new MetroFramework.Controls.MetroLabel();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ConfirmTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PictureNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Picture = new MetroFramework.Controls.MetroLabel();
            this.SellerPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureOpenBtn = new MetroFramework.Controls.MetroButton();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Title.Controls.Add(this.metroLabel1);
            this.Title.HorizontalScrollbarBarColor = true;
            this.Title.HorizontalScrollbarHighlightOnWheel = false;
            this.Title.HorizontalScrollbarSize = 10;
            this.Title.Location = new System.Drawing.Point(-1, 62);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1131, 50);
            this.Title.TabIndex = 0;
            this.Title.UseCustomBackColor = true;
            this.Title.VerticalScrollbarBarColor = true;
            this.Title.VerticalScrollbarHighlightOnWheel = false;
            this.Title.VerticalScrollbarSize = 10;
            this.Title.Paint += new System.Windows.Forms.PaintEventHandler(this.Title_Paint);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(17, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(174, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Seller Information";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // MedicineIdLabel
            // 
            this.MedicineIdLabel.AutoSize = true;
            this.MedicineIdLabel.Location = new System.Drawing.Point(299, 209);
            this.MedicineIdLabel.Name = "MedicineIdLabel";
            this.MedicineIdLabel.Size = new System.Drawing.Size(73, 20);
            this.MedicineIdLabel.TabIndex = 2;
            this.MedicineIdLabel.Text = "Username";
            // 
            // MedicineNameLabel
            // 
            this.MedicineNameLabel.AutoSize = true;
            this.MedicineNameLabel.Location = new System.Drawing.Point(299, 268);
            this.MedicineNameLabel.Name = "MedicineNameLabel";
            this.MedicineNameLabel.Size = new System.Drawing.Size(42, 20);
            this.MedicineNameLabel.TabIndex = 2;
            this.MedicineNameLabel.Text = "Email";
            // 
            // CatagoryLabel
            // 
            this.CatagoryLabel.AutoSize = true;
            this.CatagoryLabel.Location = new System.Drawing.Point(299, 328);
            this.CatagoryLabel.Name = "CatagoryLabel";
            this.CatagoryLabel.Size = new System.Drawing.Size(66, 20);
            this.CatagoryLabel.TabIndex = 2;
            this.CatagoryLabel.Text = "Password";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(299, 386);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(120, 20);
            this.ManufacturerLabel.TabIndex = 2;
            this.ManufacturerLabel.Text = "Confirm password";
            // 
            // EmailTextBox
            // 
            // 
            // 
            // 
            this.EmailTextBox.CustomButton.Image = null;
            this.EmailTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.EmailTextBox.CustomButton.Name = "";
            this.EmailTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.EmailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.EmailTextBox.CustomButton.TabIndex = 1;
            this.EmailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.EmailTextBox.CustomButton.UseSelectable = true;
            this.EmailTextBox.CustomButton.Visible = false;
            this.EmailTextBox.Lines = new string[0];
            this.EmailTextBox.Location = new System.Drawing.Point(459, 268);
            this.EmailTextBox.MaxLength = 32767;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.SelectionLength = 0;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.ShortcutsEnabled = true;
            this.EmailTextBox.Size = new System.Drawing.Size(233, 30);
            this.EmailTextBox.TabIndex = 2;
            this.EmailTextBox.UseSelectable = true;
            this.EmailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ConfirmTextBox
            // 
            // 
            // 
            // 
            this.ConfirmTextBox.CustomButton.Image = null;
            this.ConfirmTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.ConfirmTextBox.CustomButton.Name = "";
            this.ConfirmTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ConfirmTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConfirmTextBox.CustomButton.TabIndex = 1;
            this.ConfirmTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConfirmTextBox.CustomButton.UseSelectable = true;
            this.ConfirmTextBox.CustomButton.Visible = false;
            this.ConfirmTextBox.Lines = new string[0];
            this.ConfirmTextBox.Location = new System.Drawing.Point(459, 386);
            this.ConfirmTextBox.MaxLength = 32767;
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.PasswordChar = '●';
            this.ConfirmTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConfirmTextBox.SelectedText = "";
            this.ConfirmTextBox.SelectionLength = 0;
            this.ConfirmTextBox.SelectionStart = 0;
            this.ConfirmTextBox.ShortcutsEnabled = true;
            this.ConfirmTextBox.Size = new System.Drawing.Size(233, 30);
            this.ConfirmTextBox.TabIndex = 4;
            this.ConfirmTextBox.UseSelectable = true;
            this.ConfirmTextBox.UseSystemPasswordChar = true;
            this.ConfirmTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConfirmTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(459, 210);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(233, 30);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(557, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 66);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(459, 328);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(233, 30);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PictureNameTextBox
            // 
            // 
            // 
            // 
            this.PictureNameTextBox.CustomButton.Image = null;
            this.PictureNameTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.PictureNameTextBox.CustomButton.Name = "";
            this.PictureNameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PictureNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PictureNameTextBox.CustomButton.TabIndex = 1;
            this.PictureNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PictureNameTextBox.CustomButton.UseSelectable = true;
            this.PictureNameTextBox.CustomButton.Visible = false;
            this.PictureNameTextBox.Lines = new string[0];
            this.PictureNameTextBox.Location = new System.Drawing.Point(459, 437);
            this.PictureNameTextBox.MaxLength = 32767;
            this.PictureNameTextBox.Name = "PictureNameTextBox";
            this.PictureNameTextBox.PasswordChar = '\0';
            this.PictureNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PictureNameTextBox.SelectedText = "";
            this.PictureNameTextBox.SelectionLength = 0;
            this.PictureNameTextBox.SelectionStart = 0;
            this.PictureNameTextBox.ShortcutsEnabled = true;
            this.PictureNameTextBox.Size = new System.Drawing.Size(233, 30);
            this.PictureNameTextBox.TabIndex = 7;
            this.PictureNameTextBox.UseSelectable = true;
            this.PictureNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PictureNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Picture
            // 
            this.Picture.AutoSize = true;
            this.Picture.Location = new System.Drawing.Point(299, 444);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(52, 20);
            this.Picture.TabIndex = 8;
            this.Picture.Text = "Picture";
            // 
            // SellerPictureBox
            // 
            this.SellerPictureBox.Location = new System.Drawing.Point(821, 209);
            this.SellerPictureBox.Name = "SellerPictureBox";
            this.SellerPictureBox.Size = new System.Drawing.Size(226, 258);
            this.SellerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SellerPictureBox.TabIndex = 9;
            this.SellerPictureBox.TabStop = false;
            // 
            // PictureOpenBtn
            // 
            this.PictureOpenBtn.Location = new System.Drawing.Point(705, 440);
            this.PictureOpenBtn.Name = "PictureOpenBtn";
            this.PictureOpenBtn.Size = new System.Drawing.Size(78, 27);
            this.PictureOpenBtn.TabIndex = 10;
            this.PictureOpenBtn.Text = "Open";
            this.PictureOpenBtn.UseSelectable = true;
            this.PictureOpenBtn.Click += new System.EventHandler(this.PictureOpenBtn_Click);
            // 
            // AddSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 600);
            this.ControlBox = false;
            this.Controls.Add(this.PictureOpenBtn);
            this.Controls.Add(this.SellerPictureBox);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.PictureNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.CatagoryLabel);
            this.Controls.Add(this.MedicineNameLabel);
            this.Controls.Add(this.MedicineIdLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddSeller";
            this.Text = "Add Seller";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.AddSeller_Load);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Title;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel MedicineIdLabel;
        private MetroFramework.Controls.MetroLabel MedicineNameLabel;
        private MetroFramework.Controls.MetroLabel CatagoryLabel;
        private MetroFramework.Controls.MetroLabel ManufacturerLabel;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private MetroFramework.Controls.MetroTextBox ConfirmTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox PictureNameTextBox;
        private MetroFramework.Controls.MetroLabel Picture;
        private System.Windows.Forms.PictureBox SellerPictureBox;
        private MetroFramework.Controls.MetroButton PictureOpenBtn;
    }
}