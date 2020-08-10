using BookShop.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.MemberPortal
{
    public partial class UseLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie loginCookie = Request.Cookies["UserLoginInfo"];
            if (loginCookie == null)
            {
                this.pnlLogin.Visible = true;
                this.pnlLoginView.Visible = false;

                lblMessage.Text = "请输入账号与密码";
            }
            else
            {
                this.pnlLogin.Visible = false;
                this.pnlLoginView.Visible = true;

                lblLoginId.Text = loginCookie.Values["LoginId"].ToString();
                lblVisite.Text = loginCookie.Values["VisitDate"].ToString();
                lblIP.Text = Request.UserHostAddress;

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string loginId = txtLoginid.Text.Trim();
            string loginPwd = txtLoginPwd.Text.Trim();
            int returnId = UserManager.Login(loginId, loginPwd);
            if (returnId == -1)
            {
                lblMessage.Text = "账号不存在";
            }
            else if (returnId == -2)
            {
                lblMessage.Text = "密码错误";
            }
            else
            {
                lblMessage.Text = "登陆成功，欢迎访问网上商城";

                //使用Cookie保存用户登录信息

                //创建Cookie
                HttpCookie loginCookie = new HttpCookie("UserLoginInfo");
                loginCookie.Values["LoginId"] = loginId;
                loginCookie.Values["VisitDate"] = DateTime.Now.ToString();
                //两周之内是否登录
                if (cbLoginExpires.Checked)
                {
                    loginCookie.Expires = DateTime.Now.AddDays(14);
                }
                else
                {
                    loginCookie.Expires = DateTime.Now.AddDays(1);
                }
                //保存Cookie
                Response.Cookies.Add(loginCookie);

                Response.Redirect("~/Index.aspx");
            }
        }
           //用户注销
        protected void btnLogout_Click1(object sender, EventArgs e)
        {
            HttpCookie loginCookie = Request.Cookies["UserLoginInfo"];
            if(loginCookie !=null)
            {
                loginCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(loginCookie);

                this.pnlLogin.Visible = true;
                this.pnlLoginView.Visible = false;
            }
        }
    }
    }

