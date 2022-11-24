using BE.DTOs;
using Interfaces;
using Newtonsoft.Json;
using Servicios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Reserva : IReserva
    {
        private readonly DAL.Reserva _reservaDAL;
        private readonly DAL.Observer.Idioma _idiomaDAL;
        private readonly IBitacora _bitacora;
        private readonly IDeudas _deudas;

        public Reserva()
        {
            _reservaDAL = new DAL.Reserva();
            _idiomaDAL = new DAL.Observer.Idioma();
            _bitacora = new BLL.Bitacora();
            _deudas = new BLL.Deudas();
        }

        public int AltaReserva(BE.Reserva reserva)
        {
            try
            {
                ValidarCampos(reserva);
                ValidarReservaFecha(reserva);
                ValidarReservaSeña(reserva);
                int validarReservaHora = ValidarReservaClienteFechaHora(reserva);
                if(validarReservaHora == 0)
                {
                    int resultado = ValidarDeudaCliente(reserva);
                    if (resultado == 0)
                    {
                        if(reserva.Semana == true)
                        {
                            reserva.Id = _reservaDAL.AltaReserva(reserva);

                            int i = 0;
                            int contador = 0;
                            for (contador = 0; contador <= 48; contador++)
                            {
                                i += 7;
                                contador = contador + 1;
                                reserva.Fecha = DateTime.Today.AddDays(i);
                                reserva.Seña = 0;
                                reserva.Pagar = reserva.Total;
                                reserva.Pagado = "No pagado";

                                reserva.Id = _reservaDAL.AltaReserva(reserva);
                                SerializarReserva(reserva);
                            }
                            
                            //GUARDAR EN BITACORA
                            _bitacora.AltaBitacora("Se dió de alta la reserva semanal para el cliente " + reserva.Id_Cliente + ".", "MEDIA");
                            return reserva.Id;
                        }
                        else
                        {
                            reserva.Id = _reservaDAL.AltaReserva(reserva);

                            //GUARDAR EN BITACORA
                            _bitacora.AltaBitacora("Se dió de alta la reserva " + reserva.Id + ".", "MEDIA");
                            SerializarReserva(reserva);
                            return reserva.Id;
                        }
                        
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    throw new Exception(TraducirMensaje("msg_ReservaClienteHoraDuplicada"));
                }
                    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarReserva(BE.Reserva reserva)
        {
            try
            {
                ValidarCampos(reserva);
                ValidarReservaSeña(reserva);
                ValidarReservaFecha(reserva);
                int validarReservaHora = ValidarReservaClienteFechaHora(reserva);
                if (validarReservaHora == 0)
                {
                    if (reserva.Semana == true)
                    {
                        reserva.Id = _reservaDAL.ModificarReserva(reserva);

                        int i = 0;
                        int contador = 0; 
                        List<BE.Reserva> lista = _reservaDAL.ObtenerReservaSemanaCliente(reserva.Id_Cliente);
                        for(contador = 0; contador < lista.Count; contador++)
                        { 
                            i = 7;
                            reserva.Id = lista[contador].Id;
                            reserva.Fecha = reserva.Fecha.AddDays(i);
                            reserva.Seña = 0;
                            reserva.Pagar = reserva.Total;
                            reserva.Pagado = "No pagado";

                            reserva.Id = _reservaDAL.ModificarReserva(reserva);
                        }


                        //GUARDAR EN BITACORA
                        _bitacora.AltaBitacora("Se dió de modificó la reserva semanal para el cliente " + reserva.Id_Cliente + ".", "MEDIA");
                        SerializarReserva(reserva);
                        return reserva.Id;
                    }
                    else
                    {
                        reserva.Id = _reservaDAL.ModificarReserva(reserva);

                        //GUARDAR EN BITACORA
                        _bitacora.AltaBitacora("Se modificó la reserva " + reserva.Id + ".", "MEDIA");
                        SerializarReserva(reserva);
                        return reserva.Id;
                    }
                    
                }
                else
                {
                    throw new Exception(TraducirMensaje("msg_ReservaClienteHoraDuplicada"));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaReserva(BE.Reserva reserva, bool semana)
        {
            try
            {
                int id = _reservaDAL.BajaReserva(reserva);
                if (semana == true)
                {
                    int contador = 0;
                    List<BE.Reserva> lista = _reservaDAL.ObtenerReservaSemanaClienteBaja(reserva.Id_Cliente);
                    for (contador = 0; contador < lista.Count; contador++)
                    {
                        reserva.Id = lista[contador].Id;
                        if(lista[contador].Semana != false)
                        {
                            _reservaDAL.BajaReserva(reserva);
                        }
                    }
                    //GUARDAR EN BITACORA
                    _bitacora.AltaBitacora("Se dió de baja la reserva semanal para el cliente " + reserva.Id_Cliente + ".", "MEDIA");
                }
                else
                {
                    //GUARDAR EN BITACORA
                    _bitacora.AltaBitacora("Se dió de baja la reserva " + id + ".", "MEDIA");
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int PagarDeudaCliente(int idReserva, float seña, float deuda)
        {
            try
            {
                seña = seña + deuda;
                int id = _reservaDAL.PagarDeudaCliente(idReserva, seña, deuda);
                _deudas.BajaDeudaPorReserva(idReserva);

                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se pagó la deuda de la reserva " + idReserva + ".", "ALTA");
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public float CalcularDeuda(float seña, float total, string formaPago)
        {
            try
            {
                float deuda = 0;
                deuda = total - seña;
               
                return deuda;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int CalcularTotalHora(int hora, int total)
        {
            int tot;
            if (hora > 18)
                tot = total + 500;
            else
                tot = total;

            return tot;
        }

        public int ModificarReservaPorPrecioCancha(int cancha, float precio)
        {
            try
            {
                List<BE.Reserva> lista = _reservaDAL.ObtenerReservaCanchaFecha(cancha);
                for(int i = 0; i < lista.Count; i++)
                {
                    int idCancha = cancha;
                    int hora = int.Parse(lista[i].Hora.ToString().Substring(0,2));
                    string formaPago = lista[i].Forma_Pago;
                    float total = precio;
                    total = CalcularTotalTipoPago(hora, int.Parse(total.ToString()), formaPago);
                    float pagar = CalcularDeuda(lista[i].Seña, total, formaPago);

                    

                    BE.Reserva reserva = new BE.Reserva()
                    {
                        Id = lista[i].Id,
                        Id_Cancha = idCancha,
                        Id_Cliente = lista[i].Id_Cliente,
                        Fecha = lista[i].Fecha,
                        Hora = hora.ToString() + ":00",
                        Semana = lista[i].Semana,
                        Forma_Pago = formaPago,
                        Total = total,
                        Pagar = pagar,
                        Pagado = lista[i].Pagado
                    };
                    _reservaDAL.ModificarReserva(reserva);

                }

                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se modificó el precio total para las reservas de la cancha " + cancha + ".", "MEDIA");

                return 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public float CalcularTotalTipoPago(int hora, int total, string formaPago)
        {
            int tot = CalcularTotalHora(hora, total);
            if (formaPago == "Efectivo")
            {
                tot = ((tot * 90) / 100);
            }
            
            return tot;
        }

        public string Pagado(int deuda)
        {
            try
            {
                string pagado = "";
                if(deuda > 0)
                {
                    pagado = "No pagado";
                }
                else if (deuda == 0) 
                {
                    pagado = "Pagado";
                }
                return pagado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BE.Reserva> ObtenerReservas()
        {
            try
            {
                List<BE.Reserva> reserva = _reservaDAL.ObtenerReservas();
                return reserva;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public List<BE.Reserva> ObtenerReservaCanchaFecha(int idCancha)
        {
            try
            {
                List<BE.Reserva> reserva = _reservaDAL.ObtenerReservaCanchaFecha(idCancha);
                return reserva;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerReservaVencida()
        {
            try
            {
                DataTable reserva = _reservaDAL.ObtenerReservaVencida();
                return reserva;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerReservaCliente()
        {
            try
            {
                DataTable bit = _reservaDAL.ObtenerReservaCliente();
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerReservaClienteFechaHora(int idCliente, string fecha, string hora, int idReserva)
        {
            try
            {
                DataTable dt = _reservaDAL.ObtenerReservaClienteFechaHora(idCliente, fecha, hora, idReserva);
                return dt;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerReservaClienteFecha(string fecha)
        {
            try
            {
                DataTable bit = _reservaDAL.ObtenerReservaClienteFecha(fecha);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerReservaClienteCliente(string cliente)
        {
            try
            {
                DataTable bit = _reservaDAL.ObtenerReservaClienteCliente(cliente);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerReservaFechaCliente(string fecha, string cliente)
        {
            try
            {
                DataTable bit = _reservaDAL.ObtenerReservaFechaCliente(fecha, cliente);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public List<string> ObtenerReservaHora(string fecha, string cancha)
        {
            try
            {
                List<string> listaHora = _reservaDAL.ObtenerReservaHora(fecha, cancha);
                return listaHora;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private void ValidarCampos(BE.Reserva reserva)
        {
            if (string.IsNullOrEmpty(reserva.Id.ToString()) || string.IsNullOrEmpty(reserva.Id_Cancha.ToString()) || string.IsNullOrEmpty(reserva.Id_Cliente.ToString()) || string.IsNullOrWhiteSpace(reserva.Fecha.ToString()) || string.IsNullOrWhiteSpace(reserva.Hora) || string.IsNullOrWhiteSpace(reserva.Semana.ToString()) || string.IsNullOrWhiteSpace(reserva.Forma_Pago) || string.IsNullOrEmpty(reserva.Seña.ToString()) || string.IsNullOrEmpty(reserva.Total.ToString()) || string.IsNullOrEmpty(reserva.Pagar.ToString()))
                throw new Exception(TraducirMensaje("msg_CamposVacios"));
        }

        private int ValidarDeudaCliente(BE.Reserva reserva)
        {
            DataTable dt = _deudas.ObtenerDeudaCliente(reserva.Id_Cliente);
            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void ValidarReservaFecha(BE.Reserva reserva)
        {
            string fecha = reserva.Fecha.ToString("dd/MM/yyyy");
            fecha = fecha + " " + reserva.Hora;
            if (DateTime.Parse(fecha) < DateTime.Today)
                throw new Exception(TraducirMensaje("msg_ReservaVencida"));
        }

        private void ValidarReservaSeña(BE.Reserva reserva)
        {
            if(reserva.Seña > reserva.Total)
                throw new Exception(TraducirMensaje("msg_SeñaMayorTotal"));
        }

        private int ValidarReservaClienteFechaHora(BE.Reserva reserva)
        {
            try
            {
                int id = reserva.Id_Cliente;
                string fecha = reserva.Fecha.ToString();
                string hora = reserva.Hora;
                int idReserva = reserva.Id;
                DataTable tabla = _reservaDAL.ObtenerReservaClienteFechaHora(id, fecha, hora, idReserva);
                if (tabla.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorReservaClienteHora"));
            }
        }

        public void SerializarReserva(BE.Reserva reserva)
        {
            try
            {
                DAL.Cancha canchaDAL = new DAL.Cancha();
                DAL.Cliente clienteDAL = new DAL.Cliente();

                string tipoCancha = canchaDAL.ObtenerTipoCanchaPorId(reserva.Id_Cancha);
                List<BE.Cliente> clienteLista = clienteDAL.ObtenerClientePorId(reserva.Id_Cliente);
                string nombreCliente = clienteLista[0].Nombre;
                string apellidoCliente = clienteLista[0].Apellido;

                SerializacionReserva serializacionReserva = SerializacionReserva.FillObject(reserva, tipoCancha, nombreCliente, apellidoCliente);

                string ruta = ConfigurationManager.AppSettings["RutaReservas"];

                string directorio = $"{ruta}Reserva_{reserva.Id}";

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                StreamWriter fichero;
                fichero = File.CreateText($"{directorio}\\Reserva_{reserva.Id}.json");

                string reservaSerializada = JsonConvert.SerializeObject(serializacionReserva, Formatting.Indented);

                fichero.WriteLine($"{reservaSerializada}");
                fichero.Close();
            }
            catch (Exception)
            {
                throw new Exception("Hubo un error al querer serializar la reserva.");
            }
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_idiomaDAL, msgTag);
        }
    }
}
