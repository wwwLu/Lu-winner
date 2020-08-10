using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class CartItemInfo
    {
       public BookInfo Book { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
    }
         
    }

