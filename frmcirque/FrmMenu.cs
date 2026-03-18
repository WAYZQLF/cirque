using Moncirque;
namespace frmcirque
{
    public partial class FrmMenu : Form
    {
        Accessoire[] tabAccessoire = new Accessoire[3];
        Personnel[] tabPersonnel = new Personnel[3];
        Utilisation[] tabUtilisation = new Utilisation[3];
        int i = 0;
        int j = 0;
        int k = 0;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnValiderA_Click(object sender, EventArgs e)
        {
            tabAccessoire[i] = new Accessoire(txtNom.Text, txtCouleur.Text, Convert.ToDouble(txtVolume.Text), Convert.ToInt32(txtRatelier.Text), Convert.ToInt32(txtCamion.Text));
            i++;
            if (i == 3)
            {
                MessageBox.Show("Limite atteinte");
                btnValiderA.Enabled = false;
            }
            txtNom.Clear();
            txtCouleur.Clear();
            txtRatelier.Clear();
            txtCamion.Clear();
            txtVolume.Clear();
        }

        private void btnvaliderP_Click(object sender, EventArgs e)
        {
            tabPersonnel[j] = new Personnel(txtNom_Personnel.Text, txtRôle_Personnel.Text);
            j++;
            if (j == 3)
            {
                MessageBox.Show("Limite atteinte");
                btnvaliderP.Enabled = false;
            }
            txtNom_Personnel.Clear();
            txtRôle_Personnel.Clear();

        }

        private void btnValiderU_Click(object sender, EventArgs e)
        {
            Accessoire a = new Accessoire();
            foreach (Accessoire acces in tabAccessoire)
            {
                if (acces.getNom() == txtAccessoire.Text)
                {
                    a=acces;
                }
            }
            Personnel p = new Personnel();
            foreach(Personnel personnel in tabPersonnel)
            {
                if(personnel.getNomP() == txtPersonnel.Text)
                {
                    p=personnel;
                }
            }
            tabUtilisation[k] = new Utilisation(a, p);
            k++;
            if (k == 3)
            {
                MessageBox.Show("Limite atteinte");
                btnValiderU.Enabled = false;
            }
            txtAccessoire.Clear();
            txtPersonnel.Clear();

        }
    }
}