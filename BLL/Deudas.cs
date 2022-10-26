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
    public class Deudas : IDeudas
    {
        private readonly DAL.Deudas _deudasDAL;
        private readonly DAL.Observer.Idioma _IdiomaDAL;
        private readonly IDigito_Verificador _digitoVerificador;

        public Deudas()
        {
            _deudasDAL = new DAL.Deudas();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _digitoVerificador = new BLL.DigitoVerificador();
        }

        public int AltaDeuda(int idReserva, int idCliente, DateTime fechaPago)
        {
            try
            {
                BE.Deudas deuda = new BE.Deudas()
                {
                    Id_Reserva = idReserva,
                    Id_Cliente = idCliente,
                    Fecha_Pago = fechaPago
                };

                ValidarCampo(deuda);
                int id = _deudasDAL.AltaDeuda(deuda);
                _digitoVerificador.RecalcularDV();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarDeuda(int idCliente, DateTime fechaPago)
        {
            try
            {
                int id = _deudasDAL.ModificarDeuda(idCliente, fechaPago);
                _digitoVerificador.RecalcularDV();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaDeuda(int idCliente)
        {
            try
            {
                int id = _deudasDAL.BajaDeuda(idCliente);
                _digitoVerificador.RecalcularDV();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarDeudas()
        {
            try
            {
                DataTable dt = _deudasDAL.ListarDeudas();
                return dt;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerDeudaCliente(int idCliente)
        {
            try
            {
                DataTable dt = _deudasDAL.ObtenerDeudaCliente(idCliente);
                return dt;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private void ValidarCampo(BE.Deudas deuda)
        {
            if (string.IsNullOrEmpty(deuda.Id_Reserva.ToString()) || string.IsNullOrWhiteSpace(deuda.Id_Cliente.ToString()) || string.IsNullOrEmpty(deuda.Fecha_Pago.ToString()))
                throw new Exception(TraducirMensaje("msg_CamposVacios"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_IdiomaDAL, msgTag);
        }
    }
}
