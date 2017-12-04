using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LOLAccount.Entity;
using LOLAccount.Method;

namespace LOLAccount
{
    public partial class index : System.Web.UI.Page
    {
        private bool LoginStatus = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataView dv = new DataView(SqlHelp.SelectAll());
            GridView1.DataSource = dv;
            GridView1.DataBind();
            if (LoginStatus)
            {
                Panel4.Visible = true;
                panel_hd.Visible = false;

            }

            //GridView1.HeaderRow.Cells[0].Text = "ID";
            //GridView1.HeaderRow.Cells[1].Text = "QQ";
            //GridView1.HeaderRow.Cells[1].Text = "密码";
            //GridView1.HeaderRow.Cells[1].Text = "昵称";
            //GridView1.HeaderRow.Cells[1].Text = "段位";
            //GridView1.HeaderRow.Cells[1].Text = "英雄数";
            //GridView1.HeaderRow.Cells[1].Text = "皮肤数";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            IList<UserEntity> users = DtToList<UserEntity>.ConvertToModel(SqlHelp.SelectAllQQ());
            var user = users.FirstOrDefault(x => x.QQ == txtLogin.Text);
            if (user == null)
            {
                lbl0.Text = "此QQ非暗影岛轰炸机成员！";
                return;
            }
            if (user.State == 1)
            {
                panel_hd.Visible = false;
                Panel4.Visible = true;
                LoginStatus = true;
                GridView1.Visible = true;
                lbl0.Visible = false;
                Panel1.Visible = false;
                this.Title = "欢迎回来!";
            }
            else
            {
                lbl0.Text = "此QQ没有开放查看权限！！！";
            }

            //if (Login(txtLogin.Text))
            //{
            //    GridView1.Visible = true;
            //    Panel1.Visible = false;
            //    lbl0.Visible = false;
            //}
            //else
            //{
            //    lbl0.Text = "You dont have 权限！";
            //}
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // e.Row.Attributes.Add("onmouseover", "if(this!=prevselitem){this.style.backgroundColor='#Efefef'}");//当鼠标停留时更改背景色
                // e.Row.Attributes.Add("onmouseout", "if(this!=prevselitem){this.style.backgroundColor='#ffffff'}");//当鼠标移开时还原背景色
                e.Row.Attributes.Add("onclick", e.Row.ClientID.ToString() + ".checked=true;selectx(this)");//点击行变色

                //e.Row.Attributes["style"] = "Cursor:hand"; //设置悬浮鼠标指针形状为"小手"
                //  GridView1.HeaderRow.Cells[10].Visible = false;
                // e.Row.Cells[10].Visible = false;//隐藏选择按钮
                //String evt = Page.ClientScript.GetPostBackClientHyperlink(sender as System.Web.UI.WebControls.GridView, "Select$" + e.Row.RowIndex.ToString());
                // e.Row.Attributes.Add("onclick", evt);//执行选择行GridView1_SelectedIndexChanged事件
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open('http://lol.qq.com/act/a20171113sejuani/?e_code=371188&atm_cl=ad&atm_pos=16601&idata_id=171827','_blank')</script>");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open('http://lol.qq.com/act/a20171102match/index.html?e_code=370560&atm_cl=ad&atm_pos=16602&idata_id=171496','_blank')</script>");
            
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>window.open('http://lol.qq.com/act/a20171119canyon/?e_code=373092&atm_cl=ad&atm_pos=17542&idata_id=172906&contentId=273584','_blank')</script>");
        }

        
    }

}