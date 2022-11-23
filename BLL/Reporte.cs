using Interfaces;
using Interfaces.Observer;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Reporte : IReporte
    {
        #region Inyección de dependencias
        private readonly DAL.Reporte _reporteDAL;        

        public Reporte()
        {
            _reporteDAL = new DAL.Reporte();
        }
        #endregion

        public List<BE.DTOs.ReporteCanchaMasReservadaDTO> CanchaMasReservadaDelMes()
        {
            try
            {
                List<BE.DTOs.ReporteCanchaMasReservadaDTO> canchas = _reporteDAL.CanchaMasReservadaDelMes();
                return canchas;
            }
            catch (Exception ex) 
            { 
                throw new Exception (ex.Message); 
            }
        }

        public List<BE.DTOs.ReporteCanchaMasReservadaDTO> HorarioMasReservadoDelMes()
        {
            try
            {
                List<BE.DTOs.ReporteCanchaMasReservadaDTO> canchas = _reporteDAL.HorarioMasReservadoDelMes();
                return canchas;
            }
            catch (Exception ex) 
            { 
                throw new Exception (ex.Message); 
            }
        }
    }
}
