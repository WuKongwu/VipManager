using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VIP.Base.Interface.Models;

namespace VIP.Base.DbModels.Models.User
{
    public class MUser:ObjectModel
    {
        //姓名
        public string Name { get; set; }

        //登录名
        public string LoginName { get; set; }

        //密码
        public string PassWord { get; set; }

        //权限
        public string Role { get; set; }
    }
}
