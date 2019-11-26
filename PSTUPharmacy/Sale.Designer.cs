namespace PSTUPharmacy
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.Title = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SearchComboBox = new MetroFramework.Controls.MetroComboBox();
            this.QuantityTextBox = new MetroFramework.Controls.MetroTextBox();
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
            this.TotalPayGroupBox = new System.Windows.Forms.GroupBox();
            this.TakaLabel = new System.Windows.Forms.Label();
            this.TotalPayable = new System.Windows.Forms.Label();
            this.TakaOnly = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TotalPayGroupBox.SuspendLayout();
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
            this.metroLabel1.Size = new System.Drawing.Size(152, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "sell information";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.ItemHeight = 24;
            this.SearchComboBox.Location = new System.Drawing.Point(39, 137);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(306, 30);
            this.SearchComboBox.TabIndex = 7;
            this.SearchComboBox.UseSelectable = true;
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // QuantityTextBox
            // 
            // 
            // 
            // 
            this.QuantityTextBox.CustomButton.Image = null;
            this.QuantityTextBox.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.QuantityTextBox.CustomButton.Name = "";
            this.QuantityTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.QuantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuantityTextBox.CustomButton.TabIndex = 1;
            this.QuantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuantityTextBox.CustomButton.UseSelectable = true;
            this.QuantityTextBox.CustomButton.Visible = false;
            this.QuantityTextBox.Lines = new string[0];
            this.QuantityTextBox.Location = new System.Drawing.Point(456, 137);
            this.QuantityTextBox.MaxLength = 32767;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.PromptText = "Quantity";
            this.QuantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.SelectionLength = 0;
            this.QuantityTextBox.SelectionStart = 0;
            this.QuantityTextBox.ShortcutsEnabled = true;
            this.QuantityTextBox.Size = new System.Drawing.Size(214, 32);
            this.QuantityTextBox.TabIndex = 8;
            this.QuantityTextBox.UseSelectable = true;
            this.QuantityTextBox.WaterMark = "Quantity";
            this.QuantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine_id,
            this.Medicime_name,
            this.catagory,
            this.Quantity,
            this.Expire_date,
            this.Selling_price,
            this.Total_price});
            this.dataGridView.Location = new System.Drawing.Point(23, 201);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1048, 194);
            this.dataGridView.TabIndex = 10;
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
            this.Total_price.HeaderText = "Total price";
            this.Total_price.Name = "Total_price";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(936, 497);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 67);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(761, 129);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(78, 66);
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
            // TotalPayGroupBox
            // 
            this.TotalPayGroupBox.Controls.Add(this.TakaLabel);
            this.TotalPayGroupBox.Controls.Add(this.TotalPayable);
            this.TotalPayGroupBox.Controls.Add(this.TakaOnly);
            this.TotalPayGroupBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPayGroupBox.ForeColor = System.Drawing.Color.Indigo;
            this.TotalPayGroupBox.Location = new System.Drawing.Point(812, 422);
            this.TotalPayGroupBox.Name = "TotalPayGroupBox";
            this.TotalPayGroupBox.Size = new System.Drawing.Size(295, 57);
            this.TotalPayGroupBox.TabIndex = 11;
            this.TotalPayGroupBox.TabStop = false;
            this.TotalPayGroupBox.Visible = false;
            this.TotalPayGroupBox.Enter += new System.EventHandler(this.TotalPayGroupBox_Enter);
            // 
            // TakaLabel
            // 
            this.TakaLabel.AutoSize = true;
            this.TakaLabel.Location = new System.Drawing.Point(121, 27);
            this.TakaLabel.Name = "TakaLabel";
            this.TakaLabel.Size = new System.Drawing.Size(0, 19);
            this.TakaLabel.TabIndex = 1;
            // 
            // TotalPayable
            // 
            this.TotalPayable.AutoSize = true;
            this.TotalPayable.Location = new System.Drawing.Point(6, 27);
            this.TotalPayable.Name = "TotalPayable";
            this.TotalPayable.Size = new System.Drawing.Size(122, 19);
            this.TotalPayable.TabIndex = 0;
            this.TotalPayable.Text = "Total Payable  :";
            this.TotalPayable.Click += new System.EventHandler(this.label1_Click);
            // 
            // TakaOnly
            // 
            this.TakaOnly.AutoSize = true;
            this.TakaOnly.Location = new System.Drawing.Point(184, 27);
            this.TakaOnly.Name = "TakaOnly";
            this.TakaOnly.Size = new System.Drawing.Size(78, 19);
            this.TakaOnly.TabIndex = 0;
            this.TakaOnly.Text = "Taka only";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(822, 500);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 64);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TotalPayGroupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sale";
            this.Text = "Sell";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TotalPayGroupBox.ResumeLayout(false);
            this.TotalPayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Title;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox SearchComboBox;
        private MetroFramework.Controls.MetroTextBox QuantityTextBox;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewLinkColumn Medicine_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicime_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
        private System.Windows.Forms.GroupBox TotalPayGroupBox;
        private System.Windows.Forms.Label TakaLabel;
        private System.Windows.Forms.Label TakaOnly;
        private System.Windows.Forms.Label TotalPayable;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}