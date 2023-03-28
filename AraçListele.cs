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
    public partial class AraçListele : Form
    {
        UlastirmaDB AracTahsis = new UlastirmaDB();
        public AraçListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            PLAKAtxt.Text = satır.Cells["PLAKA"].Value.ToString();
            MARKAcombo.Text = satır.Cells["MARKA"].Value.ToString();
            SERIcombo.Text = satır.Cells["SERI"].Value.ToString();
            YILtxt.Text = satır.Cells["YIL"].Value.ToString();
            KMtxt.Text = satır.Cells["KM"].Value.ToString();
            YAKITcombo.Text = satır.Cells["YAKIT"].Value.ToString();
        }
        private void AraçListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListele();
            
                comboAraclar.SelectedIndex = 0;
            
        }



        private void YenileAraçlarListele()
        {
            string cümle = "select * from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = AracTahsis.listele(adtr2, cümle);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "Update arac set MARKA=@MARKA,SERI=@SERI,YIL=@YIL,KM=@KM, YAKIT=@YAKIT WHERE PLAKA = @PLAKA";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@PLAKA", PLAKAtxt.Text);
            komut2.Parameters.AddWithValue("@MARKA", MARKAcombo.Text);
            komut2.Parameters.AddWithValue("@SERI", SERIcombo.Text);
            komut2.Parameters.AddWithValue("@YIL", YILtxt.Text);
            komut2.Parameters.AddWithValue("@KM", KMtxt.Text);
            komut2.Parameters.AddWithValue("@YAKIT", YAKITcombo.Text);
            AracTahsis.ekle_sil_guncelle(komut2, cümle);
            SERIcombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileAraçlarListele();
        }

        private void btnSİL_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = " delete from arac where plaka = '" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            AracTahsis.ekle_sil_guncelle(komut2,cümle);
            YenileAraçlarListele();
            SERIcombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void MARKAcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SERIcombo.Items.Clear();
                if (MARKAcombo.SelectedItem.ToString() == "MERCEDES")
                {
                    SERIcombo.Items.Add("UNIMOG");
                    SERIcombo.Items.Add("VITO");
                }
                else if (MARKAcombo.SelectedIndex == 1)
                {
                    SERIcombo.Items.Add("4x2 KAMYON");
                    SERIcombo.Items.Add("4x4 KAMYON");
                    SERIcombo.Items.Add("SULTAN");
                }
                else if (MARKAcombo.SelectedIndex == 2)
                {
                    SERIcombo.Items.Add("MEGANE");
                    SERIcombo.Items.Add("CLIO");
                    SERIcombo.Items.Add("TALISMAN");
                }
                else if (MARKAcombo.SelectedIndex == 3)
                {
                    SERIcombo.Items.Add("TOURNAEO");
                    SERIcombo.Items.Add("TRANSIT");
                }
                else if (MARKAcombo.SelectedIndex == 4)
                {
                    SERIcombo.Items.Add("DOBLO");
                    SERIcombo.Items.Add("L200");
                }
                else if (MARKAcombo.SelectedIndex == 5)
                {
                    SERIcombo.Items.Add("COROLLA");
                    SERIcombo.Items.Add("HILUX");
                }
            }
            catch
            {


            }
        }

        private void comboAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               if (comboAraclar.SelectedIndex == 0)
                {
                    YenileAraçlarListele();
                }
                if (comboAraclar.SelectedIndex == 1)
                {
                    string cümle = "select *from arac where DURUM = 'BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = AracTahsis.listele(adtr2, cümle);
                }
                if (comboAraclar.SelectedIndex == 2)
                {
                    string cümle = "select *from arac where DURUM = 'DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = AracTahsis.listele(adtr2, cümle);
                }
            }
            catch
            {

            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {

        }
    }
}
