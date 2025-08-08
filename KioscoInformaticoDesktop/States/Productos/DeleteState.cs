﻿using Desktop.Interfaces;
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
    public class DeleteState : IFormState
    {
        ProductosView _form;
        public DeleteState(ProductosView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser null");
        }
        public async void OnDelete() 
        {
            var producto = (Producto)_form.ListProductos.Current;
            var result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _form.productoCurrent = _form.ListProductos.Current as Producto;
                if (_form.productoCurrent != null)
                {

                    await _form.productoService.DeleteAsync(_form.productoCurrent.Id);
                    _form.SetState(_form.InitialDisplayState);
                    _form.currentState.UpdateUI();
                }

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
