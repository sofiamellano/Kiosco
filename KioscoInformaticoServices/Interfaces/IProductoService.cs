using KioscoInformaticoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoServices.Interfaces
{
    public interface IProductoService : IGenericService<Producto>
    {
        public Task<List<Producto>?> GetAllInOfferAsync();
    }
}
