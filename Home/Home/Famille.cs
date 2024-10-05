using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Famille
    {
        string nom;
        string description;
        List<Personne> personnes;

        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        internal List<Personne> Personnes { get => personnes; set => personnes = value; }
    }
}
