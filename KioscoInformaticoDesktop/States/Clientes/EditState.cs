using Desktop.Interfaces;
using KioscoInformaticoDesktop;
using KioscoInformaticoDesktop.Views;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Clientes
{
    public class EditState : IFormState
    {
        ClientesView _form;
        public EditState(ClientesView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
        public void OnCancel()
        {
            _form.txtNombre.Text = string.Empty;
            _form.txtDireccion.Text = string.Empty;
            _form.txtTelefonos.Text = string.Empty;
            _form.comboLocalidades.SelectedIndex = 0;
            _form.SetState(_form.InitialDisplayState);
            _form.currentState.UpdateUI();
        }
        public async void OnSave()
        {
            _form.clienteCurrent.Nombre = _form.txtNombre.Text;
            _form.clienteCurrent.Direccion = _form.txtDireccion.Text;
            _form.clienteCurrent.Telefonos = _form.txtTelefonos.Text;
            _form.clienteCurrent.LocalidadId = (int)_form.comboLocalidades.SelectedValue;
            _form.clienteCurrent.FechaNacimiento = _form.dateTimeFechaNacimiento.Value;


            await _form.clienteService.UpdateAsync(_form.clienteCurrent);
            _form.SetState(_form.InitialDisplayState);
            await _form.currentState.UpdateUI();
        }
        public Task UpdateUI()
        {
            _form.clienteCurrent = (Cliente)_form.ListClientes.Current;
            _form.txtNombre.Text = _form.clienteCurrent.Nombre;
            _form.txtDireccion.Text = _form.clienteCurrent.Direccion;
            _form.txtTelefonos.Text = _form.clienteCurrent.Telefonos;
            _form.comboLocalidades.SelectedValue = _form.clienteCurrent.LocalidadId;
            _form.dateTimeFechaNacimiento.Value = _form.clienteCurrent.FechaNacimiento;
            _form.tabControl.SelectTab(_form.tabPageAgregarEditar);
            return Task.CompletedTask;
        }
        public void OnEdit()
        {
            UpdateUI();
        }

        public void OnGoOut() { }
        public void OnDelete() { }
        public void OnSearch() { }
        public void OnAdd() { }
    }
}