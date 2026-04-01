using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace MesQualifications
{
    public class Entreprise
    {
        public string Nom { get; set; }
        public Entreprise(string nom)
        {
            this.Nom = nom;
        }
        public void AjouterEmploye(Employe employe)
        {

        }
        public void GetEmployesdequalification(Qualification qualification, Employe employe)
        {
            List<Employe> ListEmploye = new List<Employe>();
            if (employe.Qualification == qualification)
            {
                ListEmploye.Add(employe);
            }

        }
    }
}