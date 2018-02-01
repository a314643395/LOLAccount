using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using LOLAccount.Entity;
using LOLAccount.Method;

namespace LOLAccount.Service
{
    /// <summary>
    /// AnYingDaoService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class AnYingDaoService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

          [WebMethod(EnableSession = true)]
        public string GetState(string account)
        {
            SqlHelp sql=new SqlHelp();
            return sql.Login(account).ToString();
        }

          //[WebMethod(EnableSession = true)]
          //public List<UserEntity> GetLoLAccount()
          //{
          //    var userList=new List<UserEntity>();
          //   var users = DtToList<UserEntity>.ConvertToModel(SqlHelp.SelectAllQQ()).ToList();
          //    //foreach (var item in users)
          //    //{
          //    //    var poDate=new UserEntity()
          //    //    {
                      
          //    //    };
          //    //}

          //   return userList.ToArray();
          //}
    }
}
