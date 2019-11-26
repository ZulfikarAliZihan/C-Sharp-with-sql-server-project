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
    public partial class Sale : MetroFramework.Forms.MetroForm
    {
        public float price = 0;
        float TotalBuying_price = 0;
        float TotalSelling_price = 0;
        public Sale()
        {
            InitializeComponent();
            AddComboItem();
        }

        //Add medicine name from database to combobox end
        public void AddComboItem()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select medicine_name from tbl_medicine", connection);



            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string itm = dataFromDb["medicine_name"].ToString();
                    SearchComboBox.Items.Add(itm);


                }
                catch (Exception esadsad)
                { }
            }
        }
                //Add medicine name from database to combobox end

        private void Title_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Close();
            h1.Show();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (TotalPayGroupBox.Visible == true)
                TotalPayGroupBox.Visible = false;
            else
                TotalPayGroupBox.Visible = true;

        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {

            //dataGridView.Rows.Clear();
            
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);

                SqlCommand selectCommand = new SqlCommand("select * from tbl_medicine where medicine_name = '" + SearchComboBox.Text + "' ", connection);



                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {
                    if (int.Parse(QuantityTextBox.Text) <= int.Parse(dataFromDb["Quantity"].ToString()))
                    {
                        try
                        {
                            var index = dataGridView.Rows.Add();
                            Console.WriteLine(index);


                            dataGridView.Rows[index].Cells[0].Value = dataFromDb["medicine_id"].ToString();
                            dataGridView.Rows[index].Cells[1].Value = dataFromDb["medicine_name"].ToString();
                            dataGridView.Rows[index].Cells[2].Value = dataFromDb["catagory"].ToString();
                            dataGridView.Rows[index].Cells[3].Value = QuantityTextBox.Text;
                            dataGridView.Rows[index].Cells[4].Value = dataFromDb["expire_date"].ToString();
                            dataGridView.Rows[index].Cells[5].Value = dataFromDb["selling_price"].ToString();
                            dataGridView.Rows[index].Cells[6].Value = (float.Parse(QuantityTextBox.Text) * float.Parse(dataFromDb["selling_price"].ToString())).ToString();

                            price = price + (float.Parse(QuantityTextBox.Text) * float.Parse(dataFromDb["selling_price"].ToString()));
                            TakaLabel.Text = price.ToString();

                            //update database start

                            int NumberofUpdateMedicine = int.Parse(dataFromDb["quantity"].ToString()) - int.Parse(QuantityTextBox.Text);
                            //Console.WriteLine(NumberofUpdateMedicine);
                            SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                            connection1.Open();
                            SqlCommand insertCommand = new SqlCommand(" update tbl_medicine set quantity='" + NumberofUpdateMedicine + "' where medicine_id='" + dataFromDb["medicine_id"].ToString() + "'", connection1);

                            insertCommand.ExecuteNonQuery();
                            //Update Database end

                            //Insert information into Sells table start
                            string SellingDate = DateTime.Now.ToShortDateString();
                            TotalBuying_price = float.Parse(QuantityTextBox.Text) * float.Parse(dataFromDb["buying_price"].ToString());
                            TotalSelling_price = float.Parse(QuantityTextBox.Text) * float.Parse(dataFromDb["selling_price"].ToString());
                            float net_profit = TotalSelling_price - TotalBuying_price;
                            SqlConnection connection2 = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                            connection2.Open();
                            Console.WriteLine(SellingDate, TotalBuying_price + "a", TotalSelling_price);
                            SqlCommand insertCommand2 = new SqlCommand("INSERT INTO  tbl_sells(medicine_name,genetic_name,manufacturer ,quantity,selling_date,expire_date,buying_price,selling_price,net_Profit)values ('" + dataFromDb["medicine_name"].ToString() + "','" + dataFromDb["genetic_name"].ToString() + "','" + dataFromDb["manufacturer"].ToString() + "','" + QuantityTextBox.Text + "','" + SellingDate + "','" + dataFromDb["expire_date"].ToString() + "','" + TotalBuying_price + "','" + TotalSelling_price + "','" + net_profit + "')", connection2);

                            insertCommand2.ExecuteNonQuery();

                            //Insert information into Sells table end

                            QuantityTextBox.Text = "";
                        }



                        catch (Exception esadsad)
                        { }



                    }
                    else {
                        MessageBox.Show("Not enough Stock");
                    }

                }
            
                }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            TakaLabel.Text = "";
            TotalPayGroupBox.Visible = false;
            price = 0;
        }

        private void TotalPayGroupBox_Enter(object sender, EventArgs e)
        {

        }


            }
        }
    

