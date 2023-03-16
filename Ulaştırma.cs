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
            Application.Exit();
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
    }

}
