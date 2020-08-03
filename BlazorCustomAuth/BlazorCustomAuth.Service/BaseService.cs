using BlazorCustomAuth.Entities;
using BlazorCustomAuth.Repo;
using System;
using System.Collections.Generic;
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
    }
}
