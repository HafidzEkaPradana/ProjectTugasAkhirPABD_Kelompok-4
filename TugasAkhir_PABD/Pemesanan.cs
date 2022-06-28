using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_PABD
{
    public partial class Pemesanan : Form
    {
        public Pemesanan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            this.Hide();
            cust.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pemesanan_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cbJam.Items.Add("08.00");
            cbJam.Items.Add("13.00");
            cbJam.Items.Add("16.00");
            cbJam.Items.Add("20.00");

            cbHarga.Items.Add("150000");
            cbHarga.Items.Add("200000");
            cbHarga.Items.Add("250000");
            cbHarga.Items.Add("120000");

        }

        private void btPesan_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Apakah anda ingin lanjut ?","Lanjut ke Data Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("data source=LAPTOP-8MKEQ456; database=ProjectAkhirPABD; Integrated Security=True; User ID=sa;Password=mentepermaib20");
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Pemesanan]([idPesan],[alamatTujuan],[alamatJemput],[jumlahOrang],[harga],[tanggal],[jam],[idMobil],[noTelp]) VALUES ('" + idPesan.Text + "','" + txTujuan.Text + "','" + txAlamat.Text + "','" + txJumlah.Text + "','" + cbHarga.Text + "','" + dtTanggal.Value.ToString() + "','" + cbJam.Text + "','" + idMobil.Text + "','" + txNotelp.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Berhasil melakukan Pemesanan", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                idMobil.Clear();
                idPesan.Clear();
                txAlamat.Clear();
                txJumlah.Clear();
                txTujuan.Clear();
                txNotelp.Clear();

                DataCustomer data = new DataCustomer();
                this.Hide();
                data.Show();
            }
        }
    }
}
