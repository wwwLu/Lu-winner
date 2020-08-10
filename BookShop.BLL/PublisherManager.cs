using BookShop.DAL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class PublisherManager
    {
        public static IList<PublisherInfo> GetPublishers()
        {
            return CategoryService.GetPublishers();
        }

    }
}
