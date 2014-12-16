using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using VIP.Base.DbModels.Models.User;
using Data.Configurations;

namespace Vip.Data
{
    public class DataContext : DbContext
    {
        public DbSet<MUser> mUsers { get; set; }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MUserConfiguration());
          
        }
       
    }
}
