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
    public partial class frmGiveFeedback : Form
    {
        public frmGiveFeedback()
        {
            InitializeComponent();
        }

        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string adminID; 
            string subject; 
            string feedback; 

            adminID = txtAdminID.Text;
            subject = txtSubj.Text;
            feedback = txtFeedback.Text;

            AdminFeedback adminFeedback = new AdminFeedback(adminID, subject, feedback);
            adminFeedback.SendFeedback();


            MessageBox.Show("Your feedback was sent to the admin.");
        }

        private void btnFeedbackClear_Click(object sender, EventArgs e)
        {
            txtAdminID.Clear();
            txtSubj.Clear();
            txtFeedback.Clear();
        }
    }
}
