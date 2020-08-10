using BookShop.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI
{
    public partial class GetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                HttpCookie loginCookie = Request.Cookies["UserLoginInfo"];
                if(loginCookie !=null)
                {
                    this.txtLoginId.Text = loginCookie.Values["LoginId"].ToString();
                }
            }



        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string loginId = this.txtLoginId.Text.Trim();
            string oldPwd = this.txtOldLoginPwd.Text.Trim();
            string newPwd = this.txtNewLoginPwd.Text.Trim();
            int result =UserManager.UpdateUserPassword(loginId, oldPwd, newPwd);
            if (result == -1)
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "error", "<script>alert('账号不存在')</script>");
            }
            else if (result == -2)
            {
                ClientScript.RegisterClientScriptBlock(GetType(), "error", "<script>alert('密码错误')</script>");
            }
            else
            {
                //注销登录状态
                HttpCookie loginCookie = Request.Cookies["UserLoginInfo"];
                if (loginCookie != null)
                {
                    loginCookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(loginCookie);

                }

              ClientScript.RegisterClientScriptBlock(GetType(), "sucess", "<script>alert('修改密码成功');location.href='UserLogin.aspx'</script>");
            }

        }
    }
}