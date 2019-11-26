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
    public partial class Report : MetroFramework.Forms.MetroForm
    {

        public Report()
        {
            InitializeComponent();
            
            
        }

        
        
        private void HometoSellAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string date1 = DateTime.Now.ToShortDateString();
            string[] day = date1.Split('/');
            
            if (TypeComboBox.Text == "Daily") {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);
                string SellingDay = day[0] + "-" + day[1] + "-"+day[2];
                //MessageBox.Show(SellingDay);
                SqlCommand selectCommand = new SqlCommand("select * from tbl_sells where selling_date= '"+date1+"'", connection);
               // SqlCommand selectCommand = new SqlCommand("SELECT DATEDIFF(DAY,  DATEADD(day, -1, '2018-06-30 00:00:00.000'), GETDATE())", connection);
                
                StringBuilder sb = new StringBuilder();

                int s_id=0;
                sb.Append("Serial no" + ",");
                sb.Append("Medicine name" + ",");
                sb.Append("Genetic name" + ",");
                sb.Append("Manufacturer" + ",");
                sb.Append("Selling date" + ",");
                sb.Append("Expire date"+ ",");
                sb.Append("Quantity" + ",");
                sb.Append("Buying price" + ",");
                sb.Append("Selling price" + ",");
                sb.Append("Total profit");
                sb.Append("\r\n");

                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {

                    try
                    {   s_id+=1;
                        sb.Append(s_id + ",");
                        sb.Append(dataFromDb["medicine_name"].ToString() + ",");
                        sb.Append(dataFromDb["genetic_name"].ToString() + ",");
                        sb.Append(dataFromDb["manufacturer"].ToString() + ",");
                        sb.Append(dataFromDb["selling_date"].ToString() + ",");
                        sb.Append(dataFromDb["expire_date"].ToString() + ",");
                        sb.Append(dataFromDb["quantity"].ToString() + ",");
                        sb.Append(dataFromDb["buying_price"].ToString() + ",");
                        sb.Append(dataFromDb["selling_price"].ToString() + ",");
                        sb.Append(dataFromDb["net_profit"].ToString());
                        sb.Append("\r\n");

                        StreamWriter file = new StreamWriter(@"C:\Users\ZIHAN\Daily_report.csv");
                        file.WriteLine(sb.ToString());
                        file.Close();
                       
                    }
                         
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                MessageBox.Show("Report Created");
                this.Close();
            }

            if (TypeComboBox.Text == "Last month")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);
                string SellingDay1 = (int.Parse(day[0])-1).ToString() + "-" + "01" + "-" + day[2];
                string SellingDay2 = (int.Parse(day[0])-1).ToString() + "-" + "30" + "-" + day[2];

                SqlCommand selectCommand = new SqlCommand("select * from tbl_sells where selling_date between '" + SellingDay1 + "' and '" + SellingDay2 + "'", connection);

                StringBuilder sb = new StringBuilder();

                int s_id = 0;
                sb.Append("Serial no" + ",");
                sb.Append("Medicine name" + ",");
                sb.Append("Genetic name" + ",");
                sb.Append("Manufacturer" + ",");
                sb.Append("Selling date" + ",");
                sb.Append("Expire date" + ",");
                sb.Append("Quantity" + ",");
                sb.Append("Buying price" + ",");
                sb.Append("Selling price" + ",");
                sb.Append("Total profit");
                sb.Append("\r\n");

                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {

                    try
                    {
                        s_id += 1;
                        sb.Append(s_id + ",");
                        sb.Append(dataFromDb["medicine_name"].ToString() + ",");
                        sb.Append(dataFromDb["genetic_name"].ToString() + ",");
                        sb.Append(dataFromDb["manufacturer"].ToString() + ",");
                        sb.Append(dataFromDb["selling_date"].ToString() + ",");
                        sb.Append(dataFromDb["expire_date"].ToString() + ",");
                        sb.Append(dataFromDb["quantity"].ToString() + ",");
                        sb.Append(dataFromDb["buying_price"].ToString() + ",");
                        sb.Append(dataFromDb["selling_price"].ToString() + ",");
                        sb.Append(dataFromDb["net_profit"].ToString());
                        sb.Append("\r\n");

                        StreamWriter file = new StreamWriter(@"C:\Users\ZIHAN\data.csv");
                        file.WriteLine(sb.ToString());
                        file.Close();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
                MessageBox.Show("Report Created");
                this.Close();
            }

            if (TypeComboBox.Text == "Yearly")
            {
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-25NMO9E;Initial Catalog=PSTUPharmacy; Integrated Security=true");
                connection.Open();
                //Console.WriteLine(connection.State);
                string SellingDay1 = "01"+ "-" + "01" + "-" + day[2];
                string SellingDay2 = "12" + "-" + "31" + "-" + day[2];

                SqlCommand selectCommand = new SqlCommand("select * from tbl_sells where selling_date between '" + SellingDay1 + "' and '" + SellingDay2 + "'", connection);

                StringBuilder sb = new StringBuilder();

                int s_id = 0;
                sb.Append("Serial no" + ",");
                sb.Append("Medicine name" + ",");
                sb.Append("Genetic name" + ",");
                sb.Append("Manufacturer" + ",");
                sb.Append("Selling date" + ",");
                sb.Append("Expire date" + ",");
                sb.Append("Quantity" + ",");
                sb.Append("Buying price" + ",");
                sb.Append("Selling price" + ",");
                sb.Append("Total profit");
                sb.Append("\r\n");

                SqlDataReader dataFromDb = selectCommand.ExecuteReader();


                while (dataFromDb.Read())
                {

                    try
                    {
                        s_id += 1;
                        sb.Append(s_id + ",");
                        sb.Append(dataFromDb["medicine_name"].ToString() + ",");
                        sb.Append(dataFromDb["genetic_name"].ToString() + ",");
                        sb.Append(dataFromDb["manufacturer"].ToString() + ",");
                        sb.Append(dataFromDb["selling_date"].ToString() + ",");
                        sb.Append(dataFromDb["expire_date"].ToString() + ",");
                        sb.Append(dataFromDb["quantity"].ToString() + ",");
                        sb.Append(dataFromDb["buying_price"].ToString() + ",");
                        sb.Append(dataFromDb["selling_price"].ToString() + ",");
                        sb.Append(dataFromDb["net_profit"].ToString());
                        sb.Append("\r\n");

                        StreamWriter file = new StreamWriter(@"C:\Users\ZIHAN\Yearly_report.csv");
                        file.WriteLine(sb.ToString());
                        file.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }
                MessageBox.Show("Report Created");
                this.Close();
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }
    }
}
