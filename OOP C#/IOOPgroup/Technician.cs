using DocumentFormat.OpenXml.Wordprocessing;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPgroup
{
    internal class Technician
    {
        private string Name;
        private string AddInfo;
        private string Completion;
        private string Pass;
        private string Reff;
        private string Name2;
        private string Date1;
        private string check;



        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        public string Name1 { get => Name; set => Name = value; }
        public string AddInfo1 { get => AddInfo; set => AddInfo = value; }
        public string Completion1 { get => Completion; set => Completion = value; }
        public string Pass1 { get => Pass; set => Pass = value; }
        public string Name21 { get => Name2; set => Name2 = value; }
        public string Reff1 { get => Reff; set => Reff = value; }
        public string Date11 { get => Date1; set => Date1 = value; }
        public string Check { get => check; set => check = value; }

        public Technician(string n, string c,string AD, string date, string Cheeckt1)
        {
            Name1 = n;
            Completion1 = c;
            AddInfo1 = AD;   
            Date11 = date;
            Check = Cheeckt1;
        }
        public Technician(string n, string s, string r)
        {
            Name21 = n;
            Pass1 = s;
            Reff1 = r;

        }

        public Technician(string n)
        {
            Name1 = n;
        }
        

       

        

        public static ArrayList ViewAllTechU()
        {
            //Name, LaptopBrand, Urgency, ServiceChoosen, LaptopSerialNum  (this is data)
            con.Open();
            ArrayList nm = new ArrayList();
            
            SqlCommand cmd = new SqlCommand("select * from Data where Urgency='Urgent' and (Completion='In Proggress' or Completion ='Pending');", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(2));
            }
            
            con.Close();
            return nm; 
        }
        public static ArrayList ViewAllTechN()
        {
            //Name, LaptopBrand, Urgency, ServiceChoosen, LaptopSerialNum  (this is data)
            con.Open();
            ArrayList nm = new ArrayList();

            SqlCommand cmd = new SqlCommand("select * from Data where Urgency='Normal' and (Completion='In Proggress' or Completion ='Pending');", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(2));
            }

            con.Close();
            return nm;
        }

        public Technician(string Name, string check1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select LaptopBrand, ServiceChoosen, LaptopSerialNum from Data where Name='"+ Name +"';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MessageBox.Show(rd.GetString(0), "Brand");
                MessageBox.Show(rd.GetString(1), "Service Choosen");
                MessageBox.Show(rd.GetString(2), "SerialNum");
            }
            con.Close();
        }

        public static string TechnicianCheck(string Name)
        {
            con.Open();
            string Services = "check";
            
            SqlCommand cmd = new SqlCommand("select * from Data where Name='" + Name + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Services = rd.GetString(4);
            }
            con.Close();
            return Services;
        }

        public string UpdateTechnicianAcc()
        {
            string status = "Failed desu";
            if (!string.IsNullOrEmpty(Name21))
            {
                if (!string.IsNullOrEmpty(Pass1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Employee set Username='" + Name21 + "', Password='" + Pass1 + "'  where Username='" + Reff1 + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed Desu";
                    con.Close();
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Employee set Username='" + Name21 + "' where Username='" + Reff1 + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed Desu";
                    con.Close();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(Pass1))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Employee set Password='" + Pass1 + "'  where Username='" + Reff1 + "';", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        status = "Success";
                    else
                        status = "Failed Desu";
                    con.Close();
                }
                else
                {
                    status = "Failed";
                }
            }
            return status;
        }


        public string ReviewCompletion()
        {
            string Complete = "In Proggress";
            string status = "Failed";
            if (Check == "1")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Data set Completion='" + Complete + "', AddInfo='" + AddInfo1 + "' , Date='" + Date11 + "'  where Name='" + Name1 + "';", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    status = "Success";
                else
                    status = "Failed Desu";
                con.Close();
            }

            else if (Check == "2")
            {
                Complete = "Completed";

                con.Open();
                SqlCommand cmd = new SqlCommand("update Data set Completion='" + Complete + "', AddInfo='" + AddInfo1 + "' , Date='" + Date11 + "'  where Name='" + Name1 + "';", con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                    status = "Success";
                else
                    status = "Failed Desu";
                con.Close();
            }
            return status;
        }


    }
}
