using Interfaces;
using Interfaces.Observer;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cancha : ICancha
    {
        
        private readonly DAL.Cancha _CanchaDAL;
        private readonly DAL.Observer.Idioma _IdiomaDAL;
        private readonly IBitacora _bitacora;
        private readonly IDigito_Verificador _digitoVerificador;

        public Cancha()
        {
            _CanchaDAL = new DAL.Cancha();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _bitacora = new BLL.Bitacora();
            _digitoVerificador = new BLL.DigitoVerificador();
        }
        

        public int AltaCancha(BE.Cancha cancha)
        {
            try
            {
                ValidarCampo(cancha);
                int id = _CanchaDAL.AltaCancha(cancha);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se dió de alta la cancha " + id + ".", "BAJA");
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarCancha(BE.Cancha cancha)
        {
            try
            {
                ValidarCampo(cancha);
                int id =  _CanchaDAL.ModificarCancha(cancha);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se modificó la cancha " + id + ".", "BAJA");
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaCancha(BE.Cancha cancha)
        {
            try
            {
                int id = _CanchaDAL.BajaCancha(cancha);
                //GUARDAR EN BITACORA
                _bitacora.AltaBitacora("Se dió de baja la cancha " + id + ".", "ALTA");
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BE.Cancha> ObtenerCanchas()
        {
            try
            {
                List<BE.Cancha> canchas = _CanchaDAL.ObtenerCanchas();
                return canchas;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorObtenerCanchas"));
            }
        }

        public DataTable ObtenerTipoCanchas()
        {
            try
            {
                DataTable bit = _CanchaDAL.ObtenerTipoCanchas();
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable ObtenerIdCanchas(string tipo)
        {
            try
            {
                DataTable bit = _CanchaDAL.ObtenerIdCanchas(tipo);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public int ObtenerCanchaPorId(int id)
        {
            try
            {
                return _CanchaDAL.ObtenerCanchaPorId(id);
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public string ObtenerTipoCanchaPorId(int id)
        {
            try
            {
                return _CanchaDAL.ObtenerTipoCanchaPorId(id);
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private void ValidarCampo(BE.Cancha cancha)
        { 
            if (string.IsNullOrEmpty(cancha.Id.ToString()) || string.IsNullOrWhiteSpace(cancha.Tipo) || string.IsNullOrWhiteSpace(cancha.Material) || string.IsNullOrEmpty(cancha.PrecioBase.ToString()))
                throw new Exception(TraducirMensaje("msg_CamposVacios"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_IdiomaDAL, msgTag);
        }
        
        public float ObtenerPrecio(string id)
        {
            try
            {
                float cancha = _CanchaDAL.ObtenerPrecio(id);
                return cancha;
            }
            catch (Exception) 
            { 
                throw new Exception(TraducirMensaje("msg_ErrorPrecio"));
            }
        }
    }
}
