using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormKelolaTiket : Form
    {
        string connString = "Data Source=10.69.0.116\\LAILANSYAHDA;Initial Catalog=DBKebunBinatangADO;User ID=sa;Password=Syahda123";
        SqlConnection conn;

        public FormKelolaTiket()
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

        private void FormKelolaTiket_Load(object sender, EventArgs e)
        {
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
                using (SqlCommand cmd = new SqlCommand("sp_GetTiket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tiketBindingSource.DataSource = dt;
                    bindingNavigator1.BindingSource = tiketBindingSource;
                    dgvKelolaTiket.DataSource = tiketBindingSource;
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

            // Pastikan koneksi menggunakan string koneksi yang tepat
            // (di sini menggunakan objek 'conn' yang sudah kamu definisikan sebelumnya)
            conn.Open();

            // Inisialisasi SqlTransaction di luar blok try-catch seperti di modul
            SqlTransaction trans = null;

            try
            {
                // Memulai transaksi database
                trans = conn.BeginTransaction();

                // Eksekusi Stored Procedure sp_InsertTiket dengan menyertakan objek trans
                SqlCommand cmd = new SqlCommand("sp_InsertTiket", conn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NamaTiket", txtTiket.Text);
                cmd.Parameters.AddWithValue("@Harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@KuotaHarian", numKuota.Value);

                cmd.ExecuteNonQuery();

                // Struktur pencatatan log aktivitas sukses ke database sebelum Commit (Sesuai Modul)
                // Catatan: Pastikan tabel 'LogAktivitas' atau sejenisnya ada di databasemu.
                SqlCommand cmdLog = new SqlCommand(
                    "INSERT INTO LogAktivitas (aktivitas, waktu) VALUES (@aktivitas, GETDATE())",
                    conn,
                    trans
                );
                cmdLog.Parameters.AddWithValue("@aktivitas", "INSERT TIKET : " + txtTiket.Text);
                cmdLog.ExecuteNonQuery();

                // Jika semua perintah sukses, lakukan Commit untuk menyimpan perubahan secara permanen
                trans.Commit();

                MessageBox.Show("Tiket berhasil ditambah!");
                LoadData();
            }
            catch (SqlException ex)
            {
                // Jika terjadi kesalahan SQL, batalkan semua transaksi kembali ke titik awal
                if (trans != null) trans.Rollback();

                SimpanLog("ROLLBACK INSERT : " + ex.Message);
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Jika terjadi kesalahan umum, lakukan rollback juga
                if (trans != null) trans.Rollback();

                SimpanLog("GENERAL ERROR : " + ex.Message);
                MessageBox.Show("General Error: " + ex.Message);
            }
            finally
            {
                // Memastikan koneksi database selalu ditutup kembali
                conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) { MessageBox.Show("Pilih data di tabel dulu!"); return; }
            if (!IsValidInput()) return;

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_UpdateTiket", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDTiket", txtID.Text);
                    cmd.Parameters.AddWithValue("@NamaTiket", txtTiket.Text);
                    cmd.Parameters.AddWithValue("@Harga", txtHarga.Text);
                    cmd.Parameters.AddWithValue("@KuotaHarian", numKuota.Value);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tiket berhasil diupdate!");
                LoadData();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;

            if (MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_DeleteTiket", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDTiket", txtID.Text);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    txtID.Clear();
                    txtTiket.Clear();
                    txtHarga.Clear();
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
        }

        private void dgvKelolaTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKelolaTiket.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTiket.Text = row.Cells[1].Value.ToString();
                txtHarga.Text = row.Cells[2].Value.ToString();
                numKuota.Value = Convert.ToInt32(row.Cells[3].Value);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestInjection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    string query = "UPDATE Tiket SET NamaTiket = 'HACKED' WHERE IDTiket = " + txtID.Text;

                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update berhasil");
                    LoadData();
                }
            }
            catch (SqlException ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("SQL Error (Security Trigger): \n" + ex.Message);
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("General Error: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // PERBAIKAN: Gunakan UPDATE agar tidak melanggar relasi (Foreign Key) database
                    string query = @"
                        UPDATE Tiket SET NamaTiket = 'Dewasa', Harga = 70000, KuotaHarian = 300 WHERE IDTiket = 1;
                        UPDATE Tiket SET NamaTiket = 'Pelajar', Harga = 50000, KuotaHarian = 300 WHERE IDTiket = 2;
                        UPDATE Tiket SET NamaTiket = 'Anak', Harga = 30000, KuotaHarian = 200 WHERE IDTiket = 3;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Bersihkan komponen inputan di Form
                txtID.Clear();
                txtTiket.Clear();
                txtHarga.Clear();
                numKuota.Value = 0;

                // Refresh DataGridView agar menampilkan nama yang sudah normal kembali
                LoadData();

                MessageBox.Show("Data master berhasil dipulihkan ke kondisi semula!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("SQL Error (Reset Gagal): " + ex.Message);
            }
            catch (Exception ex)
            {
                SimpanLog(ex.Message);
                MessageBox.Show("Gagal mereset data: " + ex.Message);
            }
        }
    }
}