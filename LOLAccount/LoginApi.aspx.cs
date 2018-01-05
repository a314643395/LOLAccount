using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOLAccount.Entity;
using LOLAccount.Method;

namespace LOLAccount
{
    public partial class LoginApi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string Login(string UserName, string PassWord)
        {

            try
            {
                IList<UserEntity> users = DtToList<UserEntity>.ConvertToModel(SqlHelp.SelectAllQQ());

                var user = users.FirstOrDefault(x => x.QQ == UserName);
                if (user == null)
                {
                    return "此QQ非暗影岛轰炸机成员！";

                }
                if (user.State == 1)
                {
                    return "登录成功！";
                }
                else
                {
                    return "此QQ没有开放查看权限！！！";
                }
            }
            catch (Exception ex)
            {

                return(ex.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           Response.Write(Login("314643395", "0")); 
        }
    }
}