using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chiffrement;
namespace Mini_Projet
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Chiffrage codage = new Chiffrage(Application.StartupPath);
             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(codage.LireInfo().IsFirstTime==true )
            {
                codage.EnregisterInfo();
                Application.Run(new ActivateKey( ));
            }
            else
                Application.Run(new Home());
        }
    }
}
