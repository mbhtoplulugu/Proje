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
        }



        private void YenileAraçlarListele()
        {
            string cümle = "select *from arac";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = AracTahsis.listele(adtr2, cümle);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "Update arac set MARKA=@MARKA,SERI=@SERI,YIL=@YIL,KM=@KM, YAKIT=@YAKIT,TARIH=@TARIH WHERE PLAKA = @PLAKA";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@PLAKA", PLAKAtxt.Text);
            komut2.Parameters.AddWithValue("@MARKA", MARKAcombo.Text);
            komut2.Parameters.AddWithValue("@SERI", SERIcombo.Text);
            komut2.Parameters.AddWithValue("@YIL", YILtxt.Text);
            komut2.Parameters.AddWithValue("@KM", KMtxt.Text);
            komut2.Parameters.AddWithValue("@YAKIT", YAKITcombo.Text);
            komut2.Parameters.AddWithValue("@TARIH", DateTime.Now.ToString());
            AracTahsis.ekle_sil_guncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

            YenileAraçlarListele();
        }
    }
}
