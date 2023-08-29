using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPgroup
{
    internal class loginpage
    {
        private string UserName;
        private string Password;

        //constructor
        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public loginpage(string userName, string password)
        {
            UserName1 = userName;
            Password1 = password;
        }
        
        public string login1()
        {
            
            string status = null;
            con.Open();
            
            

            if (!string.IsNullOrEmpty(UserName1))
            {
                
                if (!string.IsNullOrEmpty(Password1))
                {
                    
                    int count2 = 0;
                    //input sql query for customer
                    SqlCommand cmd = new SqlCommand("select count(*) from Data where Name ='" + UserName + "' and Password ='" + Password + "';", con);

                    int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    


                    if (count == 0)
                    {
                        SqlCommand cmd3 = new SqlCommand("select count(*) from Employee where Username ='" + UserName1 + "' and Password ='" + Password1 + "';", con);

                        count2 = Convert.ToInt32(cmd3.ExecuteScalar().ToString());
                        
                    }

                    if (count > 0)
                    {
                        status = "success";
                        Menu a = new Menu(UserName1);
                        a.ShowDialog();
                    }
                    else if (count2 > 0)
                    {
                        status = "success";
                        SqlCommand cmd2 = new SqlCommand("select Role from Employee where Username ='" + UserName1 + "';", con);
                        string userRole = cmd2.ExecuteScalar().ToString();
                        if (userRole == "Receptionist")
                        {
                            mainMenuRecep a = new mainMenuRecep(UserName1);
                            a.ShowDialog();
                        }
                        else if (userRole == "Admin")
                        {
                            Frm_Main_admin N = new Frm_Main_admin(UserName1);
                            N.ShowDialog();
                        }
                        else if (userRole == "Technician")
                        {
                            TechnicianMenu T = new TechnicianMenu(UserName1);
                            T.ShowDialog();
                        }
                    }

                    else
                        status = "invalid input";
                }
                else
                {
                    status = "invalid input";
                }
            }
            else
            {
                status = "invalid input";
            }

            con.Close();

            return status;

        }
    }
}
