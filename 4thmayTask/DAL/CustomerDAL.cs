using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Data.SqlClient;

using Customer.Models;
using System.Data;

namespace Customer.DAL
{
    public class CustomerDAL
    {
        public string cnn = "";


        public CustomerDAL()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cnn = builder.GetSection("ConnectionStrings:Conn").Value;
        }

        public List<Customers> GetAllCustomers()
        {
            List<Customers> listCustomer = new List<Customers>();
            using (SqlConnection con = new SqlConnection(cnn))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllCustomers", con))
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listCustomer.Add(new Customers()
                        {
                            CustomerID = int.Parse(reader["CustomerID"].ToString()),
                            CustomerName = reader["CustomerName"].ToString(),
                            EmailID = reader["EmailID"].ToString(),
                            MobileNo = reader["MobileNo"].ToString()
                        }); ;
                    }

                }
            }
            return listCustomer;
        }


        public int NewCustomer(Customers cust)
        {
            /* int CustomerId = cust.CustomerID;
             string CustomerName = cust.CustomerName;
             string emailId = cust.EmailID;
             string MobileNo = cust.MobileNo;
             SqlConnection con = new SqlConnection(cnn);
             string sqlqry = "NewCustomer '"+ CustomerId +"','"+CustomerName+"','"+emailId+"','"+MobileNo+"'";
             SqlCommand cmd = new SqlCommand(sqlqry, con);
             con.Open();
             cmd.ExecuteNonQuery();
             con.Close();*/
            SqlConnection con = new SqlConnection(cnn);

            SqlCommand cmd = new SqlCommand("NewCustomer", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustID", cust.CustomerID);
            cmd.Parameters.AddWithValue("@CustName", cust.CustomerName);
            cmd.Parameters.AddWithValue("@Email", cust.EmailID);
            cmd.Parameters.AddWithValue("@Mobile", cust.MobileNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();

            con.Close();
            return result;
        }
        public int UpdCustomer(Customers obj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("UpdCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustID", obj.CustomerID);
            cmd.Parameters.AddWithValue("@CustName", obj.CustomerName);
            cmd.Parameters.AddWithValue("@Email", obj.EmailID);
            cmd.Parameters.AddWithValue("@Mobile", obj.MobileNo);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DelCustomer(Customers obj)
        {
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("DelCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustId", obj.CustomerID);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}
