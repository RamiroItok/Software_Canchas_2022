using System;
using System.Collections.Generic;
using BE.Observer;
using BE.Composite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DTOs
{
    public class UsuarioDTO
    {
        List<Componente> _permisos;
        public UsuarioDTO()
        {
            _permisos = new List<Componente>();
        }

        public int Id_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public IIdioma Idioma { get; set; }
        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }
    }
}
