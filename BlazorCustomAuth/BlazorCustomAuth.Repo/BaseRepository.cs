using BlazorCustomAuth.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Repo
{
    public class BaseRepository<TEntry> : IBaseRepository<TEntry> where TEntry : Entry
    {
        private readonly AppDbContext _appDbContext;

        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<TEntry>> GetAllAsync()
        {
            var query = _appDbContext.Set<TEntry>().AsQueryable();
            foreach (var property in _appDbContext.Model.FindEntityType(typeof(TEntry)).GetNavigations())
                query = query.Include(property.Name);
            return await query.ToListAsync();

        }

        public async Task<TEntry> GetByIdAsync(int id)
        {
            var query = _appDbContext.Set<TEntry>().Where(s => s.Id == id).AsQueryable();
            foreach (var property in _appDbContext.Model.FindEntityType(typeof(TEntry)).GetNavigations())
                query = query.Include(property.Name);
            return await query.FirstOrDefaultAsync();
        }
        public virtual async Task<long> GetCountAsync(Expression<Func<TEntry, bool>> predicate)
        {
            var query = this._appDbContext.Set<TEntry>().AsQueryable();

            return await query.Where(predicate).CountAsync();
        }

        public virtual async Task<TEntry> GetByIdAsync(int id, bool includeRelated = false)
        {
            var query = this._appDbContext.Set<TEntry>().AsQueryable();

            if (includeRelated)
            {
                foreach (var property in this._appDbContext.Model.FindEntityType(typeof(TEntry)).GetNavigations())
                    query = query.Include(property.Name);
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task<TEntry> GetByIdAsync(int id, params Expression<Func<TEntry, object>>[] properties)
        {
            var query = this._appDbContext.Set<TEntry>().AsQueryable();

            if (properties.Any())
                query = properties.Aggregate(query, (current, property) => current.Include(property));

            return await query.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task AddAsync(TEntry entity)
        {
            await this._appDbContext.Set<TEntry>().AddAsync(entity);
            await this._appDbContext.SaveChangesAsync();
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntry> entities)
        {
            await this._appDbContext.Set<TEntry>().AddRangeAsync(entities);
            await this._appDbContext.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntry entity)
        {
            this._appDbContext.Set<TEntry>().Update(entity);
            await this._appDbContext.SaveChangesAsync();
        }
      

    }
}
