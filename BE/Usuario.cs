using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Puesto { get; set; }
        public int Dni { get; set; }
        public string Sexo { get; set; }
        public string Mail { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Calle { get; set; }
        public int Numero{ get; set; }
        public string Localidad { get; set; }
        public int Telefono { get; set; }
        public string Tipo{ get; set; }
        public string Estado { get; set; }
        public int DVH { get; set; }

    }
}
