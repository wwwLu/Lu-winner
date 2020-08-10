using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace BookShop.DAL
{
    public class UserService
    {
        /// <summary>
        /// 根据Id查询用户
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public static UserInfo GetUserByLoginId(string loginId)
        {
            //根据账号从数据库中获取用户信息

            //1.创建数据库链接
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //2.创建SqlCommand
            string sql = "select * from Users where LoginId=@LoginId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@LoginId", SqlDbType.NVarChar, 50));
            cmd.Parameters[0].Value = loginId;

            //3.执行命令,处理结果
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                UserInfo user = new UserInfo();
                user.LoginId = reader["LoginId"].ToString();
                user.LoginPwd = reader["LoginPwd"].ToString();
                conn.Close();
                return user;
            }
            else
            {
                conn.Close();
                return null;
            }
        }



        /// <summary>
        /// 根据email查询用户
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public static UserInfo GetUserByEmail(string email)
        {
            //根据账号从数据库中获取用户信息

            //1.创建数据库链接
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //2.创建SqlCommand
            string sql = "select * from Users where Mail=@Mail";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@LoginId", SqlDbType.NVarChar, 50));
            cmd.Parameters[0].Value = email;

            //3.执行命令,处理结果
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                UserInfo user = new UserInfo();
                user.LoginId = reader["LoginId"].ToString();
                user.LoginPwd = reader["LoginPwd"].ToString();
                conn.Close();
                return user;
            }
            else
            {
                conn.Close();
                return null;
            }
        }


         /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int AddUser(UserInfo user)
        {
            //模拟数据库操作
            //1.创建数据库链接
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            //2.定义SQL
            string sql = "insert into Users(LoginId,LoginPwd,Name,Addree,Phone,Mail,UserRoldId,UserStateId) values(@LoginId,@LoginPwd,@Name,@Addree,@Phone,@Mail,1,1)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //3.设置参数的值
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginId",user.LoginId),
                new SqlParameter("@LoginPwd",user.LoginPwd),
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@Addree",user.Addree),
                new SqlParameter("@Phone",user.Phone),
                new SqlParameter("@Mail",user.Email)
                };
            cmd.Parameters.AddRange(param);
            int nums = cmd.ExecuteNonQuery();

            conn.Close();

            return nums;
        }

        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
         public static int UpdateUserPassword(string loginId,string loginPwd)
        {
            //模拟数据库操作
            //1.创建数据库链接
            string strConn = ConfigurationManager.ConnectionStrings["BookShopConnectionString"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            //2.SQL
            string sql = "update Users set LoginPwd=@LoginPwd where LoginId=@LoginId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //3.设置参数的值
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginId",loginId),
                new SqlParameter("@LoginPwd",loginPwd)
            };
            cmd.Parameters.AddRange(param);
            int nums = cmd.ExecuteNonQuery();
            conn.Close();
            return nums;

        }
        public static IList<UserInfo> GetUserList()
        {
            string strConn = ConfigurationManager.ConnectionStrings["BookshopConnectionString"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {

                string strsql = "select * from Users";

                SqlDataAdapter sa = new SqlDataAdapter(strsql, conn);
                sa.Fill(ds);
            }
            List<UserInfo> list = new List<UserInfo>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                UserInfo users = new UserInfo
                {
                    Id = Convert.ToInt32(row["Id"]),
                    LoginId = (row["LoginId"]).ToString(),
                    LoginPwd = (row["LoginPwd"]).ToString(),
                    Name = (row["Name"]).ToString(),
                    Address = (row["Address"]).ToString(),
                    Phone = (row["Phone"]).ToString(),
                    Mail = (row["Mail"]).ToString(),
                };

                list.Add(users);
            }

            return list;




        }
    }
}

    







