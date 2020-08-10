using BookShop.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.AdminPortal
{
    public partial class AdminOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindListData();
            }
        }
        private void BindListData()
        {
            gvwOrderList.DataSource = OrderManager.GetOrders();
            gvwOrderList.DataBind();
        }

        protected void GVBook_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvwOrderList.PageIndex = e.NewPageIndex;
            BindListData();
        }

        protected void GvwBookList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteOrder")
            {
                if (OrderManager.DeleteOrder(Convert.ToInt32(e.CommandArgument)) == 1)
                {
                    Response.Write("<script>alert('删除成功!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败!')</script>");
                }
                BindListData();
            }
        }

        protected void gvwBookList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Attributes.Add("onmouseover", "crrentcolor=this.style.backgroundColor;this.style.backgroundColor='#D3D7F5'");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=crrentcolor");
        }
    }
}