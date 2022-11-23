using Interfaces;
using Interfaces.Observer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Canchas_2022
{
    public partial class Informes : Form
    {
        private readonly IReporte _iReporte;
        private readonly ITraductor _iTraductor;
        public Informes(IReporte reporte, ITraductor traductor)
        {
            InitializeComponent();
            _iReporte = reporte;
            _iTraductor = traductor;
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            ReporteCanchaMasReservadaPorMes();
            ReporteHorarioMasReservadoPorMes();
        }

        private void ReporteCanchaMasReservadaPorMes()
        {
            try
            {
                List<BE.DTOs.ReporteCanchaMasReservadaDTO> canchas = _iReporte.CanchaMasReservadaDelMes();

                reporteCanchaMasReservada.Reset();

                ReportDataSource reporte = new ReportDataSource();
                reporte.Name = "DataSetCanchaMasReservada";
                reporte.Value = canchas;
                reporteCanchaMasReservada.LocalReport.DataSources.Add(reporte);
                reporteCanchaMasReservada.LocalReport.ReportEmbeddedResource = "Software_Canchas_2022.ReporteCanchaMasReservadaDelMes.rdlc";
                reporteCanchaMasReservada.LocalReport.Refresh();
                reporteCanchaMasReservada.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReporteHorarioMasReservadoPorMes()
        {
            try
            {
                List<BE.DTOs.ReporteCanchaMasReservadaDTO> canchas = _iReporte.HorarioMasReservadoDelMes();

                reporteHorarioMasReservadoDelMes.Reset();

                ReportDataSource reporte = new ReportDataSource();
                reporte.Name = "DataSetHorarioMasReservado";
                reporte.Value = canchas;
                reporteHorarioMasReservadoDelMes.LocalReport.DataSources.Add(reporte);
                reporteHorarioMasReservadoDelMes.LocalReport.ReportEmbeddedResource = "Software_Canchas_2022.ReporteHorarioMasReservadoDelMes.rdlc";
                reporteHorarioMasReservadoDelMes.LocalReport.Refresh();
                reporteHorarioMasReservadoDelMes.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
