using BE.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Observer
{
    public interface ITraductor
    {
        IList<IIdioma> ObtenerIdiomas();
        IIdioma ObtenerIdiomaDefault();
        IDictionary<string, ITraduccion> ObtenerTraducciones(IIdioma idioma);
        int AltaIdioma(BE.Observer.Idioma idioma);
        int BajaIdioma(BE.Observer.Idioma idioma);
        int AltaTraduccion(BE.Observer.IIdioma idioma, BE.Observer.Traduccion traduccion);
        int ModificarTraduccion(BE.Observer.Traduccion traduccion);
        List<BE.Observer.Etiqueta> GetEtiquetas();
        List<BE.Observer.Traduccion> GetTraduccionesPorIdioma(int Id_Idioma);
        BE.Observer.Traduccion GetTraduccionId(int Id_Traduccion);
    }
}
