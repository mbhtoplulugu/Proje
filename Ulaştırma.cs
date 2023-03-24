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

        private void btnAracKay�t_Click(object sender, EventArgs e)
        {
            frmAra�_Kay�t kay�t=new frmAra�_Kay�t();
            kay�t.ShowDialog();
        }

        private void btnG�rev_Click(object sender, EventArgs e)
        {
            frmGorevlendirme duty = new frmGorevlendirme();
            duty.ShowDialog();
       
        }

        private void btnAracList_Click(object sender, EventArgs e)
        {
            Ara�Listele listele = new Ara�Listele();
            listele.ShowDialog();
        }
    }

}
