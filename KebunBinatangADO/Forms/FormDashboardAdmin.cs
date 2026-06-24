using System;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void btnKelolaTiket_Click(object sender, EventArgs e)
        {
            FormKelolaTiket form = new FormKelolaTiket();
            form.Show();
        }

        private void btnDataBook_Click(object sender, EventArgs e)
        {
            FormDataBooking form = new FormDataBooking();
            form.Show();
        }

        private void btnVerfikasi_Click(object sender, EventArgs e)
        {
            FormVerifikasi form = new FormVerifikasi();
            form.Show();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan form = new FormLaporan(DateTime.Now);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}