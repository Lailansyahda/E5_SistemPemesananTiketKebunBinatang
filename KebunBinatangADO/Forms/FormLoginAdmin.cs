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

namespace KebunBinatangADO
{
    public partial class FormLoginAdmin: Form
    {
        string connString = "Data Source=LAPTOP-2V9KUAS1\\LAILANSYAHDA; Initial Catalog=DBKebunBinatangADO; Integrated Security=True";
        SqlConnection conn;

        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLoginAdmin_Click(object sender, EventArgs e)
        {

        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
        }
    }
}
