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
        DataTable CurrentDataTableEnseignant = new DataTable();
        DataTable CurrentDataTableProgrammes = new DataTable();
        Enseignants CurrentEns = null;

        public Programmes()
        {
            InitializeComponent();
            FillReportEnseignants();
        }

        public void FillReportEnseignants()
        {
            CurrentDataTableEnseignant = new Dal_Enseignant().GetAllEnseignantsDataTable(); 
            CurrentDataTableEnseignant = Helper.AdaptDataTableEnseignant(CurrentDataTableEnseignant);

            foreach (DataRow row in CurrentDataTableEnseignant.Rows)
            {
                 
                FillReportProgrames(1, row[1].ToString(), row[2].ToString());

                 
            }

        }
        
        public void FillReportProgrames(int IdEns, string Name, string Dept)
        {
            //reportViewer1.LocalReport.DataSources.Clear(); //clear report

            CurrentDataTableProgrammes = new Dal_Surveillance().GetSurveillancesByEnseignant(IdEns); 
            CurrentDataTableProgrammes = Helper.AdaptDataTableProgrammes(CurrentDataTableProgrammes);
            List<SurveillanceRecordForProgrammes> list = new List<SurveillanceRecordForProgrammes>();
            SurveillanceRecordForProgrammes Surv = new SurveillanceRecordForProgrammes();
            foreach (DataRow row in CurrentDataTableProgrammes.Rows)
            {
                Surv.Seance = row["CodeSeances"].ToString();
                Surv.Salle =  row["NomSalle"].ToString();
                Surv.Date = row["DateSurveillance"].ToString(); 
                Surv.HeureD = row["HeureDebut"].ToString();
                Surv.HeureF = row["HeureFin"].ToString();
                list.Add(Surv);
            }
            
            ReportParameter[] rparams = new ReportParameter[]
                {
                   new ReportParameter("NomEnseignant", Name ),
                    new ReportParameter("Departement",Dept  ),
                     new ReportParameter("DateNow",DateTime.Now.ToString())
            };

            ReportDataSource dataset = new ReportDataSource("Programmes", list); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = list;
            reportViewer1.LocalReport.SetParameters(rparams);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report

        } 

        private void Programmes_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'miniProjetDataSet1.Surveillances'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.surveillancesTableAdapter.Fill(this.miniProjetDataSet1.Surveillances);

            this.reportViewer1.Visible = true;
              
            this.reportViewer1.RefreshReport();
        }

    }
}
 
