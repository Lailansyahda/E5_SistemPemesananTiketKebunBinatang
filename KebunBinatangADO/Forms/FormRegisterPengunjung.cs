using System;
using System.Data;
using System.Data.SqlClient;
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

        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtUserRegis.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassRegis.Text))
            {
                MessageBox.Show("Semua data wajib diisi!");
                return false;
            }

            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Format email salah! Harus mengandung tanda @ dan titik (.)");
                return false;
            }

            if (txtPassRegis.Text.Length < 6)
            {
                MessageBox.Show("Password minimal harus 6 karakter!");
                return false;
            }

            return true;
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;

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
            txtUserRegis.Clear();
            txtUserRegis.Focus();
        }

        private void FormRegisterPengunjung_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }

        private void btnLoginRegis_Click(object sender, EventArgs e)
        {
            FormLoginPengunjung loginForm = new FormLoginPengunjung();
            loginForm.Show();
            this.Hide();
        }
    }
}