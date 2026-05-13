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
                conn.Open();
                string query = "SELECT * FROM Booking";


                if (!string.IsNullOrEmpty(filter))
                {
                    query += " WHERE KodeBooking LIKE @filter OR Nama LIKE @filter";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (!string.IsNullOrEmpty(filter))
                {
                    da.SelectCommand.Parameters.AddWithValue("@filter", "%" + filter + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDataBooking.DataSource = dt;
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
    }
}