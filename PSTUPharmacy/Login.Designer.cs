namespace PSTUPharmacy
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StoreName = new System.Windows.Forms.Label();
            this.Address1 = new MetroFramework.Controls.MetroLabel();
            this.Address = new MetroFramework.Controls.MetroLabel();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ActiveLoginPanel = new MetroFramework.Controls.MetroPanel();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SellerPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.StoreName);
            this.panel1.Controls.Add(this.Address1);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 100);
            this.panel1.TabIndex = 0;
            // 
            // StoreName
            // 
            this.StoreName.AutoSize = true;
            this.StoreName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StoreName.Location = new System.Drawing.Point(555, 10);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(261, 32);
            this.StoreName.TabIndex = 2;
            this.StoreName.Text = "PSTU PHARMACY";
            // 
            // Address1
            // 
            this.Address1.AutoSize = true;
            this.Address1.Location = new System.Drawing.Point(595, 72);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(155, 20);
            this.Address1.TabIndex = 1;
            this.Address1.Text = "Dumki ,Patuakhali-8062";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(531, 52);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(289, 20);
            this.Address.TabIndex = 0;
            this.Address.Text = "Patuakhali Science and Technology University";
            // 
            // UsernameTextBox
            // 
            // 
            // 
            // 
            this.UsernameTextBox.CustomButton.Image = null;
            this.UsernameTextBox.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.UsernameTextBox.CustomButton.Name = "";
            this.UsernameTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.UsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTextBox.CustomButton.TabIndex = 1;
            this.UsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTextBox.CustomButton.UseSelectable = true;
            this.UsernameTextBox.CustomButton.Visible = false;
            this.UsernameTextBox.DisplayIcon = true;
            this.UsernameTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("UsernameTextBox.Icon")));
            this.UsernameTextBox.Lines = new string[0];
            this.UsernameTextBox.Location = new System.Drawing.Point(615, 373);
            this.UsernameTextBox.MaxLength = 32767;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.PromptText = "Username";
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.SelectionLength = 0;
            this.UsernameTextBox.SelectionStart = 0;
            this.UsernameTextBox.ShortcutsEnabled = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(198, 30);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.UseSelectable = true;
            this.UsernameTextBox.WaterMark = "Username";
            this.UsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // PasswordTextBox
            // 
            // 
            // 
            // 
            this.PasswordTextBox.CustomButton.Image = null;
            this.PasswordTextBox.CustomButton.Location = new System.Drawing.Point(170, 2);
            this.PasswordTextBox.CustomButton.Name = "";
            this.PasswordTextBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTextBox.CustomButton.TabIndex = 1;
            this.PasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTextBox.CustomButton.UseSelectable = true;
            this.PasswordTextBox.CustomButton.Visible = false;
            this.PasswordTextBox.DisplayIcon = true;
            this.PasswordTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("PasswordTextBox.Icon")));
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(615, 423);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PromptText = "Password";
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(198, 30);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WaterMark = "Password";
            this.PasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // ActiveLoginPanel
            // 
            this.ActiveLoginPanel.BackColor = System.Drawing.Color.Red;
            this.ActiveLoginPanel.HorizontalScrollbarBarColor = true;
            this.ActiveLoginPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.ActiveLoginPanel.HorizontalScrollbarSize = 10;
            this.ActiveLoginPanel.Location = new System.Drawing.Point(590, 374);
            this.ActiveLoginPanel.Name = "ActiveLoginPanel";
            this.ActiveLoginPanel.Size = new System.Drawing.Size(10, 29);
            this.ActiveLoginPanel.TabIndex = 5;
            this.ActiveLoginPanel.UseCustomBackColor = true;
            this.ActiveLoginPanel.UseCustomForeColor = true;
            this.ActiveLoginPanel.VerticalScrollbarBarColor = true;
            this.ActiveLoginPanel.VerticalScrollbarHighlightOnWheel = false;
            this.ActiveLoginPanel.VerticalScrollbarSize = 10;
            this.ActiveLoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ActiveLoginPanel_Paint);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtn.Location = new System.Drawing.Point(615, 475);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(198, 30);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseSelectable = true;
            this.LoginBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.Controls.Add(this.SellerPictureBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 136);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1390, 596);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // SellerPictureBox
            // 
            this.SellerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SellerPictureBox.Image")));
            this.SellerPictureBox.InitialImage = null;
            this.SellerPictureBox.Location = new System.Drawing.Point(620, 60);
            this.SellerPictureBox.Name = "SellerPictureBox";
            this.SellerPictureBox.Size = new System.Drawing.Size(149, 147);
            this.SellerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SellerPictureBox.TabIndex = 10;
            this.SellerPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1430, 722);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ActiveLoginPanel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Username";
            this.TransparencyKey = System.Drawing.Color.DeepSkyBlue;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SellerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StoreName;
        private MetroFramework.Controls.MetroLabel Address1;
        private MetroFramework.Controls.MetroLabel Address;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroPanel ActiveLoginPanel;
        private MetroFramework.Controls.MetroButton LoginBtn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox SellerPictureBox;

    }
}