using BookShop.DAL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class OrderManager
    {
        public static int CreateOrder(string userId, DateTime orderDate, CartInfo cart)
        {
            int orderId = 0;
            int userid = Int32.Parse(userId);
            orderId = OrderService.AddOrder(userid, orderDate, cart.TotalPrice);
            foreach (CartItemInfo item in cart.Items)
            {
                OrderService.AddOrderBook(orderId, item);
            }
            return orderId;
        }
        public static IList<OrderInfo> GetOrders()
        {
            return OrderService.GetOrders();
        }
        public static int DeleteOrder(int Id)
        {
            if (OrderService.DeleteOrderBook(Id) == 1)
            {
                return OrderService.DeleteOrder(Id);
            }
            else
            {
                return 0;
            }


        }
    }
}
