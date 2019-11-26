namespace PSTUPharmacy
{
    partial class MedicineUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            this.Title = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MedicineIdLabel = new MetroFramework.Controls.MetroLabel();
            this.MedicineNameLabel = new MetroFramework.Controls.MetroLabel();
            this.CatagoryLabel = new MetroFramework.Controls.MetroLabel();
            this.ManufacturerLabel = new MetroFramework.Controls.MetroLabel();
            this.QuantityLabel = new MetroFramework.Controls.MetroLabel();
            this.SellingPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MedicineNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ManufacturerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EntryDateLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductionDateLabel = new MetroFramework.Controls.MetroLabel();
            this.ExpireDateLabel = new MetroFramework.Controls.MetroLabel();
            this.BuyingPreceLabel = new MetroFramework.Controls.MetroLabel();
            this.SellingPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.BuyingPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CatagoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.EntryDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.ProductionDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.ExpireDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MedicineIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.metroLabel1.Size = new System.Drawing.Size(206, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Medicine Information";
            this.metroLabel1.UseCustomBackColor = true;
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
            // MedicineIdLabel
            // 
            this.MedicineIdLabel.AutoSize = true;
            this.MedicineIdLabel.Location = new System.Drawing.Point(98, 187);
            this.MedicineIdLabel.Name = "MedicineIdLabel";
            this.MedicineIdLabel.Size = new System.Drawing.Size(81, 20);
            this.MedicineIdLabel.TabIndex = 2;
            this.MedicineIdLabel.Text = "Medicine Id";
            // 
            // MedicineNameLabel
            // 
            this.MedicineNameLabel.AutoSize = true;
            this.MedicineNameLabel.Location = new System.Drawing.Point(98, 246);
            this.MedicineNameLabel.Name = "MedicineNameLabel";
            this.MedicineNameLabel.Size = new System.Drawing.Size(108, 20);
            this.MedicineNameLabel.TabIndex = 2;
            this.MedicineNameLabel.Text = "Medicine Name";
            // 
            // CatagoryLabel
            // 
            this.CatagoryLabel.AutoSize = true;
            this.CatagoryLabel.Location = new System.Drawing.Point(98, 306);
            this.CatagoryLabel.Name = "CatagoryLabel";
            this.CatagoryLabel.Size = new System.Drawing.Size(65, 20);
            this.CatagoryLabel.TabIndex = 2;
            this.CatagoryLabel.Text = "Catagory";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(98, 364);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(92, 20);
            this.ManufacturerLabel.TabIndex = 2;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(98, 424);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(61, 20);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Quantity";
            // 
            // SellingPriceTextBox
            // 
            // 
            // 
            // 
            this.SellingPriceTextBox.CustomButton.Image = null;
            this.SellingPriceTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.SellingPriceTextBox.CustomButton.Name = "";
            this.SellingPriceTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.SellingPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SellingPriceTextBox.CustomButton.TabIndex = 1;
            this.SellingPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SellingPriceTextBox.CustomButton.UseSelectable = true;
            this.SellingPriceTextBox.CustomButton.Visible = false;
            this.SellingPriceTextBox.Lines = new string[0];
            this.SellingPriceTextBox.Location = new System.Drawing.Point(749, 424);
            this.SellingPriceTextBox.MaxLength = 32767;
            this.SellingPriceTextBox.Name = "SellingPriceTextBox";
            this.SellingPriceTextBox.PasswordChar = '\0';
            this.SellingPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SellingPriceTextBox.SelectedText = "";
            this.SellingPriceTextBox.SelectionLength = 0;
            this.SellingPriceTextBox.SelectionStart = 0;
            this.SellingPriceTextBox.ShortcutsEnabled = true;
            this.SellingPriceTextBox.Size = new System.Drawing.Size(233, 30);
            this.SellingPriceTextBox.TabIndex = 3;
            this.SellingPriceTextBox.UseSelectable = true;
            this.SellingPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SellingPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SellingPriceTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // MedicineNameTextBox
            // 
            // 
            // 
            // 
            this.MedicineNameTextBox.CustomButton.Image = null;
            this.MedicineNameTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.MedicineNameTextBox.CustomButton.Name = "";
            this.MedicineNameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.MedicineNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MedicineNameTextBox.CustomButton.TabIndex = 1;
            this.MedicineNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MedicineNameTextBox.CustomButton.UseSelectable = true;
            this.MedicineNameTextBox.CustomButton.Visible = false;
            this.MedicineNameTextBox.Lines = new string[0];
            this.MedicineNameTextBox.Location = new System.Drawing.Point(258, 246);
            this.MedicineNameTextBox.MaxLength = 32767;
            this.MedicineNameTextBox.Name = "MedicineNameTextBox";
            this.MedicineNameTextBox.PasswordChar = '\0';
            this.MedicineNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MedicineNameTextBox.SelectedText = "";
            this.MedicineNameTextBox.SelectionLength = 0;
            this.MedicineNameTextBox.SelectionStart = 0;
            this.MedicineNameTextBox.ShortcutsEnabled = true;
            this.MedicineNameTextBox.Size = new System.Drawing.Size(233, 30);
            this.MedicineNameTextBox.TabIndex = 3;
            this.MedicineNameTextBox.UseSelectable = true;
            this.MedicineNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MedicineNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ManufacturerTextBox
            // 
            // 
            // 
            // 
            this.ManufacturerTextBox.CustomButton.Image = null;
            this.ManufacturerTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.ManufacturerTextBox.CustomButton.Name = "";
            this.ManufacturerTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ManufacturerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManufacturerTextBox.CustomButton.TabIndex = 1;
            this.ManufacturerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManufacturerTextBox.CustomButton.UseSelectable = true;
            this.ManufacturerTextBox.CustomButton.Visible = false;
            this.ManufacturerTextBox.Lines = new string[0];
            this.ManufacturerTextBox.Location = new System.Drawing.Point(258, 364);
            this.ManufacturerTextBox.MaxLength = 32767;
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.PasswordChar = '\0';
            this.ManufacturerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManufacturerTextBox.SelectedText = "";
            this.ManufacturerTextBox.SelectionLength = 0;
            this.ManufacturerTextBox.SelectionStart = 0;
            this.ManufacturerTextBox.ShortcutsEnabled = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(233, 30);
            this.ManufacturerTextBox.TabIndex = 3;
            this.ManufacturerTextBox.UseSelectable = true;
            this.ManufacturerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManufacturerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuantityTextBox
            // 
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Lines = new string[0];
            this.QuantityTextBox.Location = new System.Drawing.Point(258, 424);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(233, 30);
            this.QuantityTextBox.TabIndex = 3;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EntryDateLabel
            // 
            this.EntryDateLabel.AutoSize = true;
            this.EntryDateLabel.Location = new System.Drawing.Point(589, 187);
            this.EntryDateLabel.Name = "EntryDateLabel";
            this.EntryDateLabel.Size = new System.Drawing.Size(75, 20);
            this.EntryDateLabel.TabIndex = 2;
            this.EntryDateLabel.Text = "Entry Date";
            // 
            // ProductionDateLabel
            // 
            this.ProductionDateLabel.AutoSize = true;
            this.ProductionDateLabel.Location = new System.Drawing.Point(589, 246);
            this.ProductionDateLabel.Name = "ProductionDateLabel";
            this.ProductionDateLabel.Size = new System.Drawing.Size(109, 20);
            this.ProductionDateLabel.TabIndex = 2;
            this.ProductionDateLabel.Text = "Production Date";
            // 
            // ExpireDateLabel
            // 
            this.ExpireDateLabel.AutoSize = true;
            this.ExpireDateLabel.Location = new System.Drawing.Point(589, 306);
            this.ExpireDateLabel.Name = "ExpireDateLabel";
            this.ExpireDateLabel.Size = new System.Drawing.Size(83, 20);
            this.ExpireDateLabel.TabIndex = 2;
            this.ExpireDateLabel.Text = "Expire Datel";
            // 
            // BuyingPreceLabel
            // 
            this.BuyingPreceLabel.AutoSize = true;
            this.BuyingPreceLabel.Location = new System.Drawing.Point(589, 364);
            this.BuyingPreceLabel.Name = "BuyingPreceLabel";
            this.BuyingPreceLabel.Size = new System.Drawing.Size(91, 20);
            this.BuyingPreceLabel.TabIndex = 2;
            this.BuyingPreceLabel.Text = "Buying Prece";
            // 
            // SellingPriceLabel
            // 
            this.SellingPriceLabel.AutoSize = true;
            this.SellingPriceLabel.Location = new System.Drawing.Point(589, 424);
            this.SellingPriceLabel.Name = "SellingPriceLabel";
            this.SellingPriceLabel.Size = new System.Drawing.Size(84, 20);
            this.SellingPriceLabel.TabIndex = 2;
            this.SellingPriceLabel.Text = "Selling Price";
            // 
            // BuyingPriceTextBox
            // 
            // 
            // 
            // 
            this.BuyingPriceTextBox.CustomButton.Image = null;
            this.BuyingPriceTextBox.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.BuyingPriceTextBox.CustomButton.Name = "";
            this.BuyingPriceTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.BuyingPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BuyingPriceTextBox.CustomButton.TabIndex = 1;
            this.BuyingPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BuyingPriceTextBox.CustomButton.UseSelectable = true;
            this.BuyingPriceTextBox.CustomButton.Visible = false;
            this.BuyingPriceTextBox.Lines = new string[0];
            this.BuyingPriceTextBox.Location = new System.Drawing.Point(749, 364);
            this.BuyingPriceTextBox.MaxLength = 32767;
            this.BuyingPriceTextBox.Name = "BuyingPriceTextBox";
            this.BuyingPriceTextBox.PasswordChar = '\0';
            this.BuyingPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BuyingPriceTextBox.SelectedText = "";
            this.BuyingPriceTextBox.SelectionLength = 0;
            this.BuyingPriceTextBox.SelectionStart = 0;
            this.BuyingPriceTextBox.ShortcutsEnabled = true;
            this.BuyingPriceTextBox.Size = new System.Drawing.Size(236, 30);
            this.BuyingPriceTextBox.TabIndex = 3;
            this.BuyingPriceTextBox.UseSelectable = true;
            this.BuyingPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BuyingPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CatagoryComboBox
            // 
            this.CatagoryComboBox.FormattingEnabled = true;
            this.CatagoryComboBox.ItemHeight = 24;
            this.CatagoryComboBox.Items.AddRange(new object[] {
            "Tablet",
            "Capsul",
            "Syrup",
            "Other"});
            this.CatagoryComboBox.Location = new System.Drawing.Point(258, 301);
            this.CatagoryComboBox.Name = "CatagoryComboBox";
            this.CatagoryComboBox.Size = new System.Drawing.Size(233, 30);
            this.CatagoryComboBox.TabIndex = 4;
            this.CatagoryComboBox.UseSelectable = true;
            // 
            // EntryDatePicker
            // 
            this.EntryDatePicker.Location = new System.Drawing.Point(749, 188);
            this.EntryDatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.EntryDatePicker.Name = "EntryDatePicker";
            this.EntryDatePicker.Size = new System.Drawing.Size(236, 30);
            this.EntryDatePicker.TabIndex = 5;
            // 
            // ProductionDatePicker
            // 
            this.ProductionDatePicker.Location = new System.Drawing.Point(749, 246);
            this.ProductionDatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.ProductionDatePicker.Name = "ProductionDatePicker";
            this.ProductionDatePicker.Size = new System.Drawing.Size(236, 30);
            this.ProductionDatePicker.TabIndex = 5;
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.Location = new System.Drawing.Point(749, 307);
            this.ExpireDatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(236, 30);
            this.ExpireDatePicker.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(936, 506);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 42);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(842, 506);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 42);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MedicineIdTextBox
            // 
            // 
            // 
            // 
            this.MedicineIdTextBox.CustomButton.Image = null;
            this.MedicineIdTextBox.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.MedicineIdTextBox.CustomButton.Name = "";
            this.MedicineIdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.MedicineIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MedicineIdTextBox.CustomButton.TabIndex = 1;
            this.MedicineIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MedicineIdTextBox.CustomButton.UseSelectable = true;
            this.MedicineIdTextBox.CustomButton.Visible = false;
            this.MedicineIdTextBox.Lines = new string[0];
            this.MedicineIdTextBox.Location = new System.Drawing.Point(258, 188);
            this.MedicineIdTextBox.MaxLength = 32767;
            this.MedicineIdTextBox.Name = "MedicineIdTextBox";
            this.MedicineIdTextBox.PasswordChar = '\0';
            this.MedicineIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MedicineIdTextBox.SelectedText = "";
            this.MedicineIdTextBox.SelectionLength = 0;
            this.MedicineIdTextBox.SelectionStart = 0;
            this.MedicineIdTextBox.ShortcutsEnabled = true;
            this.MedicineIdTextBox.Size = new System.Drawing.Size(233, 30);
            this.MedicineIdTextBox.TabIndex = 7;
            this.MedicineIdTextBox.UseSelectable = true;
            this.MedicineIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MedicineIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 600);
            this.ControlBox = false;
            this.Controls.Add(this.MedicineIdTextBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ExpireDatePicker);
            this.Controls.Add(this.ProductionDatePicker);
            this.Controls.Add(this.EntryDatePicker);
            this.Controls.Add(this.CatagoryComboBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.BuyingPriceTextBox);
            this.Controls.Add(this.ManufacturerTextBox);
            this.Controls.Add(this.MedicineNameTextBox);
            this.Controls.Add(this.SellingPriceLabel);
            this.Controls.Add(this.SellingPriceTextBox);
            this.Controls.Add(this.BuyingPreceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ExpireDateLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.ProductionDateLabel);
            this.Controls.Add(this.CatagoryLabel);
            this.Controls.Add(this.EntryDateLabel);
            this.Controls.Add(this.MedicineNameLabel);
            this.Controls.Add(this.MedicineIdLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddMedicine";
            this.Text = "Add Medicine";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private MetroFramework.Controls.MetroLabel QuantityLabel;
        private MetroFramework.Controls.MetroTextBox SellingPriceTextBox;
        private MetroFramework.Controls.MetroTextBox MedicineNameTextBox;
        private MetroFramework.Controls.MetroTextBox ManufacturerTextBox;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroLabel EntryDateLabel;
        private MetroFramework.Controls.MetroLabel ProductionDateLabel;
        private MetroFramework.Controls.MetroLabel ExpireDateLabel;
        private MetroFramework.Controls.MetroLabel BuyingPreceLabel;
        private MetroFramework.Controls.MetroLabel SellingPriceLabel;
        private MetroFramework.Controls.MetroTextBox BuyingPriceTextBox;
        private MetroFramework.Controls.MetroComboBox CatagoryComboBox;
        private MetroFramework.Controls.MetroDateTime EntryDatePicker;
        private MetroFramework.Controls.MetroDateTime ProductionDatePicker;
        private MetroFramework.Controls.MetroDateTime ExpireDatePicker;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTextBox MedicineIdTextBox;
    }
}