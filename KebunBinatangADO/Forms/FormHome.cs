using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KebunBinatangADO.Forms
{
    public partial class FormHome: Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormHome()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin loginAdmin = new FormLoginAdmin();
            loginAdmin.Show();

            this.Hide();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void btnpengunjung_Click(object sender, EventArgs e)
        {
            FormRegisterPengunjung regisPengunjung = new FormRegisterPengunjung();
            regisPengunjung.Show();

            this.Hide();
        }
    }
}
