using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICliente
    {
        int AltaCliente(BE.Cliente cliente);
        int ModificarCliente(BE.Cliente cliente);
        int BajaCliente(BE.Cliente Cliente);
        List<BE.Cliente> ObtenerClientes();
        DataTable ObtenerNombreClientes();
        int ObtenerClientePorId(int id);

    }
}
