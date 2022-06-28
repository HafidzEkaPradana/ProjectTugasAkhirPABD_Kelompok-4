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
    public partial class InfoAdmin : Form
    {
        public InfoAdmin()
        {
            InitializeComponent();
        }

        private void InfoAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.projectAkhirPABDDataSet.Admin);
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }
    }
}
