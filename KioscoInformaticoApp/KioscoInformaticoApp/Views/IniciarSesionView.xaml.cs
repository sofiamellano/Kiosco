using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class IniciarSesionView : ContentPage
{
	public IniciarSesionView()
	{
		InitializeComponent();
        /////CÓDIGO QUE para preparar la recepción de mensajes y la llamada al método RecibirMensaje
        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceiveMessage(mensaje);
        });
    }

    private async void OnReceiveMessage(Message mensaje)
    {
        if (mensaje.Value == "AbrirProductos")
        {
            await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AbrirOfertas")
        {
            await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AgregarProducto")
        {
            await Navigation.PushAsync(new AddEditProductoView());
        }
        if(mensaje.Value == "CerrarVentana")
        {
            await Navigation.PopAsync();
        }
    }
}