using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Reserva
    {
        public int Id_Reserva { get; set; }
        public int Id_Cancha { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Forma_Pago { get; set; }
        public float Seña { get; set; }
        public float Subtotal { get; set; }
        public float Total { get; set; }
        public int DVH { get; set; }
    }
}
