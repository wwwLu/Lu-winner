using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.MemberPortal
{
    public partial class UpUserPwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            string LoginId = txtuername.Text.Trim();
            string LoginPwd = txtoldpwd.Text.Trim();
            string newLoginPwd = txtrenewpwd.Text.Trim();
            int result = BLL.UserManager.UpdateUserPassword(LoginId, LoginPwd, newLoginPwd);
            if (result == 0)
            {
                Response.Write("<script>alert('请检查你的用户名或旧密码是否正确')</script>");
            }
            else if (result == 1)
            {
                Response.Write("<script>alert('修改密码成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('服务器异常')</script>");
            }


        }
    }
}