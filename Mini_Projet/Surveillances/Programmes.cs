using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.IO;
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
            CurrentDataTableEnseignant = ReportData.AdaptDataTableEnseignant(CurrentDataTableEnseignant);

            foreach (DataRow row in CurrentDataTableEnseignant.Rows)
            {
                //MessageBox.Show(row[0].ToString()+" "+row[1].ToString()+" "+row[2].ToString());
                 FillReportProgrames( Int32.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString()); 
            }

        }

       string ExportDataTableToPdf(DataTable dtblTable, string Name, string Dept)
        {

            string folderPath = "E:\\PDF\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            //File Name
            int fileCount = Directory.GetFiles("E:\\PDF").Length;
            string strFileName = "Programmes" + (fileCount + 1) + ".pdf";
            System.IO.FileStream fs = new FileStream(folderPath + strFileName, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Programme de surveillance".ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.Add(new Chunk(Name, fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Departement
            Paragraph prgDept = new Paragraph();
            BaseFont btnDept = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntDept = new Font(btnAuthor, 8, 2, BaseColor.GRAY);
            prgDept.Alignment = Element.ALIGN_LEFT;
            prgDept.Add(new Chunk(Dept, fntAuthor));
             
            document.Add(prgDept);



            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.NewPage();
            document.Close();
            writer.Close();
            fs.Close();
            return folderPath + strFileName;
        }

        public void FillReportProgrames(int  IdEns, string Name, string Dept)
        {
            //reportViewer1.LocalReport.DataSources.Clear(); //clear report

             CurrentDataTableProgrammes = new Dal_Surveillance().GetSurveillancesByEnseignant(IdEns); 
            CurrentDataTableProgrammes = ReportData.AdaptDataTableProgrammes(CurrentDataTableProgrammes); 
            foreach(DataRow row in CurrentDataTableProgrammes.Rows)
            {
                 MessageBox.Show(row[0].ToString()+" "+row[1].ToString()+" "+row[2].ToString());
            }

            try
                { 
                    //System.Diagnostics.Process.Start(ExportDataTableToPdf(CurrentDataTableProgrammes, Name, Dept));
                    //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
            

        } 

        private void Programmes_Load(object sender, EventArgs e)
        {
            
        }

    }
}
 
