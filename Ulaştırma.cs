namespace Proje
{

    public partial class FrmUlastirma : Form
    {
        public FrmUlastirma()
        {
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Sayfadan cikmak istiyor musunuz?", "Exit Window", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPerKayit_Click(object sender, EventArgs e)
        {
            frmPerGiris ekle = new frmPerGiris();
            ekle.ShowDialog();  
        }

        private void btnPerList_Click(object sender, EventArgs e)
        {
            frmPerList listele = new frmPerList();    
            listele.ShowDialog();
        }

        private void FrmUlastirma_Load(object sender, EventArgs e)
        {

        }

        private void btnAracKayýt_Click(object sender, EventArgs e)
        {
            frmAraç_Kayýt kayýt=new frmAraç_Kayýt();
            kayýt.ShowDialog();
        }

        private void btnGörev_Click(object sender, EventArgs e)
        {
            frmGorevlendirme duty = new frmGorevlendirme();
            duty.ShowDialog();
       
        }

        private void btnAracList_Click(object sender, EventArgs e)
        {
            AraçListele listele = new AraçListele();
            listele.ShowDialog();
        }
    }

}
