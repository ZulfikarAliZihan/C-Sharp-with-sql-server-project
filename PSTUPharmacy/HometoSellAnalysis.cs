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
    public partial class HometoSellAnalysis : MetroFramework.Forms.MetroForm
    {
        
        public HometoSellAnalysis()
        {
            InitializeComponent();
            AddComboItem();
            
        }

        public void AddComboItem()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select distinct genetic_name from tbl_medicine", connection);



            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string itm = dataFromDb["genetic_name"].ToString();
                    SearchComboBox.Items.Add(itm);


                }
                catch (Exception esadsad)
                { }
            }
        }
        //Add medicine name from database to combobox end

        private void HometoSellAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            SellAnalysis s1 = new SellAnalysis(SearchComboBox.Text);
            this.Close();
            s1.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Close();
            h1.Show();
        }
    }
}
