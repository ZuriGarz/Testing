using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace IOOPgroup
{
    internal class Users
    {
        private string UserName;
        private string Password;

        //constructor
        public Users(string u, string p)
        {
            UserName1 = u;
            Password1 = p;
        }

        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }

        //method to login
        public string login(string name)
        {
            //create variable status as string type with no value
            string? status = null;

            //open connection to database
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            //input sql query for customer
            SqlCommand cmd = new SqlCommand("select count() from Data where Name ='" + UserName1 + "' and password ='"
                + Password1 + "'", con);

            //for admin/tech/receptionist
            SqlCommand cmd3 = new SqlCommand("select count() from Employee where Username ='" + UserName1 + "' and Password ='"
                + Password1 + "'", con);

            //execute query and convert to int
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            int count1 = Convert.ToInt32(cmd3.ExecuteScalar().ToString());

            //verify users 

            if (count > 0)
            {
                Menu a = new Menu();
                a.ShowDialog();
            }

            return status;
        }
    }
}
