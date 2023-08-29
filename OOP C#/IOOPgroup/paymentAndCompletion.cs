using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPgroup
{
    internal class paymentAndCompletion
    {
        string customerID;
        string cusName;
        string pass;
        string laptopBrand;
        string laptopSerialNum;
        string urgency;
        string chooseService;
        string payment;
        string completion;
        string date;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //public void dateAndCompletionInsert()

        public void forGenerateRandT(string cusID, RichTextBox receiptRTB, TextBox total)
        {
            con.Open();
            customerID = cusID;
            SqlCommand name = new SqlCommand("select Name from Data where OrderID='"+ customerID +"'", con);
            SqlCommand lBrand = new SqlCommand("select LaptopBrand from Data where OrderID='" + customerID + "'", con);
            SqlCommand lSerial = new SqlCommand("select LaptopSerialNum from Data where OrderID='" + customerID + "'", con);
            SqlCommand sc = new SqlCommand("select ServiceChoosen from Data where OrderID='" + customerID + "'", con);
            SqlCommand urgencys = new SqlCommand("select Urgency from Data where OrderID='" + customerID + "'", con);
            SqlCommand pay = new SqlCommand("select Payment from Data where OrderID='" + customerID + "'", con);
            SqlCommand dates = new SqlCommand("select Date from Data where OrderID='" + customerID + "'", con);
            cusName = (string)name.ExecuteScalar();
            pass = (string)lBrand.ExecuteScalar();
            laptopBrand = (string)lBrand.ExecuteScalar();
            laptopSerialNum = (string)lSerial.ExecuteScalar();
            chooseService = (string)sc.ExecuteScalar();
            urgency = (string)urgencys.ExecuteScalar();
            payment = (string)pay.ExecuteScalar().ToString();
            date = Convert.ToString(dates.ExecuteScalar());
            

            receiptRTB.AppendText("*********************************************************\n");
            receiptRTB.AppendText("*************      Welcome To       *************\n");
            receiptRTB.AppendText("*************     ___________________   **************\n");
            receiptRTB.AppendText("*************     KL Computer Service   **************\n");
            receiptRTB.AppendText("*************    -------------------   **************\n");
            receiptRTB.AppendText("**********************************************************\n");
            receiptRTB.AppendText("==========================================================\n");
      
            receiptRTB.AppendText("      Name: " + cusName + "\n");
            receiptRTB.AppendText("      Laptop Brand: " + laptopBrand + "\n");
            receiptRTB.AppendText("         Laptop Serial Number: " + laptopSerialNum + "\n");
            receiptRTB.AppendText("      Chosen Service: " + chooseService + "\n");
            receiptRTB.AppendText("      Urgency: " + urgency + "\n");
            receiptRTB.AppendText("      Total: " + payment + "\n");
            receiptRTB.AppendText("             Date: " + date+ "\n");
        
            receiptRTB.AppendText("===========================================================\n");
            receiptRTB.AppendText("**********************************************************\n");
            receiptRTB.AppendText("**********************************************************\n");
            receiptRTB.AppendText("**********************************************************\n");
            receiptRTB.AppendText("**********************************************************\n");
            receiptRTB.AppendText("**********************************************************\n");
            receiptRTB.AppendText("**********************************************************\n");

            total.AppendText(payment);
            con.Close();
        }

        public static ArrayList retrieveCusID()
        {
            con.Open();
            ArrayList cusID = new ArrayList();
            SqlCommand cmd = new SqlCommand("select OrderID from Data", con);
            SqlDataReader er = cmd.ExecuteReader();
            while (er.Read())
            {
                cusID.Add(er.GetInt32(0));
            }
            con.Close();
            return cusID;
        }

        
      
    }
}
