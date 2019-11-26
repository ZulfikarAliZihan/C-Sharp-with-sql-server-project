using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSTUPharmacy
{
    public partial class AddMedicine : MetroFramework.Forms.MetroForm
    {
        public AddMedicine()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           string MedicineId = MedicineIdTextBox.Text;
           string SellingPrice=SellingPriceTextBox.Text;
           string MedicineName=MedicineNameTextBox.Text;
           string GeneticName = GeneticNameTextBox.Text;
           string Catagory = CatagoryComboBox.Text;
           string Quantity=QuantityTextBox.Text;
           string BuyingPrice=BuyingPriceTextBox.Text;
           string Manufacturer= ManufacturerTextBox.Text;
           string EntryDate = EntryDatePicker.Text;
           string ProductionDate = ProductionDatePicker.Text;
           string ExpireDate = EntryDatePicker.Text;
           try
           {
               //Connection of Database start
               if (MedicineId != "" && SellingPrice != "" && MedicineName != "" && GeneticName != "" && BuyingPrice != "" && Catagory != "" && Quantity != "" && Manufacturer != "")
               {
                   SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                   connection.Open();
                   Console.WriteLine(connection.State);

                   SqlCommand insertCommand = new SqlCommand(" INSERT INTO  tbl_medicine(medicine_id,medicine_name,genetic_name,catagory,manufacturer ,quantity,entry_date,production_date,expire_date,buying_price,selling_price)values ('" + MedicineId + "','" + MedicineName + "','" + GeneticName + "','" + Catagory + "','" + Manufacturer + "','" + Quantity + "','" + EntryDate + "','" + ProductionDate + "','" + ExpireDate + "','" + BuyingPrice + "','" + SellingPrice + "')", connection);

                   insertCommand.ExecuteNonQuery();
                   MessageBox.Show("Successfull");
               }
               else
               {
                   MessageBox.Show("Fill all field");
               }
               //Connection of Database end
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
