
namespace TugasAkhir_PABD
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.PemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjectAkhirPABDDataSet = new TugasAkhir_PABD.ProjectAkhirPABDDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PemesananTableAdapter = new TugasAkhir_PABD.ProjectAkhirPABDDataSetTableAdapters.PemesananTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PemesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAkhirPABDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PemesananBindingSource
            // 
            this.PemesananBindingSource.DataMember = "Pemesanan";
            this.PemesananBindingSource.DataSource = this.ProjectAkhirPABDDataSet;
            // 
            // ProjectAkhirPABDDataSet
            // 
            this.ProjectAkhirPABDDataSet.DataSetName = "ProjectAkhirPABDDataSet";
            this.ProjectAkhirPABDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PemesananBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TugasAkhir_PABD.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(79, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1072, 525);
            this.reportViewer1.TabIndex = 0;
            // 
            // PemesananTableAdapter
            // 
            this.PemesananTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back To Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1217, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PemesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAkhirPABDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PemesananBindingSource;
        private ProjectAkhirPABDDataSet ProjectAkhirPABDDataSet;
        private ProjectAkhirPABDDataSetTableAdapters.PemesananTableAdapter PemesananTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}