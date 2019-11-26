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
    public partial class DeleteMedicine : MetroFramework.Forms.MetroForm
    {
        public float price = 0;
        public string id="";

        public DeleteMedicine()
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
            Medicine m1 = new Medicine();
            this.Close();
            m1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           // Connection of Database start

            SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection1.Open();

             
           SqlCommand updateCommand = new SqlCommand(" delete from tbl_medicine where id='" + id + "'", connection1);

            updateCommand.ExecuteNonQuery();

            MessageBox.Show("Successfully deleted");
            

        }
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {

            if (SearchComboBox.Text == "") {
                MessageBox.Show("Please select a name first.");
            }
              
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);
                dataGridView.Rows.Clear();
                SqlCommand selectCommand = new SqlCommand("select * from tbl_medicine where medicine_name = '" + SearchComboBox.Text + "' ", connection);



                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {
                    

                    try
                    {
                        var index = dataGridView.Rows.Add();
                        Console.WriteLine(index);

                        id = dataFromDb["id"].ToString();
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
    

