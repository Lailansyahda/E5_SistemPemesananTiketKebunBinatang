using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormBookingPengunjung : Form
    {
        
        string connString = "Data Source=10.69.0.116\\LAILANSYAHDA;Initial Catalog=DBKebunBinatangADO;User ID=sa;Password=Syahda123";
        SqlConnection conn;

        DataTable dtbooking = new DataTable();
        DataTable dtringkasan = new DataTable();

        ClassBookingPengunjung ClassBookingPengunjung = new ClassBookingPengunjung();

        string Status { get; set; }
        DateTime Tanggal { get; set; }

        public FormBookingPengunjung(string Status, DateTime Tanggal)
        {
            InitializeComponent();
            conn = new SqlConnection(connString);

           
            numTiketDewasa.ValueChanged += (s, e) => UpdateSisaKuota();
            numTiketPelajar.ValueChanged += (s, e) => UpdateSisaKuota();
            numTiketAnak.ValueChanged += (s, e) => UpdateSisaKuota();
            dtpBooking.ValueChanged += (s, e) => UpdateSisaKuota();

            txtNoHP.KeyPress += txtNoHP_KeyPress;
        }

        private void txtNoHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang diketik bukan angka, bukan tombol Backspace, dan bukan tombol Delete
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Jika bukan angka, batalkan aksi pengetikan (karakter tidak akan muncul di TextBox)
                e.Handled = true;

                // Opsional: memberi efek suara beep peringatan standar Windows
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void FormBookingPengunjung_Load(object sender, EventArgs e)
        {
           
            dtpBooking.MinDate = DateTime.Today;
            dtpBooking.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);

            txtSisaKuota.ReadOnly = true;
            UpdateSisaKuota();
        }

        private int GetSisaKuotaDatabase(DateTime tanggal)
        {
            int kuotaTotalMaks = 0;
            int totalDipesan = 0;

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                
                string queryMaster = "SELECT SUM(KuotaHarian) FROM Tiket";
                using (SqlCommand cmd = new SqlCommand(queryMaster, conn))
                {
                    object res = cmd.ExecuteScalar();
                    if (res != DBNull.Value && res != null) kuotaTotalMaks = Convert.ToInt32(res);
                }

               
                string queryBooking = "SELECT SUM(TiketDewasa + TiketPelajar + TiketAnak) FROM Booking WHERE TanggalKunjungan = @tgl";
                using (SqlCommand cmd = new SqlCommand(queryBooking, conn))
                {
                    cmd.Parameters.AddWithValue("@tgl", tanggal.Date);
                    object res = cmd.ExecuteScalar();
                    if (res != DBNull.Value && res != null) totalDipesan = Convert.ToInt32(res);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Sinkronisasi Data: " + ex.Message);
            }
            finally { conn.Close(); }

            return kuotaTotalMaks - totalDipesan;
        }

        private void UpdateSisaKuota()
        {
            int sisaDiDB = GetSisaKuotaDatabase(dtpBooking.Value);

           
            if (btnPesan.Enabled)
            {
                int sedangInput = (int)(numTiketDewasa.Value + numTiketPelajar.Value + numTiketAnak.Value);
                int sisaAkhir = sisaDiDB - sedangInput;
                txtSisaKuota.Text = sisaAkhir.ToString();
            }
            else
            {
              
                txtSisaKuota.Text = sisaDiDB.ToString();
            }

            
            if (int.TryParse(txtSisaKuota.Text, out int sisa))
            {
                txtSisaKuota.ForeColor = (sisa < 0) ? Color.Red : Color.Black;
            }
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Lengkapi semua data diri!");
                return false;
            }

            
            foreach (char c in txtNama.Text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Nama tidak boleh mengandung angka atau simbol!");
                    return false;
                }
            }

            
            foreach (char c in txtNoHP.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Nomor HP harus berupa angka!");
                    return false;
                }
            }

            
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Format email tidak valid!");
                return false;
            }

            if (int.Parse(txtSisaKuota.Text) < 0)
            {
                MessageBox.Show("Kuota tidak mencukupi untuk jumlah tiket yang Anda pilih!");
                return false;
            }

            return true;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            int dewasa = (int)numTiketDewasa.Value;
            int pelajar = (int)numTiketPelajar.Value;
            int anak = (int)numTiketAnak.Value;

            int total = (dewasa * 70000) + (pelajar * 50000) + (anak * 30000);

            if (total == 0)
            {
                MessageBox.Show("Silakan pilih tiket terlebih dahulu.");
                return;
            }

            string detail = $"{dewasa} Dewasa, {pelajar} Pelajar, {anak} Anak";
            string kode = "ZOO-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Buka koneksi terlebih dahulu sebelum memulai transaksi (Sesuai Modul)
            conn.Open();

            // Inisialisasi variabel transaksi di luar blok try-catch seperti contoh praktikum
            SqlTransaction trans = null;

            try
            {
                // Memulai transaksi database
                trans = conn.BeginTransaction();

                string query = @"INSERT INTO Booking (KodeBooking, Nama, NoHP, Email, TanggalKunjungan, 
                       TiketDewasa, TiketPelajar, TiketAnak, TotalHarga, StatusPembayaran, DetailTiket, IDPengunjung, IDAdmin, IDTiket) 
                       VALUES (@kode, @nama, @hp, @email, @tgl, @dewasa, @pelajar, @anak, @total, 'Bayar Di Loket', @detail, 1, 1, 1)";

                // Sertakan objek 'trans' ke dalam konstruktor SqlCommand (Sesuai Modul)
                SqlCommand cmd = new SqlCommand(query, conn, trans);

                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@hp", txtNoHP.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@tgl", dtpBooking.Value.Date);
                cmd.Parameters.AddWithValue("@dewasa", dewasa);
                cmd.Parameters.AddWithValue("@pelajar", pelajar);
                cmd.Parameters.AddWithValue("@anak", anak);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@detail", detail);

                cmd.ExecuteNonQuery();

                // Integrasi Pencatatan Log Aktivitas sukses ke database sebelum Commit (Sesuai Modul)
                SqlCommand cmdLog = new SqlCommand(
                    "INSERT INTO LogAktivitas (aktivitas, waktu) VALUES (@aktivitas, GETDATE())",
                    conn,
                    trans
                );
                cmdLog.Parameters.AddWithValue("@aktivitas", "INSERT BOOKING SUKSES : " + kode);
                cmdLog.ExecuteNonQuery();

                // Jika semua eksekusi SQL di atas berhasil tanpa error, lakukan Commit
                trans.Commit();

                // Perubahan UI dan Notifikasi diletakkan setelah Commit sukses dilakukan
                txtKodeBook.Text = kode;
                txtStatusPembayaran.Text = "Bayar Di Loket";
                txtTanggalKunjungan.Text = dtpBooking.Value.ToShortDateString();
                txtDetailTiket.Text = detail;
                txtTotalHarga.Text = "Rp. " + total.ToString("N0");

                MessageBox.Show("Booking Berhasil Tersimpan!");

                btnPesan.Enabled = false;
                UpdateSisaKuota();
                LockForm();
            }
            catch (SqlException ex)
            {
                // Jika terjadi kesalahan SQL, batalkan seluruh rangkaian perintah (Rollback)
                if (trans != null) trans.Rollback();

                // Pencatatan log kegagalan eksekusi ke file/sistem log (Sesuai Modul)
                SimpanLog("ROLLBACK INSERT BOOKING : " + ex.Message);
                MessageBox.Show("Gagal menyimpan data (SQL Error): " + ex.Message);
            }
            catch (Exception ex)
            {
                // Antisipasi kesalahan umum non-SQL, lakukan rollback juga
                if (trans != null) trans.Rollback();

                SimpanLog("GENERAL ERROR BOOKING : " + ex.Message);
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
            finally
            {
                // Memastikan koneksi database ditutup kembali pada kondisi apa pun
                conn.Close();
            }
        }

        private void LockForm()
        {
            
            txtNama.Enabled = false;
            txtNoHP.Enabled = false;
            txtEmail.Enabled = false;
            dtpBooking.Enabled = false;
            numTiketDewasa.Enabled = false;
            numTiketPelajar.Enabled = false;
            numTiketAnak.Enabled = false;
            btnPesan.Enabled = false;

            
            txtDetailTiket.ReadOnly = true;
            txtTotalHarga.ReadOnly = true;
            txtKodeBook.ReadOnly = true;
            txtStatusPembayaran.ReadOnly = true;
            txtTanggalKunjungan.ReadOnly = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpBoxDataTiket_Enter(object sender, EventArgs e)
        {

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

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validasi data kode booking wajib ada
                if (string.IsNullOrEmpty(txtKodeBook.Text))
                {
                    MessageBox.Show("Belum ada transaksi data booking yang aktif!");
                    return;
                }

                // 2. Pastikan koneksi database terbuka
                if (conn.State == ConnectionState.Closed) conn.Open();

                // 3. Alokasikan memori baru untuk DataTable tingkat class
                dtbooking = new DataTable();

                // 4. Panggil SP dengan 1 parameter tunggal agar tidak memicu error "Too many arguments"
                using (SqlCommand cmdUtama = new SqlCommand("sp_ReportRingkasanBooking", conn))
                {
                    cmdUtama.CommandType = CommandType.StoredProcedure;
                    cmdUtama.Parameters.AddWithValue("@inKodeBooking", txtKodeBook.Text);

                    SqlDataAdapter daUtama = new SqlDataAdapter(cmdUtama);
                    daUtama.Fill(dtbooking);
                }

                // 5. Buka Form ReportBooking dengan melempar Kode Booking yang aktif
                ReportBooking frmCetak = new ReportBooking(txtKodeBook.Text);
                frmCetak.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                SimpanLog("SQL ERROR CETAK FORM: " + ex.Message);
                MessageBox.Show("SQL Error saat memproses laporan: " + ex.Message);
            }
            catch (Exception ex)
            {
                SimpanLog("GENERAL ERROR CETAK FORM: " + ex.Message);
                MessageBox.Show("Gagal memproses cetak data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}