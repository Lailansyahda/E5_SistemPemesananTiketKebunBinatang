using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormLaporan : Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        SqlDataAdapter da;
        DataTable dtbooking = new DataTable();

        ClassLaporanBooking classLaporan = new ClassLaporanBooking();

        public DateTime tglKunjungan { get; set; }


        public FormLaporan(DateTime tglKunjungan)
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
            this.tglKunjungan = tglKunjungan; 
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

        private void btnTampilLaporan_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT * FROM vw_Laporan WHERE CONVERT(DATE, Tanggal) = @tgl";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tgl", dtpLaporan.Value.Date);

                    da = new SqlDataAdapter(cmd);

                    dtbooking.Clear();

                    da.Fill(dtbooking);

                    laporanBindingSource.DataSource = dtbooking;
                    bindingNavigator1.BindingSource = laporanBindingSource;
                    dgvLaporan.DataSource = laporanBindingSource;

                    if (dtbooking.Rows.Count > 0)
                    {
                        btnCetak.Enabled = true;
                    }
                    else
                    {
                        btnCetak.Enabled = false;
                        MessageBox.Show("Data tidak ditemukan");
                    }
                }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            dtpLaporan.Format = DateTimePickerFormat.Custom;
            dtpLaporan.CustomFormat = "yyyy-MM-dd";
            dtpLaporan.ShowUpDown = false;
            dtpLaporan.MinDate = new DateTime(2000, 1, 1);
            dtpLaporan.MaxDate = DateTime.Now;

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT TOP 100 * FROM vw_Laporan ORDER BY Tanggal DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;

                    da = new SqlDataAdapter(cmd);

                    dtbooking.Clear();
                    da.Fill(dtbooking);

                    laporanBindingSource.DataSource = dtbooking;
                    bindingNavigator1.BindingSource = laporanBindingSource;
                    dgvLaporan.DataSource = laporanBindingSource;
                }
            }
            catch (SqlException ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Gagal load data umum: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {

        }
    }
}