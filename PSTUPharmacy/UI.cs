using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSTUPharmacy
{
    public partial class UI: MetroFramework.Forms.MetroForm
    {
        public UI()
        {
            InitializeComponent();
        }

        private void ClockLabel_Click(object sender, EventArgs e)
        {
            


        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ClockLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

       
    }
}
