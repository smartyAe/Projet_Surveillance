namespace Mini_Projet.Surveillances
{
    partial class Programmes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.miniProjetDataSet1 = new Mini_Projet.MiniProjetDataSet1();
            this.surveillancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surveillancesTableAdapter = new Mini_Projet.MiniProjetDataSet1TableAdapters.SurveillancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.miniProjetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveillancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mini_Projet.Surveillances.Programmes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(837, 639);
            this.reportViewer1.TabIndex = 0;
            // 
            // miniProjetDataSet1
            // 
            this.miniProjetDataSet1.DataSetName = "MiniProjetDataSet1";
            this.miniProjetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surveillancesBindingSource
            // 
            this.surveillancesBindingSource.DataMember = "Surveillances";
            this.surveillancesBindingSource.DataSource = this.miniProjetDataSet1;
            // 
            // surveillancesTableAdapter
            // 
            this.surveillancesTableAdapter.ClearBeforeFill = true;
            // 
            // Programmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 738);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Programmes";
            this.Text = "Programmes";
            this.Load += new System.EventHandler(this.Programmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniProjetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveillancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MiniProjetDataSet1 miniProjetDataSet1;
        private System.Windows.Forms.BindingSource surveillancesBindingSource;
        private MiniProjetDataSet1TableAdapters.SurveillancesTableAdapter surveillancesTableAdapter;
    }
}