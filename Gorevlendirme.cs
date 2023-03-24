using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void textAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSicili_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from personel where ad like '%" + textAdi.Text + "%' and " +
               "soyad like '%" + textSoyadi.Text + "%' and sınıfı like '%" + textSinifi.Text + "%' and sicili like '%" + textSicili.Text + "%'";
            arac.PerGoster(textAdi, textSoyadi, textSinifi, textRutbesi, textSicili, sorgu);
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
    }
}
