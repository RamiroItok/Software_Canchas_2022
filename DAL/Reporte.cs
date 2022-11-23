using DAL.Conexion;
using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Reporte : Acceso
    {
        #region Inyección de dependencias
        private readonly Fill _fill;
        public Reporte()
        {
            _fill = new Fill();
        }
        #endregion

        #region CONSULTAS
        private const string CANCHA_MAS_RESERVADA_DEL_MES = @"SELECT Id_Cancha, c.Tipo, COUNT(Tipo) AS Cantidad, Fecha, Hora
                                                            FROM Reserva r
                                                            INNER JOIN Cancha c ON c.Id = r.Id_Cancha
                                                            WHERE MONTH(Fecha) = MONTH(GETDATE()) 
                                                            GROUP BY Id_Cancha, Tipo, Fecha, Hora
                                                            ORDER BY Cantidad DESC";

        private const string HORARIO_MAS_RESERVADO_DEL_MES = @"SELECT r.Hora, Count(r.Hora) as Cantidad
                                                             FROM Reserva r
                                                             INNER JOIN Cancha c ON c.Id = r.Id_Cancha
                                                             WHERE MONTH(Fecha) = MONTH(GETDATE()) 
                                                             GROUP BY r.Hora
                                                             ORDER BY r.Hora ASC";

        #endregion

        public List<BE.DTOs.ReporteCanchaMasReservadaDTO> CanchaMasReservadaDelMes()
        {
            try
            {
                SelectCommandText = String.Format(CANCHA_MAS_RESERVADA_DEL_MES);
                DataSet ds = ExecuteNonReader();

                List<BE.DTOs.ReporteCanchaMasReservadaDTO> canchas = new List<BE.DTOs.ReporteCanchaMasReservadaDTO>();

                if (ds.Tables[0].Rows.Count > 0)
                    canchas = _fill.FillListCanchaMasReservada(ds);

                return canchas;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.DTOs.ReporteCanchaMasReservadaDTO> HorarioMasReservadoDelMes()
        {
            try
            {
                SelectCommandText = String.Format(HORARIO_MAS_RESERVADO_DEL_MES);
                DataSet ds = ExecuteNonReader();

                List<BE.DTOs.ReporteCanchaMasReservadaDTO> canchas = new List<BE.DTOs.ReporteCanchaMasReservadaDTO>();

                if (ds.Tables[0].Rows.Count > 0)
                    canchas = _fill.FillListCanchaMasReservada(ds);

                return canchas;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }
    }
}
