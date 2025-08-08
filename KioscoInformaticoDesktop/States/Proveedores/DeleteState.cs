using Desktop.Interfaces;
using KioscoInformaticoDesktop;
using KioscoInformaticoDesktop.Views;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Proveedores
{
    public class DeleteState : IFormState
    {
        ProveedoresView _form;
        public DeleteState(ProveedoresView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
        public async void OnDelete() 
        {
            _form.proveedorCurrent = (Proveedor)_form.ListProveedores.Current;
            if (_form.proveedorCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show($"¿Está seguro que desea eliminar el proveedor {_form.proveedorCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (_form.proveedorCurrent != null)
                {

                    await _form.proveedorService.DeleteAsync(_form.proveedorCurrent.Id);
                    _form.SetState(_form.InitialDisplayState);
                    _form.currentState.UpdateUI();
                }
            }
            else
            {
                _form.SetState(_form.InitialDisplayState);
            }
            _form.proveedorCurrent = null;
        }
        public Task UpdateUI()
        {
            return Task.CompletedTask;
        }

        public void OnAdd(){}
        public void OnCancel(){}
        public void OnEdit(){}
        public void OnGoOut(){}
        public void OnSave(){}
        public void OnSearch(){}
    }
}