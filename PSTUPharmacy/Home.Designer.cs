namespace PSTUPharmacy
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retailSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSEXELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StafftoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Report = new MetroFramework.Controls.MetroTile();
            this.SellAnalysis = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // miniToolStrip
            // 
            resources.ApplyResources(this.miniToolStrip, "miniToolStrip");
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.miniToolStrip_ItemClicked);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.menuStrip1);
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.retailSaleToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.StafftoolStripMenuItem1,
            this.adminToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // saleToolStripMenuItem
            // 
            resources.ApplyResources(this.saleToolStripMenuItem, "saleToolStripMenuItem");
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // medicineToolStripMenuItem
            // 
            resources.ApplyResources(this.medicineToolStripMenuItem, "medicineToolStripMenuItem");
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Click += new System.EventHandler(this.medicineToolStripMenuItem_Click);
            // 
            // retailSaleToolStripMenuItem
            // 
            resources.ApplyResources(this.retailSaleToolStripMenuItem, "retailSaleToolStripMenuItem");
            this.retailSaleToolStripMenuItem.Name = "retailSaleToolStripMenuItem";
            this.retailSaleToolStripMenuItem.Click += new System.EventHandler(this.retailSaleToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.mSEXELToolStripMenuItem,
            this.reportToolStripMenuItem});
            resources.ApplyResources(this.orderToolStripMenuItem, "orderToolStripMenuItem");
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            resources.ApplyResources(this.calculatorToolStripMenuItem, "calculatorToolStripMenuItem");
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click_1);
            // 
            // mSEXELToolStripMenuItem
            // 
            resources.ApplyResources(this.mSEXELToolStripMenuItem, "mSEXELToolStripMenuItem");
            this.mSEXELToolStripMenuItem.Name = "mSEXELToolStripMenuItem";
            this.mSEXELToolStripMenuItem.Click += new System.EventHandler(this.mSEXELToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            resources.ApplyResources(this.reportToolStripMenuItem, "reportToolStripMenuItem");
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // StafftoolStripMenuItem1
            // 
            this.StafftoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffToolStripMenuItem,
            this.deleteStaffToolStripMenuItem,
            this.viewStaffToolStripMenuItem,
            this.modifyStaffToolStripMenuItem});
            resources.ApplyResources(this.StafftoolStripMenuItem1, "StafftoolStripMenuItem1");
            this.StafftoolStripMenuItem1.Name = "StafftoolStripMenuItem1";
            // 
            // addStaffToolStripMenuItem
            // 
            resources.ApplyResources(this.addStaffToolStripMenuItem, "addStaffToolStripMenuItem");
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // deleteStaffToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteStaffToolStripMenuItem, "deleteStaffToolStripMenuItem");
            this.deleteStaffToolStripMenuItem.Name = "deleteStaffToolStripMenuItem";
            this.deleteStaffToolStripMenuItem.Click += new System.EventHandler(this.deleteStaffToolStripMenuItem_Click);
            // 
            // viewStaffToolStripMenuItem
            // 
            resources.ApplyResources(this.viewStaffToolStripMenuItem, "viewStaffToolStripMenuItem");
            this.viewStaffToolStripMenuItem.Name = "viewStaffToolStripMenuItem";
            this.viewStaffToolStripMenuItem.Click += new System.EventHandler(this.viewStaffToolStripMenuItem_Click);
            // 
            // modifyStaffToolStripMenuItem
            // 
            resources.ApplyResources(this.modifyStaffToolStripMenuItem, "modifyStaffToolStripMenuItem");
            this.modifyStaffToolStripMenuItem.Name = "modifyStaffToolStripMenuItem";
            this.modifyStaffToolStripMenuItem.Click += new System.EventHandler(this.modifyStaffToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            resources.ApplyResources(this.adminToolStripMenuItem, "adminToolStripMenuItem");
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            // 
            // changePasswordToolStripMenuItem
            // 
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            resources.ApplyResources(this.logOutToolStripMenuItem, "logOutToolStripMenuItem");
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Report
            // 
            this.Report.ActiveControl = null;
            this.Report.BackColor = System.Drawing.Color.LightSalmon;
            resources.ApplyResources(this.Report, "Report");
            this.Report.Name = "Report";
            this.Report.UseSelectable = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // SellAnalysis
            // 
            this.SellAnalysis.ActiveControl = null;
            this.SellAnalysis.BackColor = System.Drawing.Color.LightSalmon;
            resources.ApplyResources(this.SellAnalysis, "SellAnalysis");
            this.SellAnalysis.Name = "SellAnalysis";
            this.SellAnalysis.UseSelectable = true;
            this.SellAnalysis.Click += new System.EventHandler(this.SellAnalysis_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.metroTile1, "metroTile1");
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.SellAnalysis);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel1);
            this.MainMenuStrip = this.miniToolStrip;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retailSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StafftoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSEXELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private MetroFramework.Controls.MetroTile Report;
        private MetroFramework.Controls.MetroTile SellAnalysis;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

