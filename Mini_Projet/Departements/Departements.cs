using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Departements
    {
        private string Nom;
        private string Code;


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

    }
}
