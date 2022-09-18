using System;
using System.Collections.Generic;
using System.Data;
using BE;
using DAL;
using BE.DTOs;
using BE.Observer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tools
{
    public class Fill
    {
        #region Usuario
        public BE.Usuario FillObjectUsuario(DataRow dr)
        {
            BE.Usuario usuario = new BE.Usuario();
            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    usuario.Id = Convert.ToInt32(dr["Id"]);

                if(dr.Table.Columns.Contains("Nombre") && !Convert.IsDBNull(dr["Nombre"]))
                    usuario.Nombre = Convert.ToString(dr["Nombre"]);

                if (dr.Table.Columns.Contains("Apellido") && !Convert.IsDBNull(dr["Apellido"]))
                    usuario.Apellido = Convert.ToString(dr["Apellido"]);

                if (dr.Table.Columns.Contains("Nombre_Usuario") && !Convert.IsDBNull(dr["Nombre_Usuario"]))
                    usuario.Nombre_Usuario = Convert.ToString(dr["Nombre_Usuario"]);

                if (dr.Table.Columns.Contains("Contraseña") && !Convert.IsDBNull(dr["Contraseña"]))
                    usuario.Contraseña = Convert.ToString(dr["Contraseña"]);

                if (dr.Table.Columns.Contains("Puesto") && !Convert.IsDBNull(dr["Puesto"]))
                    usuario.Puesto = Convert.ToString(dr["Puesto"]);

                if (dr.Table.Columns.Contains("Dni") && !Convert.IsDBNull(dr["Dni"]))
                    usuario.Dni = Convert.ToInt32(dr["Dni"]);

                if(dr.Table.Columns.Contains("Sexo") && !Convert.IsDBNull(dr["Sexo"]))
                    usuario.Sexo = Convert.ToString(dr["Sexo"]);

                if (dr.Table.Columns.Contains("Mail") && !Convert.IsDBNull(dr["Mail"]))
                    usuario.Mail = Convert.ToString(dr["Mail"]);

                if (dr.Table.Columns.Contains("Telefono") && !Convert.IsDBNull(dr["Telefono"]))
                    usuario.Telefono = Convert.ToInt32(dr["Telefono"]);

                if (dr.Table.Columns.Contains("Tipo") && !Convert.IsDBNull(dr["Tipo"]))
                    usuario.Tipo = Convert.ToString(dr["Tipo"]);

                if (dr.Table.Columns.Contains("Estado") && !Convert.IsDBNull(dr["Estado"]))
                    usuario.Estado = Convert.ToInt32(dr["Estado"]);

                if (dr.Table.Columns.Contains("DVH") && !Convert.IsDBNull(dr["DVH"]))
                    usuario.DVH = Convert.ToInt32(dr["DVH"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }
            return usuario;
        }

        public List<BE.Usuario> FillListUsuario(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectUsuario(dr)).ToList();
        }

        public UsuarioDTO FillObjectUsuarioDTO(DataRow dr)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            try
            {
                if(dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    usuario.Id = Convert.ToInt32(dr["Id"]);

                if (dr.Table.Columns.Contains("Nombre_Usuario") && !Convert.IsDBNull(dr["Nombre_Usuario"]))
                    usuario.Nombre_Usuario = Convert.ToString(dr["Nombre_Usuario"]);

                if (dr.Table.Columns.Contains("Nombre") && !Convert.IsDBNull(dr["Nombre"]))
                    usuario.Nombre = Convert.ToString(dr["Nombre"]);

                if (dr.Table.Columns.Contains("Apellido") && !Convert.IsDBNull(dr["Apellido"]))
                    usuario.Apellido = Convert.ToString(dr["Apellido"]);

                if (dr.Table.Columns.Contains("Telefono") && !Convert.IsDBNull(dr["Telefono"]))
                    usuario.Telefono = Convert.ToInt32(dr["Telefono"]);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }
            return usuario;
        }

        public List<BE.DTOs.UsuarioDTO> FillListUsuarioDTO(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectUsuarioDTO(dr)).ToList();
        }

        public List<BE.DTOs.UsuarioDTO> FillListBloqueado(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectUsuarioDTO(dr)).ToList();
        }
        #endregion Usuario

        #region Cancha
        public BE.Cancha FillObjectCancha(DataRow dr)
        {
            BE.Cancha cancha = new BE.Cancha();
            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    cancha.Id = Convert.ToInt32(dr["Id"]);

                if (dr.Table.Columns.Contains("Tipo") && !Convert.IsDBNull(dr["Tipo"]))
                    cancha.Tipo = Convert.ToString(dr["Tipo"]);

                if (dr.Table.Columns.Contains("Material") && !Convert.IsDBNull(dr["Material"]))
                    cancha.Material = Convert.ToString(dr["Material"]);

                if (dr.Table.Columns.Contains("PrecioBase") && !Convert.IsDBNull(dr["PrecioBase"]))
                    cancha.PrecioBase = float.Parse(Convert.ToString(dr["PrecioBase"]));

            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }
            return cancha;
        }
        public List<BE.Cancha> FillListCancha(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectCancha(dr)).ToList();
        }
        #endregion Cancha

        #region Reserva
        public BE.Reserva FillObjectReserva(DataRow dr)
        {
            BE.Reserva reserva = new BE.Reserva();
            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    reserva.Id = Convert.ToInt32(dr["Id"]);

                if (dr.Table.Columns.Contains("Id_Cancha") && !Convert.IsDBNull(dr["Id_Cancha"]))
                    reserva.Id_Cancha = Convert.ToInt32(dr["Id_Cancha"]);

                if (dr.Table.Columns.Contains("Id_Cliente") && !Convert.IsDBNull(dr["Id_Cliente"]))
                    reserva.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);

                if (dr.Table.Columns.Contains("Fecha") && !Convert.IsDBNull(dr["Fecha"]))
                    reserva.Fecha = Convert.ToDateTime(dr["Fecha"]);

                if (dr.Table.Columns.Contains("Hora") && !Convert.IsDBNull(dr["Hora"]))
                    reserva.Hora = Convert.ToString(dr["Hora"]);

                if (dr.Table.Columns.Contains("Forma_Pago") && !Convert.IsDBNull(dr["Forma_Pago"]))
                    reserva.Forma_Pago = Convert.ToString(dr["Forma_Pago"]);

                if (dr.Table.Columns.Contains("Seña") && !Convert.IsDBNull(dr["Seña"]))
                    reserva.Seña = float.Parse(Convert.ToString(dr["Seña"]));

                if (dr.Table.Columns.Contains("Total") && !Convert.IsDBNull(dr["Total"]))
                    reserva.Total = float.Parse(Convert.ToString(dr["Total"]));

                if (dr.Table.Columns.Contains("Deuda") && !Convert.IsDBNull(dr["Deuda"]))
                    reserva.Deuda = float.Parse(Convert.ToString(dr["Deuda"]));

                if (dr.Table.Columns.Contains("DVH") && !Convert.IsDBNull(dr["DVH"]))
                    reserva.DVH = Convert.ToInt32(dr["DVH"]);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }
            return reserva;
        }
        public List<BE.Reserva> FillListReserva(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectReserva(dr)).ToList();
        }

        #endregion Reserva

        #region Cliente
        public BE.Cliente FillObjectCliente(DataRow dr)
        {
            BE.Cliente cliente = new BE.Cliente();
            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    cliente.Id = Convert.ToInt32(dr["Id"]);

                if (dr.Table.Columns.Contains("Nombre") && !Convert.IsDBNull(dr["Nombre"]))
                    cliente.Nombre = Convert.ToString(dr["Nombre"]);

                if (dr.Table.Columns.Contains("Apellido") && !Convert.IsDBNull(dr["Apellido"]))
                    cliente.Apellido = Convert.ToString(dr["Apellido"]);

                if (dr.Table.Columns.Contains("Telefono") && !Convert.IsDBNull(dr["Telefono"]))
                    cliente.Telefono = Convert.ToInt32(dr["Telefono"]);

            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }
            return cliente;
        }
        public List<BE.Cliente> FillListCliente(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectCliente(dr)).ToList();
        }
        #endregion Cliente

        #region Idioma
        public BE.Observer.IIdioma FillObjectIdioma(DataRow dr)
        { 
            BE.Observer.Idioma idioma = new BE.Observer.Idioma();

            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    idioma.Id = Convert.ToInt32(dr["Id"]);

                if (dr.Table.Columns.Contains("Nombre") && !Convert.IsDBNull(dr["Nombre"]))
                    idioma.Nombre = Convert.ToString(dr["Nombre"]);

                if (dr.Table.Columns.Contains("Default") && !Convert.IsDBNull(dr["Default"]))
                    idioma.Default = Convert.ToBoolean(dr["Default"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }

            return idioma;
        }

        public List<BE.Observer.IIdioma> FillListIdioma(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectIdioma(dr)).ToList();
        }
        #endregion

        #region Traducción
        public IDictionary<string, ITraduccion> FillTraducciones(DataSet ds)
        {
            IDictionary<string, ITraduccion> _traducciones = new Dictionary<string, ITraduccion>();

            try
            {
                foreach (var item in ds.Tables[0].Rows)
                {
                    DataRow dr = item as DataRow;

                    ITraduccion traduccion = new Traduccion();
                    traduccion.Texto = Convert.ToString(dr["Traduccion"]);
                    Etiqueta etiqueta = new Etiqueta()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nombre = Convert.ToString(dr["Nombre_Etiqueta"])
                    };
                    traduccion.Etiqueta = etiqueta;

                    _traducciones.Add(traduccion.Etiqueta.Nombre, traduccion);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }

            return _traducciones;
        }

        public BE.Observer.Traduccion FillGridTraduccion(DataRow dr)
        {
            Traduccion traduccion = new BE.Observer.Traduccion();
            Observer.Idioma _idiomaDAL = new Observer.Idioma();

            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    traduccion.Id = (Convert.ToInt32(dr["Id"]));

                if (dr.Table.Columns.Contains("EtiquetaId") && !Convert.IsDBNull(dr["EtiquetaId"]))
                    traduccion.Etiqueta = _idiomaDAL.GetEtiqueta(Convert.ToInt32(dr["EtiquetaId"]));

                if (dr.Table.Columns.Contains("Traduccion") && !Convert.IsDBNull(dr["Traduccion"]))
                    traduccion.Texto = (Convert.ToString(dr["Traduccion"]));
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }

            return traduccion;
        }

        public List<BE.Observer.Traduccion> FillListGridTraduccion(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillGridTraduccion(dr)).ToList();
        }

        #endregion

        #region Etiqueta
        public BE.Observer.Etiqueta FillObjectEtiqueta(DataRow dr)
        {
            BE.Observer.Etiqueta etiqueta = new BE.Observer.Etiqueta();

            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    etiqueta.Id = Convert.ToInt32(dr["Id"]);


                if (dr.Table.Columns.Contains("Nombre") && !Convert.IsDBNull(dr["Nombre"]))
                    etiqueta.Nombre = Convert.ToString(dr["Nombre"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }

            return etiqueta;
        }

        public List<BE.Observer.Etiqueta> FillListEtiqueta(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectEtiqueta(dr)).ToList();
        }
        #endregion

        #region Familia
        public BE.Composite.Familia FillObjectFamilia(DataRow dr)
        {
            BE.Composite.Familia familia = new BE.Composite.Familia();

            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    familia.Id = Convert.ToInt32(dr["Id"]);


                if (dr.Table.Columns.Contains("Nombre") && !Convert.IsDBNull(dr["Nombre"]))
                    familia.Nombre = Convert.ToString(dr["Nombre"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }

            return familia;
        }

        public List<BE.Composite.Familia> FillListFamilia(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectFamilia(dr)).ToList();
        }
        #endregion

        #region Patente
        public BE.Composite.Patente FillObjectPatente(DataRow dr)
        {
            BE.Composite.Patente patente = new BE.Composite.Patente();

            try
            {
                if (dr.Table.Columns.Contains("Id") && !Convert.IsDBNull(dr["Id"]))
                    patente.Id = Convert.ToInt32(dr["Id"]);


                if (dr.Table.Columns.Contains("Nombre") && !Convert.IsDBNull(dr["Nombre"]))
                    patente.Nombre = Convert.ToString(dr["Nombre"]);

                if (dr.Table.Columns.Contains("Permiso") && !Convert.IsDBNull(dr["Permiso"]))
                    patente.Permiso = (BE.Composite.Permiso)Enum.Parse(typeof(BE.Composite.Permiso), dr["Permiso"].ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el método FillObject, " + ex.Message);
            }

            return patente;
        }

        public List<BE.Composite.Patente> FillListPatente(DataSet ds)
        {
            return (from DataRow dr in ds.Tables[0].Rows select (new Fill()).FillObjectPatente(dr)).ToList();
        }
        #endregion
    }
}
