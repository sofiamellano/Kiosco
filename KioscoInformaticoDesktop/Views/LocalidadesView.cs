using Service.Services;
using Service.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class LocalidadesView : Form
    {
        ILocalidadService localidadService = new LocalidadService();
        BindingSource listaLocalidades = new BindingSource();
        Localidad localidadCurrent;

        public LocalidadesView()
        {
            InitializeComponent();
            dataGridLocalidades.DataSource = listaLocalidades;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaLocalidades.DataSource = await localidadService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localidadCurrent != null)
            {
                localidadCurrent.Nombre = txtNombre.Text;
                await localidadService.UpdateAsync(localidadCurrent);
                localidadCurrent = null;
            }
            else
            {
                var localidad = new Localidad
                {
                    Nombre = txtNombre.Text
                };
                await localidadService.AddAsync(localidad);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)listaLocalidades.Current;
            txtNombre.Text = localidadCurrent.Nombre;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)listaLocalidades.Current;
            var result = MessageBox.Show($"¿Está seguro que desea eliminar la localidad {localidadCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await localidadService.DeleteAsync(localidadCurrent.Id);
                await CargarGrilla();
            }
            localidadCurrent = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            localidadCurrent = null;
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarLocalidades();
        }

        private async void FiltrarLocalidades()
        {
            listaLocalidades.DataSource = await localidadService.GetAllAsync(txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
