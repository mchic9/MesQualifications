using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MesQualifications;

using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace FrmQualifications
{

    public partial class FrmMenu : Form
    {
        List<Qualification> listQualification;
        List<Employe> listEmploye;
        public FrmMenu()
        {
            InitializeComponent();
            listQualification = new List<Qualification>();
            listEmploye = new List<Employe>();
        }


        private void btnValiderQ_Click_1(object sender, EventArgs e)
        {
            listQualification.Add(new Qualification(Convert.ToInt16(txtCode.Text), txtLibelle.Text));
            cmbQualification.Items.Clear();
            foreach (Qualification item in listQualification)
            {
                cmbQualification.Items.Add(item.Code);
            }
            txtCode.Clear();
            txtLibelle.Clear();
        }

        private void btnValiderE_Click_1(object sender, EventArgs e)
        {
            Qualification q = new Qualification();
            int qualificationCode = Convert.ToInt16(cmbQualification.SelectedItem.ToString());
            foreach (Qualification item in listQualification)
            {
                if (item.Code == qualificationCode)
                {
                    q = item;
                }

                listEmploye.Add(new Employe(txtnumSecu.Text, txtNom.Text, txtPrenom.Text));
            }
        }
        private void BtnValiderF_Click(object sender, EventArgs e)
        {
            Entreprise entreprise = new Entreprise(txtNomEntreprise.Text);
            foreach (Employe item in listEmploye)
            {
                entreprise.AjouterEmploye(item);
            }

        }
    }
}
