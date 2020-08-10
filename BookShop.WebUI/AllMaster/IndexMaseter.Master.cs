using BookShop.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.MemberPortal
{
    public partial class Masge : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //获取图书列表
                this.RpBookList.DataSource = CategoryManager.GetAllCategoryList();
                this.RpBookList.DataBind();

                //获取出版社信息
                this.rpPublisherList.DataSource = PublisherManager.GetPublishers();
                this.rpPublisherList.DataBind();

            }

        }

        protected void RpBookList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "ShowBookList")
            {
                string catId = e.CommandArgument.ToString();
                Response.Redirect("~/MemberPortal/BookList.aspx?CatId=" + catId);
            }
        }
    }
}