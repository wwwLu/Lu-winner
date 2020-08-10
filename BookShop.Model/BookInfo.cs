using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
   public class BookInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int PublisherId { get; set; }
        public string Category { get; set; }
        public int WordsCount { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImgUrl { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string ContentDescription { get; set; }
        public string AuthorDescription { get; set; }
        public string EditorComment { get; set; }
    }
}
