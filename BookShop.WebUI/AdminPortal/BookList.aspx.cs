using BookShop.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShop.DAL;

namespace BookShop.WebUI.AdminPortal
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.ddlCategory.DataTextField = "Name";
                this.ddlCategory.DataValueField = "Id";
                //绑定图书分类数据
                this.ddlCategory.DataSource = CategoryManager.GetAllCategoryList();
                this.ddlCategory.DataBind();
                this.ddlCategory.Items.Insert(0, new ListItem("===请选择图书分类===", ""));




                int recordCount = 0;
                this.gvBooks.DataSource = BookManager.GetBookListByCatId("", 1, 20, out recordCount);
                this.gvBooks.DataBind();
                this.AspNetPager1.RecordCount = recordCount;
                this.AspNetPager1.PageSize = 20;
            }

        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            int recordCount = 0;
            this.gvBooks.DataSource = BookManager.GetBookListByCatId("", e.NewPageIndex, 20, out recordCount);
            this.gvBooks.DataBind();
            this.AspNetPager1.PageSize = 20;
        }

        protected void gvBooks_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditBook")
            {

            }
            else if (e.CommandName == "DeleteBook")
            {
                try
                {
                    int delete = Convert.ToInt32(e.CommandArgument.ToString());
                    BookManager.DeleteBookById(delete);
                    this.ddlCategory.DataSource = CategoryManager.GetAllCategoryList();
                    this.ddlCategory.DataBind();
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "sucess", "<script>alter('删除成功'）</script>");
                }
                catch
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "sucess", "<script>alter('删除失败'）</script>");
                }
            }


        }

        

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //传入图书分类id
            string catId = this.ddlCategory.SelectedValue;
            int recordCount = 0;
            this.gvBooks.DataSource = BookManager.GetBookListByCatId(catId, 1, 20, out recordCount);
            this.gvBooks.DataBind();
            this.AspNetPager1.CurrentPageIndex = 1;
            this.AspNetPager1.PageSize = 20;
            this.AspNetPager1.RecordCount = recordCount;
        }
    }
    }
