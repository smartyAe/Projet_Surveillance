using Microsoft.Reporting.WinForms;
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

            this.reportViewer1.Visible = true;

            List<string> list = new List<string>();

            Surveillances Surv = new Surveillances();
            foreach (DataRow row in MainFacture.dt.Rows)
            {
                Surv.RefProp = row["Reference"].ToString();
                Surv.PrixUProp = float.Parse(row["Pu"].ToString());
                Surv.QuantProp = Int32.Parse(row["Quantite"].ToString());
                list.Add(Surv);
            }
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            ReportParameter[] rparams = new ReportParameter[]
                {
                    new ReportParameter("ReportRef",MainFacture.dt.Rows[0]["Reference1"].ToString()),
                    new ReportParameter("ReportDate",MainFacture.dt.Rows[0]["Date"].ToString())
        };

            ReportDataSource dataset = new ReportDataSource("LgFacture", list); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = list;
            reportViewer1.LocalReport.SetParameters(rparams);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report

        }

    }
}
}
