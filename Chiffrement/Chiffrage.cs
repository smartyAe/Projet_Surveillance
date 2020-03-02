using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Chiffrement
{
    [Serializable]
    public class Chiffrage
    {
         
        private static string Ouput;
        public String ProcessorId;
        public bool IsFirstTime =false;

        public string PropOuput
        {
            get { return Ouput; }
        }

        private string folderPath;
            
        public Chiffrage(string chemin)
        { 
                this.folderPath = chemin;
                this.ProcessorId = Cryptage(System.GetSysInfo(), "Coulibal", "CoulibalyAthanase1");
        }
       
        public static string Dechiffrage(string cipherText)
        {
            return Decryptage( cipherText, "Coulibal", "CoulibalyAthanase1");
        }
        private static string Cryptage(string clearText, string strKey, string strIv)
        {
            /// 
            /// Chiffre une chaîne de caractère
            /// 
            /// Texte clair à chiffrer
            /// Clé de chiffrement
            /// Vecteur d'initialisation
            /// Retourne le texte chiffré
        
            // Place le texte à chiffrer dans un tableau d'octets
            byte[] plainText = Encoding.UTF8.GetBytes(clearText);

            // Place la clé de chiffrement dans un tableau d'octets
            byte[] key = Encoding.UTF8.GetBytes(strKey);

            // Place le vecteur d'initialisation dans un tableau d'octets
            byte[] iv = Encoding.UTF8.GetBytes(strIv);


            RijndaelManaged rijndael = new RijndaelManaged();

            // Définit le mode utilisé
            rijndael.BlockSize = 128;
            rijndael.KeySize = 128;
             
            rijndael.Mode = CipherMode.CBC;
            rijndael.Padding = PaddingMode.None;
            

            // Crée le chiffreur AES - Rijndael
            ICryptoTransform aesEncryptor = rijndael.CreateEncryptor(key, iv);

            MemoryStream ms = new MemoryStream();

            // Ecris les données chiffrées dans le MemoryStream
            CryptoStream cs = new CryptoStream(ms, aesEncryptor, CryptoStreamMode.Write);
            cs.Write(plainText, 0, plainText.Length);
             


            // Place les données chiffrées dans un tableau d'octet
            byte[] CipherBytes = ms.ToArray();


            ms.Close();
             

            // Place les données chiffrées dans une chaine encodée en Base64
            return Convert.ToBase64String(CipherBytes);


        }

        /// <summary>
        /// Déchiffre une chaîne de caractère
        /// </summary>
        /// <param name="cipherText">Texte chiffré</param>
        /// <param name="strKey">Clé de déchiffrement</param>
        /// <param name="strIv">Vecteur d'initialisation</param>
        /// <returns></returns>
        private static string Decryptage(string cipherText, string strKey, string strIv)
        {

            // Place le texte à déchiffrer dans un tableau d'octets
            byte[] cipheredData = Convert.FromBase64String(cipherText);

            // Place la clé de déchiffrement dans un tableau d'octets
            byte[] key = Encoding.UTF8.GetBytes(strKey);

            // Place le vecteur d'initialisation dans un tableau d'octets
            byte[] iv = Encoding.UTF8.GetBytes(strIv);

            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.BlockSize = 128;
            rijndael.KeySize = 128;

            rijndael.Mode = CipherMode.CBC;
            rijndael.Padding = PaddingMode.None;

            // Ecris les données déchiffrées dans le MemoryStream
            ICryptoTransform decryptor = rijndael.CreateDecryptor(key, iv);
            MemoryStream ms = new MemoryStream(cipheredData);
            CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);

            // Place les données déchiffrées dans un tableau d'octet
            byte[] plainTextData = new byte[cipheredData.Length];

            int decryptedByteCount = cs.Read(plainTextData, 0, plainTextData.Length);

            ms.Close();
            cs.Close();

            return Encoding.UTF8.GetString(plainTextData, 0, decryptedByteCount);

        }

         
        public void EnregisterInfo()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream output = new FileStream( @"" + folderPath + "\\Dataconfig.dat", FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(output, this);
            output.Close();
        }

        

        public Chiffrage LireInfo()
        {
            BinaryFormatter reader = new BinaryFormatter();
            FileStream input = new FileStream(@"" + folderPath + "\\Dataconfig.dat", FileMode.Open, FileAccess.Read);
            Chiffrage Configurations1 = (Chiffrage)reader.Deserialize(input);
            input.Close();
            return Configurations1;
        }
        
       

    }
}
