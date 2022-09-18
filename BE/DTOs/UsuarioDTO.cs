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

        public int Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public IIdioma Idioma { get; set; }
        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }

        public static UsuarioDTO FillObject(Usuario usuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO()
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Nombre_Usuario = usuario.Nombre_Usuario,
                Telefono = usuario.Telefono,
            };

            return usuarioDTO;
        }

        public static List<UsuarioDTO> FillListDTO(List<Usuario> usuarios)
        {
            List<UsuarioDTO> usuarioDTO = new List<UsuarioDTO>();
            foreach (Usuario usuario in usuarios)
            {
                usuarioDTO.Add(FillObject(usuario));
            }
            return usuarioDTO;
        }
    }
}
