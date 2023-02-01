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
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void userLogbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = nameLogtxt.Text;
            string gelenSifre = passwordLogtxt.Text;

            var personel = db.Personeller.Where(x => x.personel_ad.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null)
            {
                MessageBox.Show("username or password is wrong!");
            }
            else
            {
                MessageBox.Show("Successful");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }

        }

      
    }
}
