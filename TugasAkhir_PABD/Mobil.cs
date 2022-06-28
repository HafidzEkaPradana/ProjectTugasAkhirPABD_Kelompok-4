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
    public partial class Mobil : Form
    {
        DataRow dr;
        DataTable dt;
        public Mobil()
        {
            InitializeComponent();
        }

        private void Mobil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Mobil' table. You can move, or remove it, as needed.
            this.mobilTableAdapter.Fill(this.projectAkhirPABDDataSet.Mobil);

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
    }
}
