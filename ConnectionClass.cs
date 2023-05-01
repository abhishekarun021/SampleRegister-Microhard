using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Student
{
    public class ConnectionClass
    {
        SqlConnection con;
        SqlCommand cmd;

        public ConnectionClass()
        {
            con = new SqlConnection(@"server=DESKTOP-IFK5AR1\SQLEXPRESS;database=Machine_Test;integrated security=true");
        }
        public int Fn_NonQuery(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            cmd = new SqlCommand(query, con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public string Fn_Scalar(string query)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            cmd = new SqlCommand(query, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
    }
}