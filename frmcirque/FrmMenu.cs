using Moncirque;
namespace frmcirque
{
    public partial class FrmMenu : Form
    {
        List<Accessoire> listAccessoire;
        List<Personnel> listPersonnel;
        List<Utilisation> listUtilisation;

        public FrmMenu()
        {
            InitializeComponent();
            listAccessoire = new List<Accessoire>();
            listPersonnel = new List<Personnel>();
            listUtilisation = new List<Utilisation>();
        }

        private void btnValiderA_Click(object sender, EventArgs e)
        {
            listAccessoire.Add(new Accessoire(txtNom.Text, txtCouleur.Text, Convert.ToDouble(txtVolume.Text), Convert.ToInt32(txtRatelier.Text), Convert.ToInt32(txtCamion.Text)));
            cmbAccessoire.Items.Clear();
            foreach (Accessoire accessoire in listAccessoire)
            {
                cmbAccessoire.Items.Add(accessoire.getNom());
            }
            txtNom.Clear();
            txtCouleur.Clear();
            txtRatelier.Clear();
            txtCamion.Clear();
            txtVolume.Clear();
        }

        private void btnvaliderP_Click(object sender, EventArgs e)
        {
            listPersonnel.Add(new Personnel(txtNom_Personnel.Text, txtRôle_Personnel.Text));
            cmbPersonnnel.Items.Clear();
            foreach(Personnel personnel in listPersonnel)
            {
                cmbPersonnnel.Items.Add(personnel.getNomP());
            }   
            txtNom_Personnel.Clear();
            txtRôle_Personnel.Clear();

        }

        private void btnValiderU_Click(object sender, EventArgs e)
        {
            Accessoire a = new Accessoire();
            string accessoire=cmbAccessoire.SelectedItem.ToString();
            foreach (Accessoire acces in listAccessoire)
            {
                if (acces.getNom() == accessoire)
                {
                    a = acces;
                }
            }
            Personnel p = new Personnel();
            string personnel=cmbPersonnnel.SelectedItem.ToString();
            foreach (Personnel perso in listPersonnel)
            {
                if (perso.getNomP() == personnel)
                {
                    p = perso;
                }
            }
            listUtilisation.Add(new Utilisation(p, a));

            // Désélectionner sans vider la liste
            cmbAccessoire.SelectedIndex = -1;
            cmbPersonnnel.SelectedIndex = -1;
        }
    }
}