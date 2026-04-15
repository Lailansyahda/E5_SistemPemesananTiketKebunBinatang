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
    public partial class FormRegisterPengunjung: Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormRegisterPengunjung()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {

        }

        private void FormRegisterPengunjung_Load(object sender, EventArgs e)
        {

        }
    }
}
