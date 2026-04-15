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

namespace KebunBinatangADO
{
    public partial class FormLoginAdmin: Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Admin WHERE Username = @user AND Password = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Login Berhasil!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoginAdmin_Click(object sender, EventArgs e)
        {

        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }
    }
}
