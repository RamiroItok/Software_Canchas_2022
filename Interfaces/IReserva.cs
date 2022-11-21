using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IReserva
    {
        int AltaReserva(BE.Reserva reserva);
        int ModificarReserva(BE.Reserva reserva);
        int BajaReserva(BE.Reserva reserva, bool semana);
        int ModificarReservaPorPrecioCancha(int cancha, float precio);
        List<BE.Reserva> ObtenerReservas();
        DataTable ObtenerReservaCliente();
        DataTable ObtenerReservaVencida();
        DataTable ObtenerReservaClienteFecha(string fecha);
        DataTable ObtenerReservaClienteFechaHora(int idCliente, string fecha, string hora, int idReserva);
        DataTable ObtenerReservaClienteCliente(string cliente);
        DataTable ObtenerReservaFechaCliente(string fecha, string cliente);
        List<string> ObtenerReservaHora(string fecha, string cancha);
        List<BE.Reserva> ObtenerReservaCanchaFecha(int idCancha);
        int PagarDeudaCliente(int idReserva, float seña, float deuda);

    }
}
