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
        }

        public void FillDtgListeEnseignants()
        {
            CurrentDataTableEnseignant = new Dal_Enseignant().GetAllEnseignantsDataTable(); 
            CurrentDataTableEnseignant = Helper.AdaptDataTableEnseignant(CurrentDataTableEnseignant);

             

        }
        
        public void FillDtgListeProgrames(int IdEns)
        {

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

        private void Programmes_Load(object sender, EventArgs e)
        {

            this.reportViewer1.Visible = true;



            
        }  

    }
}
 
