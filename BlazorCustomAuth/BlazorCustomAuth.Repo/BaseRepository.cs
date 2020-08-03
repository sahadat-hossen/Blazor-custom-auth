using BlazorCustomAuth.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
