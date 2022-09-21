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
    public class Cliente : Acceso, ICliente
    {
        private readonly Fill _fill;
        public Cliente()
        {
            _fill = new Fill();  
        }

        private const string ALTA_CLIENTE = "INSERT INTO Cliente (Nombre, Apellido, Telefono) OUTPUT inserted.Id VALUES (@parNombre, @parApellido, @parTelefono)";
        private const string MODIFICAR_CLIENTE = "UPDATE Cliente SET Nombre = @parNombre, Apellido = @parApellido, Telefono = @parTelefono OUTPUT inserted.Id WHERE Id = @parId";
        private const string BAJA_CLIENTE = "DELETE FROM Cliente WHERE Id = @parId";
        private const string OBTENER_CLIENTES = "SELECT * FROM Cliente";
        private const string OBTENER_NOMBRE_CLIENTES = "SELECT Id, Nombre + ' ' + Apellido as Nombre FROM Cliente";

        public int AltaCliente(BE.Cliente cliente)
        {
            try
            {
                ExecuteCommandText = ALTA_CLIENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parNombre", cliente.Nombre);
                ExecuteParameters.Parameters.AddWithValue("@parApellido", cliente.Apellido);
                ExecuteParameters.Parameters.AddWithValue("@parTelefono", cliente.Telefono);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public int ModificarCliente(BE.Cliente cliente)
        {
            try
            {
                ExecuteCommandText = MODIFICAR_CLIENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", cliente.Id);
                ExecuteParameters.Parameters.AddWithValue("@parNombre", cliente.Nombre);
                ExecuteParameters.Parameters.AddWithValue("@parApellido", cliente.Apellido);
                ExecuteParameters.Parameters.AddWithValue("@parTelefono", cliente.Telefono); 

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public int BajaCliente(BE.Cliente cliente)
        {
            try
            {
                ExecuteCommandText = BAJA_CLIENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", cliente.Id);

                ExecuteNonQuery();
                return cliente.Id;
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public List<BE.Cliente> ObtenerClientes()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_CLIENTES);
                DataSet ds = ExecuteNonReader();

                List<BE.Cliente> clientes = new List<BE.Cliente>();

                if (ds.Tables[0].Rows.Count > 0)
                    clientes = _fill.FillListCliente(ds);

                return clientes;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerNombreClientes()
        {
            try
            {
                string consulta = OBTENER_NOMBRE_CLIENTES;
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
