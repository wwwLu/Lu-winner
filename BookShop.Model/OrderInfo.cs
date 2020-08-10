using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class OrderInfo
    {
        public string OrderState { get; set; }
        public decimal TotalPrice { get; set; }   //合计金额
        public string UserId { get; set; }
        public DateTime OrderDate { get; set; }

        public int Id { get; set; }
    }
}
