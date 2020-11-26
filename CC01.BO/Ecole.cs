using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {

        public string Nom_ecole;

        public string Date_de_creation;

        public string Abreviation;

        public string Lieu;

        public long Contact;

        public byte[] Logo;

        public string BP;

        public int cmp = 0;

        public Ecole(string v1, string text1, string text2, string text3, string text4, long v2, byte[] vs)
        {
        }
        public Ecole()
        {
                
        }

        public Ecole
            (
            string nom_ecole,
            string date_de_creation,
            string matricule,
            string abreviation,
            string lieu, long contact,
            byte[] logo,
            string bP
            )
        {
            Nom_ecole = nom_ecole;
            Date_de_creation = date_de_creation;
            Abreviation = abreviation;
            Lieu = lieu;
            Contact = contact;
            Logo = logo;
            BP = bP;
            cmp++;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom_ecole == ecole.Nom_ecole;
        }

        public override int GetHashCode()
        {
            return -186051840 + EqualityComparer<string>.Default.GetHashCode(Nom_ecole);
        }
    }
}
