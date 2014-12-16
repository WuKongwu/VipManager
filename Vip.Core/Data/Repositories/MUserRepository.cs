using Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vip.Data;
using VIP.Base.DbModels.Models.User;

namespace Data.Repositories
{
   
    public class MUserRepository : Repository<MUser>, IMUserRepository
    {
    }
}
