using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIP.Base.DbModels.Models.User;

namespace Data.Configurations
{
    public class MUserConfiguration : EntityTypeConfiguration<MUser>
    {
        public MUserConfiguration()
        {
            ToTable("MUser");
            HasKey(o=>o.Id);
            Property(o => o.Name).HasMaxLength(100).IsRequired();
            Property(o => o.LoginName).HasMaxLength(100).IsRequired();
            Property(o => o.PassWord).IsRequired();
            Property(o => o.Role).HasMaxLength(100).IsRequired();
            Property(o => o.CreateTime).IsRequired();
        }
    }
}
