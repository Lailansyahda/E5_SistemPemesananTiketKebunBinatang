using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KebunBinatangADO
{
    public partial class ReportLaporan : Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        List<ClassLaporanBooking> listLaporan = new List<ClassLaporanBooking>();

        public ReportLaporan()
        {
            InitializeComponent();
        }

        public ReportLaporan(DateTime tglFilter)
        {
            InitializeComponent();
            LoadReportData(tglFilter);
        }

        private void LoadReportData(DateTime tgl)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string query = "SELECT * FROM vw_Laporan WHERE CONVERT(DATE, Tanggal) = @tgl";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tgl", tgl.Date);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        conn.Open();
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            ClassLaporanBooking rpt = new ClassLaporanBooking();

                            rpt.IDBooking = row["IDBooking"].ToString();
                           
                            rpt.TanggalKunjungan = Convert.ToDateTime(row["Tanggal"]).ToShortDateString();
                            rpt.TotalHarga = row["TotalTransaksi"].ToString();
                           

                            listLaporan.Add(rpt);
                        }
                    }
                }

                CrystalReportLaporan myReport = new CrystalReportLaporan();
                myReport.SetDataSource(listLaporan);

                crystalReportViewer1.ReportSource = myReport;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}