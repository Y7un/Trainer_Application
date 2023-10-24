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

namespace ioop_assignment3
{
    public partial class frmViewStdList : Form
    {
        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);

        public frmViewStdList()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }

        private void dgvStdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {

        }
    }
}
