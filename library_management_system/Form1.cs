using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userLogbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = nameLogtxt.Text;
            string gelenSifre = passwordLogtxt.Text;

            if(gelenAd.Equals("furkan") && gelenSifre.Equals("123"))
            {
                MessageBox.Show("successful");
            }
            else
            {
                MessageBox.Show("username or password is wrong!");
            }

        }

      
    }
}
