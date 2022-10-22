using BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ControlCliente
    {
        public int Id { get; set;}
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }

    }
}
