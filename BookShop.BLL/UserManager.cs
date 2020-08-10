using BookShop.DAL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class UserManager
    {
        /// <summary>
            
            /// 用户登录处理
        /// </summary>
        /// <param name="loginId">账号</param>
        /// <param name="loginnPwd">密码</param>
        /// <returns>0:登陆成功，-1:账号不存在 -2:密码错误</returns>
        public static int Login(string loginId,string loginPwd)
        {
            //从数据库访问层DAL得到用户信息
            UserInfo user = UserService.GetUserByLoginId(loginId);
            if(user.LoginPwd !=loginPwd)
            {
                return -2;
            }
            return 0 ;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true:注册成功.false:注册失败</returns>
        public static bool UserRegister(UserInfo user)
        {
            //调用DAL层添加方法
            int returnId= UserService.AddUser(user);
            if (returnId == 0)
                return false;
            return true;
        }

        public static int UpdateUserPassword(string loginId,string oldPwd,string newPwd)
        {
            //1.根据登录账号获取用户信息
            UserInfo user = UserService.GetUserByLoginId(loginId);
            //2.判断用户原密码是否正确，如果正确修改密码
            if(user==null)
            {
                return -1;
            }

           if(oldPwd !=user.LoginPwd)
            {
                return -2;
            }

            int result = UserService.UpdateUserPassword(loginId, newPwd);
            return result;
        }

        /// <summary>
        /// 检查这个用户名是否存在
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public static bool IsLoginIdExist(string loginId)
        {
            UserInfo user = UserService.GetUserByLoginId(loginId);
            if(user==null)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 检查这个邮件地址是否存在
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public static bool IsEmailExist(string email)
        {
            UserInfo user = UserService.GetUserByEmail(email);
            if (user == null)
            {
                return false;
            }
            return true;
        }
        public static IList<UserInfo> GetUserList() {
            return UserService.GetUserList();
        }

    }
}





