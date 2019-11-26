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
using System.Diagnostics;
using System.IO;
using System.Configuration;

namespace PSTUPharmacy
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ab = @"python tf_files\label_image.py E:\\I.jpg";
            Process test = new Process();
            test.StartInfo.FileName = @"python tf_files\label_image.py E:\5.jpg";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/all";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            richTextBox1.Text = test.StandardOutput.ReadToEnd();

            //datagredview load start

            //MessageBox.Show("ok");
            

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select * from tbl_users", connection);

            StringBuilder sb=new StringBuilder();

            SqlDataReader dataFromDb = selectCommand.ExecuteReader();
            

            while (dataFromDb.Read())
            {

                try
                {
                    
                   
                    


                    sb.Append(dataFromDb["username"].ToString()+",");
                    sb.Append(dataFromDb["email"].ToString());
                    sb.Append("\r\n");

                    StreamWriter file = new StreamWriter(@"C:\Users\ZIHAN\data.csv");
                    file.WriteLine(sb.ToString());
                    file.Close();
                }
                catch (Exception esadsad)
                { }
            }
            //datagredview load end

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            SqlCommand selectCommand = new SqlCommand("select * from tbl_medicine where medicine_name='napa' and medicine_id=1", connection);

            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {



                    chart1.Series["med"].Points.AddXY("napa", dataFromDb["medicine_name"].ToString());
                    //Console.WriteLine(dataFromDb["medicine_name"].ToString());
                    chart1.Series["med"].Points.AddXY("napa", dataFromDb["quantity"].ToString());
                    // Console.WriteLine(dataFromDb["quantity"].ToString());



                }
                catch (Exception esadsad)
                { }
            }

            SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection1.Open();
            SqlCommand selectCommand1 = new SqlCommand("select * from tbl_medicine where medicine_name='p' and medicine_id=99", connection1);



            SqlDataReader dataFromDb1 = selectCommand1.ExecuteReader();


            while (dataFromDb1.Read())
            {

                try
                {



                    chart1.Series["np"].Points.AddXY("pn", dataFromDb1["medicine_name"].ToString());
                    chart1.Series["np"].Points.AddXY("pn", dataFromDb1["quantity"].ToString());




                }
                catch (Exception esadsad)
                { }







            }
            }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Close();
            h1.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
