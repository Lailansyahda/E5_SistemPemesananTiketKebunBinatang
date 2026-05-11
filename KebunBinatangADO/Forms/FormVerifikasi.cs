using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormVerifikasi : Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormVerifikasi()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Booking WHERE KodeBooking LIKE @kode";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@kode", "%" + txtCariKode.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVerifikasi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnVerifikasi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCariKode.Text))
            {
                MessageBox.Show("Pilih data yang akan diverifikasi!");
                return;
            }

            try
            {
                conn.Open();
                string query = "UPDATE Booking SET StatusPembayaran = 'Lunas' WHERE KodeBooking = @kode";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode", txtCariKode.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Pembayaran berhasil diverifikasi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

           
            btnLoadData_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}