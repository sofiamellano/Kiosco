using Desktop.Interfaces;
using KioscoInformaticoDesktop;
using KioscoInformaticoDesktop.Views;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Productos
{
    public class AddState : IFormState
    {
        ProductosView _form;
        public AddState(ProductosView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
        public void OnCancel()
        {
            _form.txtNombre.Clear();
            _form.numericPrecio.Value = 0;
            _form.SetState(_form.InitialDisplayState);
            _form.currentState.UpdateUI();
        }
        public async void OnSave()
        {
            if (string.IsNullOrEmpty(_form.txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var producto = new Producto
            {
                Nombre = _form.txtNombre.Text,
                Precio = _form.numericPrecio.Value
            };

            await _form.productoService.AddAsync(producto);
            _form.SetState(_form.InitialDisplayState);
            await _form.currentState.UpdateUI();
        }
        public Task UpdateUI()
        {
            _form.txtNombre.Clear();
            _form.numericPrecio.Value = 0;
            _form.tabControl.SelectTab(_form.tabPageAgregarEditar);
            return Task.CompletedTask;
        }
        public void OnAdd()
        {
            UpdateUI();
        }

        public void OnGoOut() { }
        public void OnEdit() { }
        public void OnDelete() { }
        public void OnSearch() { }
    }
}
