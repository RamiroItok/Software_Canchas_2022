using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IControlReserva
    {
        int AltaControlReserva(BE.Reserva reserva);
        int ActualizarControlReserva(BE.Reserva reserva);
        int BajaReservaControlReserva(BE.Reserva reserva);
        List<BE.ControlReserva> ObtenerControlReservas();
    }
}
