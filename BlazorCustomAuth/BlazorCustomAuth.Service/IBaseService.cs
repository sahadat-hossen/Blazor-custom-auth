using BlazorCustomAuth.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Service
{
   public interface IBaseService<TEntry> where TEntry:Entry
    {
        Task<List<TEntry>> GetAllAsync();
        Task<TEntry> GetByIdAsync(int id);
    }
}
