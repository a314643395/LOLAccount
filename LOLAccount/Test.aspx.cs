using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LOLAccount
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

           System.Data.SqlClient.SqlConnection conn = CreateSqlConnection();
           SqlCommand cmd = new SqlCommand("select * from RCKJ_CMS_UserLogin ", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Label1.Text = dr["UserName"].ToString();
                }

            }
            catch (Exception ex)
            {
                
                Label1.Text=ex.ToString();
            }
        }
        public static SqlConnection CreateSqlConnection()
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection("server=hds330978129.my3w.com;database=hds330978129_db;uid=hds330978129;pwd=SA0500ZBKJ");
            conn.Open();
            return conn;
        }
    }
}