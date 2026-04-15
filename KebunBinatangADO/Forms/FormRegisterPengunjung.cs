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
    public partial class FormRegisterPengunjung : Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormRegisterPengunjung()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserRegis.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nama dan Email wajib diisi!");
                return;
            }

            try
            {
                conn.Open();
                string query = "INSERT INTO Pengunjung (Email, Username, Password) VALUES (@email, @user, @pass)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassRegis.Text);
                    cmd.Parameters.AddWithValue("@user", txtUserRegis.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registrasi Berhasil!");

                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal registrasi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassRegis.Clear();
            txtUserRegis.Focus();
        }

        private void FormRegisterPengunjung_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }
    }
}
