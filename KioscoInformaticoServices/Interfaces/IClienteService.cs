using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IClienteService : IGenericService<Cliente>
    {
        public Task<List<Cliente>?> GetAllAsync(string? Filtro);
    }
}
