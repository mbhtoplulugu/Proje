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
            string sorgu1 = "select * from arac";
            arac.Araclar(comboKonvoyPlaka, sorgu1);
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
            if (checkKonvoy.Checked)
            {
                label6.Visible = true;
                textKonvoy.Visible = true;
                comboKonvoyPlaka.Visible = true;
                label7.Visible = true;
                btnKonAracEkle.Visible = true;
                btnKonAracSil.Visible = true;
            }
            else
            {
                label6.Visible = false;
                textKonvoy.Visible = false;
                comboKonvoyPlaka.Visible = false;
                label7.Visible = false;
                btnKonAracEkle.Visible = false;
                btnKonAracSil.Visible = false;
            }
        }

        private void btnPerAra_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel where AD like '%" + textAdi.Text + "%' and " +
               "SOYAD like '%" + textSoyadi.Text + "%' and SINIFI like '%" + textSinifi.Text + "%' and SICILI like '%" + textSicili.Text + "%'";
            arac.PerGoster(textTel, textAdi, textSoyadi, textSinifi, textRutbesi, textSicili,  sorgu);
        }

        private void btnGorev_Click(object sender, EventArgs e)
        {
            if(textAdi.Text.Length>0 && textSicili.Text.Length>0 && textSinifi.Text.Length>0 && textTel.Text.Length > 0) {
                if (comboPlaka.Text.Length > 0 || comboKonvoyPlaka.Text.Length> 0)
                {
                    if (checkKonvoy.Checked)
                    {
                        
                        // AYNI İSİMLİ KONVOY VAR MI KONTROL
                        string sorgu1 = "update personel set KONVOY_ID=@konvoyID where SICILI = @sicili and SINIFI=@sınıfı ";
                        string sorgu2 = "insert into Konvoy (KONVOY_ID, KONVOY_K_,KONVOY_K_TEL_NO, CIKIS_TARIHI, CIKIS_SAATI, DONUS_TARIHI, DONUS_SAATI)" +
                            " values (@konvoyID, @konvoyK,@tel, @konvoyCikisTarihi, @konvoyCikisSaati, @konvoyDonusTarih, @konvoyDonusSaati) ";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.AddWithValue("@konvoyID", textKonvoy.Text);
                        komut.Parameters.AddWithValue("@konvoyK", textSinifi.Text + " " + textRutbesi.Text + " " + textAdi.Text + " " + textSoyadi.Text + " " + textSicili.Text);
                        komut.Parameters.AddWithValue("@konvoyCikisTarihi", cikisGun.Text);
                        komut.Parameters.AddWithValue("@konvoyCikisSaati", cikisZaman.Text);
                        komut.Parameters.AddWithValue("@konvoyDonusTarih", donusGun.Text);
                        komut.Parameters.AddWithValue("@konvoyDonusSaati", donusZaman.Text);
                        komut.Parameters.AddWithValue("@sicili", textSicili.Text);
                        komut.Parameters.AddWithValue("@sınıfı", textSinifi.Text);
                        komut.Parameters.AddWithValue("@tel", textTel.Text);
                        if (arac.baglanti.State != ConnectionState.Open)
                        {
                            arac.baglanti.Close();
                            arac.baglanti.Open();
                        }
                        komut.Connection = arac.baglanti;
                        komut.CommandText = sorgu1;
                        komut.ExecuteNonQuery();
                        komut.CommandText = sorgu2;
                        komut.ExecuteNonQuery();
                        arac.baglanti.Close();
                    }
                    else
                    {
                        string sorgu = "update arac set CIKIS_TARIHI = @CikisTarihi, CIKIS_SAATI = @CikisSaati, " +
                            "DONUS_TARIHI = @DonusTarih, DONUS_SAATI = @DonusSaati,DURUM= 'DOLU', ARAC_KOMUTANI=@aracK, ARAC_K_TEL_NO = @telNo where PLAKA = @plaka ";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.AddWithValue("@plaka", comboPlaka.Text);
                        komut.Parameters.AddWithValue("@CikisTarihi", cikisGun.Text);
                        komut.Parameters.AddWithValue("@CikisSaati", cikisZaman.Text);
                        komut.Parameters.AddWithValue("@DonusTarih", donusGun.Text);
                        komut.Parameters.AddWithValue("@DonusSaati", donusZaman.Text);
                        komut.Parameters.AddWithValue("@aracK", textSinifi.Text + " " + textRutbesi.Text + " " + textAdi.Text + " " + textSoyadi.Text + " " + textSicili.Text);
                        komut.Parameters.AddWithValue("@telNo", textTel.Text);
                        arac.ekle_sil_guncelle(komut, sorgu);
                    }
                    MessageBox.Show("Görev Emri Tamamlandı", "Sonuç", MessageBoxButtons.OK);
                    foreach (Control item in Controls) if (item is TextBox || item is ComboBox) item.Text = "";

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
            string sorgu = "update arac set CIKIS_TARIHI = @konvoyCikisTarihi, CIKIS_SAATI= @konvoyCikisSaati, " +
                "DONUS_TARIHI=@konvoyDonusTarih,DONUS_SAATI=@konvoyDonusSaati, KONVOY_ID=@konvoyID, " +
                "DURUM = 'DOLU', ARAC_KOMUTANI=@aracK, ARAC_K_TEL_NO where PLAKA = @plaka ";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@konvoyID", textKonvoy.Text);
            komut.Parameters.AddWithValue("@plaka", comboKonvoyPlaka.Text);
            komut.Parameters.AddWithValue("@konvoyCikisTarihi", cikisGun.Text);
            komut.Parameters.AddWithValue("@konvoyCikisSaati", cikisZaman.Text);
            komut.Parameters.AddWithValue("@konvoyDonusTarih", donusGun.Text);
            komut.Parameters.AddWithValue("@konvoyDonusSaati", donusZaman.Text);
            komut.Parameters.AddWithValue("@aracK", textSinifi.Text + " " + textRutbesi.Text + " " + textAdi.Text + " " + textSoyadi.Text + " " + textSicili.Text);
            komut.Parameters.AddWithValue("@telNo", textTel.Text);
            arac.ekle_sil_guncelle(komut, sorgu);

            MessageBox.Show("Araç Konvoya Eklendi", "Sonuç", MessageBoxButtons.OK);

            foreach (Control item in Controls) if (item is TextBox || item is ComboBox) item.Text = "";
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from arac where DURUM like '%DOLU%' ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu);
        }

        private void btnKonvoyListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from konvoy ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu);
        }

        private void btnKonAracSil_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Aracı Konvoydan Çıkarmak istediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
                string sorgu = "update arac set CIKIS_TARIHI = '', CIKIS_SAATI= '', DONUS_TARIHI='', " +
                "DONUS_SAATI='', KONVOY_ID='', DURUM = 'BOŞ', ARAC_KOMUTANI='', ARAC_K_TEL_NO='' where PLAKA = @plaka ";
               
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@plaka", comboKonvoyPlaka.Text);
                arac.ekle_sil_guncelle(komut, sorgu);

                MessageBox.Show("Araç Konvoydan Silindi", "Sonuç", MessageBoxButtons.OK);

                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            }
        }

        private void cikisZaman_ValueChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
