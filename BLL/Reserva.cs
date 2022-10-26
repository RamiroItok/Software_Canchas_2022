using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
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
                int resultado = ValidarDeudaCliente(reserva);
                if (resultado == 0)
                {
                    int id = _reservaDAL.AltaReserva(reserva);
                    if (reserva.Deuda > 0)
                    {
                        _deudas.AltaDeuda(id, reserva.Id_Cliente, DateTime.Now);
                    }

                    //GUARDAR EN BITACORA
                    _bitacora.AltaBitacora("Se dió de alta la reserva " + id + ".", "MEDIA");
                    return id;
                }
                else
                {
                    return 0;
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
                int id = _reservaDAL.ModificarReserva(reserva);
                if (reserva.Deuda > 0)
                {
                    _deudas.ModificarDeuda(reserva.Id_Cliente, DateTime.Now);
                }
                else
                {
                    _deudas.BajaDeuda(reserva.Id_Cliente);
                }

                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se modificó la reserva " + id + ".", "MEDIA");
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaReserva(BE.Reserva reserva)
        {
            try
            {
                int id = _reservaDAL.BajaReserva(reserva);
                _deudas.BajaDeuda(reserva.Id_Cliente);

                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se dió de baja la reserva " + id + ".", "MEDIA");
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

        public float CalcularTotalHora(int hora, int total)
        {
            float tot;
            if (hora > 18)
                tot = total + 500;
            else
                tot = total;

            return tot;
        }

        public float CalcularTotalTipoPago(int total, string formaPago)
        {
            if (formaPago == "Efectivo")
            {
                total = ((total * 90) / 100);
            }
            
            return total;
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
            if (string.IsNullOrEmpty(reserva.Id.ToString()) || string.IsNullOrEmpty(reserva.Id_Cancha.ToString()) || string.IsNullOrEmpty(reserva.Id_Cliente.ToString()) || string.IsNullOrWhiteSpace(reserva.Fecha.ToString()) || string.IsNullOrWhiteSpace(reserva.Hora) || string.IsNullOrWhiteSpace(reserva.Forma_Pago) || string.IsNullOrEmpty(reserva.Seña.ToString()) || string.IsNullOrEmpty(reserva.Total.ToString()) || string.IsNullOrEmpty(reserva.Deuda.ToString()))
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

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_idiomaDAL, msgTag);
        }
    }
}
