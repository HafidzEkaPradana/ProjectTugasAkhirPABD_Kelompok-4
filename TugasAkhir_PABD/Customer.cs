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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void btMobil_Click(object sender, EventArgs e)
        {
            ViewMobil viewMobil = new ViewMobil();
            this.Hide();
            viewMobil.Show();
        }

        private void btPemesanan_Click(object sender, EventArgs e)
        {
            Pemesanan pesan = new Pemesanan();
            this.Hide();
            pesan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewPemesanan viewPemesanan = new ViewPemesanan();
            this.Hide();
            viewPemesanan.Show();
        }
    }
}
