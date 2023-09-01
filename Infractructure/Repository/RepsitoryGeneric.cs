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
    public class RepsitoryGeneric<T> : IGeneryRepository<T> where T : BaseEntity
    {
        protected readonly UserContext _userContext;

        public RepsitoryGeneric(UserContext userContext)
        {
            _userContext = userContext;
        }
        public void Add(T entity)
        {
            _userContext.Set<T>().Add(entity);
            _userContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _userContext.Set<T>().Remove(entity);
            _userContext.SaveChanges();
        }

        public async Task<IEnumerable<T>> GetByAll()
        {
           return await _userContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _userContext.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _userContext.Set<T>().Update(entity);
            _userContext.SaveChanges();
        }
    }
}
