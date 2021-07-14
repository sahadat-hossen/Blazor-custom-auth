using BlazorCustomAuth.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Service
{
   public interface IBaseService<TEntry> where TEntry:Entry
    {
        Task<List<TEntry>> GetAllAsync();
        Task<TEntry> GetByIdAsync(int id);

        Task<long> GetCountAsync(Expression<Func<TEntry, bool>> predicate);

        Task<TEntry> GetByIdAsync(int id, bool includeRelated = false);

        Task<TEntry> GetByIdAsync(int id, params Expression<Func<TEntry, object>>[] properties);

        Task<int> AddAsync(TEntry entry);
        Task AddRangeAsync(IEnumerable<TEntry> entities);
    }
}
