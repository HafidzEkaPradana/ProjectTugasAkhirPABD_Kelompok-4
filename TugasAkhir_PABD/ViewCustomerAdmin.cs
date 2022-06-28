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
    public partial class ViewCustomerAdmin : Form
    {
        DataTable dt;
        DataRow dr;
        public ViewCustomerAdmin()
        {
            InitializeComponent();
        }

        private void ViewCustomerAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.projectAkhirPABDDataSet.Customer);
            this.CenterToScreen();


            cbJenisklamin.Items.Add("Laki - Laki");
            cbJenisklamin.Items.Add("Perempuan");

            btUpdate.Enabled = false;
            btDelete.Enabled = false;



        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            dt = projectAkhirPABDDataSet.Tables["Customer"];
            dr = dt.NewRow();

            dr[0] = txIDcust.Text;
            dr[1] = txNamaCust.Text;
            dr[2] = txNotelp.Text;
            dr[3] = txEmail.Text;
            dr[4] = cbJenisklamin.Text;

            dt.Rows.Add(dr);
            customerTableAdapter.Update(projectAkhirPABDDataSet);
            txIDcust.Text = System.Convert.ToString(dr[0]);

            this.customerTableAdapter.Fill(this.projectAkhirPABDDataSet.Customer);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin menghapus Customer ?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id;
                id = txIDcust.Text;
                dr = projectAkhirPABDDataSet.Tables["Customer"].Rows.Find(id);
                dr.Delete();
                customerTableAdapter.Update(projectAkhirPABDDataSet);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                btUpdate.Enabled = true;
                btDelete.Enabled = true;
            }
            else
            {
                btUpdate.Enabled = false;
                btDelete.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }
    }
}
