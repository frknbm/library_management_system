﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system.Kullanici
{
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public void Listele()
        {

            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        
        }
            private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult silinsilMi = MessageBox.Show("Silmek İstediğinden Emin Misiniz? ",
                "Silme İşlemi", MessageBoxButtons.YesNo);

            if (silinsilMi == DialogResult.Yes)
            {
                int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
                db.Kullanicilar.Remove(kullanici);
                db.SaveChanges();
                Listele();
                MessageBox.Show("Silindi");
            }
           
        }
    }
}
