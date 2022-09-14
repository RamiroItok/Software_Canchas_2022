using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente : ICliente
    {
        private readonly DAL.Cliente _clienteDAL;
        private readonly DAL.Observer.Idioma _idiomaDAL;

        public Cliente()
        {
            _clienteDAL = new DAL.Cliente();
            _idiomaDAL = new DAL.Observer.Idioma();
        }

        public int AltaCliente(BE.Cliente cliente)
        {
            try
            {
                ValidarCliente(cliente);
                return _clienteDAL.AltaCliente(cliente);
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
                return _clienteDAL.ModificarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void BajaCliente(BE.Cliente cliente)
        {
            try
            {
                _clienteDAL.BajaCliente(cliente);
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
                throw new Exception(TraducirMensaje("msg_ErrorListarClientes"));
            }
        }

        private void ValidarCliente(BE.Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Id_Cliente.ToString()))
                throw new Exception(TraducirMensaje("msg_CanchaId_Cancha"));

            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido) || string.IsNullOrEmpty(cliente.Telefono.ToString()))
                throw new Exception(TraducirMensaje("msg_CampoVacio"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_idiomaDAL, msgTag);
        }
    }
}
