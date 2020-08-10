using BookShop.DAL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class CategoryManager
    {
        public static List<Categorylnfo> GetAllCategoryList()
        {
            return CategoryService.GetAllCategoryList();
        }
    }
}
