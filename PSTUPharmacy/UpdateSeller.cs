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
    public partial class UpdateSeller : MetroFramework.Forms.MetroForm
    {
        public string user_name="";
        public UpdateSeller()
        {
            InitializeComponent();
        }

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
            nameTextBox.Clear();
            
            EmailTextBox.Clear();
            
            
            ConfirmTextBox.Clear();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirm = ConfirmTextBox.Text;
            try
            {
                if (password == confirm)
                { }
                else
                {
                    MessageBox.Show("Password doesn't match");
                }
                if (name != "" && email != "" && password != "" && confirm != "" && password == confirm && System.Text.RegularExpressions.Regex.IsMatch(password, @"[^a-zA-Z0-9]") && email.Contains("@") && email.Contains(".com"))
                {
                    //Connection of Database start

                    SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                    connection.Open();
                    Console.WriteLine(connection.State);

                    SqlCommand insertCommand = new SqlCommand(" update tbl_users set username='" + name + "',email='" + email + "',password='" + password + "' where username='" + user_name + "'", connection);

                    insertCommand.ExecuteNonQuery();
                    //Connection of Database end
                    MessageBox.Show("Registration Successfull!");
                }
                else
                {
                    MessageBox.Show("Fill all field");
                }

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSeller_Load(object sender, EventArgs e)
        {

        }

        private void Staff_Click(object sender, EventArgs e)
        {

        }

        private void StaffSearchBtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
            connection.Open();
            //Console.WriteLine(connection.State);

            SqlCommand selectCommand = new SqlCommand("select * from tbl_users where username like '" + StaffSearchTextBox.Text + "%'", connection);



            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            while (dataFromDb.Read())
            {

                try
                {
                    user_name = dataFromDb["username"].ToString();
                  nameTextBox.Text  = dataFromDb["username"].ToString();
                  EmailTextBox.Text = dataFromDb["email"].ToString();
                  PasswordTextBox.Text = dataFromDb["password"].ToString();
                  ConfirmTextBox.Text = dataFromDb["password"].ToString();
                }
                catch (Exception esadsad)
                { }
            }

        }
    }
}
