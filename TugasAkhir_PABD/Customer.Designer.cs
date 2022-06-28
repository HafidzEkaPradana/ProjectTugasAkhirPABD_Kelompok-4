
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMobil
            // 
            this.btMobil.Location = new System.Drawing.Point(37, 135);
            this.btMobil.Name = "btMobil";
            this.btMobil.Size = new System.Drawing.Size(155, 136);
            this.btMobil.TabIndex = 6;
            this.btMobil.Text = "Data Mobil";
            this.btMobil.UseVisualStyleBackColor = true;
            this.btMobil.Click += new System.EventHandler(this.btMobil_Click);
            // 
            // btPemesanan
            // 
            this.btPemesanan.Location = new System.Drawing.Point(264, 135);
            this.btPemesanan.Name = "btPemesanan";
            this.btPemesanan.Size = new System.Drawing.Size(155, 136);
            this.btPemesanan.TabIndex = 7;
            this.btPemesanan.Text = "Pemesanan";
            this.btPemesanan.UseVisualStyleBackColor = true;
            this.btPemesanan.Click += new System.EventHandler(this.btPemesanan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 136);
            this.button2.TabIndex = 8;
            this.button2.Text = "Riwayat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(715, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 136);
            this.button3.TabIndex = 9;
            this.button3.Text = "Data Customer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 379);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btPemesanan);
            this.Controls.Add(this.btMobil);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btMobil;
        private System.Windows.Forms.Button btPemesanan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}