using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormDataBooking : Form
    {

        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
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
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        dtBooking = new DataTable();
                        da.Fill(dtBooking);
                        bookingBindingSource.DataSource = dtBooking;
                        bindingNavigator1.BindingSource = bookingBindingSource;
                        dgvDataBooking.DataSource = bookingBindingSource;

                    }
                }
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