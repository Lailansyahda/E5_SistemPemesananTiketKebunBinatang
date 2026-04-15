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

namespace KebunBinatangADO.Forms
{
    public partial class FormLoginPengunjung: Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormLoginPengunjung()
        {
            InitializeComponent();
        }

        private void btnLoginPengunjung_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Pengunjung WHERE Username = @user AND Password = @pass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", txtUsernamePengunjung.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPasswordPengunjung.Text);

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Login Berhasil! Selamat datang di Kebun Binatang.");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email atau Password salah!");
                    }
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

        private void FormLoginPengunjung_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }
    }
}
