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
    public partial class Medicine : MetroFramework.Forms.MetroForm
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void ClockLabel_Click(object sender, EventArgs e)
        {
            


        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ClockLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            AddMedicine add1 = new AddMedicine();
            this.Close();
            add1.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ViewStock v1 = new ViewStock();
            this.Close();
            v1.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale s1 = new Sale();
            this.Hide();
            s1.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Update u1 = new Update();
            this.Close();
            u1.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DeleteMedicine d1 = new DeleteMedicine();
            this.Close();
            d1.Show();


        }

        private void viewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSellers vs1 = new ViewSellers();
            this.Close();
            vs1.Show();
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void retailSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HometoSellAnalysis hts1 = new HometoSellAnalysis();
            this.Close();
            hts1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void mSEXELToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Microsoft Office\Office15\EXCEL.EXE");
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report r1 = new Report();
            r1.Show();
        }

        private void addStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddSeller ad1 = new AddSeller();
            this.Hide();
            ad1.Show();
        }

        private void deleteStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSeller ds1 = new DeleteSeller();
            this.Close();
            ds1.Show();
        }

        private void viewStaffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewSellers vs1 = new ViewSellers();
            this.Hide();
            vs1.Show();
        }

        private void modifyStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSeller us1 = new UpdateSeller();
            this.Close();
            us1.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Login l1 = new Login();
            this.Hide();
            l1.Show();
        }
       
    }
}
