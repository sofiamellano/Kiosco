using Desktop.Interfaces;
using KioscoInformaticoDesktop;
using KioscoInformaticoDesktop.Views;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Productos
{
    public class InitialDisplayState : IFormState
    {
        ProductosView _form;
        public InitialDisplayState(ProductosView form) 
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
      
        public async void OnSearch()
        {
          await UpdateUI();
        }
        public async Task UpdateUI()
        {

            var productos = await _form.productoService.GetAllAsync(_form.txtFiltro.Text); 
            _form.ListProductos.DataSource = productos;
            _form.dataGridProductosView.DataSource = _form.ListProductos;
            _form.tabControl.SelectTab(_form.tabPageLista);
        }
        public void OnGoOut()
        {
            _form.Close();
        }

        public void OnCancel() { }
        public void OnSave() { }
        public void OnAdd() { }
        public void OnEdit() { }
        public void OnDelete() { }

    }
}
