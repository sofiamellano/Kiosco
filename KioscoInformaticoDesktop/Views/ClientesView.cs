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
using Desktop.Interfaces;
using Desktop.States.Clientes;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ClientesView : Form
    {
        public IFormState InitialDisplayState;
        public IFormState AddState;
        public IFormState EditState;
        public IFormState DeleteState;
        public IFormState currentState;

        public IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        public IGenericService<Localidad> localidadService = new GenericService<Localidad>();
        public BindingSource ListClientes = new BindingSource();
        public Cliente clienteCurrent;
        public ClientesView()
        {
            InitializeComponent();

            InitialDisplayState = new InitialDisplayState(this);
            AddState = new AddState(this);
            EditState = new EditState(this);
            DeleteState = new DeleteState(this);

            currentState = InitialDisplayState;
            currentState.UpdateUI();
            tabControl.Selecting += tabControl_Selecting;
            dataGridClientesView.DataSource = ListClientes;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Si el usuario intenta ir a la pestaña de agregar/editar manualmente
            if (e.TabPage == tabPageAgregarEditar)
            {
                // Solo permite si el estado actual es AddState o EditState
                if (!(currentState is AddState) && !(currentState is EditState))
                {
                    e.Cancel = true;
                }
            }
        }

        public void SetState(IFormState state)
        {
            currentState = state ?? throw new ArgumentNullException(nameof(state), "El estado no puede ser null");
        }
        private void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            SetState(AddState);
            currentState.OnAdd();
            //tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            currentState.OnSave();
            //if (clienteCurrent != null)
            //{
            //    clienteCurrent.Nombre = txtNombre.Text;
            //    clienteCurrent.Direccion = txtDireccion.Text;
            //    clienteCurrent.Telefonos = txtTelefonos.Text;
            //    clienteCurrent.LocalidadId = (int)comboLocalidades.SelectedValue;
            //    clienteCurrent.FechaNacimiento = dateTimeFechaNacimiento.Value;
            //    await clienteService.UpdateAsync(clienteCurrent);
            //    clienteCurrent = null;
            //}
            //else
            //{
            //    var cliente = new Cliente
            //    {
            //        Nombre = txtNombre.Text,
            //        Direccion = txtDireccion.Text,
            //        Telefonos = txtTelefonos.Text,
            //        LocalidadId = (int)comboLocalidades.SelectedValue,
            //        FechaNacimiento = dateTimeFechaNacimiento.Value
            //    };
            //    await clienteService.AddAsync(cliente);
            //}
            //await CargarGrilla();
            //txtNombre.Text = string.Empty;
            //txtDireccion.Text = string.Empty;
            //txtTelefonos.Text = string.Empty;
            //tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            currentState.OnCancel();
            //clienteCurrent = null;
            //txtNombre.Text = string.Empty;
            //txtDireccion.Text = string.Empty;
            //txtTelefonos.Text = string.Empty;
            //comboLocalidades.SelectedIndex = 0;
            //tabControl.SelectTab(tabPageLista);
        }

        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            SetState(EditState);
            currentState.OnEdit();
            //clienteCurrent = (Cliente)ListClientes.Current;
            //txtNombre.Text = clienteCurrent.Nombre;
            //txtDireccion.Text = clienteCurrent.Direccion;
            //txtTelefonos.Text = clienteCurrent.Telefonos;
            //comboLocalidades.SelectedValue = clienteCurrent.LocalidadId;
            //dateTimeFechaNacimiento.Value = clienteCurrent.FechaNacimiento;
            //tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            SetState(DeleteState);
            currentState.OnDelete();
            //clienteCurrent = (Cliente)ListClientes.Current;
            //if (clienteCurrent == null)
            //{
            //    MessageBox.Show("Debe seleccionar un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //var result = MessageBox.Show($"¿Está seguro que desea eliminar el cliente {clienteCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    clienteCurrent = (Cliente)ListClientes.Current;
            //    if (clienteCurrent != null)
            //    {
            //        await clienteService.DeleteAsync(clienteCurrent.Id);
            //        await CargarGrilla();
            //    }
            //}
            //clienteCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           currentState.OnSearch();
            
        }

        //private async void FiltrarCliente()
        //{
        //    var clientesFiltrados = await clienteService.GetAllAsync(txtFiltro.Text);
        //    ListClientes.DataSource = clientesFiltrados;
        //}


    }
}
