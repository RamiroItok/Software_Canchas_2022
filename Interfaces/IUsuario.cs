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
        List<UsuarioDTO> ListarUsuario();
        List<UsuarioDTO> ObtenerUsuarioDesencriptado();
        int AltaUsuario(BE.Usuario usuario);
        int BajaUsuario(BE.Usuario usuario);
        int ModificarUsuario(BE.Usuario usuario);
        void Login(string nombre_usuario, string contraseña);
        void Logout();
        List<BE.DTOs.UsuarioDTO> ListarBloqueados();
        int CambiarContraseña(UsuarioDTO usuario, string passwordActual, string nuevaPassword);

    }
}
