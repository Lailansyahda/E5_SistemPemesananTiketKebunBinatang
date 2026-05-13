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

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        if (!string.IsNullOrEmpty(filter))
                        {
                            da.SelectCommand.Parameters.AddWithValue("@filter", "%" + filter + "%");
                        }

                        dtBooking = new DataTable();
                        da.Fill(dtBooking);
                        bindingSource.DataSource = dtBooking;
                        dgvDataBooking.DataSource = bindingSource;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
            finally
            {
                conn.Close();
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
                            DELETE FROM dbo.Booking;
                            INSERT INTO dbo.Booking
                            SELECT * FROM dbo.Booking_Backup;
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
                    string query = "SELECT * FROM vw_DataBooking WHERE KodeBooking = '" + textBox1.Text + "'";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDataBooking.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}