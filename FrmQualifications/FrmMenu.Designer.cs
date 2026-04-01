namespace FrmQualifications
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbEmploye = new GroupBox();
            lblQualification = new Label();
            cmbQualification = new ComboBox();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            txtnumSecu = new TextBox();
            btnValiderE = new Button();
            lblPrenom = new Label();
            lblNom = new Label();
            lblnumSecu = new Label();
            grbQualification = new GroupBox();
            lblLibelle = new Label();
            lblCode = new Label();
            txtCode = new TextBox();
            txtLibelle = new TextBox();
            btnValiderQ = new Button();
            grpEntreprise = new GroupBox();
            lblEmploye = new Label();
            cmbEmploye = new ComboBox();
            txtNomEntreprise = new TextBox();
            BtnValiderF = new Button();
            lblnomm = new Label();
            grbEmploye.SuspendLayout();
            grbQualification.SuspendLayout();
            grpEntreprise.SuspendLayout();
            SuspendLayout();
            // 
            // grbEmploye
            // 
            grbEmploye.Controls.Add(lblQualification);
            grbEmploye.Controls.Add(cmbQualification);
            grbEmploye.Controls.Add(txtPrenom);
            grbEmploye.Controls.Add(txtNom);
            grbEmploye.Controls.Add(txtnumSecu);
            grbEmploye.Controls.Add(btnValiderE);
            grbEmploye.Controls.Add(lblPrenom);
            grbEmploye.Controls.Add(lblNom);
            grbEmploye.Controls.Add(lblnumSecu);
            grbEmploye.Location = new Point(420, 73);
            grbEmploye.Name = "grbEmploye";
            grbEmploye.Size = new Size(344, 304);
            grbEmploye.TabIndex = 3;
            grbEmploye.TabStop = false;
            grbEmploye.Text = "Employé";
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Location = new Point(15, 228);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(111, 25);
            lblQualification.TabIndex = 8;
            lblQualification.Text = "Qualification";
            // 
            // cmbQualification
            // 
            cmbQualification.FormattingEnabled = true;
            cmbQualification.Location = new Point(167, 225);
            cmbQualification.Name = "cmbQualification";
            cmbQualification.Size = new Size(145, 33);
            cmbQualification.TabIndex = 2;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(167, 165);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(150, 31);
            txtPrenom.TabIndex = 7;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(167, 99);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(150, 31);
            txtNom.TabIndex = 6;
            // 
            // txtnumSecu
            // 
            txtnumSecu.Location = new Point(167, 39);
            txtnumSecu.Name = "txtnumSecu";
            txtnumSecu.Size = new Size(150, 31);
            txtnumSecu.TabIndex = 5;
            // 
            // btnValiderE
            // 
            btnValiderE.Location = new Point(112, 264);
            btnValiderE.Name = "btnValiderE";
            btnValiderE.Size = new Size(112, 34);
            btnValiderE.TabIndex = 4;
            btnValiderE.Text = "Valider";
            btnValiderE.UseVisualStyleBackColor = true;
            btnValiderE.Click += btnValiderE_Click_1;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(15, 168);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(74, 25);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(15, 99);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 25);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom";
            // 
            // lblnumSecu
            // 
            lblnumSecu.AutoSize = true;
            lblnumSecu.Location = new Point(15, 42);
            lblnumSecu.Name = "lblnumSecu";
            lblnumSecu.Size = new Size(146, 25);
            lblnumSecu.TabIndex = 0;
            lblnumSecu.Text = "N° securité social";
            // 
            // grbQualification
            // 
            grbQualification.Controls.Add(lblLibelle);
            grbQualification.Controls.Add(lblCode);
            grbQualification.Controls.Add(txtCode);
            grbQualification.Controls.Add(txtLibelle);
            grbQualification.Controls.Add(btnValiderQ);
            grbQualification.Location = new Point(36, 73);
            grbQualification.Name = "grbQualification";
            grbQualification.Size = new Size(300, 278);
            grbQualification.TabIndex = 2;
            grbQualification.TabStop = false;
            grbQualification.Text = "Qualification";
            // 
            // lblLibelle
            // 
            lblLibelle.AutoSize = true;
            lblLibelle.Location = new Point(17, 168);
            lblLibelle.Name = "lblLibelle";
            lblLibelle.Size = new Size(61, 25);
            lblLibelle.TabIndex = 4;
            lblLibelle.Text = "Libellé";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(17, 99);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(54, 25);
            lblCode.TabIndex = 3;
            lblCode.Text = "Code";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(94, 93);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(150, 31);
            txtCode.TabIndex = 2;
            // 
            // txtLibelle
            // 
            txtLibelle.Location = new Point(94, 162);
            txtLibelle.Name = "txtLibelle";
            txtLibelle.Size = new Size(150, 31);
            txtLibelle.TabIndex = 1;
            // 
            // btnValiderQ
            // 
            btnValiderQ.Location = new Point(94, 238);
            btnValiderQ.Name = "btnValiderQ";
            btnValiderQ.Size = new Size(112, 34);
            btnValiderQ.TabIndex = 0;
            btnValiderQ.Text = "Valider";
            btnValiderQ.UseVisualStyleBackColor = true;
            btnValiderQ.Click += btnValiderQ_Click_1;
            // 
            // grpEntreprise
            // 
            grpEntreprise.Controls.Add(lblEmploye);
            grpEntreprise.Controls.Add(cmbEmploye);
            grpEntreprise.Controls.Add(txtNomEntreprise);
            grpEntreprise.Controls.Add(BtnValiderF);
            grpEntreprise.Controls.Add(lblnomm);
            grpEntreprise.Location = new Point(842, 67);
            grpEntreprise.Name = "grpEntreprise";
            grpEntreprise.Size = new Size(344, 310);
            grpEntreprise.TabIndex = 9;
            grpEntreprise.TabStop = false;
            grpEntreprise.Text = "Entreprise";
            // 
            // lblEmploye
            // 
            lblEmploye.AutoSize = true;
            lblEmploye.Location = new Point(15, 171);
            lblEmploye.Name = "lblEmploye";
            lblEmploye.Size = new Size(81, 25);
            lblEmploye.TabIndex = 8;
            lblEmploye.Text = "Employe";
            // 
            // cmbEmploye
            // 
            cmbEmploye.FormattingEnabled = true;
            cmbEmploye.Location = new Point(167, 174);
            cmbEmploye.Name = "cmbEmploye";
            cmbEmploye.Size = new Size(145, 33);
            cmbEmploye.TabIndex = 2;
            // 
            // txtNomEntreprise
            // 
            txtNomEntreprise.Location = new Point(167, 99);
            txtNomEntreprise.Name = "txtNomEntreprise";
            txtNomEntreprise.Size = new Size(150, 31);
            txtNomEntreprise.TabIndex = 6;
            // 
            // BtnValiderF
            // 
            BtnValiderF.Location = new Point(112, 264);
            BtnValiderF.Name = "BtnValiderF";
            BtnValiderF.Size = new Size(112, 34);
            BtnValiderF.TabIndex = 4;
            BtnValiderF.Text = "Valider";
            BtnValiderF.UseVisualStyleBackColor = true;
            // 
            // lblnomm
            // 
            lblnomm.AutoSize = true;
            lblnomm.Location = new Point(15, 99);
            lblnomm.Name = "lblnomm";
            lblnomm.Size = new Size(52, 25);
            lblnomm.TabIndex = 1;
            lblnomm.Text = "Nom";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 450);
            Controls.Add(grpEntreprise);
            Controls.Add(grbEmploye);
            Controls.Add(grbQualification);
            Name = "FrmMenu";
            Text = "FrmMenu";
            grbEmploye.ResumeLayout(false);
            grbEmploye.PerformLayout();
            grbQualification.ResumeLayout(false);
            grbQualification.PerformLayout();
            grpEntreprise.ResumeLayout(false);
            grpEntreprise.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbEmploye;
        private Label lblQualification;
        private ComboBox cmbQualification;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private TextBox txtnumSecu;
        private Button btnValiderE;
        private Label lblPrenom;
        private Label lblNom;
        private Label lblnumSecu;
        private GroupBox grbQualification;
        private Label lblLibelle;
        private Label lblCode;
        private TextBox txtCode;
        private TextBox txtLibelle;
        private Button btnValiderQ;
        private GroupBox grpEntreprise;
        private Label lblEmploye;
        private ComboBox cmbEmploye;
        private TextBox txtNomEntreprise;
        private Button BtnValiderF;
        private Label lblnomm;
    }
}