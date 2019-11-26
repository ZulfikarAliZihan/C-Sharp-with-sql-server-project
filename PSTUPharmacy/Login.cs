using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSTUPharmacy
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        string name = "";
        public Login()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            ActiveLoginPanel.Height = PasswordTextBox.Height;
            ActiveLoginPanel.Top = PasswordTextBox.Top;
            //test a featuere start
            string username = UsernameTextBox.Text;
            if (username != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                SqlCommand selectCommand = new SqlCommand(" select * from tbl_users where username = '" + username + "'", connection);


                SqlDataReader dataFromDb = selectCommand.ExecuteReader();
                while (dataFromDb.Read())
                {
                    
                    if (dataFromDb["image"].ToString() != "")
                    {
                        byte[] SellerPicture = (byte[])dataFromDb["image"];
                        Image newImage;
                        MemoryStream stream = new MemoryStream(SellerPicture);
                        newImage = Image.FromStream(stream);
                        SellerPictureBox.Image = newImage;
                    }
                }
                Console.WriteLine(name);
            }
            //test a feature end

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            ActiveLoginPanel.Height = UsernameTextBox.Height; 
            ActiveLoginPanel.Top = UsernameTextBox.Top;
        }

        private void ActiveLoginPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
           if (username != "" && password != "")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);

                SqlCommand selectCommand = new SqlCommand(" select * from tbl_users where username = '" + username + "' and password ='" + password + "'", connection);


                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                if (dataFromDb.HasRows)
                {


                    Home h1 = new Home();
                    this.Hide();
                    h1.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username and/or password");
                }


            }
            else {
                MessageBox.Show("Please fill username and/or password");
            }
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
