using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public  interface IGeneryRepository <T> where T : BaseEntity
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetByAll();
        void Add (T entity);
        void Update (T entity);
        void Delete (T entity);

    }
}
