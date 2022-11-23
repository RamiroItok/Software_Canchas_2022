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
    public class Cliente : ICliente
    {
        private readonly DAL.Cliente _clienteDAL;
        private readonly DAL.Observer.Idioma _idiomaDAL;
        private readonly IBitacora _bitacora;
        private readonly IDigito_Verificador _digitoVerificador;
        private readonly IControlCliente _controlCliente;

        public Cliente()
        {
            _clienteDAL = new DAL.Cliente();
            _idiomaDAL = new DAL.Observer.Idioma();
            _bitacora = new BLL.Bitacora();
            _digitoVerificador = new BLL.DigitoVerificador();
            _controlCliente = new BLL.ControlCliente();
        }

        public int AltaCliente(BE.Cliente cliente)
        {
            try
            {
                ValidarCliente(cliente);
                int id = _clienteDAL.AltaCliente(cliente);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se dió de alta el cliente " + id + ".", "MEDIA");
                _controlCliente.AltaControlCliente(cliente);
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarCliente(BE.Cliente cliente)
        {
            try
            {
                ValidarCliente(cliente);
                int id = _clienteDAL.ModificarCliente(cliente);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se modificó el cliente " + id + ".", "MEDIA");
                _controlCliente.ActualizarControlCliente(cliente);
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaCliente(BE.Cliente cliente)
        {
            try
            {
                int id = _clienteDAL.BajaCliente(cliente);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se dió de baja el cliente " + id + ".", "ALTA");
                _controlCliente.BajaControlCliente(cliente);
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BE.Cliente> ObtenerClientes()
        {
            try
            {
                List<BE.Cliente> clientes = _clienteDAL.ObtenerClientes();
                return clientes;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerNombreClientes()
        {
            try
            {
                DataTable bit = _clienteDAL.ObtenerNombreClientes();
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public List<BE.Cliente> ObtenerClientePorId(int id)
        {
            try
            {
                return _clienteDAL.ObtenerClientePorId(id);
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private void ValidarCliente(BE.Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Id.ToString()) || string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido) || string.IsNullOrEmpty(cliente.Telefono.ToString()))
                throw new Exception(TraducirMensaje("msg_CamposVacios"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_idiomaDAL, msgTag);
        }
    }
}
