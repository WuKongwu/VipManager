using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using VIP.Base.DbModels.Models.User;

namespace VIP.Base.DbModels.Models
{
    public class BaseDb : DbContext
    {

        public BaseDb() : base("") { }

        public DbSet<MUser> TbUser   { get; set;}
    }
}
