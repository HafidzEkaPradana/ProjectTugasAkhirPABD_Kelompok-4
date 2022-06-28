
namespace TugasAkhir_PABD
{
    partial class ViewMobil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mobilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.projectAkhirPABDDataSet1 = new TugasAkhir_PABD.ProjectAkhirPABDDataSet();
            this.mobilBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mobilTableAdapter2 = new TugasAkhir_PABD.ProjectAkhirPABDDataSetTableAdapters.MobilTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAkhirPABDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.mobilBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(41, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(975, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // mobilBindingSource
            // 
            this.mobilBindingSource.DataMember = "Mobil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectAkhirPABDDataSet1
            // 
            this.projectAkhirPABDDataSet1.DataSetName = "ProjectAkhirPABDDataSet";
            this.projectAkhirPABDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mobilBindingSource1
            // 
            this.mobilBindingSource1.DataMember = "Mobil";
            this.mobilBindingSource1.DataSource = this.projectAkhirPABDDataSet1;
            // 
            // mobilTableAdapter2
            // 
            this.mobilTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idMobil";
            this.dataGridViewTextBoxColumn1.HeaderText = "idMobil";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaMobil";
            this.dataGridViewTextBoxColumn2.HeaderText = "NamaMobil";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlatNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "PlatNo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "jenisMobil";
            this.dataGridViewTextBoxColumn4.HeaderText = "jenisMobil";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Merk";
            this.dataGridViewTextBoxColumn5.HeaderText = "Merk";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // ViewMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewMobil";
            this.Text = "ViewMobil";
            this.Load += new System.EventHandler(this.ViewMobil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectAkhirPABDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectAkhirPABDDataSetTableAdapters.MobilTableAdapter mobilTableAdapter;
        private System.Windows.Forms.Button button1;
        private ProjectAkhirPABDDataSet projectAkhirPABDDataSet;
        private System.Windows.Forms.BindingSource mobilBindingSource;
        private ProjectAkhirPABDDataSetTableAdapters.MobilTableAdapter mobilTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisMobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn merkDataGridViewTextBoxColumn;
        private ProjectAkhirPABDDataSet projectAkhirPABDDataSet1;
        private System.Windows.Forms.BindingSource mobilBindingSource1;
        private ProjectAkhirPABDDataSetTableAdapters.MobilTableAdapter mobilTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}