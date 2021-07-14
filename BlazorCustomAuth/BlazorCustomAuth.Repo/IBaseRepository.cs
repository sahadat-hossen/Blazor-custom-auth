using BlazorCustomAuth.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Repo
{
    public  interface IBaseRepository<TEntry> where TEntry : Entry
    {
        Task<List<TEntry>> GetAllAsync();
        Task<TEntry> GetByIdAsync(int id);
        Task<long> GetCountAsync(Expression<Func<TEntry, bool>> predicate);

        Task<TEntry> GetByIdAsync(int id, bool includeRelated = false);

        Task<TEntry> GetByIdAsync(int id, params Expression<Func<TEntry, object>>[] properties);

        Task AddAsync(TEntry entity);
        Task AddRangeAsync(IEnumerable<TEntry> entities);
    }
}
