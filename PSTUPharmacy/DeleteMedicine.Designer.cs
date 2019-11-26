namespace PSTUPharmacy
{
    partial class DeleteMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMedicine));
            this.Title = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SearchComboBox = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Medicine_id = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Medicime_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.production_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selling_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.metroLabel1.Size = new System.Drawing.Size(266, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Delete Medicine information";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.ItemHeight = 24;
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
            this.manufacturer,
            this.Quantity,
            this.entry_date,
            this.production_date,
            this.Expire_date,
            this.Selling_price,
            this.Total_price});
            this.dataGridView.Location = new System.Drawing.Point(22, 201);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1131, 194);
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
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.Name = "manufacturer";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // entry_date
            // 
            this.entry_date.HeaderText = "Entry date";
            this.entry_date.Name = "entry_date";
            // 
            // production_date
            // 
            this.production_date.HeaderText = "Production date";
            this.production_date.Name = "production_date";
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
            this.pictureBox2.Location = new System.Drawing.Point(554, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.Location = new System.Drawing.Point(836, 122);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(73, 73);
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
            // DeleteMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 600);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeleteMedicine";
            this.Text = "Delete Medicine";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridViewLinkColumn Medicine_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicime_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn production_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selling_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_price;
    }
}