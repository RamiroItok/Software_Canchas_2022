using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class ControlReserva : IControlReserva
    {
        private readonly DAL.ControlReserva _controlReservaDAL;
        private readonly ICancha _cancha;
        private readonly ICliente _cliente;
        private readonly IDigito_Verificador _digitoVerificador;
        private readonly DAL.Observer.Idioma _idiomaDAL;

        public ControlReserva()
        {
            _controlReservaDAL = new DAL.ControlReserva();
            _idiomaDAL = new DAL.Observer.Idioma();
            _cancha = new BLL.Cancha();
            _cliente = new BLL.Cliente();
            _digitoVerificador = new BLL.DigitoVerificador();
        }

        public int AltaControlReserva(BE.Reserva reserva)
        {
            try
            {
                BE.ControlReserva controlReserva = new BE.ControlReserva()
                {
                    Id_Cancha = _cancha.ObtenerCanchaPorId(reserva.Id_Cancha),
                    Id_Cliente = _cliente.ObtenerClientePorId(reserva.Id_Cliente),
                    Fecha = reserva.Fecha,
                    Hora = reserva.Hora,
                    Forma_Pago = reserva.Forma_Pago,
                    Seña = reserva.Seña,
                    Total = reserva.Total,
                    Deuda = reserva.Deuda,
                    Fecha_Modificacion = DateTime.Now,
                    Id_Usuario = Sesion.GetInstance().Id,
                    Descripcion = "Se dió de alta la reserva",
                };

                ValidarCampo(controlReserva);
                _controlReservaDAL.AltaControlReserva(controlReserva);
                _digitoVerificador.RecalcularDV();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ActualizarControlReserva(BE.Reserva reserva)
        {
            try
            {
                BE.ControlReserva controlReserva = new BE.ControlReserva()
                {
                    Id_Cancha = _cancha.ObtenerCanchaPorId(reserva.Id_Cancha),
                    Id_Cliente = _cliente.ObtenerClientePorId(reserva.Id_Cliente),
                    Fecha = reserva.Fecha,
                    Hora = reserva.Hora,
                    Forma_Pago = reserva.Forma_Pago,
                    Seña = reserva.Seña,
                    Total = reserva.Total,
                    Deuda = reserva.Deuda,
                    Fecha_Modificacion = DateTime.Now,
                    Id_Usuario = Sesion.GetInstance().Id,
                    Descripcion = "Se realizaron modificaciones en la reserva",
                };

                ValidarCampo(controlReserva);
                _controlReservaDAL.AltaControlReserva(controlReserva);
                _digitoVerificador.RecalcularDV();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaReservaControlReserva(BE.Reserva reserva)
        {
            try
            {
                BE.ControlReserva controlReserva = new BE.ControlReserva()
                {
                    Id_Cancha = _cancha.ObtenerCanchaPorId(reserva.Id_Cancha),
                    Id_Cliente = _cliente.ObtenerClientePorId(reserva.Id_Cliente),
                    Fecha = reserva.Fecha,
                    Hora = reserva.Hora,
                    Forma_Pago = reserva.Forma_Pago,
                    Seña = reserva.Seña,
                    Total = reserva.Total,
                    Deuda = reserva.Deuda,
                    Fecha_Modificacion = DateTime.Now,
                    Id_Usuario = Sesion.GetInstance().Id,
                    Descripcion = "Se dió de baja la reserva",
                };

                ValidarCampo(controlReserva);
                _controlReservaDAL.AltaControlReserva(controlReserva);
                _digitoVerificador.RecalcularDV();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BE.ControlReserva> ObtenerControlReservas()
        {
            try
            {
                List<BE.ControlReserva> controlReservas = _controlReservaDAL.ObtenerControlReserva();
                return controlReservas;

            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }


        private void ValidarCampo(BE.ControlReserva controlReserva)
        {
            if (string.IsNullOrEmpty(controlReserva.Id.ToString()) || string.IsNullOrEmpty(controlReserva.Id_Cancha.ToString()) || string.IsNullOrEmpty(controlReserva.Id_Cliente.ToString()) || string.IsNullOrEmpty(controlReserva.Fecha.ToString()) || string.IsNullOrWhiteSpace(controlReserva.Hora) || string.IsNullOrWhiteSpace(controlReserva.Forma_Pago) || string.IsNullOrEmpty(controlReserva.Seña.ToString()) || string.IsNullOrEmpty(controlReserva.Total.ToString()) || string.IsNullOrEmpty(controlReserva.Deuda.ToString()) || string.IsNullOrWhiteSpace(controlReserva.Fecha_Modificacion.ToString()) || string.IsNullOrEmpty(controlReserva.Id_Usuario.ToString()))
                throw new Exception(TraducirMensaje("msg_CamposVacios"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_idiomaDAL, msgTag);
        }

    }
}
