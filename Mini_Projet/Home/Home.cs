using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Projet
{
    public partial class Home : MetroFramework.Forms.MetroForm
    {
         

        public Home()
        {
            InitializeComponent();
        }
 

        private void Home_Load(object sender, EventArgs e)
        {

        }

        

        private void Btn_Surveillance_Click(object sender, EventArgs e)
        {
            Surveillance SurveillanceView = new Surveillance(); 
            SurveillanceView.ShowDialog();
        }

        private void Btn_Config_Click(object sender, EventArgs e)
        {
            Configuration Config = new Configuration();
            Config.ShowDialog();
        }

        private void Btn_Enseignant_Click(object sender, EventArgs e)
        {
            Enseignant EnseignantView = new Enseignant();
            EnseignantView.ShowDialog();
        }

        private void Btn_Seance_Click(object sender, EventArgs e)
        {
            Seance SeanceView = new Seance();
            SeanceView.ShowDialog();
        }

        private void Btn_Salle_Click(object sender, EventArgs e)
        {
            Salle SalleView = new Salle();
            SalleView.ShowDialog();
        }

        private void Btn_Departement_Click(object sender, EventArgs e)
        {
            Departement DepartementView = new Departement();
            DepartementView.ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
