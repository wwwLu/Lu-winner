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
    public class CategoryService
    {
       /// <summary>
       /// 获取所有图书分类
       /// </summary>
       /// <returns></returns>

         public static List<Categorylnfo> GetAllCategoryList()
        {
            List<Categorylnfo> list = new List<Categorylnfo>();
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;
            using(SqlConnection conn=new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "select*from Categories order by Id desc";
                DataSet ds = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter(sql, conn);
                sa.Fill(ds);

                //转对象集合
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    Categorylnfo c = new Categorylnfo();
                    c.Id = Convert.ToInt32(dr["Id"].ToString());
                    c.Name = dr["Name"].ToString();
                    list.Add(c);
                }
                return list;
            }
        }
        public static List<PublisherInfo> GetPublishers()
        {
            List<PublisherInfo> list = new List<PublisherInfo>();
            string strConn = ConfigurationManager.ConnectionStrings["BookshopConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strsql = "select top 15 Id,Name from Publishers order by Name desc";
                DataSet da = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter(strsql, conn);
                sa.Fill(da);
                foreach (DataRow row in da.Tables[0].Rows)
                {
                    PublisherInfo publisherInfo = new PublisherInfo();
                    publisherInfo.Id = Convert.ToInt32(row["Id"]);
                    publisherInfo.Name = row["Name"].ToString();

                    list.Add(publisherInfo);
                }
                return list;
            }
        }


    }
}
