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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proje
{
    public partial class frmPerList : Form
    {
        UlastirmaDB personel = new UlastirmaDB();

        public frmPerList()
        {
            InitializeComponent();
        }

        private void frmPerList_Load(object sender, EventArgs e)
        {
            YenileListele();

        }

        private void YenileListele()
        {
            string sorgu = "select * from personel";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = personel.listele(adtr2, sorgu);
        }
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = personel.listele(adtr2, sorgu);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
             this.Close();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textAd.Text = satir.Cells[0].Value.ToString();
            textSoyad.Text = satir.Cells[1].Value.ToString();
            textSinif.Text = satir.Cells[2].Value.ToString();
            textRutbe.Text = satir.Cells[3].Value.ToString();
            textSicil.Text = satir.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Personelin verileri geri dönmemek üzere değiştirilecektir. \nDevam etmek istiyor musunuz?", "Remove Window", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
                string sorgu = "update personel set ad=@ad, soyad=@soyad, sınıfı=@sınıfı, rütbesi=@rütbesi, sicili=@sicili where " +
                                "sicili = @sicili and sınıfı=@sınıfı ";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.AddWithValue("@ad", textAd.Text);
                komut2.Parameters.AddWithValue("@soyad", textSoyad.Text);
                komut2.Parameters.AddWithValue("@sınıfı", textSinif.Text);
                komut2.Parameters.AddWithValue("@rütbesi", textRutbe.Text);
                komut2.Parameters.AddWithValue("@sicili", textSicil.Text);
                
                personel.ekle_sil_guncelle(komut2, sorgu);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                
                YenileListele();
            }
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            string sorgu = "select * from personel where ad like '%" + textAd.Text + "%' " +
                "and soyad like '%" + textSoyad.Text + "%'and sicili like '%" + textSicil.Text + "%' ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = personel.listele(adtr2, sorgu);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Personeli silmek istiyor musunuz?", "Remove Window", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
            string sorgu = "delete from personel where ad=@ad and soyad=@soyad and sınıfı = @sınıfı" +
                " and rütbesi=@rütbesi and sicili = @sicili";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ad", textAd.Text);
            komut2.Parameters.AddWithValue("@soyad", textSoyad.Text);
            komut2.Parameters.AddWithValue("@sınıfı", textSinif.Text);
            komut2.Parameters.AddWithValue("@rütbesi", textRutbe.Text);
            komut2.Parameters.AddWithValue("@sicili", textSicil.Text);
            personel.ekle_sil_guncelle(komut2, sorgu);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            personel.ekle_sil_guncelle(komut2, sorgu);
            YenileListele();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
