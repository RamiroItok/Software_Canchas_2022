﻿using Interfaces;
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

        public Reserva()
        {
            _reservaDAL = new DAL.Reserva();
            _idiomaDAL = new DAL.Observer.Idioma();
        }

        public int AltaReserva(BE.Reserva reserva)
        {
            try
            {
                ValidarReserva(reserva);
                return _reservaDAL.AltaReserva(reserva);
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
                ValidarReserva(reserva);
                return _reservaDAL.ModificarReserva(reserva);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void BajaReserva(BE.Reserva reserva)
        {
            try
            {
                _reservaDAL.BajaReserva(reserva);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public float CalcularDeuda(out float tot, float seña, int hora, float total)
        {
            try
            {
                float deuda;
                if (hora > 18)
                {
                    tot = total + 500;
                }
                else
                    tot = total;

                deuda = tot - seña;
                return deuda;
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

        public List<string> ObtenerReservaHora(string fecha)
        {
            try
            {
                List<string> listaHora = _reservaDAL.ObtenerReservaHora(fecha);
                return listaHora;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private void ValidarReserva(BE.Reserva reserva)
        {
            if (string.IsNullOrEmpty(reserva.Id.ToString()))
                throw new Exception(TraducirMensaje("msg_ReservaId"));

            if (string.IsNullOrEmpty(reserva.Id_Cancha.ToString()) || string.IsNullOrEmpty(reserva.Id_Cliente.ToString()) || string.IsNullOrWhiteSpace(reserva.Fecha.ToString()) || string.IsNullOrWhiteSpace(reserva.Hora) || string.IsNullOrWhiteSpace(reserva.Forma_Pago) || string.IsNullOrEmpty(reserva.Seña.ToString()) || string.IsNullOrEmpty(reserva.Total.ToString()) || string.IsNullOrEmpty(reserva.Deuda.ToString()))
                throw new Exception(TraducirMensaje("msg_CampoVacio"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_idiomaDAL, msgTag);
        }
    }
}