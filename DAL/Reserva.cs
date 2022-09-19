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
    public class Reserva : Acceso, IReserva
    {
        private readonly Fill _fill;

        public Reserva()
        {
            _fill = new Fill();
        }

        private const string ALTA_RESERVA = "INSERT INTO Reserva (Id_Cancha, Id_Cliente, Fecha, Hora, Forma_Pago, Seña, Total, Deuda, DVH) OUTPUT inserted.Id VALUES (@parId_Cancha, @parId_Cliente, @parFecha, @parHora, @parForma_Pago, @parSeña, @parTotal, @parDeuda, @parDVH)";
        private const string MODIFICAR_RESERVA = "UPDATE Reserva SET Id_Cancha = @parId_Cancha, Id_Cliente = @parId_Cliente, Fecha = @parFecha, Hora = @parHora, Forma_Pago = @parForma_Pago, Seña = @parSeña, Total = @parTotal, Deuda = @parDeuda OUTPUT inserted.Id WHERE Id = @parId";
        private const string BAJA_RESERVA = "DELETE FROM Reserva WHERE Id = @parId";
        private const string OBTENER_RESERVA = "SELECT * FROM Reserva";
        private const string OBTENER_RESERVA_CLIENTE = "SELECT r.Id, r.Id_Cancha as Cancha, cancha.Tipo as TipoCancha, r.Id_Cliente, cliente.Nombre + ' ' + cliente.Apellido as Cliente, r.Fecha as Fecha, r.Hora, r.Forma_Pago, r.Seña, r.Total, r.Deuda FROM Reserva r inner join Cancha cancha on r.Id_Cancha = cancha.Id join Cliente cliente on cliente.Id = r.Id_Cliente WHERE r.Fecha > GETDATE() ORDER BY r.Fecha asc, r.Hora asc";

        public int AltaReserva(BE.Reserva reserva)
        {
            try
            {
                ExecuteCommandText = ALTA_RESERVA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Cancha", reserva.Id_Cancha);
                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", reserva.Id_Cliente);
                ExecuteParameters.Parameters.AddWithValue("@parFecha", reserva.Fecha);
                ExecuteParameters.Parameters.AddWithValue("@parHora", reserva.Hora);
                ExecuteParameters.Parameters.AddWithValue("@parForma_Pago", reserva.Forma_Pago);
                ExecuteParameters.Parameters.AddWithValue("@parSeña", reserva.Seña);
                ExecuteParameters.Parameters.AddWithValue("@parTotal", reserva.Total);
                ExecuteParameters.Parameters.AddWithValue("@parDeuda", reserva.Deuda);
                ExecuteParameters.Parameters.AddWithValue("@parDVH", 0);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public int ModificarReserva(BE.Reserva reserva)
        {
            try
            {
                ExecuteCommandText = MODIFICAR_RESERVA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", reserva.Id);
                ExecuteParameters.Parameters.AddWithValue("@parId_Cancha", reserva.Id_Cancha);
                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", reserva.Id_Cliente);
                ExecuteParameters.Parameters.AddWithValue("@parFecha", reserva.Fecha);
                ExecuteParameters.Parameters.AddWithValue("@parHora", reserva.Hora);
                ExecuteParameters.Parameters.AddWithValue("@parForma_Pago", reserva.Forma_Pago);
                ExecuteParameters.Parameters.AddWithValue("@parSeña", reserva.Seña);
                ExecuteParameters.Parameters.AddWithValue("@parTotal", reserva.Total);
                ExecuteParameters.Parameters.AddWithValue("@parDeuda", reserva.Deuda);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public void BajaReserva(BE.Reserva reserva)
        {
            try
            {
                ExecuteCommandText = BAJA_RESERVA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", reserva.Id);

                ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public List<BE.Reserva> ObtenerReservas()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_RESERVA);
                DataSet ds = ExecuteNonReader();

                List<BE.Reserva> reservas = new List<BE.Reserva>();

                if (ds.Tables[0].Rows.Count > 0)
                    reservas = _fill.FillListReserva(ds);

                return reservas;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerReservaCliente()
        {
            try
            {
                string consulta = OBTENER_RESERVA_CLIENTE;
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<string> ObtenerReservaHora(string fecha)
        {
            try
            {
                string consulta = $@"SELECT Hora FROM Reserva WHERE Fecha = convert(datetime, '{fecha}', 103) order by Hora asc";
                DataTable dt = GenerarConsulta(consulta);
                List<string> listaHora = new List<string>();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    var hora = dt.Rows[i]["Hora"].ToString();
                    listaHora.Add(hora);
                }

                return listaHora;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }
    }
}
