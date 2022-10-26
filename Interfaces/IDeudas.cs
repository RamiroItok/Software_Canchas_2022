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
        int BajaDeudaPorCliente(int idCliente);
        int BajaDeudaPorReserva(int idReserva);
        int ModificarDeuda(int idCliente, DateTime fechaPago);
        DataTable ObtenerDeudaCliente(int idCliente);
        DataTable ListarDeudas();
        DataTable ListarDeudaCliente(string cliente);
    }
}
