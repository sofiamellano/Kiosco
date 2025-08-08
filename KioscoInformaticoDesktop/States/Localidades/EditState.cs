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
    public class EditState : IFormState
    {
        LocalidadesView _form;
        public EditState(LocalidadesView form)
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

            _form.localidadCurrent.Nombre = _form.txtNombre.Text;


            await _form.localidadService.UpdateAsync(_form.localidadCurrent);
            _form.SetState(_form.InitialDisplayState);
            await _form.currentState.UpdateUI();
        }
        public Task UpdateUI()
        {
            _form.localidadCurrent = _form.dataGridLocalidades.CurrentRow.DataBoundItem as Localidad;
            _form.txtNombre.Text = _form.localidadCurrent.Nombre;
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
