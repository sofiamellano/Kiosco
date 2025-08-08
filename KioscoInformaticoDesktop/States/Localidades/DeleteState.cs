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
    public class DeleteState : IFormState
    {
        LocalidadesView _form;
        public DeleteState(LocalidadesView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
        public async void OnDelete() 
        {
            var localidad = (Localidad)_form.listaLocalidades.Current;
            var result = MessageBox.Show($"¿Está seguro que desea eliminar la localidad {localidad.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                await _form.localidadService.DeleteAsync(localidad.Id);
                _form.SetState(_form.InitialDisplayState);
                _form.currentState.UpdateUI();
            }
            else
            {
                _form.SetState(_form.InitialDisplayState);
            }
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
