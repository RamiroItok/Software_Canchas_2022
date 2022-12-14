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
    public class Bitacora : IBitacora
    {
        private readonly DAL.Bitacora _BitacoraDAL;
        private readonly DAL.Observer.Idioma _IdiomaDAL;
        private readonly IDigito_Verificador _digitoVerificador;

        public Bitacora()
        {
            _BitacoraDAL = new DAL.Bitacora();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _digitoVerificador = new BLL.DigitoVerificador();
        }

        public int AltaBitacora(string descripcion, string criticidad)
        {
            try
            {
                BE.Bitacora bitacora = new BE.Bitacora();
                bitacora.Nombre_Usuario = Sesion.GetInstance().Nombre_Usuario;
                bitacora.Descripcion = descripcion;
                bitacora.Fecha = DateTime.Now;
                bitacora.Criticidad = criticidad;
                
                
                ValidarCampo(bitacora);
                _BitacoraDAL.AltaBitacora(bitacora);
                _digitoVerificador.RecalcularDV();
                return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaBitacora(string fechaIni, string fechaFin)
        {
            try
            {
                int id = _BitacoraDAL.BajaBitacora(fechaIni, fechaFin);
                //GUARDAR EN BITACORA
                AltaBitacora("Se eliminaron las bitacoras desde el día " + fechaIni + " hasta el día " + fechaFin + "." , "ALTA");
                _digitoVerificador.RecalcularDV();
                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BE.Bitacora> ListarEventos()
        {
            try
            {
                List<BE.Bitacora> bitacora = _BitacoraDAL.ListarEventos();
                return bitacora;

            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable Listar_Evento_Between(string fecha_ini, string fecha_fin)
        {
            try
            {
                DataTable bit = _BitacoraDAL.Listar_Evento_Between(fecha_ini, fecha_fin);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable Listar_Evento_Between_Usuario(string fecha_ini, string fecha_fin, string nombre_usuario)
        {
            try
            {
                DataTable bit = _BitacoraDAL.Listar_Evento_Between_Usuario(fecha_ini, fecha_fin, nombre_usuario);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable Listar_Evento_Usuario(string nombre_usuario)
        {
            try
            {
                DataTable bit = _BitacoraDAL.Listar_Evento_Usuario(nombre_usuario);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable Listar_Evento_Between_Critic(string fecha_ini, string fecha_fin, string critic)
        {
            try
            {
                DataTable bit = _BitacoraDAL.Listar_Evento_Between_Critic(fecha_ini, fecha_fin, critic);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable Listar_Evento_Crit(string critic)
        {
            try
            {
                DataTable bit = _BitacoraDAL.Listar_Evento_Crit(critic);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable Listar_Evento_Crit_Usu(string nombre_usuario, string crit)
        {
            try
            {
                DataTable bit = _BitacoraDAL.Listar_Evento_Crit_Usu(nombre_usuario, crit);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        public DataTable Listar_Evento_Fecha_Usu_Crit(string fecha_ini, string fecha_fin, string nombre_usuario, string crit)
        {
            try
            {
                DataTable bit = _BitacoraDAL.Listar_Evento_Fecha_Usu_Crit(fecha_ini, fecha_fin, nombre_usuario, crit);
                return bit;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private void ValidarCampo(BE.Bitacora bitacora)
        {
            if (string.IsNullOrEmpty(bitacora.Id.ToString()) || string.IsNullOrEmpty(bitacora.Nombre_Usuario) || string.IsNullOrWhiteSpace(bitacora.Descripcion) || string.IsNullOrEmpty(bitacora.Fecha.ToString()) || string.IsNullOrWhiteSpace(bitacora.Criticidad))
                throw new Exception(TraducirMensaje("msg_CamposVacios"));
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_IdiomaDAL, msgTag);
        }

    }
}
