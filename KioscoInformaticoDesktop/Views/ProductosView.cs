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
using System.Windows.Controls;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProductosView : Form
    {
        IGenericService<Producto> productoService = new GenericService<Producto>();
        BindingSource ListProductos = new BindingSource();
        List<Producto> ListaAFiltrar = new List<Producto>();
        Producto productoCurrent;

        public ProductosView()
        {
            InitializeComponent();
            dataGridProductosView.DataSource = ListProductos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ListProductos.DataSource = await productoService.GetAllAsync();
            ListaAFiltrar = (List<Producto>)ListProductos.DataSource;

        }

        private void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)ListProductos.Current;
            txtNombre.Text = productoCurrent.Nombre;
            numericPrecio.Value = productoCurrent.Precio;
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (productoCurrent != null)
            {
                productoCurrent.Nombre = txtNombre.Text;
                productoCurrent.Precio = numericPrecio.Value;
                await productoService.UpdateAsync(productoCurrent);
                productoCurrent = null;
            }
            else
            {
                decimal precio = numericPrecio.Value;
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = precio
                };
                await productoService.AddAsync(producto);

            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            numericPrecio.Value = 0;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                productoCurrent = ListProductos.Current as Producto;
                if (productoCurrent != null)
                {
                    await productoService.DeleteAsync(productoCurrent.Id);
                    await CargarGrilla();
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void FiltrarProductos()
        {
            var productosFiltrados = ListaAFiltrar.Where(p => p.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();
            ListProductos.DataSource = productosFiltrados;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }
    }
}
