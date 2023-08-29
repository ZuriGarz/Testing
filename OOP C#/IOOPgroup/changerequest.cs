using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPgroup
{
    internal class changerequest
    {
        private string Name;
        private string Password;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Name1 { get => Name; set => Name = value; }

        public changerequest(string n)
        {
            Name1 = n;
        }
        public string UpdateProfile(string ser, string Des, string lap)
        {
            
            con.Open();
            MessageBox.Show(ser);
            MessageBox.Show(Des);
            MessageBox.Show(lap);
            
            string status = "Failed";
            if (!string.IsNullOrEmpty(ser))
            {

                if (!string.IsNullOrEmpty(Des))
                {
                    if (!string.IsNullOrEmpty(lap))
                    {
                        
                        SqlCommand cmd = new SqlCommand("update Data set ServiceChoosen ='" + ser + "', LaptopBrand ='" + lap + "', AddInfo='" + Des + "' where Name='" + Name1 + "';", con);
                        int i = cmd.ExecuteNonQuery();
                        if
                            (i != 0)
                            status = "Success";
                        else
                                status = "Failed";
                           
                    }
                        
                    else
                    {
                        
                        SqlCommand cmd = new SqlCommand("update Data set ServiceChoosen ='" + ser + "',AddInfo='" + Des + "' where Name='" + Name1 + "';", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                            status = "Success";
                        else
                            status = "Failed";
                        
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(lap))
                    {
                        
                        SqlCommand cmd = new SqlCommand("update Data set ServiceChoosen ='" + ser + "', LaptopBrand='" + lap + "' where Name='" + Name1 + "';", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                            status = "Success";
                        else
                            status = "Failed";
                        
                    }
                    else
                    {
                        
                        SqlCommand cmd = new SqlCommand("update Data set ServiceChoosen ='" + ser + "' where Name='" + Name1 + "';", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                            status = "Success";
                        else
                            status = "Failed";
                        
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Des))
            {
                if (!string.IsNullOrEmpty(lap))
                {
                    
                    SqlCommand cmd = new SqlCommand("update Data set AddInfo='" + Des + "', LaptopBrand='"+lap+"' where Name='" + Name1 + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed";
                    
                }
            } 
            else
            {
                if (!string.IsNullOrEmpty(lap))
                {
                    
                    SqlCommand cmd = new SqlCommand("update Data set LaptopBrand='" + lap + "' where Name='" + Name1 + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed";
                    
                }
                else
                {
                    if (!string.IsNullOrEmpty(Des))
                    {
                        
                        SqlCommand cmd = new SqlCommand("update Data set AddInfo='" + Des + "' where Name='" + Name1 + "';", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                            status = "Success";
                        else
                            status = "Failed";
                        
                    }
                    status = "Failed";
                }
            }
            con.Close();

            return status;

        }
    }
}
