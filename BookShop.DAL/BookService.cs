using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DAL
{
    public class BookService
    {
        /// <summary>
        /// 获取最新出版的8本图书
        /// </summary>
        /// <returns>数据集</returns>
        public static List<BookInfo> GetNewBookList()
        {
            List<BookInfo> list = new List<BookInfo>();
            //将数据库（云仓）里的数据放到数据集（临时仓库）中来，用到数据适配器（运货车）
            String connStr = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;
            //创建数据库链接
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //打开数据库链接
                conn.Open();
                //创建数据集
                DataSet ds = new DataSet();
                string sql = "select top 8 * from Books order by PublishDate desc";
                //创建适配器
                SqlDataAdapter sa = new SqlDataAdapter(sql, conn);
                //填充数据集
                sa.Fill(ds);
                //将数据集转成对象集合
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //创建图书对象
                    BookInfo book = new BookInfo();
                    //设置图书对象属性值
                    book.Id = Convert.ToInt32(row["Id"].ToString());
                    book.Title = row["Title"].ToString();
                    book.ImgUrl = row["ImgUrl"].ToString();
                    book.ISBN = row["ISBN"].ToString();
                    book.PublishDate = DateTime.Parse(row["PublishDate"].ToString());
                    book.UnitPrice = Decimal.Parse(row["UnitPrice"].ToString());
                    list.Add(book);

                }

                return list;


            }


        }

        public static BookInfo GetBookById(int bookId)
        {
            BookInfo book = new BookInfo();
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "select b. * ,c.Name as Category,p.Name as Publisher from Books b,Categories c,Publishers p where b.CategoryId=c.Id and b.PublisherId=p.Id and b.Id=@BookId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@BookId", bookId));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    book.Id = Int32.Parse(reader["Id"].ToString());
                    book.Title = reader["Title"].ToString();
                    book.Category = reader["Category"].ToString();
                    book.WordsCount = Int32.Parse(reader["WordsCount"].ToString());
                    book.Publisher = reader["Publisher"].ToString();
                    book.ISBN = reader["ISBN"].ToString();
                    book.ImgUrl = reader["ImgUrl"].ToString();
                    book.PublishDate = DateTime.Parse(reader["PublishDate"].ToString());
                    book.UnitPrice = Decimal.Parse(reader["UnitPrice"].ToString());
                    book.ContentDescription = reader["ContentDescription"].ToString();
                    book.AuthorDescription = reader["AuthorDescription"].ToString();
                    book.EditorComment = reader["EditorComment"].ToString();
                }
            }
            return book;
        }
        public static List<BookInfo> GetBookListByCatId(string catId, int pageIndex, int pageSize, out int recordCount)
        {
            List<BookInfo> list = new List<BookInfo>();
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                string sql = "select * from ";

                sql = sql + "(select ROW_NUMBER() over(order by b.Id) as rn ,b.*,c.Name as Categoryname,p.Name as Publishername from Books b,Categories c,Publishers p where b.PublisherId=p.Id and b.CategoryId=c.Id ";
                if (catId != "")
                {
                    sql = sql + " and b.CategoryId=" + catId;
                }
                sql = sql + ")t";
                sql = sql + " where rn>=" + ((pageIndex - 1) * pageSize + 1) + " and rn<=" + pageIndex * pageSize;



                DataSet ds = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter(sql, conn);
                sa.Fill(ds);
                //将数据集转对象集合
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    BookInfo model = new BookInfo();
                    model.Id = Int32.Parse(dr["Id"].ToString());
                    model.ISBN = dr["ISBN"].ToString();
                    model.Title = dr["Title"].ToString();
                    model.Author = dr["Author"].ToString();
                    model.ImgUrl = dr["ImgUrl"].ToString();
                    model.PublishDate = DateTime.Parse(dr["PublishDate"].ToString());
                    model.UnitPrice = Decimal.Parse(dr["UnitPrice"].ToString());
                    model.ContentDescription = dr["ContentDescription"].ToString();
                    model.Category = dr["Categoryname"].ToString();
                    model.Publisher = dr["Publishername"].ToString();
                    list.Add(model);
                }
                recordCount = 0;
                //查询图书数量
                string sqlCount = "select count(*) from Books";
                if (catId != "")
                {
                    sql = sql + "where CategoryId=" + catId;
                }
                SqlCommand cmd = new SqlCommand(sqlCount, conn);
                recordCount = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }

            return list;


        }
        public static int DeleteBookById(int bookId)
        {
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = @"delete from books where id=@bookId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@BookId", bookId));
                return cmd.ExecuteNonQuery();
            }
        }

        public static int AddBook(BookInfo book)
        {
            string strConn = ConfigurationManager.ConnectionStrings["BookshopConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strsql = "insert into Books  and Publishers and Categories (Title,Author,Publishers.Name,PublishDate,ISBN,WordsCount,UnitPrice,ContentDescription,Category,ImgUrl) Values (@Title,@Author,@Publisher,@PublishDate,@ISBN,@WordsCount,@UnitPrice,@ContentDescription,@Category,@ImgUrl) ";
            SqlCommand cmd = new SqlCommand(strsql, conn);
            SqlParameter[] paras = new SqlParameter[]
            {
               new SqlParameter("@Title",book.Title),
               new SqlParameter("@Author",book.Author),
               new SqlParameter("@Publisher",book.Publisher),
               new SqlParameter("@PublishDate",book.PublishDate),
               new SqlParameter("@ISBN",book.ISBN),
               new SqlParameter("@WordsCount",book.WordsCount),
               new SqlParameter("@UnitPrice",book.UnitPrice),
               new SqlParameter("@ContentDescription",book.ContentDescription),
               new SqlParameter("@Category",book.Category),
               new SqlParameter("@ImgUrl",book.ImgUrl)
            };
            cmd.Parameters.AddRange(paras);
            int num = cmd.ExecuteNonQuery();
            conn.Close();
            return num;
        }

  
    }

}




