using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IOOPgroup
{
    internal class ViewData
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public static ArrayList ViewReportName(string z)
        {
            //open connection
            con.Open();
            //create dinamic array (size is not set)
            ArrayList nm  = new ArrayList();

            SqlCommand cmd = new SqlCommand("Select * from Data where MONTH(Date) = '" + z + "';", con);
            //retrieve data from sql and send it to array
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                nm.Add(dr.GetValue(2).ToString());
            //close connection
            con.Close();
            //return array
            return nm;
            
        }

        public static ArrayList ViewReportService(string z)
        {
            //open connection
            con.Open();
            //create dinamic array (size is not set)
            ArrayList nm = new ArrayList();

            SqlCommand cmd = new SqlCommand("Select * from Data where MONTH(Date) = '" + z + "';", con);
            //retrieve data from sql and send it to array
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                nm.Add(dr.GetValue(4).ToString());
            //close connection
            con.Close();
            //return array
            return nm;
        }

        public static ArrayList ViewReportUrgency(string z)
        {
            //open connection
            con.Open();
            //create dinamic array (size is not set)
            ArrayList nm = new ArrayList();

            SqlCommand cmd = new SqlCommand("Select * from Data where MONTH(Date) = '" + z + "';", con);
            //retrieve data from sql and send it to array
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                nm.Add(dr.GetValue(5).ToString());
            //close connection
            con.Close();
            //return array
            return nm;
        }

        public static ArrayList ViewReportCompletion(string z)
        {
            //open connection
            con.Open();
            //create dinamic array (size is not set)
            ArrayList nm = new ArrayList();

            SqlCommand cmd = new SqlCommand("Select * from Data where MONTH(Date) = '" + z + "';", con);
            //retrieve data from sql and send it to array
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                nm.Add(dr.GetValue(9).ToString());
            //close connection
            con.Close();
            //return array
            return nm;
        }

        public int ViewMonthlyIncome(string z)
        {
            int count = 0;
            //open connection
            con.Open();
            SqlCommand cmd = new SqlCommand("Select SUM(Payment) from Data where MONTH(Date) = '" + z + "';", con);
            count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            con.Close();
            return count;
        }
    }
}
