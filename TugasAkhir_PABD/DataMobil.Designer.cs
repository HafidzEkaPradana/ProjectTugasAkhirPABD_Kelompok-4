﻿
namespace TugasAkhir_PABD
{
    partial class DataMobil
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectAkhirPABDDataSet = new TugasAkhir_PABD.ProjectAkhirPABDDataSet();
            this.mobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobilTableAdapter = new TugasAkhir_PABD.ProjectAkhirPABDDataSetTableAdapters.MobilTableAdapter();
            this.idMobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisMobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAkhirPABDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMobilDataGridViewTextBoxColumn,
            this.namaMobilDataGridViewTextBoxColumn,
            this.platNoDataGridViewTextBoxColumn,
            this.jenisMobilDataGridViewTextBoxColumn,
            this.merkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mobilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(717, 224);
            this.dataGridView1.TabIndex = 2;
            // 
            // projectAkhirPABDDataSet
            // 
            this.projectAkhirPABDDataSet.DataSetName = "ProjectAkhirPABDDataSet";
            this.projectAkhirPABDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mobilBindingSource
            // 
            this.mobilBindingSource.DataMember = "Mobil";
            this.mobilBindingSource.DataSource = this.projectAkhirPABDDataSet;
            // 
            // mobilTableAdapter
            // 
            this.mobilTableAdapter.ClearBeforeFill = true;
            // 
            // idMobilDataGridViewTextBoxColumn
            // 
            this.idMobilDataGridViewTextBoxColumn.DataPropertyName = "idMobil";
            this.idMobilDataGridViewTextBoxColumn.HeaderText = "idMobil";
            this.idMobilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idMobilDataGridViewTextBoxColumn.Name = "idMobilDataGridViewTextBoxColumn";
            this.idMobilDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaMobilDataGridViewTextBoxColumn
            // 
            this.namaMobilDataGridViewTextBoxColumn.DataPropertyName = "NamaMobil";
            this.namaMobilDataGridViewTextBoxColumn.HeaderText = "NamaMobil";
            this.namaMobilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaMobilDataGridViewTextBoxColumn.Name = "namaMobilDataGridViewTextBoxColumn";
            this.namaMobilDataGridViewTextBoxColumn.Width = 150;
            // 
            // platNoDataGridViewTextBoxColumn
            // 
            this.platNoDataGridViewTextBoxColumn.DataPropertyName = "PlatNo";
            this.platNoDataGridViewTextBoxColumn.HeaderText = "PlatNo";
            this.platNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.platNoDataGridViewTextBoxColumn.Name = "platNoDataGridViewTextBoxColumn";
            this.platNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // jenisMobilDataGridViewTextBoxColumn
            // 
            this.jenisMobilDataGridViewTextBoxColumn.DataPropertyName = "jenisMobil";
            this.jenisMobilDataGridViewTextBoxColumn.HeaderText = "jenisMobil";
            this.jenisMobilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jenisMobilDataGridViewTextBoxColumn.Name = "jenisMobilDataGridViewTextBoxColumn";
            this.jenisMobilDataGridViewTextBoxColumn.Width = 150;
            // 
            // merkDataGridViewTextBoxColumn
            // 
            this.merkDataGridViewTextBoxColumn.DataPropertyName = "Merk";
            this.merkDataGridViewTextBoxColumn.HeaderText = "Merk";
            this.merkDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.merkDataGridViewTextBoxColumn.Name = "merkDataGridViewTextBoxColumn";
            this.merkDataGridViewTextBoxColumn.Width = 150;
            // 
            // DataMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "DataMobil";
            this.Text = "DataMobil";
            this.Load += new System.EventHandler(this.DataMobil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAkhirPABDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectAkhirPABDDataSet projectAkhirPABDDataSet;
        private System.Windows.Forms.BindingSource mobilBindingSource;
        private ProjectAkhirPABDDataSetTableAdapters.MobilTableAdapter mobilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
    }
}