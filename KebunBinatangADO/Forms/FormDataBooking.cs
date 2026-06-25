using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormDataBooking : Form
    {

        string connString = "Data Source=10.69.0.116\\LAILANSYAHDA;Initial Catalog=DBKebunBinatangADO;User ID=sa;Password=Syahda123";
        SqlConnection conn;
        private BindingSource bindingSource = new BindingSource();
        private DataTable dtBooking = new DataTable();

        public FormDataBooking()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void FormDataBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBKebunBinatangADODataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.dBKebunBinatangADODataSet.Booking);
            dgvDataBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDataBooking.MultiSelect = false;
                dgvDataBooking.ReadOnly = true;
                dgvDataBooking.AllowUserToAddRows = false;
                dgvDataBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                LoadData();
        }

        private void LoadData(string filter = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT * FROM vw_DataBooking";
                    if (!string.IsNullOrEmpty(filter))
                    {
                        query += " WHERE KodeBooking LIKE @filter OR Nama LIKE @filter";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(filter))
                        {
                            cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            dtBooking = new DataTable();
                            da.Fill(dtBooking);

                            bookingBindingSource.DataSource = dtBooking;
                            bindingNavigator1.BindingSource = bookingBindingSource;
                            dgvDataBooking.DataSource = bookingBindingSource;
                        }
                    }
                }

                // --- 🔴 BAGIAN UNTUK MENGHILANGKAN/MENYEMBUNYIKAN KOLOM ID YANG GA PENTING ---
                // Jika kolom-kolom ini terbawa dari tabel asal, kita sembunyikan dari mata user
                if (dgvDataBooking.Columns.Contains("IDPengunjung")) dgvDataBooking.Columns["IDPengunjung"].Visible = false;
                if (dgvDataBooking.Columns.Contains("IDAdmin")) dgvDataBooking.Columns["IDAdmin"].Visible = false;
                if (dgvDataBooking.Columns.Contains("IDTiket")) dgvDataBooking.Columns["IDTiket"].Visible = false;

                // --- 🟢 BAGIAN MERAPIKAN HEADER KOLOM YANG INGIN DITAMPILKAN ---
                if (dgvDataBooking.Columns.Contains("IDBooking")) dgvDataBooking.Columns["IDBooking"].HeaderText = "ID Booking";
                if (dgvDataBooking.Columns.Contains("KodeBooking")) dgvDataBooking.Columns["KodeBooking"].HeaderText = "Kode Booking";
                if (dgvDataBooking.Columns.Contains("Nama")) dgvDataBooking.Columns["Nama"].HeaderText = "Nama Pengunjung";
                if (dgvDataBooking.Columns.Contains("NoHp")) dgvDataBooking.Columns["NoHp"].HeaderText = "No HP";
                if (dgvDataBooking.Columns.Contains("Email")) dgvDataBooking.Columns["Email"].HeaderText = "Email";
                if (dgvDataBooking.Columns.Contains("TanggalKunjungan")) dgvDataBooking.Columns["TanggalKunjungan"].HeaderText = "Tanggal Kunjungan";
                if (dgvDataBooking.Columns.Contains("DetailTiket")) dgvDataBooking.Columns["DetailTiket"].HeaderText = "Detail Tiket";
                if (dgvDataBooking.Columns.Contains("TotalHarga")) dgvDataBooking.Columns["TotalHarga"].HeaderText = "Total Harga";
                if (dgvDataBooking.Columns.Contains("StatusPembayaran")) dgvDataBooking.Columns["StatusPembayaran"].HeaderText = "Status Pembayaran";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {

            LoadData(textBox1.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = @"
                        IF OBJECT_ID('dbo.Booking_Backup') IS NOT NULL
                        BEGIN
                            EXEC sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';

                            DELETE FROM dbo.Booking;

                            SET IDENTITY_INSERT dbo.Booking ON;

                            INSERT INTO dbo.Booking (IDBooking, KodeBooking, IDPengunjung, IDAdmin, IDTiket, Nama, NoHp, Email, TanggalKunjungan, TiketDewasa, TiketPelajar, TiketAnak, DetailTiket, TotalHarga, StatusPembayaran)
                            SELECT IDBooking, KodeBooking, IDPengunjung, IDAdmin, IDTiket, Nama, NoHp, Email, TanggalKunjungan, TiketDewasa, TiketPelajar, TiketAnak, DetailTiket, TotalHarga, StatusPembayaran 
                            FROM dbo.Booking_Backup;

                            SET IDENTITY_INSERT dbo.Booking OFF;

                            EXEC sp_MSforeachtable 'ALTER TABLE ? CHECK CONSTRAINT ALL';
                        END";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Data berhasil direset");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Reset gagal: " + ex.Message);
            }
        }

        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "UPDATE Booking SET Nama = 'HACKED' WHERE KodeBooking = '" + textBox1.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result + " baris terupdate");
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}