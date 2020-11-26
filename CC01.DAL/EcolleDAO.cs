using System;
using CC01.BO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
    public class EcolleDAO
    {
        private static List<Ecole> ecoles;
        private const string FILE_NAME = "ecole.json";
        private readonly string dbFolder;
        private FileInfo file;

        public EcolleDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    ecoles = JsonConvert.DeserializeObject<List<Ecole>>(json);
                }
            }
            if (ecoles == null)
            {
                ecoles = new List<Ecole>();
            }
        }
        public void Add(Ecole university)
        {
            var index = ecoles.IndexOf(university);
            if (index >= 0)
                throw new DuplicateNameException("l'ecole existe deja !");
            ecoles.Add(university);
            Save();
        }

        public IEnumerable<Ecole> Find(Func<Ecole, bool> predicate)
        {
            return new List<Ecole>(ecoles.Where(predicate).ToArray());
        }

        public IEnumerable<Ecole> Find()
        {
            return new List<Ecole>(ecoles);
        }

        public void Set(Ecole oldUniversity, Ecole newUniversity)
        {
            var oldIndex = ecoles.IndexOf(oldUniversity);
            var newIndex = ecoles.IndexOf(newUniversity);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The product doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This product reference already exists !");
            ecoles[oldIndex] = newUniversity;
            Save();
        }

        public void Remove(Ecole university)
        {
            ecoles.Remove(university);//basé sur Product.Equals redefini
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                string json = JsonConvert.SerializeObject(ecoles);
                sw.WriteLine(json);
            }
        }
    }
}

