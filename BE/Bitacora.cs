using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bitacora
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Criticidad { get; set; }
        public int DVH { get; set; }
    }
}
