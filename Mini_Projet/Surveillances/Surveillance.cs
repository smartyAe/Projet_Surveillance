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
    public partial class Surveillance : MetroFramework.Forms.MetroForm 
    {
        private int childFormNumber = 0;
        private Mailling Mail;
        List<Enseignants> Enseignants = new List<Mini_Projet.Enseignants>();
        Configurations.Configurations Conf;

        public Surveillance()
        {
            InitializeComponent();
            Conf = new Configurations.Configurations();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
  
/*
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        */
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter_Surveillance AjoutSurv = new Ajouter_Surveillance();
            AjoutSurv.ShowDialog();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            Modifier_Surveillance ModifierSurv = new Modifier_Surveillance();
            if (ModifierSurv.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void EmailATousLesEnseigantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Enseignants E in Enseignants)
            {
                Mail = new Mailling();
                Mail.Propadresses = E.PropEmail;
                Mail.Propmessage = "";
                Mail.Propjoin = "";
            }
        }

        private void EmailAuxEnseignantsSelectionnésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Enseignants E in Enseignants)
            {
                Mail = new Mailling();
                Mail.Propadresses = E.PropEmail;
                Mail.Propmessage = "";
                Mail.Propjoin = "";
            }
        }

        private void EmailALenseignantCourantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mail = new Mailling();
            Mail.Propadresses = "";
            Mail.Propmessage = "";
            Mail.Propjoin = "";
        }
    }
}
