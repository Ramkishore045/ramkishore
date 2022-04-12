using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Task
{
    class Day27task
    {
        // SqlConnection con = new SqlConnection("data source = DESKTOP-NE6M66C;database = Newdatabase;user id = sa ;password = P@ssw0rd");
        public void createtable()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-FQMB7F5;database = softura;user id=sa;password=P@ssw0rd");
            con.Open();
            SqlCommand cmd = new SqlCommand("create table newTaskTest (sno int, StuName varchar(20))", con);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Completed Query");
            con.Close();
        }
        public void insertmeth(int sno, string StuName)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-FQMB7F5;database = softura;user id=sa;password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("sp_insTask", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Updatemeth(int sno, string StuName)
        {

            SqlConnection con = new SqlConnection("data source = DESKTOP-FQMB7F5;database = softura;user id=sa;password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("upd_task", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            cmd.Parameters.Add("@StuName", SqlDbType.VarChar).Value = StuName;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deletemeth(int sno)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-FQMB7F5;database = softura;user id=sa;password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("del_task", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@sno", SqlDbType.Int).Value = sno;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void Main()
        {
            Day27task nobj = new Day27task();
            nobj.createtable();
            Console.WriteLine("Press any Key to Continue....");
            Console.ReadLine();
            Console.WriteLine("Enter sno");
            int sn = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a topic");
            //string tpic = Console.ReadLine();
            //nobj.insertmeth(sn, tpic);
            //nobj.Updatemeth(sn,tpic);
            nobj.deletemeth(sn);

        }
    }
}