using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Observer
{
    public class Etiqueta : IEtiqueta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
