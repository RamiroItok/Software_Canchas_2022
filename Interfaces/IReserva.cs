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
        int BajaReserva(BE.Reserva reserva);
        List<BE.Reserva> ObtenerReservas();
        DataTable ObtenerReservaCliente();
        DataTable ObtenerReservaClienteFecha(string fecha);
        DataTable ObtenerReservaClienteCliente(string cliente);
        DataTable ObtenerReservaFechaCliente(string fecha, string cliente);
        List<string> ObtenerReservaHora(string fecha, string cancha);
        int PagarDeudaCliente(int idReserva, float seña, float deuda);
    }
}
