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
    public partial class frmAraç_Kayıt : Form
    {
        UlastirmaDB AracTahsis = new UlastirmaDB();
        public frmAraç_Kayıt()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SERIcombo.Items.Clear();
                if (MARKAcombo.SelectedItem.ToString()=="MERCEDES")
                {
                    SERIcombo.Items.Add("UNIMOG");
                    SERIcombo.Items.Add("VITO");
                }
                else if (MARKAcombo.SelectedIndex==1)
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
            catch {
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into arac (PLAKA,MARKA,SERI,YIL,KM,YAKIT,TARIH,DURUM) values (@PLAKA,@MARKA,@SERI,@YIL,@KM,@YAKIT,@TARIH,@DURUM)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@PLAKA", PLAKAtxt.Text);
            komut2.Parameters.AddWithValue("@MARKA", MARKAcombo.Text);
            komut2.Parameters.AddWithValue("@SERI", SERIcombo.Text);
            komut2.Parameters.AddWithValue("@YIL", YILtxt.Text);
            komut2.Parameters.AddWithValue("@KM", KMtxt.Text);
            komut2.Parameters.AddWithValue("@YAKIT", YAKITcombo.Text);
            komut2.Parameters.AddWithValue("@TARIH", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@DURUM", "BOŞ");
            AracTahsis.ekle_sil_guncelle(komut2,cumle);
            SERIcombo.Items.Clear();    
            foreach (Control Item in Controls) if (Item is TextBox) Item.Text= " ";
            foreach (Control Item in Controls) if (Item is ComboBox) Item.Text = " ";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
