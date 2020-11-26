using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant
    {

        public string Nom_Ecole { get; set; }
        public string Pays { get; set; }
        public string Nom_Ettudiant { get; set; }
        public string Prenom_etudiant { get; set; }
        public string Date_Naissance { get; set; }
        public string Lieu { get; set; }
        public string Identifiant { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Logo { get; set; }


        public Etudiant()
        {

        }

        public Etudiant(
                            string nom_Ecole, 
                            string pays, 
                            string nom_Ettudiant,
                            string prenom_etudiant, 
                            string date_Naissance, 
                            string lieu, 
                            string identifiant, 
                            string contact, 
                            string email,
                            byte[] picture,
                            byte[] logo
                        )
        {
            Nom_Ecole = nom_Ecole;
            Pays = pays;
            Nom_Ettudiant = nom_Ettudiant;
            Prenom_etudiant = prenom_etudiant;
            Date_Naissance = date_Naissance;
            Lieu = lieu;
            Identifiant = identifiant;
            Contact = contact;
            Email = email;
            Picture = picture;
            Logo = logo;
        }

        public Etudiant(string text1, string text2, string text3, string text4, string dateTime, string v, string text5, string text6, string text7, byte[] vs)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant && Identifiant == etudiant.Identifiant;
        }

        public override int GetHashCode()
        {
            return 574969646 + EqualityComparer<string>.Default.GetHashCode(Identifiant);
        }
    }
}
