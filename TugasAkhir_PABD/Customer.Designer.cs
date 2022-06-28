
namespace TugasAkhir_PABD
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.button1 = new System.Windows.Forms.Button();
            this.btMobil = new System.Windows.Forms.Button();
            this.btPemesanan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMobil
            // 
            this.btMobil.Location = new System.Drawing.Point(37, 167);
            this.btMobil.Name = "btMobil";
            this.btMobil.Size = new System.Drawing.Size(155, 136);
            this.btMobil.TabIndex = 6;
            this.btMobil.Text = "Data Mobil";
            this.btMobil.UseVisualStyleBackColor = true;
            this.btMobil.Click += new System.EventHandler(this.btMobil_Click);
            // 
            // btPemesanan
            // 
            this.btPemesanan.Location = new System.Drawing.Point(264, 167);
            this.btPemesanan.Name = "btPemesanan";
            this.btPemesanan.Size = new System.Drawing.Size(155, 136);
            this.btPemesanan.TabIndex = 7;
            this.btPemesanan.Text = "Pemesanan";
            this.btPemesanan.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPemesanan);
            this.Controls.Add(this.btMobil);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btMobil;
        private System.Windows.Forms.Button btPemesanan;
    }
}