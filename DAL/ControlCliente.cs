using DAL.Conexion;
using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ControlCliente : Acceso
    {
        private readonly Fill _fill;
        public ControlCliente()
        {
            _fill = new Fill();
        }

        private const string ALTA_CONTROL_CLIENTE = @"INSERT INTO ControlCliente (ClienteId, Nombre, Apellido, Telefono, Fecha, UsuarioId, Descripcion) OUTPUT inserted.Id VALUES (@parClienteId, @parNombre, @parApellido, @parTelefono, @parFecha, @parUsuarioId, @parDescripcion)";
        private const string OBTENER_CONTROL_CLIENTE = "SELECT * FROM ControlCliente ORDER BY Fecha desc";

        public int AltaControlCliente(BE.ControlCliente controlCliente)
        {
            try
            {
                ExecuteCommandText = ALTA_CONTROL_CLIENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parClienteId", controlCliente.ClienteId);
                ExecuteParameters.Parameters.AddWithValue("@parNombre", controlCliente.Nombre);
                ExecuteParameters.Parameters.AddWithValue("@parApellido", controlCliente.Apellido);
                ExecuteParameters.Parameters.AddWithValue("@parTelefono", controlCliente.Telefono);
                ExecuteParameters.Parameters.AddWithValue("@parFecha", controlCliente.Fecha);
                ExecuteParameters.Parameters.AddWithValue("@parUsuarioId", controlCliente.UsuarioId);
                ExecuteParameters.Parameters.AddWithValue("@parDescripcion", controlCliente.Descripcion);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int RestaurarCliente(BE.ControlCliente controlCliente)
        {
            try
            {
                ExecuteCommandText = ALTA_CONTROL_CLIENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parClienteId", controlCliente.ClienteId);
                ExecuteParameters.Parameters.AddWithValue("@parNombre", controlCliente.Nombre);
                ExecuteParameters.Parameters.AddWithValue("@parApellido", controlCliente.Apellido);
                ExecuteParameters.Parameters.AddWithValue("@parTelefono", controlCliente.Telefono);
                ExecuteParameters.Parameters.AddWithValue("@parFecha", controlCliente.Fecha);
                ExecuteParameters.Parameters.AddWithValue("@parUsuarioId", controlCliente.UsuarioId);
                ExecuteParameters.Parameters.AddWithValue("@parDescripcion", controlCliente.Descripcion);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.ControlCliente> ObtenerControlCliente()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_CONTROL_CLIENTE);
                DataSet ds = ExecuteNonReader();

                List<BE.ControlCliente> controlCliente = new List<BE.ControlCliente>();

                if (ds.Tables[0].Rows.Count > 0)
                    controlCliente = _fill.FillListControlCliente(ds);

                return controlCliente;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int ObtenerControlClientePorId(int id)
        {
            try
            {
                string consulta = $@"SELECT * FROM Cliente WHERE Id = '{id}'";
                DataTable dt = GenerarConsulta(consulta);
                if(dt.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerControlClientePorCliente(int cliente)
        {
            try
            {
                string consulta = $@"SELECT * FROM ControlCliente WHERE ClienteId = '{cliente}'";
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
