namespace MesQualifications
{
    public class Qualification
    {
        private int code;
        private string libelle;

        public Qualification(int codeQ, string libelle)
        {
            this.code = codeQ;
            this.libelle = libelle;
        }

        public Qualification ()
            {

            }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public override string ToString()
        {
            return $"Code: {code}, Libelle: {libelle}";
        }

    }
}
