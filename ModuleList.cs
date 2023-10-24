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
    public partial class frmModuleList : Form
    {
        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);

        private string selectedModule;
        private string selectedLevel;
        private int selectedID;
        private string schedule;
        private string trainerID;

        public frmModuleList(string id)
        {
            InitializeComponent();
            trainerID = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
          RetrieveData();
        }

        private void dgvModuleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dgvModuleList.Rows[e.RowIndex];
                selectedModule = row.Cells[1].Value.ToString();
                selectedLevel = row.Cells[2].Value.ToString();
                selectedID = (int)row.Cells[0].Value;
                schedule = row.Cells[4].Value.ToString();
                lblChosenEdit.Text = selectedModule;
            }


            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = dgvModuleList.Rows[e.RowIndex];
                selectedModule = row.Cells[1].Value.ToString();
                selectedLevel = row.Cells[2].Value.ToString();
                selectedID = (int)row.Cells[0].Value;
                schedule = row.Cells[4].Value.ToString();
                lblChosenDelete.Text = selectedModule;
            }
        }

        private void btnEditStdList_Click(object sender, EventArgs e)
        {
            if (lblChosenEdit.Text != "")
            {
                this.Hide();
                frmEditModule editModule = new frmEditModule(selectedModule, selectedLevel, selectedID, schedule, trainerID);
                editModule.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No module was selected to be edited");
            }
        }

        private void btnDeleteStdLst_Click(object sender, EventArgs e)
        {
            if(lblChosenDelete.Text != "")
            {
                Trainer_ModuleClass moduleclass = new Trainer_ModuleClass();
                moduleclass.DeleteModule(selectedID);
                RetrieveData();
            }
            else
            {
                MessageBox.Show("No module was selected to be deleted");
            }
        }

        private void RetrieveData()
        {
            DataTable dt = new DataTable();
            Trainer_ModuleClass moduleclass = new Trainer_ModuleClass();
            dt = moduleclass.RetrieveData(trainerID);
            dgvModuleList.AutoGenerateColumns = false;
            dgvModuleList.DataSource = dt;
        }

        private void grpModuleList_Enter(object sender, EventArgs e)
        {

        }
    }
}
