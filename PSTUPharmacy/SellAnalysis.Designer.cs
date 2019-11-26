namespace PSTUPharmacy
{
    partial class SellAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellAnalysis));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Title = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Item1ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Item2ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Left = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Label();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.metroLabel1.Size = new System.Drawing.Size(174, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Sell analysis graph";
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
            // Item1ComboBox
            // 
            this.Item1ComboBox.FormattingEnabled = true;
            this.Item1ComboBox.ItemHeight = 24;
            this.Item1ComboBox.Location = new System.Drawing.Point(23, 168);
            this.Item1ComboBox.Name = "Item1ComboBox";
            this.Item1ComboBox.Size = new System.Drawing.Size(306, 30);
            this.Item1ComboBox.TabIndex = 7;
            this.Item1ComboBox.UseSelectable = true;
            this.Item1ComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // Item2ComboBox
            // 
            this.Item2ComboBox.FormattingEnabled = true;
            this.Item2ComboBox.ItemHeight = 24;
            this.Item2ComboBox.Location = new System.Drawing.Point(840, 168);
            this.Item2ComboBox.Name = "Item2ComboBox";
            this.Item2ComboBox.Size = new System.Drawing.Size(306, 30);
            this.Item2ComboBox.TabIndex = 7;
            this.Item2ComboBox.UseSelectable = true;
            this.Item2ComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(544, 502);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 75);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(379, 168);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Left";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Right";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(431, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.panel1.Location = new System.Drawing.Point(82, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 73);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.panel2.Location = new System.Drawing.Point(882, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 73);
            this.panel2.TabIndex = 10;
            // 
            // Left
            // 
            this.Left.AutoSize = true;
            this.Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Left.Location = new System.Drawing.Point(144, 373);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(48, 25);
            this.Left.TabIndex = 0;
            this.Left.Text = "Left";
            this.Left.Visible = false;
            this.Left.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Right
            // 
            this.Right.AutoSize = true;
            this.Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Right.Location = new System.Drawing.Point(925, 373);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(61, 25);
            this.Right.TabIndex = 0;
            this.Right.Text = "Right";
            this.Right.Visible = false;
            this.Right.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // SellAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Item1ComboBox);
            this.Controls.Add(this.Item2ComboBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SellAnalysis";
            this.Text = "Sell analysis";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.SellAnalysis_Load);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Title;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox Item1ComboBox;
        private MetroFramework.Controls.MetroComboBox Item2ComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Left;
        private System.Windows.Forms.Label Right;
    }
}