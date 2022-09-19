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

        public Cancha()
        {
            _CanchaDAL = new DAL.Cancha();
            _IdiomaDAL = new DAL.Observer.Idioma();
        }
        

        public int AltaCancha(BE.Cancha cancha)
        {
            try
            {
                ValidarCampo(cancha);
                return _CanchaDAL.AltaCancha(cancha);
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
                return _CanchaDAL.ModificarCancha(cancha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void BajaCancha(BE.Cancha cancha)
        {
            try
            {
                _CanchaDAL.BajaCancha(cancha);
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
                throw new Exception("Error al Obtener las canchas");
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

        private void ValidarCampo(BE.Cancha cancha)
        {
            if (string.IsNullOrEmpty(cancha.Id.ToString())) 
                throw new Exception(TraducirMensaje("msg_CanchaId_Cancha"));

            if (string.IsNullOrWhiteSpace(cancha.Tipo) || string.IsNullOrWhiteSpace(cancha.Material) || string.IsNullOrEmpty(cancha.PrecioBase.ToString()))
                throw new Exception(TraducirMensaje("msg_CampoVacio"));
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
                throw new Exception("Hubo un error al realizar el calculo."); 
            }
        }
    }
}
