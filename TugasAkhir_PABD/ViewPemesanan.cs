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
    public partial class ViewPemesanan : Form
    {
        public ViewPemesanan()
        {
            InitializeComponent();
        }

        private void ViewPemesanan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Pemesanan' table. You can move, or remove it, as needed.
            this.pemesananTableAdapter.Fill(this.projectAkhirPABDDataSet.Pemesanan);
            this.CenterToScreen();
        }
    }
}
