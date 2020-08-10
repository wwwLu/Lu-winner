using BookShop.Model;
using System;
using System.Web.UI.WebControls;
using BookShop.BLL;
using System.Web.UI;
using System.Web;

namespace BookShop.WebUI.MemberPortal
{
    public partial class UserRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RangeValidator1.MaximumValue = DateTime.Now.AddYears(-5).ToString("yyyy-MM-dd");
                RangeValidator1.MinimumValue = DateTime.Now.AddYears(-100).ToString("yyyy-MM-dd");

                this.GreatValidateCode1.Create();
                this.CompareValidator3.ValueToCompare = this.GreatValidateCode1.ValidateCode;
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //收集用户输入信息
            UserInfo user = new UserInfo();
            user.LoginId = txtLoginId.Text.Trim();
            user.Name = txtName.Text.Trim();
            user.LoginPwd = txtPassword.Text.Trim();
            user.Gender = rbMale.Checked ? "男" : "女";
            user.Birthday = txtBirthday.Text.Trim();
            user.Degree = ddlDegree.SelectedValue;
            user.Phone = txtPhone.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Addree = txtAddree.Text.Trim();
            user.Memo = txtDesciption.Text.Trim();
            string origin = "";
            foreach (ListItem item in cblSource.Items)
            {
                if (item.Selected)
                {
                    if (origin == "")
                    {
                        origin = item.Value;
                    }
                    origin = origin + "," + item.Value;
                }
            }
            user.Origin = origin;

            //验证用户
            //检查用户名是否可用
            bool result = UserManager.IsLoginIdExist(user.LoginId);
            if (result)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "sucess", "<script>alert('用户名已存在')</script>");
                return;
            }

            //验证用户邮件地址是否可用
            bool result2 = UserManager.IsEmailExist(user.Email);
            if (result2)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "sucess", "<script>alert('邮件地址已存在')</script>");
                return;
            }


            //调用业务逻辑层代码添加用户
            if (UserManager.UserRegister(user))
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "sucess", "<script>alert('注册成功')</script>");

                    //页面跳转
                    //Response.Redirect("~/MemberPortal/ UserLogin.aspx");
                }
            }
        

         protected void btnCheckLoginId_Click(object sender, EventArgs e)
        {
            //获取用户名
            string loginId = this.txtLoginId.Text.Trim();
            //检查用户名是否可用
           bool result= UserManager.IsLoginIdExist(loginId);
          if(result)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "sucess", "<script>alert('用户名不可用')</script>");
            }
          else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "sucess", "<script>alert('用户名可用')</script>");
            }
        }

        protected void lbtnCreateCode_Click(object sender, EventArgs e)
        {
                     this.GreatValidateCode1.Create();
        }
    }
}