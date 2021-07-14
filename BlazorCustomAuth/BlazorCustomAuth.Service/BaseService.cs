using BlazorCustomAuth.Entities;
using BlazorCustomAuth.Repo;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Service
{
    public class BaseService<TEntry> : IBaseService<TEntry> where TEntry : Entry
    {
        private readonly IBaseRepository<TEntry> repository;

        public BaseService(IBaseRepository<TEntry> repository)
        {
            this.repository = repository;
        }
        public async Task<List<TEntry>> GetAllAsync()
        {
          return await  this.repository.GetAllAsync();
        }

        public async Task<TEntry> GetByIdAsync(int id)
        {
            return await this.repository.GetByIdAsync(id);
        }
        public virtual async Task<int> AddAsync(TEntry entity)
        {
            await this.repository.AddAsync(entity);
          
            return entity.Id;
        }

      

        public async Task<long> GetCountAsync(Expression<Func<TEntry, bool>> predicate)
        {
            return await this.repository.GetCountAsync(predicate);
        }

        public async Task<TEntry> GetByIdAsync(int id, bool includeRelated = false)
        {
            return await this.repository.GetByIdAsync(id,includeRelated);
        }

        public async Task<TEntry> GetByIdAsync(int id, params Expression<Func<TEntry, object>>[] properties)
        {
            return await  this.repository.GetByIdAsync(id, properties);
        }

      

        public async Task AddRangeAsync(IEnumerable<TEntry> entities)
        {
            await this.repository.AddRangeAsync(entities);
        }

      
    }
}
