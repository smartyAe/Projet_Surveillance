using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Dal_Enseignant
    {

        private static OleDbCommand MyOleDbCommand;

        private static DataTable dt = new DataTable();

        static Enseignants ConvertRowToEnseignants(DataRow row)
        {

            Enseignants CurrentEnseignants = new Enseignants();

            int Id = int.Parse(row["Id"].ToString());
            CurrentEnseignants.PropId = Id;

            string Nom = (row["Nom"].ToString().Length != 0) ? row["Nom"].ToString() : "pas de Nom";
            CurrentEnseignants.PropNom = Nom;

            string Prenom = (row["Prenom"].ToString().Length != 0) ? row["Prenom"].ToString() : "pas de Prenom ";
            CurrentEnseignants.PropPrenom = Prenom;

            string Email = (row["Email"].ToString().Length != 0) ? row["Email"].ToString() : "pas d'Email";
            CurrentEnseignants.PropEmail = Email;

            string Statut = (row["Statut"].ToString().Length != 0) ? row["Statut"].ToString() : "pas de statut";
            CurrentEnseignants.PropStatut = Statut;

            string CodeDep = row["CodeDep"].ToString();

            if (CodeDep.Length != 0)
            {

                Departements CurrentDepartements = new Departements();

                string NomDep = (row["NomDep"].ToString().Length != 0) ? row["NomDep"].ToString() : "pas de Nom de Departement";
                CurrentDepartements.PropNom = NomDep;
                CurrentDepartements.PropCode = CodeDep;

                CurrentEnseignants.PropDepartements = new Departements(CurrentDepartements);
            }
            else
            {
                CodeDep = "pas de Departement";
                CurrentEnseignants.PropDepartements = null;
            }

            return CurrentEnseignants;

        }

        public List<Enseignants> GetAllEnseignantsList()
        {
            List<Enseignants> AllEnseignants = new List<Enseignants>();

            MyOleDbCommand = new OleDbCommand("select E.Id, E.Nom, E.Prenom, E.Email, E.Statut, E.CodeDep, D.Nom as NomDep from [Enseignants] as E, Departements as D where D.Code = E.CodeDep");

            dt = DBConnection.FunctionToRead(MyOleDbCommand);

            foreach (DataRow row in dt.Rows)
            {
                AllEnseignants.Add(ConvertRowToEnseignants(row));
            }

            return AllEnseignants;
        }

        public DataTable GetAllEnseignantsDataTable()
        {

            MyOleDbCommand = new OleDbCommand("select E.Id, E.Nom, E.Prenom, E.Email, E.Statut, E.CodeDep, D.Nom as NomDep from [Enseignants] as E, Departements as D where D.Code = E.CodeDep");

            dt = DBConnection.FunctionToRead(MyOleDbCommand);

            return dt;

        }

        public Enseignants GetEnseignantByEmail(string Email)
        {
            Enseignants EnseignantsSearched = new Enseignants();

            MyOleDbCommand = new OleDbCommand("select E.id, E.Nom, E.Prenom, E.Email, E.Statut, E.CodeDep, D.Nom as NomDep from [Enseignants] as E, Departements as D where Email = @Email and D.Code = E.CodeDep");

            MyOleDbCommand.Parameters.Add("@Email", OleDbType.VarChar).Value = Email;

            dt = DBConnection.FunctionToRead(MyOleDbCommand);

            foreach (DataRow row in dt.Rows)
            {
                EnseignantsSearched = ConvertRowToEnseignants(row);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return EnseignantsSearched;
        }

        public void AddEnseignant(Enseignants newEnseignant)
        {

            MyOleDbCommand = new OleDbCommand("insert into [Enseignants]( Nom,Prenom,Email,Statut, CodeDep )" +
                                         "values ( @Nom,@Prenom,@Email,@Statut, @CodeDep )");

            MyOleDbCommand.Parameters.Add("@Nom", OleDbType.VarChar).Value = newEnseignant.PropNom;
            MyOleDbCommand.Parameters.Add("@Prenom", OleDbType.VarChar).Value = newEnseignant.PropPrenom;
            MyOleDbCommand.Parameters.Add("@Email", OleDbType.VarChar).Value = newEnseignant.PropEmail;
            MyOleDbCommand.Parameters.Add("@Statut", OleDbType.VarChar).Value = newEnseignant.PropStatut;
            MyOleDbCommand.Parameters.Add("@CodeDep", OleDbType.VarChar).Value = newEnseignant.PropDepartements.PropCode;


            DBConnection.FunctionToWrite(MyOleDbCommand);

        }

        public void DeleteEnseignant(Enseignants Individu)
        {
            MyOleDbCommand = new OleDbCommand("delete from [Enseignants] where Email= @Email ");
            MyOleDbCommand.Parameters.Add("@Email", OleDbType.VarChar).Value = Individu.PropEmail;
            DBConnection.FunctionToWrite(MyOleDbCommand);


        }

        public bool CheckUniqueMail(string Email)
        {
            dt = GetAllEnseignantsDataTable();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Email"].ToString() == Email)
                {
                    return false;
                }
            }

            return true;
        }

    }
}