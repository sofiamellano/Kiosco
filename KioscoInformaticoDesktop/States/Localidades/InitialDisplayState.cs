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

namespace Desktop.States.Localidades
{
    public class InitialDisplayState : IFormState
    {
        LocalidadesView _form;
        public InitialDisplayState(LocalidadesView form) 
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
      
        public async void OnSearch()
        {
          await UpdateUI();
        }
        public async Task UpdateUI()
        {

            _form.listaLocalidades.DataSource = await _form.localidadService.GetAllAsync(_form.txtFiltro.Text);
            _form.dataGridLocalidades.DataSource = _form.listaLocalidades;
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
