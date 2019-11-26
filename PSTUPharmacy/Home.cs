using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSTUPharmacy
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void StoreName_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void miniToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ObjectLogin = new Login();
            ObjectLogin.Show();

        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine m1 = new Medicine();
            this.Hide();
            m1.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void calculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void mSEXELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office15\EXCEL.EXE");
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale s1 = new Sale();
            this.Hide();
            s1.Show();
        }

        private void viewStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSeller ad1 = new AddSeller();
            this.Hide();
            ad1.Show();
        }

        private void modifyStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSeller us1 = new UpdateSeller();
            this.Close();
            us1.Show();
        }

        private void deleteStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSeller ds1 = new DeleteSeller();
            this.Close();
            ds1.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test1 t1 = new Test1();
            this.Close();
            t1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HometoSellAnalysis hts1 = new HometoSellAnalysis();
            this.Close();
            hts1.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r1 = new Report();
            r1.Show();
        }

        private void retailSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HometoSellAnalysis hts1 = new HometoSellAnalysis();
            this.Close();
            hts1.Show();
        }

        private void SellAnalysis_Click(object sender, EventArgs e)
        {
            HometoSellAnalysis hts1 = new HometoSellAnalysis();
            this.Close();
            hts1.Show();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Report r1 = new Report();
            r1.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Sale s1 = new Sale();
            this.Hide();
            s1.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void viewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSellers vs1 = new ViewSellers();
            this.Hide();
            vs1.Show();
        }
    }
}
