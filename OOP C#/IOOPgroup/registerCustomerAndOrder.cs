using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPgroup
{
    internal class registerCustomerAndOrder
    {
        string cusName;
        string pass;
        string laptopBrand;
        string laptopSerialNum;
        string urgency;
        string chooseService;
        string payment;
        string price;
        string completion;
        string date;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public registerCustomerAndOrder(string name, string passw, string brand, string Serial, string urgencys, string chosenservice)
        {
            cusName = name;
            pass = passw;
            laptopBrand = brand;
            laptopSerialNum = Serial;
            urgency = urgencys;
            chooseService = chosenservice;
        }

        public string payments(string chooseService)
        {
            if (chooseService == "Remove virus")
            {
                if (urgency == "Normal")
                {
                    price = "50";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "80";
                    
                }
            }
            else if (chooseService == "Troubleshot and fix computer running slow")
            {
                if (urgency == "Normal")
                {
                    price = "60";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "90";
                    
                }
            }
            else if (chooseService == "Laptop screen replacement")
            {
                if (urgency == "Normal")
                {
                    price = "380";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "430";
                    
                }
            }
            else if (chooseService == "Laptop keyboard replacement")
            {
                if (urgency == "Normal")
                {
                    price = "160";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "200";
                    
                }
            }
            else if (chooseService == "Laptop battery replacement")
            {
                if (urgency == "Normal")
                {
                    price = "180";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "210";
                    
                }
            }
            else if (chooseService == "Operating System Format and Installation")
            {
                if (urgency == "Normal")
                {
                    price = "100";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "150";
                    
                }
            }
            else if (chooseService == "Data backup and recovery")
            {
                if (urgency == "Normal")
                {
                    price = "80";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "130";
                    
                }
            }
            else if (chooseService == "Internet connectivity issues")
            {
                if (urgency == "Normal")
                {
                    price = "70";
                    
                }
                else if (urgency == "Urgent")
                {
                    price = "100";
                    
                }
            }
            return price;

        }

        public string addCustomer()
        {
            string status;
            string info = " ";
            completion = "Pending";
            
            MessageBox.Show(date);
            payment = payments(chooseService);
            con.Open();
            SqlCommand cus = new SqlCommand("insert into Data (Name,Password,LaptopBrand,LaptopSerialNum,ServiceChoosen,Urgency,Payment,Completion,Date,AddInfo) values(@name,@pass,@brand,@serial,@chooseService,@urgency,@pay,@completion,@date,@addinfo)", con);
            cus.Parameters.AddWithValue("@name", cusName);
            cus.Parameters.AddWithValue("@pass", pass);
            cus.Parameters.AddWithValue("@brand", laptopBrand);
            cus.Parameters.AddWithValue("@serial", laptopSerialNum);
            cus.Parameters.AddWithValue("@urgency", urgency);
            cus.Parameters.AddWithValue("@chooseService", chooseService);
            cus.Parameters.AddWithValue("@pay", payment);
            cus.Parameters.AddWithValue("@completion", completion);
            cus.Parameters.AddWithValue("@date", DateTime.Now);
            cus.Parameters.AddWithValue("@addinfo", info);
            //cus.ExecuteNonQuery();
            int i = cus.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to register.";
            con.Close();

            return status;

        }
    }
}
