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
            // TODO: This line of code loads data into the 'dBKebunBinatangADODataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.dBKebunBinatangADODataSet.Booking);
            // TODO: This line of code loads data into the 'dBKebunBinatangADODataSet.Pengunjung' table. You can move, or remove it, as needed.
            this.pengunjungTableAdapter.Fill(this.dBKebunBinatangADODataSet.Pengunjung);
            // TODO: This line of code loads data into the 'dBKebunBinatangADODataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.dBKebunBinatangADODataSet.Admin);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Booking WHERE KodeBooking LIKE @kode";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@kode", "%" + txtCariKode.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                bookingBindingSource.DataSource = dt;
                bindingNavigator1.BindingSource = bookingBindingSource;
                dgvVerifikasi.DataSource = bookingBindingSource;
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