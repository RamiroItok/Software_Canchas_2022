using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBitacora
    {
        int AgregarEvento(BE.Bitacora bitacora);
        int EliminarBitacora(string fechaIni, string fechaFin);
        List<BE.Bitacora> ListarEventos();
        List<BE.Bitacora> ListarEventoBetween();
        List<BE.Bitacora> ListarEventoBetweenUsuario();
        List<BE.Bitacora> ListarEventoUsuario();
        List<BE.Bitacora> ListarEventoCritFecha();
        List<BE.Bitacora> ListarEventoCrit();
        List<BE.Bitacora> ListarEventoCritUsu();
        List<BE.Bitacora> ListarEventoFechaUsuCrit();
        List<BE.Bitacora> LlenarUsuario();
    }
}
