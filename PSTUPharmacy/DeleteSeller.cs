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
    public partial class DeleteSeller : MetroFramework.Forms.MetroForm
    {
        
        public string name="";

        public DeleteSeller()
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

            SqlCommand selectCommand = new SqlCommand("select username from tbl_users", connection);



            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string itm = dataFromDb["username"].ToString();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           // Connection of Database start

            SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection1.Open();

             
           SqlCommand updateCommand = new SqlCommand(" delete from tbl_users where username='" + name + "'", connection1);

            updateCommand.ExecuteNonQuery();

            MessageBox.Show("Successfully deleted");
            

        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {

            if (SearchComboBox.Text == "") {
                MessageBox.Show("Please select a username first.");
            }
              
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);
                dataGridView.Rows.Clear();
                SqlCommand selectCommand = new SqlCommand("select * from tbl_users where username = '" + SearchComboBox.Text + "' ", connection);



                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {
                    

                    try
                    {
                        var index = dataGridView.Rows.Add();
                        Console.WriteLine(index);

                        name = dataFromDb["username"].ToString();
                        dataGridView.Rows[index].Cells[0].Value = dataFromDb["username"].ToString();
                        dataGridView.Rows[index].Cells[1].Value = dataFromDb["email"].ToString();
                        
                        
                       

                        
                    }
                    catch (Exception esadsad)
                    { }

              


                    


                }
            
          
            
                }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MedicineIdTextBox_Click(object sender, EventArgs e)
        {

        }


            }
        }
    

