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
        void BajaCliente(BE.Cliente Cliente);
        List<BE.Cliente> ObtenerClientes();

    }
}
