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
        int AltaReserva(BE.Reserva reserva);
        int ModificarReserva(BE.Reserva reserva);
        void BajaReserva(BE.Reserva reserva);

    }
}
