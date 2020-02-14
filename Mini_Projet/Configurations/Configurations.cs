using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet.Configurations
{
    [Serializable]
    class Configurations
    {
        private string DirPath;
        private string Email;

        public string PropDirPath
        {
            get { return DirPath; }
            set { DirPath = value; }
        }

        public string PropEmail
        {
            get { return Email; }
            set { Email = value; }
        }
        
        public void EnregisterInfo( )
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream output = new FileStream(@"C:\Users\LMIJ\Documents\Visual Studio 2015\Projects\Mini_Projet\Mini_Projet\Userconfig.dat", FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(output, this);
            output.Close();
        }

        public Configurations LireInfo()
        {
            BinaryFormatter reader = new BinaryFormatter();
            FileStream input = new FileStream(@"C:\Users\LMIJ\Documents\Visual Studio 2015\Projects\Mini_Projet\Mini_Projet\Userconfig.dat", FileMode.Open, FileAccess.Read);
            Configurations Configurations1 = (Configurations)reader.Deserialize(input);
            input.Close();
            return Configurations1;
        }

    }
}
