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

        private void btnAracKayýt_Click(object sender, EventArgs e)
        {
            frmAraç_Kayýt kayýt-new frmAraç_Kayýt();
            kayýt.ShowDialog();
        }
    }

}
