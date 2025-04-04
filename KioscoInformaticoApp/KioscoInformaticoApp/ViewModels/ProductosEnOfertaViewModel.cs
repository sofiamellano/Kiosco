using KioscoInformaticoApp.Class;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosEnOfertaViewModel : ObjectNotification
    {
        private ProductoService productoService = new ProductoService();


		private string filterProducts;
		public string FilterProducts
        {
			get { return filterProducts; }
			set { filterProducts = value;
                OnPropertyChanged();
                _ = FiltrarProducto();
            }
		}

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Producto> productos;

        public ObservableCollection<Producto> Productos
        {
            get { return productos; }
            set
            {
                productos = value;
                OnPropertyChanged();
            }
        }
        private List<Producto>? productosListToFilter;

        //Esto es para el activity start, genera el circulo cuando esta cargando. Es un indicador de actividad cuando está iniciada.
        private bool activityStart;

        public bool ActivityStart
        {
            get { return activityStart; }
            set
            {
                activityStart = value;
                OnPropertyChanged();
            }
        }

        public Command ObtenerProductosCommand { get; }
        public Command FiltrarProductosCommand { get; }

        public ProductosEnOfertaViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () => await FiltrarProducto());
            ObtenerProductos();
        }

        private async Task FiltrarProducto()
        {
            if (productosListToFilter != null)
            {
                var productosFiltrados = productosListToFilter
                    .Where(p => p.Oferta &&
                                p.Nombre.ToUpper().Contains(FilterProducts.ToUpper()));

                Productos = new ObservableCollection<Producto>(productosFiltrados);
            }
        }

        public async Task ObtenerProductos()
        {
            FilterProducts = string.Empty;
            ActivityStart = true;
            productosListToFilter = await productoService.GetAllAsync();

            // Filtrar los productos en oferta al obtener la lista
            var productosEnOferta = productosListToFilter
                .Where(p => p.Oferta)
                .ToList();
            Productos = new ObservableCollection<Producto>(productosEnOferta);
            ActivityStart = false;
        }
    }
}
