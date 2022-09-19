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
        List<BE.Reserva> ObtenerReservas();
        DataTable ObtenerReservaCliente();
        DataTable ObtenerReservaClienteFecha(string fecha);
        DataTable ObtenerReservaClienteCliente(string cliente);
        DataTable ObtenerReservaFechaCliente(string fecha, string cliente);
        int AltaReserva(BE.Reserva reserva);
        int ModificarReserva(BE.Reserva reserva);
        void BajaReserva(BE.Reserva reserva);
        List<string> ObtenerReservaHora(string fecha, string cancha);
    }
}
