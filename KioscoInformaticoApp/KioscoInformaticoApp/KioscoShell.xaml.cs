using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoApp.Views;
//using static Java.Util.Jar.Attributes;

namespace KioscoInformaticoApp
{
    public partial class KioscoShell : Shell
    {

        public KioscoShell()
        {
            InitializeComponent();
            FlyoutItemsPrincipal.IsVisible= false; // Oculta el menú lateral
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("Registrarse", typeof(RegistrarseView));
        }


        public void EnableAppAfterLogin()
        {
            FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
            FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
            Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
            var viewmodel = this.BindingContext as KioscoShellViewModel;
            viewmodel.IsUserLogout = false;
        }
        public void DisableAppAfterLogin() {
            FlyoutItemsPrincipal.IsVisible = false; // Oculta el menú lateral
            FlyoutBehavior = FlyoutBehavior.Disabled; // Deshabilita el FlyOut
            Shell.Current.GoToAsync("//Login"); // Navega a la página de login
        }
        #region centro de mensajes desactivado para simplificar el código
        /////el centro de mensajes funciona lo desactivamos para simplificar el código usando Shell
        ////****** ESTE CÓDIGO VA EN EL CONSTRUCTOR DE LA CLASE******
        //WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        //{
        //    OnReceiveMessage(mensaje);
        //});
        ////****** ESTE CÓDIGO VA EN EL CONSTRUCTOR DE LA CLASE******

        //private async void OnReceiveMessage(Message mensaje)
        //{
        //    if (mensaje.Value == "ListaProductos")
        //    {
        //        await Shell.Current.GoToAsync("//ListaProductos");
        //    }
        //    if (mensaje.Value == "AbrirOfertas")
        //    {
        //        await Shell.Current.GoToAsync("//Ofertas");
        //    }
        //    if (mensaje.Value == "AgregarProducto")
        //    {
        //        await Shell.Current.GoToAsync("//AgregarProducto");
        //    }
        //    if (mensaje.Value == "EditarProducto")
        //    {
        //        await Shell.Current.GoToAsync("//AgregarProducto");
        //    }
        //    if (mensaje.Value == "CerrarVentana")
        //    {
        //        await Navigation.PopAsync();
        //    }
        //    if (mensaje.Value == "AbrirAppShell")
        //    {
        //        FlyoutBehavior = FlyoutBehavior.Flyout; // Habilita el FlyOut
        //        FlyoutItemsPrincipal.IsVisible = true; // Muestra el menú lateral
        //        Shell.Current.GoToAsync("//MainPage"); // Navega a la página principal
        //    }

        //}
        #endregion
    }
}
