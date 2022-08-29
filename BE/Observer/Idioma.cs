using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Observer
{
    public class Idioma : IIdioma
    {
        public int Id_Idioma { get; set; }
        public string Nombre { get; set; }
        public int Default { get; set; }
    }
}
