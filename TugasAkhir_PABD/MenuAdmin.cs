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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            this.Hide();
            report.Show();
        }

        private void btPesan_Click(object sender, EventArgs e)
        {
            ViewPemesananAdmin view = new ViewPemesananAdmin();
            this.Hide();
            view.Show();
        }

        private void btMobil_Click(object sender, EventArgs e)
        {
            ViewMobilAdmin view = new ViewMobilAdmin();
            this.Hide();
            view.Show();
        }
    }
}
