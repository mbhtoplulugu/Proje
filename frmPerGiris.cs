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

namespace Proje
{
    public partial class frmPerGiris : Form
    {
        UlastirmaDB personel = new UlastirmaDB();
        public frmPerGiris()
        {
            InitializeComponent();
        }

       

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            if (textSinifi.Text.Length > 0 && textTel.Text.Length>0) {
                string sorgu1 = "insert into personel(ad,soyad,SINIFI,RUTBESI,SICILI,TELEFON_NU) values(@ad,@soyad,@sınıfı,@rütbesi,@sicili,@telNo)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@ad", textAdi.Text);
                komut2.Parameters.AddWithValue("@soyad", textSoyadi.Text);
                komut2.Parameters.AddWithValue("@sınıfı", textSinifi.Text);
                komut2.Parameters.AddWithValue("@rütbesi", textRutbesi.Text);
                komut2.Parameters.AddWithValue("@sicili", textSicili.Text);
                komut2.Parameters.AddWithValue("@telNo", textTel.Text);
                personel.ekle_sil_guncelle(komut2, sorgu1);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Personelin Sınıfı ve Sicili Kısmını Boş Bırakmayınız.", "Hata Penceresi", MessageBoxButtons.OK);
            }
        }

        private void btnPerIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
