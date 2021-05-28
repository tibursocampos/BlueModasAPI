using BlueModas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueModas.Persistence
{
    public class Repository : IRepository
    {
        private readonly BlueModasContext context;

        public Repository(BlueModasContext context)
        {
            this.context = context;
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return context.Set<T>();
        }

        public Task CreateAsync<T>(T entity) where T : class
        {
            return context.AddAsync(entity).AsTask();
        }

        public void Remove<T>(T entity) where T : class
        {            
            context.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }
    }
}
