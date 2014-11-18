using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VIP.Base.Interface.Business;
using VIP.Base.DbModels.Models.User;
using VIP.Base.DbModels.Models;
using System.Data.Entity;

namespace VIP.Base.Business.UserBusiness
{
    public class UserBusiness : ObjectBusiness<MUser>
    {
        public void AddSystemUser()
        {
            MUser mUser = new MUser();
            using (BaseDb db = new BaseDb())
            {
                Create(db, mUser);
            }
        }
    }

    public class diaoyonglei
    {
        public void ssss()
        {
            //using ()
            //{
            //BaseDb db = new BaseDb()
            //UserBusiness business = new UserBusiness();
            //business.Create(db, new MUser { });
            //business.Addserssss(db);



            //db.SaveChange();
        }
        //}
    }
}
