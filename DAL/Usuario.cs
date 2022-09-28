using BE.DTOs;
using DAL.Conexion;
using DAL.Tools;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario : Acceso
    {
        //Inyección de dependencias
        private readonly Fill _fill;
        public Usuario()
        {
            _fill = new Fill();
        }

        //Querys
        private const string LISTAR_USUARIO = "SELECT * FROM Usuarios";
        private const string OBTENER_USUARIO_ID = "SELECT TOP 1 * FROM Usuarios WHERE Id = {0}";
        private const string ALTA_USUARIO = @"INSERT INTO Usuarios (Nombre, Apellido, Nombre_Usuario, Contraseña, Puesto, Dni, Sexo,  Mail, Telefono, Tipo, Estado, DVH) 
                                            OUTPUT inserted.Id VALUES (@parNombre, @parApellido, @parNombre_Usuario, @parContraseña, @parPuesto, @parDni, @parSexo, @parMail,
                                            @parTelefono, @parTipo, @parEstado, @parDVH)";
        private const string BAJA_USUARIO = "DELETE FROM Usuarios WHERE Id = @parId";
        private const string MODIFICAR_USUARIO = @"UPDATE Usuarios SET Nombre = @parNombre, Apellido = @parApellido, Nombre_Usuario = @parNombre_Usuario, Puesto = @parPuesto,
                                                Dni = @parDni, Sexo = @parSexo, Mail = @parMail, Telefono = @parTelefono, Tipo = @parTipo OUTPUT inserted.Id WHERE Id = @parId";
        private const string LOGIN = "SELECT TOP 1 * FROM Usuarios WHERE Nombre_Usuario = '{0}'";
        private const string BLOQUEAR = "UPDATE Usuarios SET Estado = Estado + 1 WHERE Nombre_Usuario = @parNombre_Usuario";
        private const string DESBLOQUEAR = "UPDATE Usuarios SET Estado = 0 WHERE Nombre_Usuario = @parNombre_Usuario";
        private const string LISTAR_BLOQUEADOS = "SELECT * FROM Usuarios WHERE Estado = 3";
        private const string CAMBIAR_CONTRASEÑA = "UPDATE Usuarios SET Contraseña = @parContraseña OUTPUT inserted.Id WHERE Id = @parId";

        public List<UsuarioDTO> ListarUsuarioDTO()
        {
            try
            {
                SelectCommandText = String.Format(LISTAR_USUARIO);
                DataSet ds = ExecuteNonReader();

                List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();

                if (ds.Tables[0].Rows.Count > 0)
                    usuariosDTO = _fill.FillListUsuarioDTO(ds);

                return usuariosDTO;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.Usuario> ListarUsuario()
        {
            try
            {
                SelectCommandText = String.Format(LISTAR_USUARIO);
                DataSet ds = ExecuteNonReader();

                List<BE.Usuario> usuario = new List<BE.Usuario>();

                if (ds.Tables[0].Rows.Count > 0)
                    usuario = _fill.FillListUsuario(ds);

                return usuario;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int Alta_Usuario(BE.Usuario usuario)
        {
            try
            {
                ExecuteCommandText = ALTA_USUARIO;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parNombre", usuario.Nombre);
                ExecuteParameters.Parameters.AddWithValue("@parApellido", usuario.Apellido);
                ExecuteParameters.Parameters.AddWithValue("@parNombre_Usuario", usuario.Nombre_Usuario);
                ExecuteParameters.Parameters.AddWithValue("@parContraseña", usuario.Contraseña);
                ExecuteParameters.Parameters.AddWithValue("@parPuesto", usuario.Puesto);
                ExecuteParameters.Parameters.AddWithValue("@parDni", usuario.Dni);
                ExecuteParameters.Parameters.AddWithValue("@parSexo", usuario.Sexo);
                ExecuteParameters.Parameters.AddWithValue("@parMail", usuario.Mail);
                ExecuteParameters.Parameters.AddWithValue("@parTelefono", usuario.Telefono);
                ExecuteParameters.Parameters.AddWithValue("@parTipo", usuario.Tipo);
                ExecuteParameters.Parameters.AddWithValue("@parEstado", 0);
                ExecuteParameters.Parameters.AddWithValue("@parDVH", 0);


                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int Baja_Usuario(BE.Usuario usuario)
        {
            try
            {
                ExecuteCommandText = BAJA_USUARIO;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", usuario.Id);

                ExecuteNonQuery();
                
                return usuario.Id;
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int Modificar_Usuario(BE.Usuario usuario)
        {
            try
            {
                ExecuteCommandText = MODIFICAR_USUARIO;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", usuario.Id);
                ExecuteParameters.Parameters.AddWithValue("@parNombre", usuario.Nombre);
                ExecuteParameters.Parameters.AddWithValue("@parApellido", usuario.Apellido);
                ExecuteParameters.Parameters.AddWithValue("@parNombre_Usuario", usuario.Nombre_Usuario);
                ExecuteParameters.Parameters.AddWithValue("@parPuesto", usuario.Puesto);
                ExecuteParameters.Parameters.AddWithValue("@parDni", usuario.Dni);
                ExecuteParameters.Parameters.AddWithValue("@parSexo", usuario.Sexo);
                ExecuteParameters.Parameters.AddWithValue("@parMail", usuario.Mail);
                ExecuteParameters.Parameters.AddWithValue("@parTelefono", usuario.Telefono);
                ExecuteParameters.Parameters.AddWithValue("@parTipo", usuario.Tipo);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public BE.Usuario Login(string nombre_usuario)
        {
            try
            {
                SelectCommandText = String.Format(LOGIN, nombre_usuario);

                DataSet ds = ExecuteNonReader();
                BE.Usuario usuario = ds.Tables[0].Rows.Count <= 0 ? null : _fill.FillObjectUsuario(ds.Tables[0].Rows[0]);

                return usuario;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public void Bloquear(string nombre_usuario)
        {
            try
            {
                ExecuteCommandText = BLOQUEAR;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parNombre_Usuario", nombre_usuario);
                ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public void Desbloquear(string nombre_usuario)
        {
            try
            {
                ExecuteCommandText = DESBLOQUEAR;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parNombre_Usuario", nombre_usuario);
                ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.DTOs.UsuarioDTO> ListarBloqueados()
        {
            try
            {
                SelectCommandText = String.Format(LISTAR_BLOQUEADOS);
                DataSet ds = ExecuteNonReader();

                List<BE.DTOs.UsuarioDTO> usuario = new List<BE.DTOs.UsuarioDTO>();

                if (ds.Tables[0].Rows.Count > 0)
                    usuario = _fill.FillListBloqueado(ds);

                return usuario;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public BE.Usuario ObtenerUsuarioId(int usuarioId)
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_USUARIO_ID, usuarioId);

                DataSet ds = ExecuteNonReader();
                BE.Usuario usuario = ds.Tables[0].Rows.Count <= 0 ? null : _fill.FillObjectUsuario(ds.Tables[0].Rows[0]);

                return usuario;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int ObtenerUsuarioDTOId(int usuarioId)
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_USUARIO_ID, usuarioId);

                DataSet ds = ExecuteNonReader();
                BE.DTOs.UsuarioDTO usuario = ds.Tables[0].Rows.Count <= 0 ? null : _fill.FillObjectUsuarioDTO(ds.Tables[0].Rows[0]);

                return usuario.Id;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int CambiarContraseña(BE.DTOs.UsuarioDTO usuario, string nuevaPassword)
        {
            try
            {
                ExecuteCommandText = CAMBIAR_CONTRASEÑA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", usuario.Id);
                ExecuteParameters.Parameters.AddWithValue("@parContraseña", nuevaPassword);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }
    }
}
