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

        public FormLaporan()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void btnTampilLaporan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
               
                string query = "SELECT * FROM Booking WHERE CONVERT(DATE, TanggalKunjungan) = @tgl";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tgl", dtpLaporan.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLaporan.DataSource = dt;

                    laporanBindingSource.DataSource = dt;
                    bindingNavigator1.BindingSource = laporanBindingSource;
                    dgvLaporan.DataSource = laporanBindingSource;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
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
            // TODO: This line of code loads data into the 'dBKebunBinatangADODataSet.Laporan' table. You can move, or remove it, as needed.
            // this.laporanTableAdapter.Fill(this.dBKebunBinatangADODataSet.Laporan);

        }
    }
}