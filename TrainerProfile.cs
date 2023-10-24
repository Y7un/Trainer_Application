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
    public partial class frmTrainerProfile : Form
    {
        string trainerName;
        string gender;
        string email;
        int contactNumber;
        string address;
        string trainerID;
        string password;

        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);

        public frmTrainerProfile(string n, string g, string em, int cn, string ad, string id, string pw)
        {
            InitializeComponent();
            trainerName = n;
            gender = g;
            email = em;
            contactNumber = cn;
            address = ad;
            trainerID = id;
            password = pw;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.ShowDialog();
            this.Close();
        }

        private void frmTrainerProfile_Load(object sender, EventArgs e)
        {
            txtTrainerName.Text = trainerName;
            txtGender.Text = gender;
            txtEmail.Text = email;
            txtContactNo.Text = contactNumber.ToString();
            txtAddress.Text = address;
            txtTrainerID.Text = trainerID;
            txtPassword.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            string updatedEmail = txtEmail.Text;
            string updatedPassword = txtPassword.Text;
            string updatedAddress = txtAddress.Text;    
            int updatedContact = int.Parse(txtContactNo.Text);

            if (txtEmail.Text != "" && txtPassword.Text != "" && txtAddress.Text != "" && txtContactNo.Text != "") 
            {
                Trainer profile = new Trainer(trainerName, gender, updatedEmail, updatedContact, updatedAddress, trainerID, updatedPassword);
                profile.EditProfile();
            }
            else
            {
                MessageBox.Show("Please fill in all your details.");
            }
           


        }

        private void grpProfile_Enter(object sender, EventArgs e)
        {

        }
    }
}
