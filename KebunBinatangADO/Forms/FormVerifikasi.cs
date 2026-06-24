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

        private void SimpanLog(string pesan)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = @"INSERT INTO LogError VALUES (GETDATE(), @pesan)";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@pesan", pesan);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            this.bookingTableAdapter.Fill(this.dBKebunBinatangADODataSet.Booking);
            this.pengunjungTableAdapter.Fill(this.dBKebunBinatangADODataSet.Pengunjung);
            this.adminTableAdapter.Fill(this.dBKebunBinatangADODataSet.Admin);
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = "SELECT * FROM Booking WHERE KodeBooking LIKE @kode";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@kode", "%" + txtCariKode.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                bookingBindingSource.DataSource = dt;
                bindingNavigator1.BindingSource = bookingBindingSource;
                dgvVerifikasi.DataSource = bookingBindingSource;
            }
            catch (SqlException ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("General Error: " + ex.Message);
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
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = "UPDATE Booking SET StatusPembayaran = 'Lunas' WHERE KodeBooking = @kode";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode", txtCariKode.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Pembayaran berhasil diverifikasi!");
            }
            catch (SqlException ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("General Error: " + ex.Message);
            }
            finally
            {
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