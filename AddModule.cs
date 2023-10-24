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
    public partial class frmAddModule : Form
    {
        private string trainerID;

        public frmAddModule(string id)
        {
            InitializeComponent();
            trainerID = id;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string moduleName;
            string moduleLevel;
            string schedule;
            int moduleCharge;
            string day;
            string time;  

            // assign value to var 

            moduleName = txtModuleName.Text;

            if (radbtnBgn.Checked)
            {
                moduleLevel = radbtnBgn.Text;
            }
            else if (radbtnInt.Checked)
            {
                moduleLevel = radbtnInt.Text;
            }
            else
            {
                moduleLevel = radbtnAdv.Text;
            }

            moduleCharge = int.Parse(txtCharge.Text.ToString());
            day = cmbboxDay.SelectedItem.ToString();
            time = cmbboxTime.SelectedItem.ToString();
            schedule = day + " (" + time + ") ";

            Trainer_ModuleClass moduleClass = new Trainer_ModuleClass(moduleName, moduleCharge, moduleLevel, schedule, trainerID);
            moduleClass.AddModule();

            MessageBox.Show("New module has been successfully added.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }

        private void btnAddClear_Click(object sender, EventArgs e)
        {
            txtModuleName.Clear();
            txtCharge.Clear();  
            radbtnAdv.Checked = false;
            radbtnBgn.Checked = false;
            radbtnInt.Checked = false;  
            cmbboxTime.SelectedItem = null;
            cmbboxDay.SelectedItem = null;
        }

        private void grpAddModule_Enter(object sender, EventArgs e)
        {

        }

        private void cmbboxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
