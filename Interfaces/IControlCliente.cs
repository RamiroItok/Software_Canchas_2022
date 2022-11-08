using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IControlCliente
    {
        int AltaControlCliente(BE.Cliente cliente);
        int ActualizarControlCliente(BE.Cliente cliente);
        int BajaControlCliente(BE.Cliente cliente);
        int RestaurarCliente(BE.Cliente cliente);
        List<BE.ControlCliente> ObtenerControlCliente();
        DataTable ObtenerControlClientePorCliente(int cliente);
        int ObtenerControlClientePorId(int id);
    }
}
