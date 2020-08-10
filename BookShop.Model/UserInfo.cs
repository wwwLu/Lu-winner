using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string LoginId { get; set; }
        public string LoginPwd { get; set; }

        public string Name { get; set; }
        public string Addree { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Degree { get; set; }
       public string Origin { get; set; }
        public string Memo { get; set; }
        public string Address { get; set; }//联系地址
        public string Mail { get; set; }//Email

    }
}
