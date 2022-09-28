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
        private readonly DAL.Observer.Idioma _IdiomaDAL;
        private readonly DAL.Composite.Permiso _permisoDAL;
        private readonly IBitacora _bitacora;
        private readonly IDigito_Verificador _digitoVerificador;

        public Usuario()
        {
            _UsuarioDAL = new DAL.Usuario();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _permisoDAL = new DAL.Composite.Permiso();
            _bitacora = new BLL.Bitacora();
            _digitoVerificador = new BLL.DigitoVerificador();
        }

        public int AltaUsuario(BE.Usuario usuario)
        {
            try
            {
                ValidarUsuario(usuario);
                usuario.Nombre = Encriptacion.Encriptar_AES(usuario.Nombre);
                usuario.Apellido = Encriptacion.Encriptar_AES(usuario.Apellido);
                usuario.Nombre_Usuario = Encriptacion.Encriptar_AES(usuario.Nombre_Usuario);
                usuario.Contraseña = Encriptacion.Encriptar_MD5(usuario.Contraseña);
                usuario.Puesto = usuario.Puesto;
                usuario.Dni = usuario.Dni;
                usuario.Sexo = usuario.Sexo;
                usuario.Mail = usuario.Mail;
                usuario.Telefono = usuario.Telefono;
                usuario.Tipo = usuario.Tipo;
                usuario.Estado = 0;
                usuario.DVH = 0;

                int id = _UsuarioDAL.Alta_Usuario(usuario);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se dió de alta el usuario " + id + ".", "ALTA");
                _digitoVerificador.RecalcularDV();
                return id;
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
                usuario.Nombre = Encriptacion.Encriptar_AES(usuario.Nombre);
                usuario.Apellido = Encriptacion.Encriptar_AES(usuario.Apellido);
                usuario.Nombre_Usuario = Encriptacion.Encriptar_AES(usuario.Nombre_Usuario);
                usuario.Puesto = usuario.Puesto;
                usuario.Dni = usuario.Dni;
                usuario.Sexo = usuario.Sexo;
                usuario.Mail = usuario.Mail;
                usuario.Telefono = usuario.Telefono;
                usuario.Tipo = usuario.Tipo;

                int id = _UsuarioDAL.Modificar_Usuario(usuario);
                //GUARDAR EN BITACORA
                //_bitacora.AltaBitacora("Se modificó el usuario " + id + ".", "ALTA");
                _digitoVerificador.RecalcularDV();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaUsuario(BE.Usuario usuario)
        {
            try
            {
                int id = _UsuarioDAL.Baja_Usuario(usuario);
                //GUARDAR EN BITACORA
                //_bitacora.AltaBitacora("Se dió de baja el usuario " + id + ".", "ALTA");
                _digitoVerificador.RecalcularDV();
                return id;
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
                if (Sesion.GetInstance() != null) throw new Exception("Error al obtener la sesión.");
                if (string.IsNullOrWhiteSpace(nombre_usuario) || string.IsNullOrWhiteSpace(contraseña)) throw new Exception("Hay campos sin completar.");

                string nomUsu_Encriptado = Encriptacion.Encriptar_AES(nombre_usuario);
                BE.Usuario usuario = _UsuarioDAL.Login(nomUsu_Encriptado);

                if (usuario != null)
                {
                    if (usuario.Estado >= 3) throw new Exception("El usuario está bloqueado ya que alcanzó la cantidad máxima de intentos. Contacte un administrador para su desbloqueo");

                    string passwordEncriptada = Encriptacion.Encriptar_MD5(contraseña);
                    if (passwordEncriptada == usuario.Contraseña)
                    {
                        UsuarioDTO usuarioSingleton = new UsuarioDTO()
                        {
                            Id = usuario.Id,
                            Nombre_Usuario = Encriptacion.Decrypt_AES(usuario.Nombre_Usuario),
                            Nombre = Encriptacion.Decrypt_AES(usuario.Nombre),
                            Apellido = Encriptacion.Decrypt_AES(usuario.Apellido),
                            Telefono = usuario.Telefono,
                        };
                        _permisoDAL.GetComponenteUsuario(usuarioSingleton);
                        _UsuarioDAL.Desbloquear(usuario.Nombre_Usuario);

                        Sesion.CreateInstance(usuarioSingleton, _IdiomaDAL.ObtenerIdiomaDefault());
                        //GUARDAR EN BITACORA
                        _bitacora.AltaBitacora("Se logeó el usuario.", "BAJA");
                        _digitoVerificador.RecalcularDV();
                    }
                    else
                    {
                        _UsuarioDAL.Bloquear(usuario.Nombre_Usuario);
                        _digitoVerificador.RecalcularDV();
                        throw new Exception("La contraseña ingresada es incorrecta.");
                    }
                }
                else throw new Exception("No existe un usuario con nombre de usuario.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Logout()
        {
            try
            {
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Cerró la sesión.", "BAJA");
                Sesion.RemoveInstance();
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorDeslogeo"));
            }
        }

        public void Desbloquear(string Nombre_Usuario)
        {
            try
            {
                BE.Usuario usuario = new BE.Usuario();
                usuario.Nombre_Usuario = Encriptacion.Encriptar_AES(Nombre_Usuario);

                _UsuarioDAL.Desbloquear(usuario.Nombre_Usuario);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se desbloqueó el usuario " + usuario.Id + ".", "ALTA");
                _digitoVerificador.RecalcularDV();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ValidarUsuario(BE.Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nombre) || string.IsNullOrWhiteSpace(usuario.Apellido) || string.IsNullOrWhiteSpace(usuario.Nombre_Usuario) 
                || string.IsNullOrWhiteSpace(usuario.Contraseña) || string.IsNullOrWhiteSpace(usuario.Puesto) || string.IsNullOrWhiteSpace(usuario.Sexo) 
                || string.IsNullOrWhiteSpace(usuario.Mail) || string.IsNullOrWhiteSpace((usuario.Telefono).ToString()) || string.IsNullOrWhiteSpace(usuario.Tipo))
                    throw new Exception(TraducirMensaje("msg_CamposVacios"));

            if (usuario.Nombre.Length < 3)
                throw new Exception(TraducirMensaje("msg_ValidacionNombre"));

            if (usuario.Apellido.Length < 3)
                throw new Exception(TraducirMensaje("msg_ValidacionApellido"));

            if ((usuario.Dni).ToString().Length < 6 || (usuario.Dni).ToString().Length > 10)
                throw new Exception(TraducirMensaje("msg_ValidacionDni"));
        }

        public int CambiarContraseña(UsuarioDTO usuario, string contActual, string contNueva)
        {
            try
            {
                ValidarCambioPassword(usuario, Encriptacion.Encriptar_MD5(contActual), contNueva);

                string nuevaPasswordEncriptada = Encriptacion.Encriptar_MD5(contNueva);
                _UsuarioDAL.CambiarContraseña(usuario, nuevaPasswordEncriptada);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se cambió la contraseña para el usuario " + usuario.Id + ".", "ALTA");
                _digitoVerificador.RecalcularDV();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ValidarCambioPassword(BE.DTOs.UsuarioDTO user, string passwordActual, string nuevaPassword)
        {
            BE.Usuario _usuario = _UsuarioDAL.ObtenerUsuarioId(user.Id);
            if (passwordActual != _usuario.Contraseña) throw new Exception(TraducirMensaje("msg_PasswordNoCoindice"));
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
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
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
                    user.Nombre_Usuario = Encriptacion.Decrypt_AES(user.Nombre_Usuario);
                    user.Nombre = Encriptacion.Decrypt_AES(user.Nombre);
                    user.Apellido = Encriptacion.Decrypt_AES(user.Apellido);
                    usuariosDesencriptado.Add(user);
                }

                return usuariosDesencriptado;
            }
            catch (Exception) 
            { 
                throw new Exception(TraducirMensaje("msg_ErrorObtenerUsuarios"));
            }
        }

        public List<BE.Usuario> ObtenerUsuarioDesencriptado()
        {
            try
            {
                List<BE.Usuario> usuarios = _UsuarioDAL.ListarUsuario();
                List<BE.Usuario> usuariosDesencriptado = new List<BE.Usuario>();

                foreach (BE.Usuario user in usuarios)
                {
                    user.Nombre = Encriptacion.Decrypt_AES(user.Nombre);
                    user.Apellido = Encriptacion.Decrypt_AES(user.Apellido);
                    user.Nombre_Usuario = Encriptacion.Decrypt_AES(user.Nombre_Usuario);
                    user.Contraseña = user.Contraseña;
                    user.Puesto = user.Puesto;
                    user.Dni = user.Dni;
                    user.Sexo = user.Sexo;
                    user.Mail = user.Mail;
                    user.Telefono = user.Telefono;
                    user.Tipo = user.Tipo;
                    usuariosDesencriptado.Add(user);
                }

                return usuariosDesencriptado;
            }
            catch (Exception)
            {
                throw new Exception(TraducirMensaje("msg_ErrorObtenerUsuarios"));
            }
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
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
                }
        }
        public List<BE.DTOs.UsuarioDTO> ListarBloqueados()
        {
            try
            {
                List<BE.DTOs.UsuarioDTO> usuario = _UsuarioDAL.ListarBloqueados();
                List<BE.DTOs.UsuarioDTO> usuariosDesencriptado = new List<BE.DTOs.UsuarioDTO>();

                foreach (BE.DTOs.UsuarioDTO user in usuario)
                {
                    user.Nombre = Encriptacion.Decrypt_AES(user.Nombre);
                    user.Apellido = Encriptacion.Decrypt_AES(user.Apellido);
                    user.Nombre_Usuario = Encriptacion.Decrypt_AES(user.Nombre_Usuario);
                    user.Telefono = user.Telefono;
                    usuariosDesencriptado.Add(user);
                }
                return usuariosDesencriptado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
