using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dlNewBooks.DataSource = BookManager.GetNewBookList();
                dlNewBooks.DataBind();



            }
            this.RpBookList.DataSource = CategoryManager.GetAllCategoryList();
            this.RpBookList.DataBind();

            //获取出版社信息
            this.rpPublisherList.DataSource = PublisherManager.GetPublishers();
            this.rpPublisherList.DataBind();
        }


        protected void dlNewBooks_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "ShowBookDetails")
            {
                Response.Redirect("BookDetail.aspx?BookId=" + e.CommandArgument.ToString());
            }
        }
    }
}