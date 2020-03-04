﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class DBConnection
    {
        private static string StrConnexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source="+Home.chemin+@"\MiniProjet.accdb ";
        private static OleDbConnection Connection = new OleDbConnection(StrConnexion);


        //Ouverture de la connection
        private static bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        //Fermeture de la connection
        private static bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        //Ecriture
        public static int FunctionToWrite(OleDbCommand CommandRequest)
        {

            int NumberOfRows = 0;

            try
            {

                //ouverture de la connection
                if (OpenConnection() == true)
                {
                    //creation de la commande et affectation a query et la connection du constructor
                    CommandRequest.Connection = Connection;

                    //execution de la commande 
                    NumberOfRows = CommandRequest.ExecuteNonQuery();


                }

            }
            catch (Exception e)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("------- Error in the Request ");
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine(e.Message);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("");
            }
            finally
            {
                //fermeture de la connextion
                CloseConnection();
            }
            return NumberOfRows;

        }
        public static int FunctionToWriteScalar(OleDbCommand CommandRequest)
        {

            int NumberOfRows = 0;

            try
            {

                //ouverture de la connection
                if (OpenConnection() == true)
                {
                    //creation de la commande et affectation a query et la connection du constructor
                    CommandRequest.Connection = Connection;

                    //execution de la commande 
                    NumberOfRows = (Int32)CommandRequest.ExecuteScalar();


                }

            }
            catch (Exception e)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("------- Error in the Request ");
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine(e.Message);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("");
            }
            finally
            {
                //fermeture de la connextion
                CloseConnection();
            }
            return NumberOfRows;

        }

        //lecture
        public static DataTable FunctionToRead(OleDbCommand CommanReqRead)
        {

            DataTable dt = new DataTable();

            CommanReqRead.Connection = Connection;

            try
            {
                if (OpenConnection() == true)
                {

                    //execution de la commande 
                    OleDbDataReader dre = CommanReqRead.ExecuteReader();

                    dt.Load(dre);

                    //fermeture de la connextion
                    CloseConnection();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("------- Error in the Request ");
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine(e.Message);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("");
            }
            finally
            {
                //fermeture de la connextion
                CloseConnection();
            }
            return dt;

        }

    }
}