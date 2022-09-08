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
        List<UsuarioDTO> ListarUsuarioDTO();
        List<BE.Usuario> ListarUsuario();
        List<UsuarioDTO> ObtenerUsuarioDTODesencriptado();
        List<BE.Usuario> ObtenerUsuarioDesencriptado();
        int AltaUsuario(BE.Usuario usuario);
        void BajaUsuario(BE.Usuario usuario);
        int ModificarUsuario(BE.Usuario usuario);
        void Login(string nombre_usuario, string contraseña);
        void Logout();
        List<BE.DTOs.UsuarioDTO> ListarBloqueados();
        int CambiarContraseña(UsuarioDTO usuario, string passwordActual, string nuevaPassword);

    }
}
