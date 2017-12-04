using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOLAccount.Method;

namespace LOLAccount
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "INSERT INTO LOLAccount (QQ, 密码,昵称,段位,英雄数,皮肤数) VALUES ('" + txtQQ.Text + "', " +
                            "'" + txtPwd.Text + "','" + txtName.Text + "','" + txtDw.Text + "','" + txtYxs.Text + "','" + txtPfs.Text + "')";
            SqlConnection conn = SqlHelp.CreateSqlConnection();
            SqlCommand cmd=new SqlCommand(sqlStr,conn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Label1.Text = "OK！！";
            }
            else
            {
                Label1.Text = "XXXXX";
            }
        }




    }
}