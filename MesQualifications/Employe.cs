using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MesQualifications
{
    public class Employe
    {
        private string numSecu;
        private string nom;
        private string prenom;
        public Qualification qualification;
        public Employe(string noSecu, string n, string p)
        {
            this.numSecu = noSecu;
            this.nom = n;
            this.prenom = p;
        }
        public string NumSecu
        {
            get { return numSecu; }
            set { numSecu = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public Qualification Qualification
        {
            get { return qualification; }
            set { qualification = value; }
        }
        public override string ToString()
        {
            return $"NumSecu: {numSecu}, Nom: {nom}, Prenom: {prenom}, Qualification: {qualification}";
        }
    }
}
