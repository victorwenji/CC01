using CC01.DAL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EtudiantBLO
    {
        EtudiantDAO ccrepo;
        public EtudiantBLO(string dbFolder)
        {
            ccrepo = new EtudiantDAO(dbFolder);
        }
        public void CreatEtudiant(Etudiant etudiant)
        {
            ccrepo.Add(etudiant);
        }

        public void DeleteEtudiant(Etudiant etudiant)
        {
            ccrepo.Remove(etudiant);
        }

        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return ccrepo.Find();
        }
        public IEnumerable<Etudiant> GetByIdentifiant(string identifiant)
        {
            return ccrepo.Find(x => x.Identifiant == identifiant);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return ccrepo.Find(predicate);
        }

        public void EditEtudiant(Etudiant oldetudiant, Etudiant newetudiant)
        {
            ccrepo.Set(oldetudiant, newetudiant);
        }

        public static Etudiant Getetudiant()
        {
            throw new NotImplementedException();
        }
    }
}
