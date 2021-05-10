using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Domain
{
    public interface IRepository
    {
        IQueryable<T> Query<T>() where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
    }
}
