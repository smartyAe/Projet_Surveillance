using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Projet.Surveillances
{
    public partial class Programmes : MetroFramework.Forms.MetroForm
    {
        public Programmes()
        {
            InitializeComponent();
        }

        private void Programmes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
