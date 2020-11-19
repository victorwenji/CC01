using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant
    {
        public string Nom_Ecole { get; set; }
        public string Pays { get; set; }
        public string Nom_Ettudiant { get; set; }
        public string Prenom_etudiant { get; set; }
        public DateTime Date_Naissance { get; set; }
        public string Lieu { get; set; }
        public string Identifiant { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(
                            string nom_Ecole, 
                            string pays, 
                            string nom_Ettudiant,
                            string prenom_etudiant, 
                            DateTime date_Naissance, 
                            string lieu, 
                            string identifiant, 
                            string contact, 
                            string email
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
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant && Identifiant == etudiant.Identifiant;
        }
    }
}
