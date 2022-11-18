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

        private const string ALTA_RESERVA = "INSERT INTO Reserva (Id_Cancha, Id_Cliente, Fecha, Hora, Semana, Forma_Pago, Seña, Total, Pagar, Pagado, DVH) OUTPUT inserted.Id VALUES (@parId_Cancha, @parId_Cliente, @parFecha, @parHora, @parSemana, @parForma_Pago, @parSeña, @parTotal, @parPagar, @parPagado, @parDVH)";
        private const string MODIFICAR_RESERVA = "UPDATE Reserva SET Id_Cancha = @parId_Cancha, Id_Cliente = @parId_Cliente, Fecha = @parFecha, Hora = @parHora, Semana = @parSemana, Forma_Pago = @parForma_Pago, Seña = @parSeña, Total = @parTotal, Pagar = @parPagar, Pagado = @parPagado OUTPUT inserted.Id WHERE Id = @parId";
        private const string BAJA_RESERVA = "DELETE FROM Reserva WHERE Id = @parId";
        private const string PAGAR_RESERVA = "UPDATE Reserva SET Seña = @parSeña, Pagar = @parPagar, Pagado = @parPagado OUTPUT inserted.Id WHERE Id = @parId";
        private const string OBTENER_RESERVA = "SELECT * FROM Reserva";
        private const string OBTENER_RESERVA_VENCIDA = "SELECT * FROM Reserva WHERE Pagar > 0 AND CAST(Fecha as date) <= CAST(GETDATE() as date) AND (CAST(Fecha as date) < CAST(GETDATE() as date) OR Hora < CONVERT(nvarchar(10), GETDATE(), 108)) ";
        private const string OBTENER_RESERVA_CLIENTE = @"SELECT r.Id, r.Id_Cancha as Cancha, cancha.Tipo as TipoCancha, r.Id_Cliente, cliente.Nombre + ' ' + cliente.Apellido as Cliente, 
                                                        r.Fecha as Fecha, r.Hora, r.Semana,
														(SELECT (CASE DATENAME(dw,r.Fecha)
															when 'Monday' then 'Lunes'
															when 'Tuesday' then 'Martes'
															when 'Wednesday' then 'Miercoles'
															when 'Thursday' then 'Jueves'
															when 'Friday' then 'Viernes'
															when 'Saturday' then 'Sabado'
															when 'Sunday' then 'Domingo' END)) as Dia, 
														r.Forma_Pago, r.Seña, r.Total, r.Pagar, r.Pagado 
                                                        FROM Reserva r 
                                                        inner join Cancha cancha on r.Id_Cancha = cancha.Id 
                                                        inner join Cliente cliente on cliente.Id = r.Id_Cliente 
                                                        WHERE convert(datetime, DATEADD(DAY,1, r.Fecha), 103) >= convert(datetime, GETDATE(), 103) 
														AND datepart(mm, r.Fecha) = datepart(mm, getdate())
                                                        ORDER BY r.Fecha asc, r.Hora asc";

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
                ExecuteParameters.Parameters.AddWithValue("@parSemana", reserva.Semana);
                ExecuteParameters.Parameters.AddWithValue("@parForma_Pago", reserva.Forma_Pago);
                ExecuteParameters.Parameters.AddWithValue("@parSeña", reserva.Seña);
                ExecuteParameters.Parameters.AddWithValue("@parTotal", reserva.Total);
                ExecuteParameters.Parameters.AddWithValue("@parPagar", reserva.Pagar);
                ExecuteParameters.Parameters.AddWithValue("@parPagado", reserva.Pagado);
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
                ExecuteParameters.Parameters.AddWithValue("@parSemana", reserva.Semana);
                ExecuteParameters.Parameters.AddWithValue("@parForma_Pago", reserva.Forma_Pago);
                ExecuteParameters.Parameters.AddWithValue("@parSeña", reserva.Seña);
                ExecuteParameters.Parameters.AddWithValue("@parTotal", reserva.Total);
                ExecuteParameters.Parameters.AddWithValue("@parPagar", reserva.Pagar);
                ExecuteParameters.Parameters.AddWithValue("@parPagado", reserva.Pagado);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public int BajaReserva(BE.Reserva reserva)
        {
            try
            {
                ExecuteCommandText = BAJA_RESERVA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", reserva.Id);

                ExecuteNonQuery();

                return reserva.Id;
            }
            catch
            {
                throw new Exception("Error en la base de datos. ");
            }
        }

        public int PagarDeudaCliente(int idReserva, float seña, float deuda)
        {
            try
            {
                ExecuteCommandText = PAGAR_RESERVA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", idReserva);
                ExecuteParameters.Parameters.AddWithValue("@parSeña", seña);
                ExecuteParameters.Parameters.AddWithValue("@parPagar", 0);
                ExecuteParameters.Parameters.AddWithValue("@parPagado", "Pagado");

                ExecuteNonQuery();

                return idReserva;
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

        public DataTable ObtenerReservaClienteFechaHora(int idCliente, string fecha, string hora, int reserva)
        {
            try
            {
                string consulta = $@"SELECT TOP 1 Id_Cliente, Fecha, Hora FROM Reserva WHERE Id_Cliente = '{idCliente}' and Fecha = convert(date, '{fecha}', 103) and Hora = '{hora}' and Id != '{reserva}'";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.Reserva> ObtenerReservaSemanaCliente(int idCliente)
        {
            try
            {
                SelectCommandText = $@"SELECT * FROM Reserva WHERE Id_Cliente = '{idCliente}' EXCEPT SELECT TOP 1 * FROM Reserva WHERE Id_Cliente = '{idCliente}'";
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

        public List<BE.Reserva> ObtenerReservaSemanaClienteBaja(int idCliente)
        {
            try
            {
                SelectCommandText = $@"SELECT * FROM Reserva WHERE Id_Cliente = '{idCliente}'";
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

        public DataTable ObtenerReservaVencida()
        {
            try
            {
                string consulta = OBTENER_RESERVA_VENCIDA;
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerReservaClienteFecha(string fecha)
        {
            try
            {
                string consulta = $@"SELECT r.Id, r.Id_Cancha as Cancha, cancha.Tipo as TipoCancha, r.Id_Cliente, cliente.Nombre + ' ' + cliente.Apellido as Cliente, r.Fecha as Fecha, r.Hora, r.Semana,
                                (SELECT (CASE DATENAME(dw,r.Fecha)
								    when 'Monday' then 'Lunes'
									when 'Tuesday' then 'Martes'
									when 'Wednesday' then 'Miercoles'
									when 'Thursday' then 'Jueves'
									when 'Friday' then 'Viernes'
									when 'Saturday' then 'Sabado'
									when 'Sunday' then 'Domingo' END)) as Dia, 
                                 r.Forma_Pago, r.Seña, r.Total, r.Pagar, r.Pagado 
                                FROM Reserva r 
                                inner join Cancha cancha on r.Id_Cancha = cancha.Id 
                                inner join Cliente cliente on cliente.Id = r.Id_Cliente 
                                WHERE r.Fecha = convert(datetime, '{fecha}', 103) ORDER BY r.Fecha asc, r.Hora asc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerReservaClienteCliente(string cliente)
        {
            try
            {
                string consulta = $@"SELECT r.Id, r.Id_Cancha as Cancha, cancha.Tipo as TipoCancha, r.Id_Cliente, cliente.Nombre + ' ' + cliente.Apellido as Cliente, r.Fecha as Fecha, r.Hora, r.Semana,
                                (SELECT (CASE DATENAME(dw,r.Fecha)
								    when 'Monday' then 'Lunes'
									when 'Tuesday' then 'Martes'
									when 'Wednesday' then 'Miercoles'
									when 'Thursday' then 'Jueves'
									when 'Friday' then 'Viernes'
									when 'Saturday' then 'Sabado'
									when 'Sunday' then 'Domingo' END)) as Dia, 
                                 r.Forma_Pago, r.Seña, r.Total, r.Pagar, r.Pagado 
                                FROM Reserva r 
                                inner join Cancha cancha on r.Id_Cancha = cancha.Id 
                                inner join Cliente cliente on cliente.Id = r.Id_Cliente
                                WHERE cliente.Nombre + ' ' + cliente.Apellido = '{cliente}' ORDER BY r.Fecha asc, r.Hora asc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerReservaFechaCliente(string fecha, string cliente)
        {
            try
            {
                string consulta = $@"SELECT r.Id, r.Id_Cancha as Cancha, cancha.Tipo as TipoCancha, r.Id_Cliente, cliente.Nombre + ' ' + cliente.Apellido as Cliente, r.Fecha as Fecha, r.Hora, r.Semana,
                                (SELECT (CASE DATENAME(dw,r.Fecha)
								    when 'Monday' then 'Lunes'
									when 'Tuesday' then 'Martes'
									when 'Wednesday' then 'Miercoles'
									when 'Thursday' then 'Jueves'
									when 'Friday' then 'Viernes'
									when 'Saturday' then 'Sabado'
									when 'Sunday' then 'Domingo' END)) as Dia, 
                                 r.Forma_Pago, r.Seña, r.Total, r.Pagar, r.Pagado 
                                FROM Reserva r 
                                inner join Cancha cancha on r.Id_Cancha = cancha.Id 
                                inner join Cliente cliente on cliente.Id = r.Id_Cliente 
                                WHERE r.Fecha = convert(datetime, '{fecha}', 103) and cliente.Nombre + ' ' + cliente.Apellido = '{cliente}' ORDER BY r.Fecha asc, r.Hora asc";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<string> ObtenerReservaHora(string fecha, string cancha)
        {
            try
            {
                string consulta = $@"SELECT Hora FROM Reserva WHERE Fecha = convert(datetime, '{fecha}', 103) and Id_Cancha = '{cancha}' order by Hora asc";
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
