namespace PSTUPharmacy
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retailSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StafftoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m1PanelFill = new MetroFramework.Controls.MetroPanel();
            this.m1PanelLeft = new MetroFramework.Controls.MetroPanel();
            this.m1PanelRight = new MetroFramework.Controls.MetroPanel();
            this.Clock = new MetroFramework.Controls.MetroTile();
            this.ClockLabel = new System.Windows.Forms.Label();
            this.Date = new MetroFramework.Controls.MetroTile();
            this.DateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.m1PanelFill.SuspendLayout();
            this.m1PanelRight.SuspendLayout();
            this.Clock.SuspendLayout();
            this.Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.menuStrip1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1390, 123);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
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
            this.menuStrip1.Location = new System.Drawing.Point(324, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(748, 104);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saleToolStripMenuItem.Image")));
            this.saleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(76, 100);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.updateMedicineToolStripMenuItem,
            this.deleteMedicineToolStripMenuItem,
            this.viewStoreToolStripMenuItem});
            this.medicineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("medicineToolStripMenuItem.Image")));
            this.medicineToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(132, 100);
            this.medicineToolStripMenuItem.Text = "Medicine";
            this.medicineToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.newEntryToolStripMenuItem.Text = "New Entry";
            // 
            // updateMedicineToolStripMenuItem
            // 
            this.updateMedicineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.updateMedicineToolStripMenuItem.Name = "updateMedicineToolStripMenuItem";
            this.updateMedicineToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.updateMedicineToolStripMenuItem.Text = "Update Medicine";
            // 
            // deleteMedicineToolStripMenuItem
            // 
            this.deleteMedicineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteMedicineToolStripMenuItem.Name = "deleteMedicineToolStripMenuItem";
            this.deleteMedicineToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.deleteMedicineToolStripMenuItem.Text = "Delete Medicine";
            // 
            // viewStoreToolStripMenuItem
            // 
            this.viewStoreToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.viewStoreToolStripMenuItem.Name = "viewStoreToolStripMenuItem";
            this.viewStoreToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.viewStoreToolStripMenuItem.Text = "View Store";
            // 
            // retailSaleToolStripMenuItem
            // 
            this.retailSaleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retailSaleToolStripMenuItem.Image")));
            this.retailSaleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retailSaleToolStripMenuItem.Name = "retailSaleToolStripMenuItem";
            this.retailSaleToolStripMenuItem.Size = new System.Drawing.Size(142, 100);
            this.retailSaleToolStripMenuItem.Text = "Retail sale";
            this.retailSaleToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("orderToolStripMenuItem.Image")));
            this.orderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(93, 100);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // StafftoolStripMenuItem1
            // 
            this.StafftoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffToolStripMenuItem,
            this.deleteStaffToolStripMenuItem,
            this.viewStaffToolStripMenuItem,
            this.modifyStaffToolStripMenuItem});
            this.StafftoolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("StafftoolStripMenuItem1.Image")));
            this.StafftoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StafftoolStripMenuItem1.Name = "StafftoolStripMenuItem1";
            this.StafftoolStripMenuItem1.Size = new System.Drawing.Size(79, 100);
            this.StafftoolStripMenuItem1.Text = "Staff";
            this.StafftoolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.addStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStaffToolStripMenuItem.Image")));
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.addStaffToolStripMenuItem.Text = "Add Staff";
            // 
            // deleteStaffToolStripMenuItem
            // 
            this.deleteStaffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteStaffToolStripMenuItem.Image")));
            this.deleteStaffToolStripMenuItem.Name = "deleteStaffToolStripMenuItem";
            this.deleteStaffToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.deleteStaffToolStripMenuItem.Text = "Delete Staff";
            // 
            // viewStaffToolStripMenuItem
            // 
            this.viewStaffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.viewStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStaffToolStripMenuItem.Image")));
            this.viewStaffToolStripMenuItem.Name = "viewStaffToolStripMenuItem";
            this.viewStaffToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.viewStaffToolStripMenuItem.Text = "View Staff";
            // 
            // modifyStaffToolStripMenuItem
            // 
            this.modifyStaffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.modifyStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifyStaffToolStripMenuItem.Image")));
            this.modifyStaffToolStripMenuItem.Name = "modifyStaffToolStripMenuItem";
            this.modifyStaffToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.modifyStaffToolStripMenuItem.Text = "Modify Staff";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.adminToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminToolStripMenuItem.Image")));
            this.adminToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(103, 100);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 100);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // m1PanelFill
            // 
            this.m1PanelFill.Controls.Add(this.m1PanelLeft);
            this.m1PanelFill.Controls.Add(this.m1PanelRight);
            this.m1PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m1PanelFill.HorizontalScrollbarBarColor = true;
            this.m1PanelFill.HorizontalScrollbarHighlightOnWheel = false;
            this.m1PanelFill.HorizontalScrollbarSize = 10;
            this.m1PanelFill.Location = new System.Drawing.Point(20, 183);
            this.m1PanelFill.Name = "m1PanelFill";
            this.m1PanelFill.Size = new System.Drawing.Size(1390, 519);
            this.m1PanelFill.TabIndex = 2;
            this.m1PanelFill.UseCustomBackColor = true;
            this.m1PanelFill.VerticalScrollbarBarColor = true;
            this.m1PanelFill.VerticalScrollbarHighlightOnWheel = false;
            this.m1PanelFill.VerticalScrollbarSize = 10;
            // 
            // m1PanelLeft
            // 
            this.m1PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m1PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.m1PanelLeft.HorizontalScrollbarBarColor = true;
            this.m1PanelLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.m1PanelLeft.HorizontalScrollbarSize = 10;
            this.m1PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.m1PanelLeft.Name = "m1PanelLeft";
            this.m1PanelLeft.Size = new System.Drawing.Size(323, 519);
            this.m1PanelLeft.TabIndex = 3;
            this.m1PanelLeft.UseCustomBackColor = true;
            this.m1PanelLeft.VerticalScrollbarBarColor = true;
            this.m1PanelLeft.VerticalScrollbarHighlightOnWheel = false;
            this.m1PanelLeft.VerticalScrollbarSize = 10;
            // 
            // m1PanelRight
            // 
            this.m1PanelRight.BackColor = System.Drawing.Color.LightGray;
            this.m1PanelRight.Controls.Add(this.Clock);
            this.m1PanelRight.Controls.Add(this.Date);
            this.m1PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.m1PanelRight.HorizontalScrollbarBarColor = true;
            this.m1PanelRight.HorizontalScrollbarHighlightOnWheel = false;
            this.m1PanelRight.HorizontalScrollbarSize = 10;
            this.m1PanelRight.Location = new System.Drawing.Point(1070, 0);
            this.m1PanelRight.Name = "m1PanelRight";
            this.m1PanelRight.Size = new System.Drawing.Size(320, 519);
            this.m1PanelRight.TabIndex = 2;
            this.m1PanelRight.UseCustomBackColor = true;
            this.m1PanelRight.VerticalScrollbarBarColor = true;
            this.m1PanelRight.VerticalScrollbarHighlightOnWheel = false;
            this.m1PanelRight.VerticalScrollbarSize = 10;
            // 
            // Clock
            // 
            this.Clock.ActiveControl = null;
            this.Clock.Controls.Add(this.ClockLabel);
            this.Clock.Location = new System.Drawing.Point(8, 85);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(304, 154);
            this.Clock.TabIndex = 2;
            this.Clock.UseSelectable = true;
            // 
            // ClockLabel
            // 
            this.ClockLabel.AutoSize = true;
            this.ClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClockLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.ForeColor = System.Drawing.Color.Black;
            this.ClockLabel.Location = new System.Drawing.Point(37, 54);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(124, 47);
            this.ClockLabel.TabIndex = 0;
            this.ClockLabel.Text = "Clock";
            this.ClockLabel.Click += new System.EventHandler(this.ClockLabel_Click);
            // 
            // Date
            // 
            this.Date.ActiveControl = null;
            this.Date.BackColor = System.Drawing.Color.Magenta;
            this.Date.Controls.Add(this.DateLabel);
            this.Date.Location = new System.Drawing.Point(8, 260);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(304, 154);
            this.Date.TabIndex = 2;
            this.Date.UseCustomBackColor = true;
            this.Date.UseSelectable = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(59, 58);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(108, 49);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 722);
            this.Controls.Add(this.m1PanelFill);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UI";
            this.Load += new System.EventHandler(this.Medicine_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.m1PanelFill.ResumeLayout(false);
            this.m1PanelRight.ResumeLayout(false);
            this.Clock.ResumeLayout(false);
            this.Clock.PerformLayout();
            this.Date.ResumeLayout(false);
            this.Date.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retailSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StafftoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel m1PanelFill;
        private MetroFramework.Controls.MetroPanel m1PanelRight;
        private MetroFramework.Controls.MetroPanel m1PanelLeft;
        private MetroFramework.Controls.MetroTile Clock;
        private System.Windows.Forms.Label ClockLabel;
        private MetroFramework.Controls.MetroTile Date;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Timer timer1;
    }
}