using Service.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductoService : GenericService<Producto>, IProductoService
    {
        public async Task<List<Producto>?> GetAllInOfferAsync()
        {
            var response = await client.GetAsync($"{_endpoint}/getInOffer");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Producto>>(content, options); ;

        }
    }
}
