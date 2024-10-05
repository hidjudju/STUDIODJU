using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Personne
    {
        string prenom;
        string nom;
        string age;
        string genre;
        List<Hobby> hobbies;

        public string Prenom { get => prenom; set => prenom = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Age { get => age; set => age = value; }
        public string Genre { get => genre; set => genre = value; }
        internal List<Hobby> Hobbies { get => hobbies; set => hobbies = value; }
    }
}
