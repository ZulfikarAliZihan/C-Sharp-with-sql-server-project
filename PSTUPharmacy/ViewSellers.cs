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
    public partial class ViewSellers : MetroFramework.Forms.MetroForm
    {
        public ViewSellers()
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

            LoadDataToGredVieW();

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            dataGridView.Rows.Clear();
            string ComboBoxInput = SearchComboBox.Text;
            if (ComboBoxInput == "Name")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);

                SqlCommand selectCommand = new SqlCommand("select * from tbl_users where username like '" + SearchTextBox.Text + "%'", connection);



                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {

                    try
                    {
                        var index = dataGridView.Rows.Add();


                        dataGridView.Rows[index].Cells[0].Value = dataFromDb["username"].ToString();
                        dataGridView.Rows[index].Cells[1].Value = dataFromDb["email"].ToString();
                        


                    }
                    catch (Exception esadsad)
                    { }
                }
            }
            else if (ComboBoxInput == "Email id")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);

                SqlCommand selectCommand = new SqlCommand("select * from tbl_users where email like '" + SearchTextBox.Text + "%'", connection);


                //selectCommand.Parameters.Add("@NAME", ViewTextBox.Text);
                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {

                    try
                    {
                        var index = dataGridView.Rows.Add();


                        dataGridView.Rows[index].Cells[0].Value = dataFromDb["username"].ToString();
                        dataGridView.Rows[index].Cells[1].Value = dataFromDb["email"].ToString();
                       




                      
                    }
                    catch (Exception esadsad)
                    { }
                }
            }
            
                }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            }

        private void ViewSellers_Load(object sender, EventArgs e)
        {
            LoadDataToGredVieW();
        }
           public void LoadDataToGredVieW(){
            //datagredview load start

            //MessageBox.Show("ok");
            dataGridView.Rows.Clear();

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select * from tbl_users", connection);



            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    var index = dataGridView.Rows.Add();


                    dataGridView.Rows[index].Cells[0].Value = dataFromDb["username"].ToString();
                    dataGridView.Rows[index].Cells[1].Value = dataFromDb["email"].ToString();



                }
                catch (Exception esadsad)
                { }
            }
            //datagredview load end

           }
        }
           
            }
            
                
        


            
        
    

