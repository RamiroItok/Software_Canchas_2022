using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICliente
    {
        int AltaCliente(BE.Cliente cliente);
        int ModificarCliente(BE.Cliente cliente);
        int BajaCliente(int idCliente);
        List<BE.Cliente> ObtenerClientes();

    }
}
