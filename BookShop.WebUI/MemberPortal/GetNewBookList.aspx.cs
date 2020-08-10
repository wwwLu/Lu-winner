using BookShop.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.MemberPortal
{
    public partial class GetNewBookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //设置数据源
                this.dlBookList.DataSource = BookManager.GetNewBookList();
                //绑定数据源
                this.dlBookList.DataBind();
            }

        }

        protected void dlBookList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ShowBookDetail")
            {
                Response.Redirect("BookDetail.aspx?BookId=" +e.CommandArgument.ToString());
            }
        }
    }
}