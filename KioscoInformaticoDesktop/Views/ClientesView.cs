using Service.Services;
using Microsoft.Reporting.WinForms;
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
    public partial class ClientesView : Form
    {
        IClienteService clienteService = new ClienteService();
        ILocalidadService localidadService = new LocalidadService();
        BindingSource ListClientes = new BindingSource();
        Cliente clienteCurrent;
        public ClientesView()
        {
            InitializeComponent();
            dataGridClientesView.DataSource = ListClientes;
            CargarGrilla();
            CargarCombo();
        }

        private async Task CargarCombo()
        {
            comboLocalidades.DataSource = await localidadService.GetAllAsync();
            comboLocalidades.DisplayMember = "Nombre";
            comboLocalidades.ValueMember = "Id";
        }

        private async Task CargarGrilla()
        {
            var clientes = await clienteService.GetAllAsync(null);
            ListClientes.DataSource = clientes;
            dataGridClientesView.Columns[5].Visible = false;
        }

        private void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (clienteCurrent != null)
            {
                clienteCurrent.Nombre = txtNombre.Text;
                clienteCurrent.Direccion = txtDireccion.Text;
                clienteCurrent.Telefonos = txtTelefonos.Text;
                clienteCurrent.LocalidadId = (int)comboLocalidades.SelectedValue;
                clienteCurrent.FechaNacimiento = dateTimeFechaNacimiento.Value;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {
                var cliente = new Cliente
                {
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefonos = txtTelefonos.Text,
                    LocalidadId = (int)comboLocalidades.SelectedValue,
                    FechaNacimiento = dateTimeFechaNacimiento.Value
                };
                await clienteService.AddAsync(cliente);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteCurrent = null;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            comboLocalidades.SelectedIndex = 0;
            tabControl.SelectTab(tabPageLista);
        }

        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;
            txtNombre.Text = clienteCurrent.Nombre;
            txtDireccion.Text = clienteCurrent.Direccion;
            txtTelefonos.Text = clienteCurrent.Telefonos;
            comboLocalidades.SelectedValue = clienteCurrent.LocalidadId;
            dateTimeFechaNacimiento.Value = clienteCurrent.FechaNacimiento;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)ListClientes.Current;
            if (clienteCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show($"¿Está seguro que desea eliminar el cliente {clienteCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clienteCurrent = (Cliente)ListClientes.Current;
                if (clienteCurrent != null)
                {
                    await clienteService.DeleteAsync(clienteCurrent.Id);
                    await CargarGrilla();
                }
            }
            clienteCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarCliente();
        }

        private async void FiltrarCliente()
        {
            var clientesFiltrados = await clienteService.GetAllAsync(txtFiltro.Text);
            ListClientes.DataSource = clientesFiltrados;
        }


    }
}
