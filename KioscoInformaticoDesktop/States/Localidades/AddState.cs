using Desktop.Interfaces;
using KioscoInformaticoDesktop;
using KioscoInformaticoDesktop.Views;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Localidades
{
    public class AddState : IFormState
    {
        LocalidadesView _form;
        public AddState(LocalidadesView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
        public void OnCancel()
        {
            _form.txtNombre.Clear();
            _form.SetState(_form.InitialDisplayState);
            _form.currentState.UpdateUI();
        }
        public async void OnSave()
        {
            if (string.IsNullOrEmpty(_form.txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var localidad = new Localidad
            {
                Nombre = _form.txtNombre.Text
            };

            await _form.localidadService.AddAsync(localidad);
            _form.SetState(_form.InitialDisplayState);
            await _form.currentState.UpdateUI();
        }
        public Task UpdateUI()
        {
            _form.txtNombre.Clear();
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
