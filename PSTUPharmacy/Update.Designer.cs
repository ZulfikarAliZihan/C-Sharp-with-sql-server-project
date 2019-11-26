namespace PSTUPharmacy
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.Title = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SearchComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Medicine_id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Medicime_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MedicineIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ExpireDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.ProductionDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.EntryDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.CatagoryComboBox = new MetroFramework.Controls.MetroComboBox();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.BuyingPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ManufacturerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MedicineNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SellingPriceLabel = new MetroFramework.Controls.MetroLabel();
            this.SellingPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.BuyingPreceLabel = new MetroFramework.Controls.MetroLabel();
            this.QuantityLabel = new MetroFramework.Controls.MetroLabel();
            this.ExpireDateLabel = new MetroFramework.Controls.MetroLabel();
            this.ManufacturerLabel = new MetroFramework.Controls.MetroLabel();
            this.ProductionDateLabel = new MetroFramework.Controls.MetroLabel();
            this.CatagoryLabel = new MetroFramework.Controls.MetroLabel();
            this.EntryDateLabel = new MetroFramework.Controls.MetroLabel();
            this.MedicineNameLabel = new MetroFramework.Controls.MetroLabel();
            this.MedicineIdLabel = new MetroFramework.Controls.MetroLabel();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.Title.Size = new System.Drawing.Size(1182, 50);
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
            this.metroLabel1.Size = new System.Drawing.Size(275, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Update Medicine information";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.ItemHeight = 24;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Medicine id",
            "Medicine name"});
            this.SearchComboBox.Location = new System.Drawing.Point(447, 130);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(306, 30);
            this.SearchComboBox.TabIndex = 7;
            this.SearchComboBox.UseSelectable = true;
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeight = 50;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine_id,
            this.Medicime_name,
            this.catagory,
            this.Quantity,
            this.Expire_date,
            this.Selling_price,
            this.Total_price});
            this.dataGridView.Location = new System.Drawing.Point(368, 201);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(813, 194);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Medicine_id
            // 
            this.Medicine_id.HeaderText = "Medicine id";
            this.Medicine_id.Name = "Medicine_id";
            // 
            // Medicime_name
            // 
            this.Medicime_name.HeaderText = "Medicime name";
            this.Medicime_name.Name = "Medicime_name";
            // 
            // catagory
            // 
            this.catagory.HeaderText = "Catagory";
            this.catagory.Name = "catagory";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Expire_date
            // 
            this.Expire_date.HeaderText = "Expire date";
            this.Expire_date.Name = "Expire_date";
            // 
            // Selling_price
            // 
            this.Selling_price.HeaderText = "Selling price";
            this.Selling_price.Name = "Selling_price";
            // 
            // Total_price
            // 
            this.Total_price.HeaderText = "Selling price";
            this.Total_price.Name = "Total_price";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(600, 497);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 66);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(835, 123);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(77, 66);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.SearchBtn_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MedicineIdTextBox);
            this.groupBox1.Controls.Add(this.ExpireDatePicker);
            this.groupBox1.Controls.Add(this.ProductionDatePicker);
            this.groupBox1.Controls.Add(this.EntryDatePicker);
            this.groupBox1.Controls.Add(this.CatagoryComboBox);
            this.groupBox1.Controls.Add(this.QuantityTextBox);
            this.groupBox1.Controls.Add(this.BuyingPriceTextBox);
            this.groupBox1.Controls.Add(this.ManufacturerTextBox);
            this.groupBox1.Controls.Add(this.MedicineNameTextBox);
            this.groupBox1.Controls.Add(this.SellingPriceLabel);
            this.groupBox1.Controls.Add(this.SellingPriceTextBox);
            this.groupBox1.Controls.Add(this.BuyingPreceLabel);
            this.groupBox1.Controls.Add(this.QuantityLabel);
            this.groupBox1.Controls.Add(this.ExpireDateLabel);
            this.groupBox1.Controls.Add(this.ManufacturerLabel);
            this.groupBox1.Controls.Add(this.ProductionDateLabel);
            this.groupBox1.Controls.Add(this.CatagoryLabel);
            this.groupBox1.Controls.Add(this.EntryDateLabel);
            this.groupBox1.Controls.Add(this.MedicineNameLabel);
            this.groupBox1.Controls.Add(this.MedicineIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(-1, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 396);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MedicineIdTextBox
            // 
            // 
            // 
            // 
            this.MedicineIdTextBox.CustomButton.Image = null;
            this.MedicineIdTextBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.MedicineIdTextBox.CustomButton.Name = "";
            this.MedicineIdTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.MedicineIdTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MedicineIdTextBox.CustomButton.TabIndex = 1;
            this.MedicineIdTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MedicineIdTextBox.CustomButton.UseSelectable = true;
            this.MedicineIdTextBox.CustomButton.Visible = false;
            this.MedicineIdTextBox.Lines = new string[0];
            this.MedicineIdTextBox.Location = new System.Drawing.Point(151, 16);
            this.MedicineIdTextBox.MaxLength = 32767;
            this.MedicineIdTextBox.Name = "MedicineIdTextBox";
            this.MedicineIdTextBox.PasswordChar = '\0';
            this.MedicineIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MedicineIdTextBox.SelectedText = "";
            this.MedicineIdTextBox.SelectionLength = 0;
            this.MedicineIdTextBox.SelectionStart = 0;
            this.MedicineIdTextBox.ShortcutsEnabled = true;
            this.MedicineIdTextBox.Size = new System.Drawing.Size(204, 30);
            this.MedicineIdTextBox.TabIndex = 27;
            this.MedicineIdTextBox.UseSelectable = true;
            this.MedicineIdTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MedicineIdTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.MedicineIdTextBox.Click += new System.EventHandler(this.MedicineIdTextBox_Click);
            // 
            // ExpireDatePicker
            // 
            this.ExpireDatePicker.CustomFormat = "yyyy-MM-dd";
            this.ExpireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpireDatePicker.Location = new System.Drawing.Point(151, 278);
            this.ExpireDatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.ExpireDatePicker.Name = "ExpireDatePicker";
            this.ExpireDatePicker.Size = new System.Drawing.Size(207, 30);
            this.ExpireDatePicker.TabIndex = 26;
            // 
            // ProductionDatePicker
            // 
            this.ProductionDatePicker.CustomFormat = "yyyy-MM-dd";
            this.ProductionDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProductionDatePicker.Location = new System.Drawing.Point(151, 237);
            this.ProductionDatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.ProductionDatePicker.Name = "ProductionDatePicker";
            this.ProductionDatePicker.Size = new System.Drawing.Size(207, 30);
            this.ProductionDatePicker.TabIndex = 25;
            // 
            // EntryDatePicker
            // 
            this.EntryDatePicker.CustomFormat = "yyyy-MM-dd";
            this.EntryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EntryDatePicker.Location = new System.Drawing.Point(151, 196);
            this.EntryDatePicker.MinimumSize = new System.Drawing.Size(0, 30);
            this.EntryDatePicker.Name = "EntryDatePicker";
            this.EntryDatePicker.Size = new System.Drawing.Size(207, 30);
            this.EntryDatePicker.TabIndex = 24;
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
            this.CatagoryComboBox.Location = new System.Drawing.Point(151, 84);
            this.CatagoryComboBox.Name = "CatagoryComboBox";
            this.CatagoryComboBox.Size = new System.Drawing.Size(204, 30);
            this.CatagoryComboBox.TabIndex = 23;
            this.CatagoryComboBox.UseSelectable = true;
            // 
            // QuantityTextBox
            // 
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Lines = new string[0];
            this.QuantityTextBox.Location = new System.Drawing.Point(151, 160);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(204, 30);
            this.QuantityTextBox.TabIndex = 21;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BuyingPriceTextBox
            // 
            // 
            // 
            // 
            this.BuyingPriceTextBox.CustomButton.Image = null;
            this.BuyingPriceTextBox.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.BuyingPriceTextBox.CustomButton.Name = "";
            this.BuyingPriceTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.BuyingPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BuyingPriceTextBox.CustomButton.TabIndex = 1;
            this.BuyingPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BuyingPriceTextBox.CustomButton.UseSelectable = true;
            this.BuyingPriceTextBox.CustomButton.Visible = false;
            this.BuyingPriceTextBox.Lines = new string[0];
            this.BuyingPriceTextBox.Location = new System.Drawing.Point(151, 319);
            this.BuyingPriceTextBox.MaxLength = 32767;
            this.BuyingPriceTextBox.Name = "BuyingPriceTextBox";
            this.BuyingPriceTextBox.PasswordChar = '\0';
            this.BuyingPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BuyingPriceTextBox.SelectedText = "";
            this.BuyingPriceTextBox.SelectionLength = 0;
            this.BuyingPriceTextBox.SelectionStart = 0;
            this.BuyingPriceTextBox.ShortcutsEnabled = true;
            this.BuyingPriceTextBox.Size = new System.Drawing.Size(207, 30);
            this.BuyingPriceTextBox.TabIndex = 20;
            this.BuyingPriceTextBox.UseSelectable = true;
            this.BuyingPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BuyingPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ManufacturerTextBox
            // 
            // 
            // 
            // 
            this.ManufacturerTextBox.CustomButton.Image = null;
            this.ManufacturerTextBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.ManufacturerTextBox.CustomButton.Name = "";
            this.ManufacturerTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ManufacturerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ManufacturerTextBox.CustomButton.TabIndex = 1;
            this.ManufacturerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ManufacturerTextBox.CustomButton.UseSelectable = true;
            this.ManufacturerTextBox.CustomButton.Visible = false;
            this.ManufacturerTextBox.Lines = new string[0];
            this.ManufacturerTextBox.Location = new System.Drawing.Point(151, 124);
            this.ManufacturerTextBox.MaxLength = 32767;
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.PasswordChar = '\0';
            this.ManufacturerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ManufacturerTextBox.SelectedText = "";
            this.ManufacturerTextBox.SelectionLength = 0;
            this.ManufacturerTextBox.SelectionStart = 0;
            this.ManufacturerTextBox.ShortcutsEnabled = true;
            this.ManufacturerTextBox.Size = new System.Drawing.Size(204, 30);
            this.ManufacturerTextBox.TabIndex = 19;
            this.ManufacturerTextBox.UseSelectable = true;
            this.ManufacturerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ManufacturerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MedicineNameTextBox
            // 
            // 
            // 
            // 
            this.MedicineNameTextBox.CustomButton.Image = null;
            this.MedicineNameTextBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.MedicineNameTextBox.CustomButton.Name = "";
            this.MedicineNameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.MedicineNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MedicineNameTextBox.CustomButton.TabIndex = 1;
            this.MedicineNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MedicineNameTextBox.CustomButton.UseSelectable = true;
            this.MedicineNameTextBox.CustomButton.Visible = false;
            this.MedicineNameTextBox.Lines = new string[0];
            this.MedicineNameTextBox.Location = new System.Drawing.Point(151, 51);
            this.MedicineNameTextBox.MaxLength = 32767;
            this.MedicineNameTextBox.Name = "MedicineNameTextBox";
            this.MedicineNameTextBox.PasswordChar = '\0';
            this.MedicineNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MedicineNameTextBox.SelectedText = "";
            this.MedicineNameTextBox.SelectionLength = 0;
            this.MedicineNameTextBox.SelectionStart = 0;
            this.MedicineNameTextBox.ShortcutsEnabled = true;
            this.MedicineNameTextBox.Size = new System.Drawing.Size(204, 30);
            this.MedicineNameTextBox.TabIndex = 22;
            this.MedicineNameTextBox.UseSelectable = true;
            this.MedicineNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MedicineNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SellingPriceLabel
            // 
            this.SellingPriceLabel.AutoSize = true;
            this.SellingPriceLabel.Location = new System.Drawing.Point(5, 351);
            this.SellingPriceLabel.Name = "SellingPriceLabel";
            this.SellingPriceLabel.Size = new System.Drawing.Size(84, 20);
            this.SellingPriceLabel.TabIndex = 8;
            this.SellingPriceLabel.Text = "Selling Price";
            // 
            // SellingPriceTextBox
            // 
            // 
            // 
            // 
            this.SellingPriceTextBox.CustomButton.Image = null;
            this.SellingPriceTextBox.CustomButton.Location = new System.Drawing.Point(176, 2);
            this.SellingPriceTextBox.CustomButton.Name = "";
            this.SellingPriceTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.SellingPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SellingPriceTextBox.CustomButton.TabIndex = 1;
            this.SellingPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SellingPriceTextBox.CustomButton.UseSelectable = true;
            this.SellingPriceTextBox.CustomButton.Visible = false;
            this.SellingPriceTextBox.Lines = new string[0];
            this.SellingPriceTextBox.Location = new System.Drawing.Point(151, 354);
            this.SellingPriceTextBox.MaxLength = 32767;
            this.SellingPriceTextBox.Name = "SellingPriceTextBox";
            this.SellingPriceTextBox.PasswordChar = '\0';
            this.SellingPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SellingPriceTextBox.SelectedText = "";
            this.SellingPriceTextBox.SelectionLength = 0;
            this.SellingPriceTextBox.SelectionStart = 0;
            this.SellingPriceTextBox.ShortcutsEnabled = true;
            this.SellingPriceTextBox.Size = new System.Drawing.Size(204, 30);
            this.SellingPriceTextBox.TabIndex = 18;
            this.SellingPriceTextBox.UseSelectable = true;
            this.SellingPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SellingPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BuyingPreceLabel
            // 
            this.BuyingPreceLabel.AutoSize = true;
            this.BuyingPreceLabel.Location = new System.Drawing.Point(5, 319);
            this.BuyingPreceLabel.Name = "BuyingPreceLabel";
            this.BuyingPreceLabel.Size = new System.Drawing.Size(91, 20);
            this.BuyingPreceLabel.TabIndex = 15;
            this.BuyingPreceLabel.Text = "Buying Prece";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(5, 160);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(61, 20);
            this.QuantityLabel.TabIndex = 14;
            this.QuantityLabel.Text = "Quantity";
            // 
            // ExpireDateLabel
            // 
            this.ExpireDateLabel.AutoSize = true;
            this.ExpireDateLabel.Location = new System.Drawing.Point(5, 277);
            this.ExpireDateLabel.Name = "ExpireDateLabel";
            this.ExpireDateLabel.Size = new System.Drawing.Size(83, 20);
            this.ExpireDateLabel.TabIndex = 13;
            this.ExpireDateLabel.Text = "Expire Datel";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(5, 124);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(92, 20);
            this.ManufacturerLabel.TabIndex = 12;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ProductionDateLabel
            // 
            this.ProductionDateLabel.AutoSize = true;
            this.ProductionDateLabel.Location = new System.Drawing.Point(5, 237);
            this.ProductionDateLabel.Name = "ProductionDateLabel";
            this.ProductionDateLabel.Size = new System.Drawing.Size(109, 20);
            this.ProductionDateLabel.TabIndex = 11;
            this.ProductionDateLabel.Text = "Production Date";
            // 
            // CatagoryLabel
            // 
            this.CatagoryLabel.AutoSize = true;
            this.CatagoryLabel.Location = new System.Drawing.Point(5, 89);
            this.CatagoryLabel.Name = "CatagoryLabel";
            this.CatagoryLabel.Size = new System.Drawing.Size(65, 20);
            this.CatagoryLabel.TabIndex = 10;
            this.CatagoryLabel.Text = "Catagory";
            // 
            // EntryDateLabel
            // 
            this.EntryDateLabel.AutoSize = true;
            this.EntryDateLabel.Location = new System.Drawing.Point(5, 195);
            this.EntryDateLabel.Name = "EntryDateLabel";
            this.EntryDateLabel.Size = new System.Drawing.Size(75, 20);
            this.EntryDateLabel.TabIndex = 9;
            this.EntryDateLabel.Text = "Entry Date";
            // 
            // MedicineNameLabel
            // 
            this.MedicineNameLabel.AutoSize = true;
            this.MedicineNameLabel.Location = new System.Drawing.Point(5, 51);
            this.MedicineNameLabel.Name = "MedicineNameLabel";
            this.MedicineNameLabel.Size = new System.Drawing.Size(108, 20);
            this.MedicineNameLabel.TabIndex = 16;
            this.MedicineNameLabel.Text = "Medicine Name";
            // 
            // MedicineIdLabel
            // 
            this.MedicineIdLabel.AutoSize = true;
            this.MedicineIdLabel.Location = new System.Drawing.Point(5, 15);
            this.MedicineIdLabel.Name = "MedicineIdLabel";
            this.MedicineIdLabel.Size = new System.Drawing.Size(81, 20);
            this.MedicineIdLabel.TabIndex = 17;
            this.MedicineIdLabel.Text = "Medicine Id";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 600);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Update";
            this.Text = "Update";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Title;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox SearchComboBox;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox MedicineIdTextBox;
        private MetroFramework.Controls.MetroDateTime ExpireDatePicker;
        private MetroFramework.Controls.MetroDateTime ProductionDatePicker;
        private MetroFramework.Controls.MetroDateTime EntryDatePicker;
        private MetroFramework.Controls.MetroComboBox CatagoryComboBox;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private MetroFramework.Controls.MetroTextBox BuyingPriceTextBox;
        private MetroFramework.Controls.MetroTextBox ManufacturerTextBox;
        private MetroFramework.Controls.MetroTextBox MedicineNameTextBox;
        private MetroFramework.Controls.MetroLabel SellingPriceLabel;
        private MetroFramework.Controls.MetroTextBox SellingPriceTextBox;
        private MetroFramework.Controls.MetroLabel BuyingPreceLabel;
        private MetroFramework.Controls.MetroLabel QuantityLabel;
        private MetroFramework.Controls.MetroLabel ExpireDateLabel;
        private MetroFramework.Controls.MetroLabel ManufacturerLabel;
        private MetroFramework.Controls.MetroLabel ProductionDateLabel;
        private MetroFramework.Controls.MetroLabel CatagoryLabel;
        private MetroFramework.Controls.MetroLabel EntryDateLabel;
        private MetroFramework.Controls.MetroLabel MedicineNameLabel;
        private MetroFramework.Controls.MetroLabel MedicineIdLabel;
        private System.Windows.Forms.DataGridViewLinkColumn Medicine_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicime_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
    }
}