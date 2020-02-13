using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Dal_Enseignant
    {
        private static SqlCommand MySqlCommand;
        private static SqlCommand MySqlCommand2;

        private static DataTable dt = new DataTable();

        static Enseignants ConvertRowToEnseignants(DataRow row)
        {

            Enseignants CurrentEnseignants = new Enseignants();

            string Nom = (row["Nom"].ToString().Length != 0) ? row["Nom"].ToString() : "pas de Nom";
            CurrentEnseignants.PropNom = Nom;

            
            return CurrentEnseignants;

        }


        public List<Enseignants> GetAllEnseignantsList()
        {
            List<Enseignants> AllEnseignants = new List<Enseignants>();

            MySqlCommand = new SqlCommand("select * from [Enseignants]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                AllEnseignants.Add(ConvertRowToEnseignants(row));
            }

            return AllEnseignants;
        }

        public DataTable GetAllEnseignantsDataTable()
        {
            MySqlCommand = new SqlCommand("select * from [Enseignants]");

            dt = DBConnection.FunctionToRead(MySqlCommand);

            return dt;
        }

        
        public Enseignants GetEnseignantByNom(string Email)
        {
            Enseignants EnseignantsSearched = new Enseignants();

            MySqlCommand = new SqlCommand("select * from [Enseignants] where Email = @Email");

            MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value =Email;

            dt = DBConnection.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                EnseignantsSearched = ConvertRowToEnseignants(row);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return EnseignantsSearched;
        }

        public void AddEnseignant(Enseignants newEnseignant )
        {

            MySqlCommand = new SqlCommand("insert into [Enseignants]( Nom,  )" +
                                         "values ( @Nom, )");

            MySqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar).Value = newEnseignant.PropNom;
            

            DBConnection.FunctionToWrite(MySqlCommand);

        }
         
        public void DeleteEnseignant(Enseignants Individu)
        { 
            MySqlCommand = new SqlCommand("delete from [Enseignants] where Email= @Email ");
            MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Individu.PropNom;
            DBConnection.FunctionToWrite(MySqlCommand);


        }

        public bool CheckUniqueMail(string Email)
        {
            dt = GetAllEnseignantsDataTable();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Email"].ToString() ==Email)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
