using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KebunBinatangADO
{
    public partial class ReportBooking : Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";

        // Menggunakan List Object mirip seperti ReportLaporan yang sudah berjalan sukses
        List<ClassBookingPengunjung> listBooking = new List<ClassBookingPengunjung>();

        public ReportBooking()
        {
            InitializeComponent();
        }

        // Constructor utama menerima parameter string
        public ReportBooking(string kodeBooking)
        {
            InitializeComponent();
            LoadReportBookingData(kodeBooking);
        }

        private void LoadReportBookingData(string kodeBook)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ReportRingkasanBooking", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@inKodeBooking", kodeBook);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        conn.Open();
                        da.Fill(dt);

                        // Looping baris data dan pasangkan ke properti class model kamu
                        foreach (DataRow row in dt.Rows)
                        {
                            ClassBookingPengunjung rpt = new ClassBookingPengunjung();

                            // Mapping field disesuaikan dengan alias kolom dari Stored Procedure
                            rpt.KodeBooking = row["Kode Booking"].ToString();
                            rpt.DetailTiket = row["Detail Kategori Tiket"].ToString();
                            rpt.TotalHarga = "Rp. " + Convert.ToDecimal(row["Total Harga"]).ToString("N0");
                            rpt.StatusPembayaran = row["Status Pembayaran"].ToString();
                            rpt.TanggalKunjungan = Convert.ToDateTime(row["Tanggal Kunjungan"]).ToShortDateString();

                            listBooking.Add(rpt);
                        }
                    }
                }

                // Inisialisasi Crystal Report dan pasang List DataSource-nya
                CrystalReportBooking cr = new CrystalReportBooking();
                cr.SetDataSource(listBooking);

                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat isi data ke dalam laporan: " + ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}