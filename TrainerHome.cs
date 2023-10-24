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
using System.Xml.Linq;

namespace ioop_assignment3
{
    public partial class frmHome : Form
    {
        string trainerName;
        string gender;
        string email;
        int contactNumber;
        string address;
        string trainerID = "TA001";
        string password;

        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);


        public frmHome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddModule addModule = new frmAddModule(trainerID);
            addModule.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModuleList moduleList = new frmModuleList(trainerID);
            moduleList.ShowDialog();
            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiveFeedback feedback = new frmGiveFeedback();
            feedback.ShowDialog();
            this.Close();
        }

        private void btnStdList_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewStdList studentlist = new frmViewStdList();
            studentlist.ShowDialog();
            this.Close();
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrainerProfile profile = new frmTrainerProfile(trainerName, gender, email, contactNumber, address, trainerID, password);
            profile.ShowDialog();
            this.Close();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Trainer prof = new Trainer();
            DataTable dt = new DataTable();                
            dt = prof.GetProfile(trainerID);

            trainerName = dt.Rows[0]["trainerName"].ToString();
            gender = dt.Rows[0]["gender"].ToString();
            email = dt.Rows[0]["email"].ToString();
            string conNum = dt.Rows[0]["contactNumber"].ToString();
            contactNumber = int.Parse(conNum);
            address = dt.Rows[0]["address"].ToString();
            password = dt.Rows[0]["password"].ToString();

        }
    }
}
