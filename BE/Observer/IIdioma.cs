using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Observer
{
    public interface IIdioma
    {
        int Id_Idioma { get; set; }
        string Nombre { get; set; }
        int Default { get; set; }
    }
}
