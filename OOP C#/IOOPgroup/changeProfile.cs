using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPgroup
{
    internal class changeProfile
    {
        string names;
        string passw;
        string userini;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public void profile(string name, string pass, string useruser)
        {
            string status = "Failed";
            con.Open();
            names = name;
            passw = pass;
            userini = useruser;
            SqlCommand cmd = new SqlCommand("update Employee set Username='" + names +"',Password='" + passw + "'Where Username='" +userini+ "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Success";
            else
                status = "Failed";
            MessageBox.Show(status);
            con.Close();
        }
    }
}
