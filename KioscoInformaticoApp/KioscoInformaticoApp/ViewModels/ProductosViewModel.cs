using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosViewModel : ObjectNotification
    {
		private GenericService<Producto> productoService= new GenericService<Producto>();
        private string filterProducts;

		public string FilterProducts
		{
			get { return filterProducts; }
			set { filterProducts = value;
                OnPropertyChanged();
                _ = FiltrarProductos();
            }
		}
        //porque hacemos esto, porque lo dijo Gabriel
        //https://chatgpt.com/share/9ab527ab-34a6-426c-b7a7-362c38e460a7
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
			set { productos = value; 
			OnPropertyChanged();
            }
		}
        private List<Producto>? productosListToFilter;

        
        public Command ObtenerProductosCommand { get; }
        public Command FiltrarProductosCommand { get; }

        public ProductosViewModel()
        {
            ObtenerProductosCommand = new Command(async () => await ObtenerProductos());
            FiltrarProductosCommand = new Command(async () => await FiltrarProductos());
            ObtenerProductos();

        }

        public async Task FiltrarProductos()
        {
            var productosFiltrados = productosListToFilter.Where(p => p.Nombre.ToUpper().Contains(filterProducts.ToUpper()));
            Productos = new ObservableCollection<Producto>(productosFiltrados);
        }

        private async Task ObtenerProductos()
        {
            FilterProducts = string.Empty;
            IsRefreshing = true; // Asegúrate de que IsRefreshing se establezca en true al inicio
            productosListToFilter = await productoService.GetAllAsync();
            Productos = new ObservableCollection<Producto>(productosListToFilter);
            IsRefreshing = false; // Establece IsRefreshing en false al final
        }
    }
}
