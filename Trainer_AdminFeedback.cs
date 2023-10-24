using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioop_assignment3
{
    internal class AdminFeedback
    {
        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);

        private string adminID;
        private string subject;
        private string feedback;

        public AdminFeedback(string a, string s, string f)
        {
            adminID = a;
            subject = s;
            feedback = f;
        }

        public void SendFeedback()
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "INSERT INTO Feedback(trainerUsername, subject, feedback, adminUsername) values ( 'var','" + subject + "','" + feedback + "','" + adminID + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
        }
    }
}
