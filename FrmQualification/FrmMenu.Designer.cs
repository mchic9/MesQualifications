namespace FrmQualificationn
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
            grbQualification = new GroupBox();
            lblLibelle = new Label();
            lblCode = new Label();
            txtCode = new TextBox();
            txtLibelle = new TextBox();
            btnValiderQ = new Button();
            grbEmploye = new GroupBox();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            txtnumSecu = new TextBox();
            btnValiderE = new Button();
            lblQualification = new Label();
            lblNom = new Label();
            lblnumSecu = new Label();
            grbQualification.SuspendLayout();
            grbEmploye.SuspendLayout();
            SuspendLayout();
            // 
            // grbQualification
            // 
            grbQualification.Controls.Add(lblLibelle);
            grbQualification.Controls.Add(lblCode);
            grbQualification.Controls.Add(txtCode);
            grbQualification.Controls.Add(txtLibelle);
            grbQualification.Controls.Add(btnValiderQ);
            grbQualification.Location = new Point(40, 27);
            grbQualification.Name = "grbQualification";
            grbQualification.Size = new Size(300, 278);
            grbQualification.TabIndex = 0;
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
            btnValiderQ.Click += btnValiderQ_Click;
            // 
            // grbEmploye
            // 
            grbEmploye.Controls.Add(txtPrenom);
            grbEmploye.Controls.Add(txtNom);
            grbEmploye.Controls.Add(txtnumSecu);
            grbEmploye.Controls.Add(btnValiderE);
            grbEmploye.Controls.Add(lblQualification);
            grbEmploye.Controls.Add(lblNom);
            grbEmploye.Controls.Add(lblnumSecu);
            grbEmploye.Location = new Point(424, 27);
            grbEmploye.Name = "grbEmploye";
            grbEmploye.Size = new Size(344, 304);
            grbEmploye.TabIndex = 1;
            grbEmploye.TabStop = false;
            grbEmploye.Text = "Employé";
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
            btnValiderE.Click += btnValiderE_Click;
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Location = new Point(15, 168);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(74, 25);
            lblQualification.TabIndex = 2;
            lblQualification.Text = "Prenom";
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
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 579);
            Controls.Add(grbEmploye);
            Controls.Add(grbQualification);
            Name = "FrmMenu";
            Text = "Form1";
            grbQualification.ResumeLayout(false);
            grbQualification.PerformLayout();
            grbEmploye.ResumeLayout(false);
            grbEmploye.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbQualification;
        private Button btnValiderQ;
        private Label lblLibelle;
        private Label lblCode;
        private TextBox txtCode;
        private TextBox txtLibelle;
        private GroupBox grbEmploye;
        private Button btnValiderE;
        private Label txtQualification;
        private Label lblQualification;
        private Label lblNom;
        private Label lblnumSecu;

        private TextBox txtPrenom;
        private TextBox txtNom;
        private TextBox txtnumSecu;
    }
}
