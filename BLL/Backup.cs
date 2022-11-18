using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Backup : IBackUp
    {
        private readonly DAL.Backup _backupDAL;
        private readonly DAL.Observer.Idioma _IdiomaDAL;
        private readonly IBitacora _iBitacora;
        private readonly IDigito_Verificador _iDigitoVerificador;

        public Backup()
        {
            _backupDAL = new DAL.Backup();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _iBitacora = new BLL.Bitacora();
            _iDigitoVerificador = new BLL.DigitoVerificador();
        }

        public string Realizar_Backup(string ruta, string nombre)
        {
            try
            {
                _backupDAL.Realizar_Backup(ruta, nombre);
                _iBitacora.AltaBitacora("Se realizó una copia de seguridad.","ALTA");
                return TraducirMensaje("msg_BackupRealizado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Realizar_Restore(string ruta)
        {
            try
            {
                _backupDAL.Realizar_Restore(ruta);
                _iBitacora.AltaBitacora("Se realizó un restore.", "ALTA");
                return TraducirMensaje("msg_RestoreRealizado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CrearBaseDeDatos()
        {
            try
            {
                string server = ConfigurationManager.AppSettings["server"];
                string nombreBase = ConfigurationManager.AppSettings["base"];

                _backupDAL.CrearBaseDeDatos(server, nombreBase);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_IdiomaDAL, msgTag);
        }
    }
}
