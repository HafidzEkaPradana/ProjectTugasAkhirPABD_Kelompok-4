﻿using System;
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
    public partial class DataMobil : Form
    {
        public DataMobil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void DataMobil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Mobil' table. You can move, or remove it, as needed.
            this.mobilTableAdapter.Fill(this.projectAkhirPABDDataSet.Mobil);
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Mobil' table. You can move, or remove it, as needed.
            this.mobilTableAdapter.Fill(this.projectAkhirPABDDataSet.Mobil);
            this.CenterToScreen();
        }
    }
}
