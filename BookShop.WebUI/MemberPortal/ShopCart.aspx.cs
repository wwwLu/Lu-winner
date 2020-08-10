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
    public partial class ShopCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCart();

        }
        private void BindCart()
        {
            CartInfo cart = (CartInfo)Session["Cart"];
            gvCart.DataSource = cart.Items;
            gvCart.DataBind();
        }

        protected void gvCart_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //光棒效果
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#D3D7F5'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor =currentcolor");
            }
                if (e.Row.RowType == DataControlRowType.Footer)
            {
                CartInfo cart = (CartInfo)Session["Cart"];
                if (cart != null)
                {
                    e.Row.Cells[1].Text = "合计";
                    e.Row.Cells[3].Text = cart.TotalQuantity.ToString();
                    e.Row.Cells[4].Text = cart.TotalPrice.ToString();

                }
            }
        }

        protected void gvCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvCart_RowEditing(object sender, GridViewEditEventArgs e)
        {
            this.gvCart.EditIndex = e.NewEditIndex;
            BindCart();
        }

        protected void gvCart_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.gvCart.EditIndex = -1;
            BindCart();
        }

        protected void gvCart_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //获取Id  Label
            Label lblBookId = this.gvCart.Rows[e.RowIndex].FindControl("lblBookId") as Label;
            //获取数量TextBox
            TextBox txtnumber = this.gvCart.Rows[e.RowIndex].FindControl("txtnumber") as TextBox;
            int bookId = Int32.Parse(lblBookId.Text);
            int number = Int32.Parse(txtnumber.Text);
            //更新购物车图书数量
            if (Session["Cart"] != null)
            {
                CartInfo cart = (CartInfo)Session["Cart"];
                CartManager.UpdateBook(cart, bookId, number);
            }
            this.gvCart.EditIndex = -1;
            BindCart();
        }

        protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //获取Id  Label
            Label lblBookId = this.gvCart.Rows[e.RowIndex].FindControl("lblBookId") as Label;
            int bookId = Int32.Parse(lblBookId.Text);
            //更新购物车图书数量
            if (Session["Cart"] != null)
            {
                CartInfo cart = (CartInfo)Session["Cart"];
                CartManager.DeleteBook(cart, bookId);
            }
            BindCart();
        }
    }
}