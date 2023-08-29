using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPgroup
{
    internal class Add_Users
    {
        private string name;
        private string pass;
        private string role;

        //instance methods work on/inside individual objects
        //while static methods do something for the Class.
        //create connection to database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //constructor
        public Add_Users (string a, string b, string c)
        {
            name = a;
            pass = b;
            role = c;
        }

        public string add_recept()
        {
            string status = "";
                
            int count;
           
            //open connection to database
            con.Open();

            //sql query to check existing data
            SqlCommand check1 = new SqlCommand("select count(*) from Employee where Username = '" +name+"'", con);
            count = Convert.ToInt32(check1.ExecuteScalar().ToString());

           

            //name must different cause admin only create receptionist and technician acc
            //therefore each receptionist + technician must have diff user name. e.g. tech1,tech2,recept1,recept2
            //if data exist, prevent creating account
             try
            {
                if (count > 0)
                {
                    MessageBox.Show("Username exist!!! /n please insert another Username!!!");
                }
                else
                {
                    //sql query to create receptionist account
                    SqlCommand cmd = new SqlCommand("insert into Employee (Username, Password, Role) values(@name,@pass,@role)", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@Role", role);

                    //check registation status
                    int a = cmd.ExecuteNonQuery();
                    if (a != 0)
                        status = "Registration Successful!!!";
                    else
                        status = "Unable to Register!!!";
                }
            }
            // to show what caused error
            catch
            {
                MessageBox.Show(name);
                MessageBox.Show(role);
                MessageBox.Show(pass);
            }
            con.Close();
            
            return status;
        }

        public string add_tech()
        {
            string status = "";

            int count;

            //open connection to database
            con.Open();

            //sql query to check existing data
            SqlCommand check1 = new SqlCommand("select count(*) from Employee where Username = '" + name + "'", con);
            count = Convert.ToInt32(check1.ExecuteScalar().ToString());



            //name must different cause admin only create receptionist and technician acc
            //therefore each receptionist + technician must have diff user name. e.g. tech1,tech2,recept1,recept2
            //if data exist, prevent creating account
            try
            {
                if (count > 0)
                {
                    MessageBox.Show("Username exist!!! /n please insert another Username!!!");
                }
                else
                {
                    //sql query to create receptionist account
                    SqlCommand cmd = new SqlCommand("insert into Employee (Username, Password, Role) values(@name,@pass,@role)", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@Role", role);

                    //check registation status
                    int a = cmd.ExecuteNonQuery();
                    if (a != 0)
                        status = "Registration Successful!!!";
                    else
                        status = "Unable to Register!!!";
                }
            }
            // to show what caused error
            catch
            {
                MessageBox.Show(name);
                MessageBox.Show(role);
                MessageBox.Show(pass);
            }
            con.Close();

            return status;
        }
    }
}
