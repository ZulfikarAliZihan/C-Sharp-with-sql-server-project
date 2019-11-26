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
    public partial class AddSeller : MetroFramework.Forms.MetroForm
    {
        public AddSeller()
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
            byte[] SellerPicture = GetImageData();
            if (password == confirm)
            {
            }
            else
            {
                MessageBox.Show("Password doesn't match");
            }
            if (name != "" && email != "" && password != "" && confirm != "" && SellerPicture.ToString() != "" && password == confirm && System.Text.RegularExpressions.Regex.IsMatch(password, @"[^a-zA-Z0-9]") && email.Contains("@") && email.Contains(".com"))
            {
                //Connection of Database start

                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                Console.WriteLine(connection.State);

                SqlCommand insertCommand = new SqlCommand(" INSERT INTO  tbl_users(username,password,email,image)values (@s_name,@s_password,@s_email,@s_picture)", connection);
                insertCommand.Parameters.AddWithValue("@s_name", name);
                insertCommand.Parameters.AddWithValue("@s_password", password);
                insertCommand.Parameters.AddWithValue("@s_email", email);
                insertCommand.Parameters.AddWithValue("@s_picture", SellerPicture);

                insertCommand.ExecuteNonQuery();
                //Connection of Database end
                MessageBox.Show("Registration Successfull!");


            }
        }

        public byte[] GetImageData()
        {
            Image img = Image.FromFile(PictureNameTextBox.Text);

            ImageConverter ic = new ImageConverter();

            return (byte[])ic.ConvertTo(img, typeof(byte[]));
        }

        private void AddSeller_Load(object sender, EventArgs e)
        {

        }

        private void PictureOpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                PictureNameTextBox.Text = ofd.FileName;


                SellerPictureBox.Image = Image.FromFile(@ofd.FileName);
            }
        }
    }
}
