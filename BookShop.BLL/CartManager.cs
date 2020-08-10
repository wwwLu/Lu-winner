using BookShop.DAL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class CartManager
    {
        public static CartInfo BuildCart()
        {
            CartInfo cart = new CartInfo();
            return cart;
        }
        public static CartInfo AppendBook(CartInfo cart,BookInfo book,int number)
        {
            CartItemInfo item = new CartItemInfo();
            item.Book = book;
            item.Quantity = number;
            item.SubTotal = item.Book.UnitPrice * item.Quantity;

            cart.Items.Add(item);
            cart.TotalQuantity += item.Quantity;
            cart.TotalPrice += item.SubTotal;

            return cart;
        }

        public static bool ExistBook(CartInfo cart,BookInfo book)
        {
            foreach(CartItemInfo item in cart.Items)
            {
                if (item.Book.Id == book.Id)
                {
                    return true;
                }
            }
            return false;
        }
        public static CartInfo IncreaseBook(CartInfo cart,BookInfo book,int number)
        {
            foreach(CartItemInfo item in cart.Items)
            {
                if (item.Book.Id == book.Id)
                {
                    item.Quantity += number;
                    item.SubTotal = item.Book.UnitPrice * item.Quantity;

                    cart.TotalQuantity += number;
                    cart.TotalPrice += item.Book.UnitPrice * number;
                }
            }
            return cart;
        }
        public static CartInfo DeleteBook(CartInfo cart,int bookId)
        {
            for(int i = 0; i < cart.Items.Count; i++)
            {
                if (cart.Items[i].Book.Id == bookId)
                {
                    cart.TotalQuantity -= cart.Items[i].Quantity;
                    cart.TotalPrice -= cart.Items[i].SubTotal;

                    cart.Items.RemoveAt(i);
                }
            }
            return cart;
        }
        public static CartInfo UpdateBook(CartInfo cart, int bookId,int number)
        {
            foreach (CartItemInfo item in cart.Items)
            {
                if (item.Book.Id == bookId)
                {
                    cart.TotalQuantity +=number-item.Quantity ;
                    cart.TotalPrice +=item.Book.UnitPrice*(number-item.Quantity) ;

                    item.Quantity = number;
                    item.SubTotal = item.Book.UnitPrice * item.Quantity;
                }
            }
            return cart;
        }
       
    }
}
