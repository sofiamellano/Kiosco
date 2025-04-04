using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{

    public interface ILocalidadService : IGenericService<Localidad>
    {
        public Task<List<Localidad>?> GetAllAsync(string? filtro);
    }

}
