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
    public class ControlCliente : IControlCliente
    {
        private readonly DAL.ControlCliente _controlClienteDAL;
        private readonly DAL.Observer.Idioma _idiomaDAL;
        private readonly IBitacora _iBitacora;
        private readonly DAL.Cliente _clienteDAL;

        public ControlCliente()
        {
            _controlClienteDAL = new DAL.ControlCliente();
            _idiomaDAL = new DAL.Observer.Idioma();
            _iBitacora = new BLL.Bitacora();
            _clienteDAL = new DAL.Cliente();
        }

        public int AltaControlCliente(BE.Cliente cliente)
        {
            try
            {
                BE.ControlCliente controlCliente = new BE.ControlCliente()
                {
                    ClienteId = cliente.Id,
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Telefono = cliente.Telefono,
                    Fecha = DateTime.Now,
                    UsuarioId = Sesion.GetInstance().Id,
                    Descripcion = "Se dió de alta el cliente",
                };

                ValidarCampo(controlCliente);
                _controlClienteDAL.AltaControlCliente(controlCliente);
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ActualizarControlCliente(BE.Cliente cliente)
        {
            try
            {
                BE.ControlCliente controlCliente = new BE.ControlCliente()
                {
                    ClienteId = cliente.Id,
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Telefono = cliente.Telefono,
                    Fecha = DateTime.Now,
                    UsuarioId = Sesion.GetInstance().Id,
                    Descripcion = "Se realizaron modificaciones en el cliente",
                };

                ValidarCampo(controlCliente);
                _controlClienteDAL.AltaControlCliente(controlCliente);
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaControlCliente(BE.Cliente cliente)
        {
            try
            {
                BE.ControlCliente controlCliente = new BE.ControlCliente()
                {
                    ClienteId = cliente.Id,
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Telefono = cliente.Telefono,
                    Fecha = DateTime.Now,
                    UsuarioId = Sesion.GetInstance().Id,
                    Descripcion = "Se dió de baja el cliente",
                };

                ValidarCampo(controlCliente);
                _controlClienteDAL.AltaControlCliente(controlCliente);
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int RestaurarCliente(BE.Cliente cliente)
        {
            try
            {
                int resultado = ObtenerControlClientePorId(cliente.Id);
                if(resultado == 1)
                {
                    _clienteDAL.ModificarCliente(cliente);
                    ActualizarControlCliente(cliente);
                }
                else
                {
                    _clienteDAL.AltaCliente(cliente);
                    AltaControlCliente(cliente);
                }
                _iBitacora.AltaBitacora("Se restauró el cliente " + cliente.Id + " a un estado anterior.", "MEDIA");
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BE.ControlCliente> ObtenerControlCliente()
        {
            try
            {
                List<BE.ControlCliente> controlCliente = _controlClienteDAL.ObtenerControlCliente();
                return controlCliente;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public int ObtenerControlClientePorId(int id)
        {
            try
            {
                int resultado = _controlClienteDAL.ObtenerControlClientePorId(id);
                return resultado;

            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private void ValidarCampo(BE.ControlCliente controlCliente)
        {
            if (string.IsNullOrEmpty(controlCliente.Id.ToString()) || string.IsNullOrEmpty(controlCliente.ClienteId.ToString()) || string.IsNullOrWhiteSpace(controlCliente.Nombre) || string.IsNullOrWhiteSpace(controlCliente.Apellido) || string.IsNullOrEmpty(controlCliente.Telefono.ToString()) || string.IsNullOrWhiteSpace(controlCliente.Fecha.ToString()) || string.IsNullOrEmpty(controlCliente.UsuarioId.ToString()) || string.IsNullOrWhiteSpace(controlCliente.Descripcion))
                throw new Exception(TraducirMensaje("msg_CamposVacios"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_idiomaDAL, msgTag);
        }

    }
}
