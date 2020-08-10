using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.AdminPortal
{
    public partial class AllBookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string catId = "";
                if (Request.QueryString["CatId"] != null)
                {
                    catId = Request.QueryString["CatId"].ToString();
                }
                int recordCount = 0;
                //根据图书分类Id查询图书列表
                List<BookInfo> list = BookManager.GetBookListByCatId(catId, 1, 10, out recordCount);
                this.AspNetPager1.PageSize = 10;
                this.AspNetPager1.RecordCount = recordCount;
                this.dlBook.DataSource = list;
                this.dlBook.DataBind();
            }
        }
        protected void dlCategory_ItemCommand(object source, DataListCommandEventArgs e)
        {

            if (e.CommandName == "ShowBookDetail")
            {
                Response.Redirect("ShopCart.aspx?BookId=" + e.CommandArgument.ToString());
            }
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            //this.AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            string catId = "";
            if (Request.QueryString["CatId"] != null)
            {
                catId = Request.QueryString["CatId"].ToString();
            }
            int recordCount = 0;
            List<BookInfo> list = BookManager.GetBookListByCatId(catId, e.NewPageIndex, 10, out recordCount);
            this.dlBook.DataSource = list;
            this.dlBook.DataBind();

        }
    }
}