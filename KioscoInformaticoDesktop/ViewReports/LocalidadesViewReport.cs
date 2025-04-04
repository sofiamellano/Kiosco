using Service.Services;
using Microsoft.Reporting.WinForms;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.ViewReports
{
    public partial class LocalidadesViewReport : Form
    {
        ReportViewer reporte;
        ILocalidadService localidadService = new LocalidadService();
        public LocalidadesViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;
            
            Controls.Add(reporte);
        }

        private async void LocalidadesViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.LocalidadesReport.rdlc";
            var localidades = await localidadService.GetAllAsync();
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSLocalidades", localidades));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
