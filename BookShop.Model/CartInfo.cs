using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class CartInfo
    {
        public CartInfo()
        {
            Items = new List<CartItemInfo>();
        }
        public List<CartItemInfo> Items { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
