using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        public Task<List<T>?> GetAllAsync(string token, string? filtro);
        public Task<T?> GetByIdAsync(int id, string token);
        public Task<T?> AddAsync(T? entity, string token);
        public Task UpdateAsync(T? entity, string token);
        public Task DeleteAsync(int id, string token);
    }
}
