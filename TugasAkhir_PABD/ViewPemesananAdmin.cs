using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_PABD
{
    public partial class ViewPemesananAdmin : Form
    {
        DataTable dt;
        DataRow dr;
        public ViewPemesananAdmin()
        {
            InitializeComponent();
        }

        private void ViewPemesananAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Pemesanan' table. You can move, or remove it, as needed.
            this.pemesananTableAdapter.Fill(this.projectAkhirPABDDataSet.Pemesanan);
            this.CenterToScreen();
            btPesan.Enabled = false;
            idPesan.Enabled = false;
            idMobil.Enabled = false;

            cbJam.Items.Add("08.00");
            cbJam.Items.Add("13.00");
            cbJam.Items.Add("16.00");
            cbJam.Items.Add("20.00");

            cbHarga.Items.Add("150.000");
            cbHarga.Items.Add("200.000");
            cbHarga.Items.Add("250.000");
            cbHarga.Items.Add("120.000");
        }

        private void btPesan_Click(object sender, EventArgs e)
        {
            dt = projectAkhirPABDDataSet.Tables["Pemesanan"];
            dr = dt.NewRow();

            dr[0] = idPesan.Text;
            dr[1] = txAlamat.Text;
            dr[2] = txTujuan.Text;
            dr[3] = txJumlah.Text;
            dr[4] = cbHarga.Text;
            dr[5] = dtTanggal.Text;
            dr[6] = cbJam.Text;
            dr[7] = idMobil.Text;

            dt.Rows.Add(dr);
            pemesananTableAdapter.Update(projectAkhirPABDDataSet);
            idPesan.Text = System.Convert.ToString(dr[0]);
            idMobil.Text = System.Convert.ToString(dr[7]);

            this.pemesananTableAdapter.Fill(this.projectAkhirPABDDataSet.Pemesanan);
            btPesan.Enabled = false;



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btPesan.Enabled = true;
            }
            else
            {
                btPesan.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id;
            id = idPesan.Text;
            dr = projectAkhirPABDDataSet.Tables["Pemesanan"].Rows.Find(id);
            dr.Delete();
            pemesananTableAdapter.Update(projectAkhirPABDDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
