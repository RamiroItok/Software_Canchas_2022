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

        private const string ALTA_CLIENTE = "INSERT INTO Cliente (Nombre, Apellido, Telefono) OUTPUT inserted.Id_Cliente VALUES (@parNombre, @parApellido, @parTelefono)";
        private const string MODIFICAR_CLIENTE = "UPDATE Cliente SET Nombre = @parNombre, Apellido = @parApellido, Telefono = @parTelefono WHERE Id_Cliente = @parId_Cliente";
        private const string BAJA_CLIENTE = "DELETE FROM Cliente WHERE Id_Cliente = {0}";
        private const string OBTENER_CLIENTES = "SELECT * FROM Cliente";

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

                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", cliente.Id_Cliente);
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

        public int BajaCliente(int id_cliente)
        {
            try
            {
                ExecuteCommandText = BAJA_CLIENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", id_cliente);

                return ExecuteNonEscalar();
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
                ExecuteCommandText = String.Format(OBTENER_CLIENTES);
                DataSet ds = ExecuteNonReader();

                List<BE.Cliente> cliente = new List<BE.Cliente>();

                if (ds.Tables[0].Rows.Count > 0)
                    cliente = _fill.FillListCliente(ds);

                return cliente;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos. ");
            }
        }
    }
}
