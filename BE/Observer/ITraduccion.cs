using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Observer
{
    public interface ITraduccion
    {
        IEtiqueta Id_Etiqueta { get; set; }
        string Texto { get; set; }
    }
}
