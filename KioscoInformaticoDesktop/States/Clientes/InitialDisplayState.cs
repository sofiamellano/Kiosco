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

namespace Desktop.States.Clientes
{
    public class InitialDisplayState : IFormState
    {
        ClientesView _form;
        public InitialDisplayState(ClientesView form) 
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
      
        public async void OnSearch()
        {
          await UpdateUI();
        }
        public async Task UpdateUI()
        {
            await CargarCombo();

            var clientes = await _form.clienteService.GetAllAsync(null);
            _form.ListClientes.DataSource = clientes;
            _form.dataGridClientesView.DataSource = _form.ListClientes;
            _form.tabControl.SelectTab(_form.tabPageLista);
        }
        private async Task CargarCombo()
        {
            _form.comboLocalidades.DataSource = await _form.localidadService.GetAllAsync( _form.txtFiltro.Text);
            _form.comboLocalidades.DisplayMember = "Nombre";
            _form.comboLocalidades.ValueMember = "Id";
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