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
                comboBox2.Items.Clear();
                if (comboBox1.SelectedIndex==0)
                {
                    comboBox2.Items.Add("UNIMOG");
                    comboBox2.Items.Add("VITO");
                }
                else if (comboBox1.SelectedIndex==1)
                {
                    comboBox2.Items.Add("4x2 KAMYON");
                    comboBox2.Items.Add("4x4 KAMYON");
                    comboBox2.Items.Add("SULTAN");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    comboBox2.Items.Add("MEGANE");
                    comboBox2.Items.Add("CLIO");
                    comboBox2.Items.Add("TALISMAN");
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    comboBox2.Items.Add("TOURNAEO");
                    comboBox2.Items.Add("TRANSIT");
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    comboBox2.Items.Add("DOBLO");
                    comboBox2.Items.Add("L200");
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    comboBox2.Items.Add("COROLLA");
                    comboBox2.Items.Add("HILUX");
                }
            }
            catch {
            
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
