using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICancha
    {
        int AltaCancha(BE.Cancha cancha);
        int ModificarCancha(BE.Cancha cancha);
        int BajaCancha(BE.Cancha Cancha);
        List<BE.Cancha> ObtenerCanchas();
        DataTable ObtenerTipoCanchas();
        DataTable ObtenerIdCanchas(string tipo);
        float ObtenerPrecio(string id);
        int ObtenerCanchaPorId(int id);
        string ObtenerTipoCanchaPorId(int id);
    }
}
