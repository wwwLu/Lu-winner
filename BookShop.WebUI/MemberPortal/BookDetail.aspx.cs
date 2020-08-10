using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.WebUI.MemberPortal
{
    public partial class BookDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //获取图书编号
                int bookId = Convert.ToInt32(Request.QueryString["BookId"]);
                BookInfo book = BookManager.GetBookById(bookId);
                List<BookInfo> books = new List<BookInfo>();
                books.Add(book);

                dlBook.DataSource = books;
                dlBook.DataBind();

            }
        }

        protected void dlBook_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int bookId = Convert.ToInt32(e.CommandArgument.ToString());
           // int bookId = Int32.Parse(e.CommandArgument.ToString());
            BookInfo book = BookManager.GetBookById(bookId);
            if (Session["Cart"] != null) 
            {
                CartInfo cart = (CartInfo)Session["Cart"];
                if (CartManager.ExistBook(cart, book))
                {
                    CartManager.IncreaseBook(cart, book, 1);
                }
                else
                {
                    CartManager.AppendBook(cart, book, 1);
                }
            }
            else
            {
                CartInfo cart = CartManager.BuildCart();
                CartManager.AppendBook(cart, book, 1);
                Session["Cart"] = cart;
            }


            Response.Redirect("ShopCart.aspx");
        }
    }
}