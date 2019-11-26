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
    public partial class SellAnalysis : MetroFramework.Forms.MetroForm
    {
        public float price = 0;
       public string id="";


        public SellAnalysis(string value)
        {
            id = value;
            InitializeComponent();
            //AddComboItem();
            AddComboItem1();
            AddComboItem2();
        }

        //Add medicine name from database to combobox start
       /* public void AddComboItem()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select genetic_name from tbl_medicine", connection);



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

        //Add medicine name from database to combobox start
         */
        public void AddComboItem1()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select distinct medicine_name from tbl_medicine where genetic_name='" + id + "'", connection);



            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string itm = dataFromDb["medicine_name"].ToString();
                    Item1ComboBox.Items.Add(itm);


                }
                catch (Exception esadsad)
                { }
            }
        }
        //Add medicine name from database to combobox end

        //Add medicine name from database to combobox start
        public void AddComboItem2()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select distinct medicine_name from tbl_medicine where genetic_name='" + id + "'", connection);



            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    string itm = dataFromDb["medicine_name"].ToString();
                    Item2ComboBox.Items.Add(itm);


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

       
        
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id);

            
           


            
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

        private void SellAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            SqlCommand selectCommand = new SqlCommand("select * from tbl_sells where medicine_name='" + Item1ComboBox.Text + "'", connection);

            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {



                   // chart1.Series["med"].Points.AddXY("", dataFromDb["medicine_name"].ToString());
                    //Console.WriteLine(dataFromDb["medicine_name"].ToString());
                    chart1.Series["Left"].Points.AddXY("", dataFromDb["quantity"].ToString());
                    // Console.WriteLine(dataFromDb["quantity"].ToString());

                    Left.Text = dataFromDb["medicine_name"].ToString();


                }
                catch (Exception esadsad)
                { }
            }

            SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection1.Open();
            SqlCommand selectCommand1 = new SqlCommand("select * from tbl_sells where medicine_name='" + Item2ComboBox.Text + "'", connection1);



            SqlDataReader dataFromDb1 = selectCommand1.ExecuteReader();


            while (dataFromDb1.Read())
            {

                try
                {


                    
                   // chart1.Series["np"].Points.AddXY("", dataFromDb1["medicine_name"].ToString());
                    chart1.Series["Right"].Points.AddXY("", dataFromDb1["quantity"].ToString());

                    Right.Text = dataFromDb1["medicine_name"].ToString();


                }
                catch (Exception esadsad)
                { }







            }
            Right.Visible = true;
            Left.Visible = true;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


            }
        }
    

