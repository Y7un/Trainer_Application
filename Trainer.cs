using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioop_assignment3
{
    internal class Trainer
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

        public Trainer(string n, string g, string em, int cn, string ad, string id, string pw)
        {
            trainerName = n;
            gender = g;
            email = em;
            contactNumber = cn;
            address = ad;
            trainerID = id;
            password = pw;
        }

        public Trainer()
        {

        }

        public void EditProfile()
        {
            con.Open();
            DataTable dt = new DataTable();
            string sql = "UPDATE Trainer set email = '" + email + "' where trainerID ='" + trainerID + "'\n" +
                "UPDATE Trainer set password = '" + password + "' where trainerID ='" + trainerID + "'\n" +
                "UPDATE Trainer set address = '" + address + "' where trainerID ='" + trainerID + "'\n" +
                "UPDATE Trainer set contactNumber = '" + contactNumber + "' where trainerID ='" + trainerID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            con.Close();
        }

        public DataTable GetProfile(string trainerID)
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "SELECT * from Trainer where trainerID = '" + trainerID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();
            return dt;
        }
    }
}
