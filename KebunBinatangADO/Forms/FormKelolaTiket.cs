using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormKelolaTiket : Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormKelolaTiket()
        {
            InitializeComponent();
            conn = new SqlConnection(connString);
        }

        private void FormKelolaTiket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBKebunBinatangADODataSet.Tiket' table. You can move, or remove it, as needed.
            this.tiketTableAdapter.Fill(this.dBKebunBinatangADODataSet.Tiket);
            txtID.ReadOnly = true;
            txtID.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = "SELECT * FROM Tiket";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKelolaTiket.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private bool IsValidInput()
        {
            if (!Regex.IsMatch(txtTiket.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Nama tiket hanya boleh berisi huruf dan tidak boleh ada simbol!");
                return false;
            }

            if (!Regex.IsMatch(txtHarga.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Harga harus berupa angka dan tidak boleh berisi simbol atau titik!");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidInput()) return;

            try
            {
                conn.Open();
                string query = "INSERT INTO Tiket (NamaTiket, Harga, KuotaHarian) VALUES (@nama, @harga, @kuota)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", txtTiket.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                    cmd.Parameters.AddWithValue("@kuota", numKuota.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tiket berhasil ditambah!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) { MessageBox.Show("Pilih data di tabel dulu!"); return; }
            if (!IsValidInput()) return;

            try
            {
                conn.Open();
                string query = "UPDATE Tiket SET NamaTiket=@nama, Harga=@harga, KuotaHarian=@kuota WHERE IDTiket=@id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@nama", txtTiket.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                    cmd.Parameters.AddWithValue("@kuota", numKuota.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tiket berhasil diupdate!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            finally { conn.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Tiket WHERE IDTiket=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtID.Text);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    txtID.Clear();
                    txtTiket.Clear();
                    txtHarga.Clear();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
                finally { conn.Close(); }
            }
        }

        private void dgvKelolaTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKelolaTiket.Rows[e.RowIndex];
                txtID.Text = row.Cells["IDTiket"].Value.ToString();
                txtTiket.Text = row.Cells["NamaTiket"].Value.ToString();
                txtHarga.Text = row.Cells["Harga"].Value.ToString();
                numKuota.Value = Convert.ToInt32(row.Cells["KuotaHarian"].Value);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}