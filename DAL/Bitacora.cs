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
    public class Bitacora : Acceso
    {
        private readonly Fill _fill;
        public Bitacora()
        {
            _fill = new Fill();
        }

        private const string ALTA_BITACORA = "INSERT INTO Bitacora (Nombre_Usuario, Descripcion, Fecha, Criticidad, DVH) OUTPUT inserted.Id Values (@parNombre_Usuario, @parDescripcion, @parFecha, @parCriticidad, @parDVH)";
        private const string LISTAR_EVENTO = "SELECT Id, Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora ORDER BY Fecha asc";

        public int AltaBitacora(BE.Bitacora bitacora)
        {
            try
            {
                ExecuteCommandText = ALTA_BITACORA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parNombre_Usuario", bitacora.Nombre_Usuario);
                ExecuteParameters.Parameters.AddWithValue("@parDescripcion", bitacora.Descripcion);
                ExecuteParameters.Parameters.AddWithValue("@parFecha", bitacora.Fecha);
                ExecuteParameters.Parameters.AddWithValue("@parCriticidad", bitacora.Criticidad);
                ExecuteParameters.Parameters.AddWithValue("@parDVH", 0);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int BajaBitacora(string fecha_ini, string fecha_fin)
        {
            try
            {
                string consulta = $@"DELETE FROM Bitacora WHERE Fecha > CONVERT(datetime, '{fecha_ini} 00:00:00', 103) AND Fecha < convert(datetime, '{fecha_fin} 23:59:59', 103)";
                GenerarConsulta(consulta);
                int eliminar = 1;
                return eliminar;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.Bitacora> ListarEventos()
        {
            try
            {
                SelectCommandText = String.Format(LISTAR_EVENTO);
                DataSet ds = ExecuteNonReader();

                List<BE.Bitacora> bitacora = new List<BE.Bitacora>();

                if (ds.Tables[0].Rows.Count > 0)
                    bitacora = _fill.FillListBitacora(ds);

                return bitacora;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable Listar_Evento_Between(string fecha_ini, string fecha_fin)
        {
            try
            {
                string consulta = $@"SELECT Id, Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora WHERE Fecha >= convert(datetime, '{fecha_ini} 00:00:00', 103) AND Fecha <= convert(datetime, '{fecha_fin} 23:59:59', 103) ORDER BY Fecha desc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable Listar_Evento_Between_Usuario(string fecha_ini, string fecha_fin, string nombre_usuario)
        {
            try
            {
                string consulta = $@"SELECT Id, Nombre_Usuario as Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora WHERE Nombre_Usuario = '{nombre_usuario}' and Fecha >= CONVERT(datetime, '{fecha_ini} 00:00:00', 103) and Fecha <= convert(datetime, '{fecha_fin} 23:59:59', 103) ORDER BY Fecha desc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable Listar_Evento_Usuario(string nombre_usuario)
        {
            try
            {
                string consulta = $@"SELECT Id, Nombre_Usuario as Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora WHERE Nombre_Usuario = '{nombre_usuario}' ORDER BY Fecha desc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable Listar_Evento_Between_Critic(string fecha_ini, string fecha_fin, string critic)
        {
            try
            {
                string consulta = $@"SELECT Id, Nombre_Usuario as Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora WHERE Criticidad = '{critic}' and Fecha >= CONVERT(datetime, '{fecha_ini} 00:00:00', 103) and Fecha <= convert(datetime, '{fecha_fin} 23:59:59', 103) ORDER BY Fecha desc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable Listar_Evento_Crit(string critic)
        {
            try
            {
                string consulta = $@"SELECT Id, Nombre_Usuario as Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora WHERE Criticidad = '{critic}' ORDER BY Fecha desc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable Listar_Evento_Crit_Usu(string nombre_usuario, string crit)
        {
            try
            {
                string consulta = $@"SELECT Id, Nombre_Usuario as Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora WHERE Criticidad = '{crit}' and Nombre_Usuario = '{nombre_usuario}' ORDER BY Fecha desc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable Listar_Evento_Fecha_Usu_Crit(string fecha_ini, string fecha_fin, string nombre_usuario, string crit)
        {
            try
            {
                string consulta = $@"SELECT Id, Nombre_Usuario as Nombre_Usuario, Descripcion, Fecha, Criticidad FROM Bitacora WHERE Criticidad = '{crit}' and Fecha >= CONVERT(datetime, '{fecha_ini} 00:00:00', 103) and Fecha <= convert(datetime, '{fecha_fin} 23:59:59', 103) and Nombre_Usuario = '{nombre_usuario}' ORDER BY Fecha desc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

    }
}
