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
    public partial class LoginAdmin : Form
    {
        SqlConnection conn = new SqlConnection("data source=LAPTOP-8MKEQ456; database=ProjectAkhirPABD; Integrated Security=True; User ID=sa;Password=mentepermaib20");
        DataTable dt;
        DataRow dr;
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectAkhirPABDDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.projectAkhirPABDDataSet.Admin);
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {/*
                String emailMasuk = "eka@gmail.com";
                String passMasuk = "pradana";*/

                conn.Open();
                String query = "SELECT * FROM Login WHERE username = '" + txEmail.Text + "' AND password = '" + txPassword.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);


                dataAdapter.Fill(dt);


                if (dt.Rows.Count == 4 && dt.Rows.Count == 3)
                {
                    MenuAdmin mAdmin = new MenuAdmin();
                    this.Hide();
                    mAdmin.Show();
                }
                else if(txEmail.Text == "" || txPassword.Text == "")
                {
                    MessageBox.Show("Email dan Password belum diisi !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Email dan Password yang anda masukkan salah !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txEmail.Clear();
                    txPassword.Clear();

                    txEmail.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Email dan Password tidak ditemukan !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
