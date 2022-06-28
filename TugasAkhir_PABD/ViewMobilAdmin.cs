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
    public partial class ViewMobilAdmin : Form
    {
        DataRow dr;
        DataTable dt;
        string code;
        public ViewMobilAdmin()
        {
            InitializeComponent();
        }

        private void Mobil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet1.Mobil' table. You can move, or remove it, as needed.
            this.mobilTableAdapter1.Fill(this.projectAkhirPABDDataSet1.Mobil);
            this.CenterToScreen();

            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btUpdate.Enabled = false;


            cbNamaMobil.Items.Add("Xenia");
            cbNamaMobil.Items.Add("Avanza");
            cbNamaMobil.Items.Add("Innova");
            cbNamaMobil.Items.Add("Hiace");
            cbNamaMobil.Items.Add("Elf Microbus");
            cbNamaMobil.Items.Add("GrandMax");
            cbNamaMobil.Items.Add("Convero");

            cbJenis.Items.Add("MPV");
            cbJenis.Items.Add("SUV");
            cbJenis.Items.Add("Microbus");

            cbMerk.Items.Add("Toyota");
            cbMerk.Items.Add("Daihatsu");
            cbMerk.Items.Add("Isuzu");
            cbMerk.Items.Add("Wuling");




        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            this.Hide();
            menuAdmin.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string idMobil;
            idMobil = txIDMobil.Text;
            dr = projectAkhirPABDDataSet.Tables["Mobil"].Rows.Find(idMobil);
            dr.Delete();
            mobilTableAdapter.Update(projectAkhirPABDDataSet);

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            dt = projectAkhirPABDDataSet.Tables["Mobil"];
            dr = dt.NewRow();

            dr[0] = txIDMobil.Text;
            dr[1] = cbNamaMobil.Text;
            dr[2] = txPlatNo.Text;
            dr[3] = cbJenis.Text;
            dr[4] = cbMerk.Text;

            dt.Rows.Add(dr);
            mobilTableAdapter.Update(projectAkhirPABDDataSet);
            txIDMobil.Text = System.Convert.ToString(dr[0]);

            this.mobilTableAdapter.Fill(this.projectAkhirPABDDataSet.Mobil);
            btUpdate.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                btAdd.Enabled = true;
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
            }
            else
            {
                btAdd.Enabled = false;
                btDelete.Enabled = false;
                btUpdate.Enabled = false;
            }
        }
    }
}
