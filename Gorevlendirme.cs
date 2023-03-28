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
    public partial class frmGorevlendirme : Form
    {
        public frmGorevlendirme()
        {
            InitializeComponent();
        }
        UlastirmaDB arac = new UlastirmaDB();

        private void Gorevlendirme_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where DURUM = 'BOŞ'";
            arac.bosAraclar(comboPlaka,comboMarka,comboSeri, sorgu);
        }

        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where plaka like '%" + comboPlaka.SelectedItem + "%' and DURUM = 'BOŞ'";
            arac.PlakaileGoster (comboPlaka, comboMarka, comboSeri, sorgu);
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where Marka like '%" + comboMarka.SelectedItem + "%' and DURUM = 'BOŞ' ";
            arac.MarkaileGoster(comboPlaka, comboMarka, comboSeri, sorgu);
            
        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where SERI like '%" + comboSeri.SelectedItem + "%' and DURUM = 'BOŞ' ";
            arac.SeriileGoster(comboPlaka, comboMarka, comboSeri, sorgu);
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboPlaka.ResetText();
            comboMarka.ResetText();
            comboSeri.ResetText();
            string sorgu = "select * from arac where DURUM = 'BOŞ'";
            arac.bosAraclar(comboPlaka, comboMarka, comboSeri, sorgu);
        }

        private void konvoyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (konvoyCheck.Checked)
            {
                label6.Visible = true;
                textKonvoy.Visible = true;
                comboKonvoyPlaka.Visible = true;
                label7.Visible = true;
                btnKonAracEkle.Visible = true;
            }
            else
            {
                label6.Visible = false;
                textKonvoy.Visible = false;
                comboKonvoyPlaka.Visible = false;
                label7.Visible = false;
                btnKonAracEkle.Visible = false;
            }
        }

        private void btnPerAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel where ad like '%" + textAdi.Text + "%' and " +
               "soyad like '%" + textSoyadi.Text + "%' and sınıfı like '%" + textSinifi.Text + "%' and sicili like '%" + textSicili.Text + "%'";
            arac.PerGoster(textAdi, textSoyadi, textSinifi, textRutbesi, textSicili, sorgu);
        }

        private void btnGorev_Click(object sender, EventArgs e)
        {
            if(textAdi.Text.Length>0 && textSicili.Text.Length>0 && textSinifi.Text.Length>0) {
                if (comboPlaka.Text.Length > 0)
                {
// AYNI İSİMLİ KONVOY VAR MI KONTROL
                    string sorgu1 = "update personel set konvoyID=@konvoyID where sicili = @sicili and sınıfı=@sınıfı ";
                    string sorgu2 = "update araç set konvoyID=@konvoyID where PLAKA = @plaka ";
                    string sorgu3 = "insert into konvoy(konvoyID,konvoyK,konvoyCikisTarihi,konvoyCikisSaati,konvoyDonusTarih,konvoyDonusSaati)" +
                        " values (@konvoyID,@konvoyK,@konvoyCikisTarihi,@konvoyCikisSaati,@konvoyDonusTarih,@konvoyDonusSaati) ";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.AddWithValue("@konvoyID", textAdi.Text);
                    komut.Parameters.AddWithValue("@konvoyK", textSoyadi.Text);
                    komut.Parameters.AddWithValue("@konvoyCikisTarihi", cikisGun.Text);
                    komut.Parameters.AddWithValue("@konvoyCikisSaati", cikisZaman.Text);
                    komut.Parameters.AddWithValue("@konvoyDonusTarih", donusGun.Text);
                    komut.Parameters.AddWithValue("@konvoyDonusSaati", donusZaman.Text);

                    arac.ekle_sil_guncelle(komut, sorgu1);
                    arac.ekle_sil_guncelle(komut, sorgu2);
                    arac.ekle_sil_guncelle(komut, sorgu3);
                    foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                }
                else { MessageBox.Show("Lütfen Araç Seçiniz", "Hata Penceresi", MessageBoxButtons.OK); }
            }
            else
            {
                MessageBox.Show("Lütfen Personel Seçiniz", "Hata Penceresi", MessageBoxButtons.OK);
            }
        }

        private void btnKonAracEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "update araç set konvoyID=@konvoyID where PLAKA = @plaka ";
            SqlCommand komut = new SqlCommand();
            arac.ekle_sil_guncelle(komut, sorgu);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }
    }
}
