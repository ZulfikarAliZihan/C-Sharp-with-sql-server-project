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
    public partial class MedicineUI : MetroFramework.Forms.MetroForm
    {
        public MedicineUI()
        {
            InitializeComponent();
        }

        private void Title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Medicine m1 = new Medicine();
            this.Close();
            m1.Show();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MedicineIdTextBox.Clear();
            SellingPriceTextBox.Clear();
            MedicineNameTextBox.Clear();
            QuantityTextBox.Clear();
            BuyingPriceTextBox.Clear();
            ManufacturerTextBox.Clear();
            

        }
    }
}
