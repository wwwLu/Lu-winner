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
    public class OrderService
    {
        public static int AddOrder(int userId,DateTime orderDate,decimal totalPrice)
        {
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                string strSQL = @"insert Orders(OrderDate,UserId,TotalPrice)values (@OrderDate,@UserId,@TotalPrice) select @@IDENTITY";

                SqlCommand commOrder = new SqlCommand(strSQL, conn);
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@UserId",userId),
                     new SqlParameter("@OderDate",orderDate),
                      new SqlParameter("@TotalPrice",totalPrice)
                };
                commOrder.Parameters.AddRange(paras);

                return Convert.ToInt32(commOrder.ExecuteScalar());
            }
        }
        public static int AddOrderBook(int orderId,CartItemInfo cartItem)
        {
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSQL = @"insert OrderBooks(OrderID,BookID,Quantity,UnitPrice) values (@OrderID,@BookID,@Quantity,@UnitPrice)";

                SqlCommand commOrder = new SqlCommand(strSQL, conn);
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter("@OrderID",orderId),
                    new SqlParameter("@BookID",cartItem.Book.Id),
                     new SqlParameter("@Quantity",cartItem.Quantity),
                     new SqlParameter("@UnitPrice",cartItem.Book.UnitPrice)
                };
                commOrder.Parameters.AddRange(paras);

                return Convert.ToInt32(commOrder.ExecuteNonQuery());
                
            }

        }
        public static IList<OrderInfo> GetOrders()
        {
            string strConn = ConfigurationManager.ConnectionStrings["BookshopConnectionString"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strsql = "select * from Orders";

                SqlDataAdapter sa = new SqlDataAdapter(strsql, conn);
                sa.Fill(ds);
            }
            List<OrderInfo> list = new List<OrderInfo>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                OrderInfo order = new OrderInfo();
                order.TotalPrice = Convert.ToInt32(row["TotalPrice"]);
                order.UserId = (row["UserId"]).ToString();
                order.OrderDate = Convert.ToDateTime(row["OrderDate"]);
                order.OrderState = (row["OrderState"]).ToString();
                order.Id = Convert.ToInt32(row["Id"]);
                list.Add(order);
            }

            return list;




        }
        public static int DeleteOrder(int Id)
        {



            string strConn = ConfigurationManager.ConnectionStrings["BookshopConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(strConn))
            {


                string strsql = "delete Orders where Id=@Id";
                using (SqlCommand cmdBook = new SqlCommand(strsql, conn))
                {
                    conn.Open();
                    cmdBook.Parameters.Add(new SqlParameter("@Id", Id));
                    int m = cmdBook.ExecuteNonQuery();
                    return m;
                }

            }


        }
        public static int DeleteOrderBook(int Id)
        {
            string strConn = ConfigurationManager.ConnectionStrings["BookshopConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strsql2 = "delete OrderBooks where OrderId=@Id";
                using (SqlCommand cmdBook = new SqlCommand(strsql2, conn))
                {
                    conn.Open();
                    cmdBook.Parameters.Add(new SqlParameter("@Id", Id));
                    int m = cmdBook.ExecuteNonQuery();
                    return m;
                }
            }

        }
    } 
}
 