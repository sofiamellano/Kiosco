using Desktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
using Service.Models;
using Service.Services;
using System.Data;

namespace KioscoInformaticoDesktop.Views
{
    public partial class HistoricoVentasView : Form
    {
        GenericService<Venta> _ventaService = new GenericService<Venta>();
        List<Venta> ventas = new List<Venta>();
        public HistoricoVentasView()
        {
            InitializeComponent();
            LoadData();

        }

        private async void LoadData()
        {
            ventas = await _ventaService.GetAllAsync();
            DisplayDataGrid();
            CalculeTotal();
        }

        private void CalculeTotal()
        {
            if (checkFiltrado.Checked)
            {
                numericTotalFacturado.Value = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value &&
                                                            venta.Fecha <= dateTimeHasta.Value).Sum(venta => venta.Total);
            }
            else
            {
                numericTotalFacturado.Value = ventas.Sum(venta => venta.Total);
            }
        }

        private void DisplayDataGrid()
        {
            dataGridVentas.DataSource = ventas;
            dataGridVentas.OcultarColumnas(new string[] { "Id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void checkFiltrado_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltrado.Enabled = checkFiltrado.Checked;
            if (checkFiltrado.Checked)
            {
                dateTimeDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateTimeHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                DisplayDataGridFilter();
                CalculeTotal();
            }
            else
            {
                DisplayDataGrid();
                CalculeTotal();
            }

        }

        private void DisplayDataGridFilter()
        {

            dataGridVentas.DataSource = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value &&
                                                            venta.Fecha <= dateTimeHasta.Value).ToList();
            dataGridVentas.OcultarColumnas(new string[] { "Id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DisplayDataGridFilter();
            CalculeTotal();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var TituloReporte = "Listado de Ventas";
            var ventasAImprimir = ventas;
            if (checkFiltrado.Checked)
            {
                ventasAImprimir = ventas.Where(venta => venta.Fecha >= dateTimeDesde.Value &&
                                                            venta.Fecha <= dateTimeHasta.Value).ToList();
                TituloReporte = $"Listado de Ventas desde {dateTimeDesde.Value.ToShortDateString()} hasta {dateTimeHasta.Value.ToShortDateString()}";
            }
            var HistoricoVentasViewReport = new HistoricoVentasViewReport(ventasAImprimir, TituloReporte);
            HistoricoVentasViewReport.ShowDialog();
        }
    }
}
