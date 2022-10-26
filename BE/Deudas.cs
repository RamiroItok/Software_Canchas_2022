using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Deudas
    {
        public int Id { get; set; }
        public int Id_Reserva { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public int DVH { get; set; }
    }
}
