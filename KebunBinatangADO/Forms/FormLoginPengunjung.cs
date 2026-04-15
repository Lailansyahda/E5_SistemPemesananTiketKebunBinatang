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
    public partial class FormLoginPengunjung: Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormLoginPengunjung()
        {
            InitializeComponent();
        }

        private void btnLoginPengunjung_Click(object sender, EventArgs e)
        {

        }

        private void FormLoginPengunjung_Load(object sender, EventArgs e)
        {

        }
    }
}
