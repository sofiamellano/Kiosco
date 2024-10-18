using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class AddEditProductoViewModel : ObjectNotification
    {
		ProductoService productoService = new ProductoService();
        private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; 
			OnPropertyChanged();
            }
        }

		private decimal precio;

		public decimal Precio
		{
			get { return precio; }
			set { precio = value;
                OnPropertyChanged();
            }
        }

		private bool oferta;

		public bool Oferta
		{
			get { return oferta; }
			set { oferta = value; 
				OnPropertyChanged();
			    }
		}	

		public Command SaveProductCommand { get; }

        public AddEditProductoViewModel()
        {
            SaveProductCommand = new Command(async () => await SaveProduct());
        }

        private async Task SaveProduct()
        {
            var producto = new Producto()
            {
                Nombre = this.Nombre,
                Precio = this.Precio,
                Oferta = this.Oferta
            };
            await productoService.AddAsync(producto);
            WeakReferenceMessenger.Default.Send(new Message("CerrarVentana"));

        }
    }
}


