using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDeudas
    {
        int AltaDeuda(int idReserva, int idCliente, DateTime fechaPago);
        int BajaDeuda(int idCliente);
        int ModificarDeuda(int idCliente, DateTime fechaPago);
        DataTable ObtenerDeudaCliente(int idCliente);
        DataTable ListarDeudas();
    }
}
