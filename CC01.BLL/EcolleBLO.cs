using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EcolleBLO
    {
        EcolleDAO ecoleRepo;
        public EcolleBLO(string dbFolder)
        {
            ecoleRepo = new EcolleDAO(dbFolder);
        }
        public void CreateEcole(Ecole product)
        {
            ecoleRepo.Add(product);
        }
        public void DeleteEcole(Ecole product)
        {
            ecoleRepo.Remove(product);
        }
        public IEnumerable<Ecole> GetAlEcoles()
        {
            return ecoleRepo.Find();
        }
        public IEnumerable<Ecole> GetByReference(string reference)
        {
            return ecoleRepo.Find(x => x.Nom_ecole == reference);
        }

        public IEnumerable<Ecole> GetBy(Func<Ecole, bool> predicate)
        {
            return ecoleRepo.Find(predicate);
        }

        public void EditEcole(Ecole oldecole, Ecole newecole)
        {
            ecoleRepo.Set(oldecole, newecole);
        }
    }
}
