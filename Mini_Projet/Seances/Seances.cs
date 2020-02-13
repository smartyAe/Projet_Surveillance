using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Seances
    {
        private string Nom;
        private string Code;
        private string HeureDebut;
        private string HeureFin;

        public string PropNom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string PropCode
        {
            get { return Code; }
            set { Code = value; }
        }

        public string PropHeureDebut
        {
            get { return HeureDebut; }
            set { HeureDebut = value; }
        }

        public string PropHeureFin
        {
            get { return HeureFin; }
            set { HeureFin = value; }
        }
    }
}
