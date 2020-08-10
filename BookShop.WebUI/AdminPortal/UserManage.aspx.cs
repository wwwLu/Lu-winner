using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.AdminPortal
{
    public partial class UserManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindUsersListData();
            }
        }
        private void BindUsersListData()
        {
            gvwUserList.DataSource = BLL.UserManager.GetUserList();
            gvwUserList.DataBind();
        }
    }
}