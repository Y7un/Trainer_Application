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
    public partial class frmEditModule : Form
    {
        private string selectedModule;
        private string selectedLevel;
        private int selectedID;
        private string selectedSchedule;
        private string trainerID;

        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);

        public frmEditModule(string s, string l, int id, string sch, string tid)
        {
            InitializeComponent();
            selectedModule = s;
            selectedLevel = l;
            selectedID = id;
            selectedSchedule = sch;
            trainerID = tid;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCharge.Text == "" && cmbboxDay.Text == "" && cmbboxTime.Text == "")
            {
                MessageBox.Show("Please enter a valid change.");
            }
            else
            {
                if (txtCharge.Text != "")
                {
                    int newCharge = int.Parse(txtCharge.Text);

                    Trainer_ModuleClass moduleclass = new Trainer_ModuleClass(newCharge, "");
                    moduleclass.EditCharge(selectedID);

                }

                if ((cmbboxDay.Text == "" && cmbboxTime.Text != "") || (cmbboxDay.Text != "" && cmbboxTime.Text == ""))
                {
                    MessageBox.Show("Please provide both the time and day to update the module schedule"); 
                }
                else if (cmbboxTime.Text != "" && cmbboxDay.Text != "")
                {
                    string newDay = cmbboxDay.Text.ToString();
                    string newTime = cmbboxTime.Text.ToString();
                    string newschedule = newDay + " (" + newTime + ")";

                    Trainer_ModuleClass moduleclass = new Trainer_ModuleClass(0, newschedule);
                    moduleclass.EditSchedule(selectedID);
                }
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModuleList moduleList = new frmModuleList(trainerID);
            moduleList.ShowDialog();
            this.Close();
        }

        private void frmEditModule_Load(object sender, EventArgs e)
        {
            lblModuleName.Text = selectedModule;
            lblLevel.Text = selectedLevel;

            string day;
            string time;

            string[] splitschedule = selectedSchedule.Split(' ');
            day = splitschedule[0];
            time = splitschedule[1] + " " +  splitschedule[2] + " " +  splitschedule[3];
            time = time.Substring(1, time.Length - 2);
            cmbboxDay.Text = day;
            cmbboxTime.Text = time;
        }

        private void grpAddModule_Enter(object sender, EventArgs e)
        {

        }
    }
}
