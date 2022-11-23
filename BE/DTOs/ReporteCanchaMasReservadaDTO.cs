using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DTOs
{
    public class ReporteCanchaMasReservadaDTO
    {
        public int Id_Cancha { get; set; }
        public string TipoCancha { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
    }
}
