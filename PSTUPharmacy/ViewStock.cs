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
    public partial class ViewStock : MetroFramework.Forms.MetroForm
    {
        public ViewStock()
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



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            Console.WriteLine(connection.State);
            dataGridView.Rows.Clear();


            SqlCommand selectCommand = new SqlCommand("select * from tbl_medicine", connection);


            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    var index = dataGridView.Rows.Add();


                    dataGridView.Rows[index].Cells[0].Value = dataFromDb["medicine_id"].ToString();
                    dataGridView.Rows[index].Cells[1].Value = dataFromDb["medicine_name"].ToString();
                    dataGridView.Rows[index].Cells[2].Value = dataFromDb["catagory"].ToString();
                    dataGridView.Rows[index].Cells[3].Value = dataFromDb["manufacturer"].ToString();
                    dataGridView.Rows[index].Cells[4].Value = dataFromDb["quantity"].ToString();
                    dataGridView.Rows[index].Cells[5].Value = dataFromDb["entry_date"].ToString();
                    dataGridView.Rows[index].Cells[6].Value = dataFromDb["production_date"].ToString();
                    dataGridView.Rows[index].Cells[7].Value = dataFromDb["expire_date"].ToString();
                    dataGridView.Rows[index].Cells[8].Value = dataFromDb["buying_price"].ToString();
                    dataGridView.Rows[index].Cells[9].Value = dataFromDb["selling_price"].ToString();




                }
                catch (Exception esadsad)
                { }
            }




        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            dataGridView.Rows.Clear();
            string ComboBoxInput = SearchComboBox.Text;
            if (ComboBoxInput == "Medicine name")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);

                SqlCommand selectCommand = new SqlCommand("select * from tbl_medicine where medicine_name like '" + SearchTextBox.Text + "%'", connection);



                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {

                    try
                    {
                        var index = dataGridView.Rows.Add();


                        dataGridView.Rows[index].Cells[0].Value = dataFromDb["medicine_id"].ToString();
                        dataGridView.Rows[index].Cells[1].Value = dataFromDb["medicine_name"].ToString();
                        dataGridView.Rows[index].Cells[2].Value = dataFromDb["catagory"].ToString();
                        dataGridView.Rows[index].Cells[3].Value = dataFromDb["manufacturer"].ToString();
                        dataGridView.Rows[index].Cells[4].Value = dataFromDb["quantity"].ToString();
                        dataGridView.Rows[index].Cells[5].Value = dataFromDb["entry_date"].ToString();
                        dataGridView.Rows[index].Cells[6].Value = dataFromDb["production_date"].ToString();
                        dataGridView.Rows[index].Cells[7].Value = dataFromDb["expire_date"].ToString();
                        dataGridView.Rows[index].Cells[8].Value = dataFromDb["buying_price"].ToString();
                        dataGridView.Rows[index].Cells[9].Value = dataFromDb["selling_price"].ToString();


                    }
                    catch (Exception esadsad)
                    { }
                }
            }
            else if (ComboBoxInput == "Medicine id")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);

                SqlCommand selectCommand = new SqlCommand("select * from tbl_medicine where medicine_id like '" + SearchTextBox.Text + "%'", connection);


                //selectCommand.Parameters.Add("@NAME", ViewTextBox.Text);
                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {

                    try
                    {
                        var index = dataGridView.Rows.Add();


                        dataGridView.Rows[index].Cells[0].Value = dataFromDb["medicine_id"].ToString();
                        dataGridView.Rows[index].Cells[1].Value = dataFromDb["medicine_name"].ToString();
                        dataGridView.Rows[index].Cells[2].Value = dataFromDb["catagory"].ToString();
                        dataGridView.Rows[index].Cells[3].Value = dataFromDb["manufacturer"].ToString();
                        dataGridView.Rows[index].Cells[4].Value = dataFromDb["quantity"].ToString();
                        dataGridView.Rows[index].Cells[5].Value = dataFromDb["entry_date"].ToString();
                        dataGridView.Rows[index].Cells[6].Value = dataFromDb["production_date"].ToString();
                        dataGridView.Rows[index].Cells[7].Value = dataFromDb["expire_date"].ToString();
                        dataGridView.Rows[index].Cells[8].Value = dataFromDb["buying_price"].ToString();
                        dataGridView.Rows[index].Cells[9].Value = dataFromDb["selling_price"].ToString();




                      
                    }
                    catch (Exception esadsad)
                    { }
                }
            }
            
                }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


            }
        }
    

