using Core.Entities;
using Core.Interfaces;
using Infractructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractructure.Repository
{
    public class UserRepository: RepsitoryGeneric<UserBank>, IUserRepository
    {
        public UserRepository(UserContext context): base(context)
        {
            
        }

        public async Task<IEnumerable<UserBank>> GetAll() => await _userContext.UserBanks.ToListAsync();
    }
}
