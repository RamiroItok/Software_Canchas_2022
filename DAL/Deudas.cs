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
    public class Deudas : Acceso
    {
        #region Inyección de dependencias
        private readonly Fill _fill;
        public Deudas()
        {
            _fill = new Fill();
        }
        #endregion

        #region Querys
        private const string ALTA_DEUDA = "INSERT INTO Deudas (Id_Reserva, Id_Cliente, Fecha_Pago, DVH) OUTPUT inserted.Id Values (@parId_Reserva, @parId_Cliente, @parFecha_Pago, @parDVH)";
        private const string MODIFICAR_DEUDA = "UPDATE Deudas SET Fecha_Pago = @parFecha_Pago OUTPUT inserted.Id WHERE Id_Cliente = @parId_Cliente";
        private const string BAJA_DEUDA_CLIENTE = "DELETE FROM Deudas WHERE Id_Cliente = @parId_Cliente";
        private const string BAJA_DEUDA_RESERVA = "DELETE FROM Deudas WHERE Id_Reserva = @parId_Reserva";
        private const string LISTAR_DEUDAS = @"SELECT d.Id, r.Id as Reserva, c.Nombre + ' ' + c.Apellido AS Cliente, FORMAT(r.Fecha, 'dd/MM/yyyy') AS FechaReserva, r.Hora AS HoraReserva, 
                                            FORMAT(d.Fecha_Pago, 'dd/MM/yyyy') AS FechaPago, r.Seña, r.Total, r.Pagar FROM Deudas d
                                            INNER JOIN Reserva r on r.Id = d.Id_Reserva
                                            INNER JOIN Cliente c on c.Id = d.Id_Cliente";
        #endregion

        public int AltaDeuda(BE.Deudas deuda)
        {
            try
            {
                ExecuteCommandText = ALTA_DEUDA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Reserva", deuda.Id_Reserva);
                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", deuda.Id_Cliente);
                ExecuteParameters.Parameters.AddWithValue("@parFecha_Pago", deuda.Fecha_Pago);
                ExecuteParameters.Parameters.AddWithValue("@parDVH", 0);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int ModificarDeuda(int idCliente, DateTime fechaPago)
        {
            try
            {
                ExecuteCommandText = MODIFICAR_DEUDA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", idCliente);
                ExecuteParameters.Parameters.AddWithValue("@parFecha_Pago", fechaPago);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int BajaDeudaPorCliente(int idCliente)
        {
            try
            {
                ExecuteCommandText = BAJA_DEUDA_CLIENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", idCliente);

                ExecuteNonQuery();
                return 1;
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int BajaDeudaPorReserva(int idReserva)
        {
            try
            {
                ExecuteCommandText = BAJA_DEUDA_RESERVA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Reserva", idReserva);

                ExecuteNonQuery();
                return 1;
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ListarDeudas()
        {
            try
            {
                DataTable dt = GenerarConsulta(LISTAR_DEUDAS);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerDeudaCliente(int idCliente)
        {
            try
            {
                string consulta = $@"SELECT TOP 1 * FROM Deudas d INNER JOIN Reserva r on d.Id_Reserva = r.Id WHERE d.Id_Cliente = '{idCliente}' and r.Fecha < GETDATE()";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ListarDeudaCliente(string cliente)
        {
            try
            {
                string consulta = $@"SELECT d.Id, r.Id as Reserva, c.Nombre + ' ' + c.Apellido AS Cliente, FORMAT(r.Fecha, 'dd/MM/yyyy') AS FechaReserva, r.Hora AS HoraReserva, 
                                FORMAT(d.Fecha_Pago, 'dd/MM/yyyy') AS FechaPago, r.Seña, r.Total, r.Pagar FROM Deudas d
                                INNER JOIN Reserva r on r.Id = d.Id_Reserva
                                INNER JOIN Cliente c on c.Id = d.Id_Cliente
                                WHERE c.Nombre + ' ' + c.Apellido = '{cliente}' and r.Pagar > 0";
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
