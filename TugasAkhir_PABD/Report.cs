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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProjectAkhirPABDDataSet.Pemesanan' table. You can move, or remove it, as needed.
            this.PemesananTableAdapter.Fill(this.ProjectAkhirPABDDataSet.Pemesanan);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin admin = new MenuAdmin();
            this.Hide();
            admin.Show();
        }
    }
}
