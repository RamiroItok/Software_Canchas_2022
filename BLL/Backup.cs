﻿using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
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

        public Backup()
        {
            _backupDAL = new DAL.Backup();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _iBitacora = new BLL.Bitacora();
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

        public string Realizar_Restore()
        {
            try
            {
                _backupDAL.Realizar_Restore();
                _iBitacora.AltaBitacora("Se realizó un restore.", "ALTA");
                return TraducirMensaje("msg_RestoreRealizado");
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