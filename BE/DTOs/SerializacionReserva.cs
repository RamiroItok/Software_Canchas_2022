using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DTOs
{
    public class SerializacionReserva
    {
        public int Id_Reserva { get; set; }
        public string Tipo_Cancha { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public bool Semana { get; set; }
        public string Forma_Pago { get; set; }
        public float Seña { get; set; }
        public float Total { get; set; }
        public float Pagar { get; set; }
        public string Pagado { get; set; }

        public static SerializacionReserva FillObject(Reserva reserva, string tipoCancha, string nombreCliente, string apellidoCliente)
        {
            SerializacionReserva serializacionReserva = new SerializacionReserva()
            {
                Id_Reserva = reserva.Id,
                Tipo_Cancha = tipoCancha,
                NombreCliente = nombreCliente,
                ApellidoCliente = apellidoCliente,
                Fecha = reserva.Fecha,
                Hora = reserva.Hora,
                Semana = reserva.Semana,
                Forma_Pago = reserva.Forma_Pago,
                Seña = reserva.Seña,
                Total = reserva.Total,
                Pagar = reserva.Pagar,
                Pagado = reserva.Pagado
            };

            return serializacionReserva;
        }
    }
}
