using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_PABD
{
    public partial class DataCustomer : Form
    {
        public DataCustomer()
        {
            InitializeComponent();
        }

        private void DataCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btPesanSelesai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin memesan travel ?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("data source=LAPTOP-8MKEQ456; database=ProjectAkhirPABD; Integrated Security=True; User ID=sa;Password=mentepermaib20");
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Customer]([id],[Nama],[noTelp],[email],[jeniskelamin]) VALUES ('" + idCust.Text + "','" + txNama.Text + "','" + txNotelp.Text + "','" + txEmail.Text + "','" + cbJenis.Text + "')", conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                
                idCust.Clear();
                txNama.Clear();
                txEmail.Clear();
                txNotelp.Clear();

                InfoRek info = new InfoRek();
                this.Hide();
                info.Show();
            }
            else
            {
                Customer cust = new Customer();
                this.Hide();
                cust.Show();
            }
        }
    }
}
