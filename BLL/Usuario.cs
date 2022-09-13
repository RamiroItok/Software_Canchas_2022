using BE.DTOs;
using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario : IUsuario
    {
        private readonly DAL.Usuario _UsuarioDAL;
        private readonly Servicios.Encriptacion _encriptacion;
        private readonly DAL.Observer.Idioma _IdiomaDAL;
        private readonly DAL.Composite.Permiso _permisoDAL;

        public Usuario()
        {
            _UsuarioDAL = new DAL.Usuario();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _encriptacion = new Servicios.Encriptacion();
            _permisoDAL = new DAL.Composite.Permiso();
        }

        public int AltaUsuario(BE.Usuario usuario)
        {
            try
            {
                ValidarUsuario(usuario);
                usuario.Nombre = _encriptacion.Encriptar_AES(usuario.Nombre);
                usuario.Apellido = _encriptacion.Encriptar_AES(usuario.Apellido);
                usuario.Nombre_Usuario = _encriptacion.Encriptar_AES(usuario.Nombre_Usuario);
                usuario.Contraseña = _encriptacion.Encriptar_MD5(usuario.Contraseña);
                usuario.Puesto = usuario.Puesto;
                usuario.Dni = usuario.Dni;
                usuario.Sexo = usuario.Sexo;
                usuario.Mail = usuario.Mail;
                usuario.Telefono = usuario.Telefono;
                usuario.Tipo = usuario.Tipo;
                usuario.Estado = 0;
                usuario.DVH = 0;

                return _UsuarioDAL.Alta_Usuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarUsuario(BE.Usuario usuario)
        {
            try
            {
                usuario.Nombre = _encriptacion.Encriptar_AES(usuario.Nombre);
                usuario.Apellido = _encriptacion.Encriptar_AES(usuario.Apellido);
                usuario.Nombre_Usuario = _encriptacion.Encriptar_AES(usuario.Nombre_Usuario);
                usuario.Puesto = usuario.Puesto;
                usuario.Dni = usuario.Dni;
                usuario.Sexo = usuario.Sexo;
                usuario.Mail = usuario.Mail;
                usuario.Telefono = usuario.Telefono;
                usuario.Tipo = usuario.Tipo;

                return _UsuarioDAL.Modificar_Usuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void BajaUsuario(BE.Usuario usuario)
        {
            try
            {
                _UsuarioDAL.Baja_Usuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Login(string nombre_usuario, string contraseña)
        {
            try
            {
                if (Sesion.GetInstance() != null) throw new Exception("Ya hay una instancia de un usuario creada.");
                if (string.IsNullOrWhiteSpace(nombre_usuario) || string.IsNullOrWhiteSpace(contraseña)) throw new Exception("Se deben completar los campos");

                string nomUsu_Encriptado = _encriptacion.Encriptar_AES(nombre_usuario);
                BE.Usuario usuario = _UsuarioDAL.Login(nomUsu_Encriptado);

                if (usuario != null)
                {
                    if (usuario.Estado >= 3) throw new Exception("El usuario está bloqueado.");

                    string passwordEncriptada = _encriptacion.Encriptar_MD5(contraseña);
                    if (passwordEncriptada == usuario.Contraseña)
                    {
                        UsuarioDTO usuarioSingleton = new UsuarioDTO()
                        {
                            Id_Usuario = usuario.Id_Usuario,
                            Nombre_Usuario = _encriptacion.Decrypt_AES(usuario.Nombre_Usuario),
                            Nombre = _encriptacion.Decrypt_AES(usuario.Nombre),
                            Apellido = _encriptacion.Decrypt_AES(usuario.Apellido),
                            Telefono = usuario.Telefono,
                        };
                        _permisoDAL.GetComponenteUsuario(usuarioSingleton);
                        _UsuarioDAL.Desbloquear(usuario.Nombre_Usuario);
                        Sesion.CreateInstance(usuarioSingleton, _IdiomaDAL.ObtenerIdiomaDefault());
                    }
                    else
                    {
                        _UsuarioDAL.Bloquear(usuario.Nombre_Usuario);
                        throw new Exception("La contraseña ingresada es incorrecta.");
                    }
                }
                else throw new Exception("No existe un usuario con ese nombre de usuario.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Logout()
        {
            try
            {
                Sesion.RemoveInstance();
            }
            catch
            {
                throw new Exception("Hubo un error al querer desloguear. Contacte al administrador.");
            }
        }

        private void ValidarUsuario(BE.Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido) || string.IsNullOrWhiteSpace(usuario.Nombre_Usuario) 
                || string.IsNullOrWhiteSpace(usuario.Contraseña) || string.IsNullOrWhiteSpace(usuario.Puesto) || string.IsNullOrWhiteSpace(usuario.Sexo) 
                || string.IsNullOrWhiteSpace(usuario.Mail) || string.IsNullOrWhiteSpace((usuario.Telefono).ToString()) || string.IsNullOrWhiteSpace(usuario.Tipo))
                    throw new Exception("Falta completar un campo");
            
            if (usuario.Nombre.Length < 3)
                throw new Exception("El nombre debe tener al menos 3 caracteres");

            if (usuario.Apellido.Length < 3)
                throw new Exception("El apellido debe tener al menos 3 caracteres");

            if ((usuario.Dni).ToString().Length < 6 || (usuario.Dni).ToString().Length > 10)
                throw new Exception("Debe ingresar un DNI entre 6 y 10 digitos");
        }

        public int CambiarContraseña(UsuarioDTO usuario, string contActual, string contNueva)
        {
            try
            {
                ValidarCambioPassword(usuario, _encriptacion.Encriptar_MD5(contActual), contNueva);
                if (string.IsNullOrWhiteSpace(contNueva) || contNueva.Length < 8) throw new Exception("msg_ValidacionPassword");

                string nuevaPasswordEncriptada = _encriptacion.Encriptar_MD5(contNueva);

                return _UsuarioDAL.CambiarContraseña(usuario, nuevaPasswordEncriptada);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ValidarCambioPassword(BE.DTOs.UsuarioDTO user, string passwordActual, string nuevaPassword)
        {
            BE.Usuario _usuario = _UsuarioDAL.ObtenerUsuarioId(user.Id_Usuario);
            if (passwordActual != _usuario.Contraseña) throw new Exception(TraducirMensaje("msg_PasswordNoCoindice"));
            if (string.IsNullOrWhiteSpace(nuevaPassword) || nuevaPassword.Length < 8) throw new Exception(TraducirMensaje("msg_NuevaPasswordFormato"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_IdiomaDAL, msgTag);
        }

        public List<BE.DTOs.UsuarioDTO> ListarUsuarioDTO()
        {
            try
            {
                List<BE.DTOs.UsuarioDTO> usuario = _UsuarioDAL.ListarUsuarioDTO();
                return usuario;

            }
            catch
            {
                throw new Exception("Error al Listar Usuarios");
            }
        }

        public List<UsuarioDTO> ObtenerUsuarioDTODesencriptado()
        {
            try
            {
                List<UsuarioDTO> usuarios = _UsuarioDAL.ListarUsuarioDTO();
                List<UsuarioDTO> usuariosDesencriptado = new List<UsuarioDTO>();

                foreach (UsuarioDTO user in usuarios)
                {
                    user.Nombre_Usuario = _encriptacion.Decrypt_AES(user.Nombre_Usuario);
                    user.Nombre = _encriptacion.Decrypt_AES(user.Nombre);
                    user.Apellido = _encriptacion.Decrypt_AES(user.Apellido);
                    usuariosDesencriptado.Add(user);
                }

                return usuariosDesencriptado;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener los usuarios."); }
        }

        public List<BE.Usuario> ObtenerUsuarioDesencriptado()
        {
            try
            {
                List<BE.Usuario> usuarios = _UsuarioDAL.ListarUsuario();
                List<BE.Usuario> usuariosDesencriptado = new List<BE.Usuario>();

                foreach (BE.Usuario user in usuarios)
                {
                    user.Nombre = _encriptacion.Decrypt_AES(user.Nombre);
                    user.Apellido = _encriptacion.Decrypt_AES(user.Apellido);
                    user.Nombre_Usuario = _encriptacion.Decrypt_AES(user.Nombre_Usuario);
                    user.Contraseña = user.Contraseña;
                    user.Puesto = user.Puesto;
                    user.Dni = user.Dni;
                    user.Sexo  = user.Sexo;
                    user.Mail = user.Mail;
                    user.Telefono  = user.Telefono;
                    user.Tipo = user.Tipo;
                    usuariosDesencriptado.Add(user);
                }

                return usuariosDesencriptado;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener los usuarios."); }
        }

        public List<BE.Usuario> ListarUsuario()
        {
            try
            {
                List<BE.Usuario> usuario = _UsuarioDAL.ListarUsuario();
                return usuario;

            }
            catch
            {
                throw new Exception("Error al Listar Usuarios");
            }
        }
        public List<BE.DTOs.UsuarioDTO> ListarBloqueados()
        {
            try
            {
                List<BE.DTOs.UsuarioDTO> usuario = _UsuarioDAL.ListarBloqueados();
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
