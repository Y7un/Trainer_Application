using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioop_assignment3
{
    internal class Trainer_ModuleClass
    {
        private static string strConnToServer = System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        SqlConnection con = new SqlConnection(strConnToServer);

        private string moduleName;
        private int moduleCharge;
        private string moduleLevel;
        private string schedule;
        private string trainerID;

        public Trainer_ModuleClass(string n, int c, string l, string s, string id) 
        {
            moduleName = n;
            moduleCharge = c;
            moduleLevel = l;
            schedule = s;
            trainerID = id;
        }

        public Trainer_ModuleClass(int c, string s)
        {
            moduleCharge = c;
            schedule = s;
        }

        public Trainer_ModuleClass()
        {

        }

        public void AddModule()
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "INSERT INTO Module(Name, amount, level, schedule, trainerID) values ('" + moduleName + "'," + moduleCharge.ToString() + ",'" + moduleLevel + "','" + schedule + "','" + trainerID + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();
        }

        public void EditCharge(int selectedID)
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "UPDATE Module set amount = '" + moduleCharge + "' where Id = " + selectedID;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();
        }

        public void EditSchedule (int selectedID)
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "UPDATE Module set schedule = '" +schedule + "' where Id = " + selectedID;

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();
        }

        public void DeleteModule(int selectedID) 
        { 
            con.Open();

            DataTable dt = new DataTable();
            string sql = "DELETE from Module where Id =" + selectedID;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            con.Close();

        }

        public DataTable RetrieveData(string trainerID)
        {
            con.Open();

            DataTable dt = new DataTable();
            string sql = "SELECT Id, Name, amount, level, schedule from Module where trainerID='" + trainerID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
