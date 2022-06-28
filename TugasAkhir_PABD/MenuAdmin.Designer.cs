
namespace TugasAkhir_PABD
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.button1 = new System.Windows.Forms.Button();
            this.btMobil = new System.Windows.Forms.Button();
            this.btCustomer = new System.Windows.Forms.Button();
            this.btPesan = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back To Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMobil
            // 
            this.btMobil.Location = new System.Drawing.Point(37, 53);
            this.btMobil.Name = "btMobil";
            this.btMobil.Size = new System.Drawing.Size(155, 136);
            this.btMobil.TabIndex = 5;
            this.btMobil.Text = "Data Mobil";
            this.btMobil.UseVisualStyleBackColor = true;
            this.btMobil.Click += new System.EventHandler(this.btMobil_Click);
            // 
            // btCustomer
            // 
            this.btCustomer.Location = new System.Drawing.Point(223, 53);
            this.btCustomer.Name = "btCustomer";
            this.btCustomer.Size = new System.Drawing.Size(155, 136);
            this.btCustomer.TabIndex = 6;
            this.btCustomer.Text = "Data Customer";
            this.btCustomer.UseVisualStyleBackColor = true;
            this.btCustomer.Click += new System.EventHandler(this.btCustomer_Click);
            // 
            // btPesan
            // 
            this.btPesan.Location = new System.Drawing.Point(223, 218);
            this.btPesan.Name = "btPesan";
            this.btPesan.Size = new System.Drawing.Size(155, 136);
            this.btPesan.TabIndex = 7;
            this.btPesan.Text = "Data Pemesanan";
            this.btPesan.UseVisualStyleBackColor = true;
            this.btPesan.Click += new System.EventHandler(this.btPesan_Click);
            // 
            // btInfo
            // 
            this.btInfo.Location = new System.Drawing.Point(37, 218);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(155, 136);
            this.btInfo.TabIndex = 8;
            this.btInfo.Text = "Info Admin";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btReport
            // 
            this.btReport.Location = new System.Drawing.Point(413, 379);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(347, 40);
            this.btReport.TabIndex = 10;
            this.btReport.Text = "Lihat Report";
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btPesan);
            this.Controls.Add(this.btCustomer);
            this.Controls.Add(this.btMobil);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btMobil;
        private System.Windows.Forms.Button btCustomer;
        private System.Windows.Forms.Button btPesan;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btReport;
    }
}