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
using Desktop.Interfaces;
using System.Windows.Controls;
using Desktop.States.Proveedores;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProveedoresView : Form
    {
        public IFormState InitialDisplayState;
        public IFormState AddState;
        public IFormState EditState;
        public IFormState DeleteState;
        public IFormState currentState;

       public IGenericService<Proveedor> proveedorService = new GenericService<Proveedor>();
       public IGenericService<Localidad> localidadService = new GenericService<Localidad>();
       public BindingSource ListProveedores = new BindingSource();
       public Proveedor proveedorCurrent;
        public ProveedoresView()
        {
            InitializeComponent();

            InitialDisplayState = new InitialDisplayState(this);
            AddState = new AddState(this);
            EditState = new EditState(this);
            DeleteState = new DeleteState(this);

            currentState = InitialDisplayState;
            currentState.UpdateUI();
            tabControl1.Selecting += tabControl_Selecting;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Si el usuario intenta ir a la pestaña de agregar/editar manualmente
            if (e.TabPage == tabPageEditarAgregar)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SetState(AddState);
            currentState.OnAdd();
            //tabControl1.SelectTab(tabPageEditarAgregar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            currentState.OnSave();
            //if (proveedorCurrent != null)
            //{
            //    proveedorCurrent.Nombre = txtNombre.Text;
            //    proveedorCurrent.Direccion = txtDireccion.Text;
            //    proveedorCurrent.Telefonos = txtTelefonos.Text;
            //    proveedorCurrent.Cbu = txtCbu.Text;
            //    proveedorCurrent.LocalidadId = (int)comboLocalidades.SelectedValue;
            //    await proveedorService.UpdateAsync(proveedorCurrent);
            //    proveedorCurrent = null;
            //}
            //else
            //{
            //    var proveedor = new Proveedor
            //    {
            //        Nombre = txtNombre.Text,
            //        Direccion = txtDireccion.Text,
            //        Telefonos = txtTelefonos.Text,
            //        Cbu = txtCbu.Text,
            //        LocalidadId = (int)comboLocalidades.SelectedValue,
            //    };
            //    await proveedorService.AddAsync(proveedor);
            //}
            //await CargarGrilla();
            //txtNombre.Text = string.Empty;
            //txtDireccion.Text = string.Empty;
            //txtTelefonos.Text = string.Empty;
            //txtCbu.Text = string.Empty;
            //tabControl1.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            currentState.OnCancel();
            //proveedorCurrent = null;
            //txtNombre.Text = string.Empty;
            //txtDireccion.Text = string.Empty;
            //txtTelefonos.Text = string.Empty;
            //txtCbu.Text = string.Empty;
            //tabControl1.SelectTab(tabPageLista);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SetState(EditState);
            currentState.OnEdit();
            //proveedorCurrent = (Proveedor)ListProveedores.Current;
            //txtNombre.Text = proveedorCurrent.Nombre;
            //txtDireccion.Text = proveedorCurrent.Direccion;
            //txtTelefonos.Text = proveedorCurrent.Telefonos;
            //txtCbu.Text = proveedorCurrent.Cbu;
            //comboLocalidades.SelectedValue = proveedorCurrent.LocalidadId;
            //tabControl1.SelectTab(tabPageEditarAgregar);
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            SetState(DeleteState);
            currentState.OnDelete();
            //proveedorCurrent = (Proveedor)ListProveedores.Current;
            //if (proveedorCurrent == null)
            //{
            //    MessageBox.Show("Debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //var result = MessageBox.Show($"¿Está seguro que desea eliminar el proveedor {proveedorCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    proveedorCurrent = (Proveedor)ListProveedores.Current;
            //    if (proveedorCurrent != null)
            //    {
            //        await proveedorService.DeleteAsync(proveedorCurrent.Id);
            //        await CargarGrilla();
            //    }
            //}
            //proveedorCurrent = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            currentState.OnSearch();
        }

    }
}
