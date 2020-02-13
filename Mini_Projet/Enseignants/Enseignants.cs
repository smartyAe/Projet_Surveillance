using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Enseignants
    {
        private string Nom;
        private string Prenom;
        private string Email;
        private string Statut ="En cours";

        public string PropNom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string PropPrenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }

        public string PropEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string PropStatut
        {
            get { return Statut; }
            set { Statut = value; }
        }
    }
}
