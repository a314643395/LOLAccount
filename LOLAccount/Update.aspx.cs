using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOLAccount.Method;

namespace LOLAccount
{
    public partial class UseSqlScript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void brn_ex_Click(object sender, EventArgs e)
        {
            string sqlStr = txtSql.Text;
            if (!sqlStr.Contains("17rx"))
            {
                Label1.Text = "\r\n 你没有权限！";
                return;
            }
            else
            {
                sqlStr = sqlStr.Remove(sqlStr.Length - 4, 4);
            }
            try
            {
            SqlConnection conn = SqlHelp.CreateSqlConnection();
            SqlCommand cmd=new SqlCommand(sqlStr,conn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "\r\n 语句已成功执行！";
            }
            else
            {
                Label1.Text = "\r\n SQL语句执行失败！";
            }
                conn.Close();
            }
            catch (Exception ex)
            {

                Label1.Text = "\r\n" + ex.ToString();
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtSql.Text += Button1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtSql.Text += Button2.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtSql.Text += "UPDATE QQ SET State=1 WHERE QQ='QQ号'";
        }

        protected void brn_ex0_Click(object sender, EventArgs e)
        {
            txtSql.Text = string.Empty;
        }
        }
    }
