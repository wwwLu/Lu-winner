using BookShop.DAL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class BookManager
    {
        public static List<BookInfo> GetNewBookList()
        {
            return BookService.GetNewBookList();
        }
        public static BookInfo GetBookById(int bookId)
        {
            return BookService.GetBookById(bookId);
        }
        public static List<BookInfo> GetBookListByCatId(string catId, int pageIndex, int pageSize, out int recordCount)
        {
            return BookService.GetBookListByCatId(catId,pageIndex,pageSize,out recordCount);
        }
        public static bool DeleteBookById(int bookId)
        {
            int returnValue = BookService.DeleteBookById(bookId);

            if (returnValue == 0)
            {
                return false;
            }
            return true;
        }

        public static void DeleteBookById(string v)
        {
            throw new NotImplementedException();
        }
        public static int AddBook(BookInfo book)
        {
            return BookService.AddBook(book);
        }
    }


    }

