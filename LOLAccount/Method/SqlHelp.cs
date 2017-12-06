using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LOLAccount.Method
{
    public class SqlHelp
    {
        #region SQL

        public static SqlConnection CreateSqlConnection()
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection("server=bds244426197.my3w.com;database=bds244426197_db;uid=bds244426197;pwd=sa123456");
            conn.Open();
            return conn;
        }

        public static DataTable SelectAll()
        {
            System.Data.SqlClient.SqlConnection conn = CreateSqlConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from LOLAccount", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }


        public  DataTable SelectAllAccount()
        {
            System.Data.SqlClient.SqlConnection conn = CreateSqlConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from LOLAccount", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public static DataTable SelectAllQQ()
        {
            System.Data.SqlClient.SqlConnection conn = CreateSqlConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from QQ", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public bool Login(string str)
        {
            bool state = false;
            System.Data.SqlClient.SqlConnection conn = CreateSqlConnection();
            string sqlStr = "SELECT * FROM QQ WHERE QQ='" + str + "' AND State=1";
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                state = true;
                return state;
            }
            return state;
        }
        #endregion
    }
}