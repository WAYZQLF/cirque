namespace frmcirque
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxAccessoire = new GroupBox();
            btnValiderA = new Button();
            txtCamion = new TextBox();
            Camion = new Label();
            txtRatelier = new TextBox();
            Ratelier = new Label();
            txtVolume = new TextBox();
            Volume = new Label();
            txtCouleur = new TextBox();
            Couleur = new Label();
            txtNom = new TextBox();
            Nom = new Label();
            GroupBoxPersonnel = new GroupBox();
            btnvaliderP = new Button();
            txtRôle_Personnel = new TextBox();
            Rôle_Personnel = new Label();
            txtNom_Personnel = new TextBox();
            Nom_Personnel = new Label();
            groupBoxUtilisation = new GroupBox();
            cmbAccessoire = new ComboBox();
            cmbPersonnnel = new ComboBox();
            btnValiderU = new Button();
            Personnel = new Label();
            Accessoire = new Label();
            groupBoxAccessoire.SuspendLayout();
            GroupBoxPersonnel.SuspendLayout();
            groupBoxUtilisation.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAccessoire
            // 
            groupBoxAccessoire.Controls.Add(btnValiderA);
            groupBoxAccessoire.Controls.Add(txtCamion);
            groupBoxAccessoire.Controls.Add(Camion);
            groupBoxAccessoire.Controls.Add(txtRatelier);
            groupBoxAccessoire.Controls.Add(Ratelier);
            groupBoxAccessoire.Controls.Add(txtVolume);
            groupBoxAccessoire.Controls.Add(Volume);
            groupBoxAccessoire.Controls.Add(txtCouleur);
            groupBoxAccessoire.Controls.Add(Couleur);
            groupBoxAccessoire.Controls.Add(txtNom);
            groupBoxAccessoire.Controls.Add(Nom);
            groupBoxAccessoire.Location = new Point(57, 34);
            groupBoxAccessoire.Name = "groupBoxAccessoire";
            groupBoxAccessoire.Size = new Size(448, 255);
            groupBoxAccessoire.TabIndex = 0;
            groupBoxAccessoire.TabStop = false;
            groupBoxAccessoire.Text = "Accessoire";
            // 
            // btnValiderA
            // 
            btnValiderA.Location = new Point(94, 200);
            btnValiderA.Name = "btnValiderA";
            btnValiderA.Size = new Size(75, 23);
            btnValiderA.TabIndex = 10;
            btnValiderA.Text = "Valider";
            btnValiderA.UseVisualStyleBackColor = true;
            btnValiderA.Click += btnValiderA_Click;
            // 
            // txtCamion
            // 
            txtCamion.Location = new Point(114, 149);
            txtCamion.Name = "txtCamion";
            txtCamion.Size = new Size(100, 23);
            txtCamion.TabIndex = 9;
            // 
            // Camion
            // 
            Camion.AutoSize = true;
            Camion.Location = new Point(40, 152);
            Camion.Name = "Camion";
            Camion.Size = new Size(49, 15);
            Camion.TabIndex = 8;
            Camion.Text = "Camion";
            // 
            // txtRatelier
            // 
            txtRatelier.Location = new Point(114, 120);
            txtRatelier.Name = "txtRatelier";
            txtRatelier.Size = new Size(100, 23);
            txtRatelier.TabIndex = 7;
            // 
            // Ratelier
            // 
            Ratelier.AutoSize = true;
            Ratelier.Location = new Point(40, 123);
            Ratelier.Name = "Ratelier";
            Ratelier.Size = new Size(46, 15);
            Ratelier.TabIndex = 6;
            Ratelier.Text = "Ratelier";
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(114, 91);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(100, 23);
            txtVolume.TabIndex = 5;
            // 
            // Volume
            // 
            Volume.AutoSize = true;
            Volume.Location = new Point(40, 94);
            Volume.Name = "Volume";
            Volume.Size = new Size(47, 15);
            Volume.TabIndex = 4;
            Volume.Text = "Volume";
            // 
            // txtCouleur
            // 
            txtCouleur.Location = new Point(114, 62);
            txtCouleur.Name = "txtCouleur";
            txtCouleur.Size = new Size(100, 23);
            txtCouleur.TabIndex = 3;
            // 
            // Couleur
            // 
            Couleur.AutoSize = true;
            Couleur.Location = new Point(40, 65);
            Couleur.Name = "Couleur";
            Couleur.Size = new Size(49, 15);
            Couleur.TabIndex = 2;
            Couleur.Text = "Couleur";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(114, 33);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(100, 23);
            txtNom.TabIndex = 1;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Location = new Point(40, 36);
            Nom.Name = "Nom";
            Nom.Size = new Size(34, 15);
            Nom.TabIndex = 0;
            Nom.Text = "Nom";
            // 
            // GroupBoxPersonnel
            // 
            GroupBoxPersonnel.Controls.Add(btnvaliderP);
            GroupBoxPersonnel.Controls.Add(txtRôle_Personnel);
            GroupBoxPersonnel.Controls.Add(Rôle_Personnel);
            GroupBoxPersonnel.Controls.Add(txtNom_Personnel);
            GroupBoxPersonnel.Controls.Add(Nom_Personnel);
            GroupBoxPersonnel.Location = new Point(511, 36);
            GroupBoxPersonnel.Name = "GroupBoxPersonnel";
            GroupBoxPersonnel.Size = new Size(239, 141);
            GroupBoxPersonnel.TabIndex = 1;
            GroupBoxPersonnel.TabStop = false;
            GroupBoxPersonnel.Text = "Personnel";
            // 
            // btnvaliderP
            // 
            btnvaliderP.Location = new Point(105, 107);
            btnvaliderP.Name = "btnvaliderP";
            btnvaliderP.Size = new Size(75, 23);
            btnvaliderP.TabIndex = 4;
            btnvaliderP.Text = "valider";
            btnvaliderP.UseVisualStyleBackColor = true;
            btnvaliderP.Click += btnvaliderP_Click;
            // 
            // txtRôle_Personnel
            // 
            txtRôle_Personnel.Location = new Point(103, 63);
            txtRôle_Personnel.Name = "txtRôle_Personnel";
            txtRôle_Personnel.Size = new Size(100, 23);
            txtRôle_Personnel.TabIndex = 3;
            // 
            // Rôle_Personnel
            // 
            Rôle_Personnel.AutoSize = true;
            Rôle_Personnel.Location = new Point(10, 63);
            Rôle_Personnel.Name = "Rôle_Personnel";
            Rôle_Personnel.Size = new Size(87, 15);
            Rôle_Personnel.TabIndex = 2;
            Rôle_Personnel.Text = "Rôle_Personnel";
            // 
            // txtNom_Personnel
            // 
            txtNom_Personnel.Location = new Point(105, 22);
            txtNom_Personnel.Name = "txtNom_Personnel";
            txtNom_Personnel.Size = new Size(100, 23);
            txtNom_Personnel.TabIndex = 1;
            // 
            // Nom_Personnel
            // 
            Nom_Personnel.AutoSize = true;
            Nom_Personnel.Location = new Point(6, 25);
            Nom_Personnel.Name = "Nom_Personnel";
            Nom_Personnel.Size = new Size(91, 15);
            Nom_Personnel.TabIndex = 0;
            Nom_Personnel.Text = "Nom_Personnel";
            // 
            // groupBoxUtilisation
            // 
            groupBoxUtilisation.Controls.Add(cmbAccessoire);
            groupBoxUtilisation.Controls.Add(cmbPersonnnel);
            groupBoxUtilisation.Controls.Add(btnValiderU);
            groupBoxUtilisation.Controls.Add(Personnel);
            groupBoxUtilisation.Controls.Add(Accessoire);
            groupBoxUtilisation.Location = new Point(525, 213);
            groupBoxUtilisation.Name = "groupBoxUtilisation";
            groupBoxUtilisation.Size = new Size(234, 155);
            groupBoxUtilisation.TabIndex = 2;
            groupBoxUtilisation.TabStop = false;
            groupBoxUtilisation.Text = "Utilisation";
            // 
            // cmbAccessoire
            // 
            cmbAccessoire.FormattingEnabled = true;
            cmbAccessoire.Location = new Point(91, 30);
            cmbAccessoire.Name = "cmbAccessoire";
            cmbAccessoire.Size = new Size(121, 23);
            cmbAccessoire.TabIndex = 6;
            // 
            // cmbPersonnnel
            // 
            cmbPersonnnel.FormattingEnabled = true;
            cmbPersonnnel.Location = new Point(91, 69);
            cmbPersonnnel.Name = "cmbPersonnnel";
            cmbPersonnnel.Size = new Size(121, 23);
            cmbPersonnnel.TabIndex = 5;
            // 
            // btnValiderU
            // 
            btnValiderU.Location = new Point(86, 120);
            btnValiderU.Name = "btnValiderU";
            btnValiderU.Size = new Size(75, 23);
            btnValiderU.TabIndex = 4;
            btnValiderU.Text = "Valider";
            btnValiderU.UseVisualStyleBackColor = true;
            btnValiderU.Click += btnValiderU_Click;
            // 
            // Personnel
            // 
            Personnel.AutoSize = true;
            Personnel.Location = new Point(11, 72);
            Personnel.Name = "Personnel";
            Personnel.Size = new Size(59, 15);
            Personnel.TabIndex = 1;
            Personnel.Text = "Personnel";
            // 
            // Accessoire
            // 
            Accessoire.AutoSize = true;
            Accessoire.Location = new Point(11, 30);
            Accessoire.Name = "Accessoire";
            Accessoire.Size = new Size(63, 15);
            Accessoire.TabIndex = 0;
            Accessoire.Text = "Accessoire";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxUtilisation);
            Controls.Add(GroupBoxPersonnel);
            Controls.Add(groupBoxAccessoire);
            Name = "FrmMenu";
            Text = "Form1";
            groupBoxAccessoire.ResumeLayout(false);
            groupBoxAccessoire.PerformLayout();
            GroupBoxPersonnel.ResumeLayout(false);
            GroupBoxPersonnel.PerformLayout();
            groupBoxUtilisation.ResumeLayout(false);
            groupBoxUtilisation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAccessoire;
        private TextBox txtNom;
        private Label Nom;
        private TextBox txtCamion;
        private Label Camion;
        private TextBox txtRatelier;
        private Label Ratelier;
        private TextBox txtVolume;
        private Label Volume;
        private TextBox txtCouleur;
        private Label Couleur;
        private Button btnValiderA;
        private GroupBox GroupBoxPersonnel;
        private TextBox txtNom_Personnel;
        private Label Nom_Personnel;
        private Button btnvaliderP;
        private TextBox txtRôle_Personnel;
        private Label Rôle_Personnel;
        private GroupBox groupBoxUtilisation;
        private Button btnValiderU;
        private Label Personnel;
        private Label Accessoire;
        private ComboBox cmbAccessoire;
        private ComboBox cmbPersonnnel;
    }
}