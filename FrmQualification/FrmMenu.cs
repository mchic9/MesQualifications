using MesQualifications;
namespace FrmQualificationn
{

    public partial class FrmMenu : Form
    {

        Qualification[] tabQualification = new Qualification[5];
        int i = 0;
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void btnValiderE_Click(object sender, EventArgs e)
        {
            Qualification q = new Qualification();
            foreach (Qualification item in tabQualification)
            {
                if (item.Code == Convert.ToInt16(txtCode.Text))
                {
                    q = item;
                }
            }
        }
        //Instancier la classe Employé avec la qualification trouvée

        private void btnValiderQ_Click(object sender, EventArgs e)
        {
            tabQualification[i] = new Qualification(Convert.ToInt16(txtCode.Text), txtLibelle.Text);
            i++;
            if (i == tabQualification.Length)
            {
                MessageBox.Show("Le tableau est plein");
                btnValiderE.Enabled = false;
            }
            txtCode.Clear();
            txtLibelle.Clear();
        }
    }
}
