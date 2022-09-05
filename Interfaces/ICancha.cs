using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICancha
    {
        int AltaCancha(BE.Cancha cancha);
        int ModificarCancha(BE.Cancha cancha);
        int BajaCancha(int idCancha);
        List<BE.Cancha> ObtenerCanchas();
    }
}
