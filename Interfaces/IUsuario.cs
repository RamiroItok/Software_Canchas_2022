using BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUsuario
    {
        int AltaUsuario(BE.Usuario usuario);
        int ModificarUsuario(BE.Usuario usuario);
        int BajaUsuario(BE.Usuario usuario);
        List<UsuarioDTO> ListarUsuarioDTO();
        List<BE.Usuario> ListarUsuario();
        List<UsuarioDTO> ObtenerUsuarioDTODesencriptado();
        List<BE.Usuario> ObtenerUsuarioDesencriptado();
        void Login(string nombre_usuario, string contraseña);
        void Logout();
        void Desbloquear(string nombre);
        List<BE.DTOs.UsuarioDTO> ListarBloqueados();
        int CambiarContraseña(UsuarioDTO usuarioDTO, string passwordActual, string nuevaPassword);

    }
}
