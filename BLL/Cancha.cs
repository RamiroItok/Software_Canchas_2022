﻿using Interfaces;
using Interfaces.Observer;
using Servicios;
using System;
using System.Collections.Generic;
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
                ValidarCancha(cancha);
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
                ValidarCancha(cancha);
                return _CanchaDAL.ModificarCancha(cancha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int BajaCancha(int cancha)
        {
            try
            {
                return _CanchaDAL.BajaCancha(cancha);
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
       
        private void ValidarCancha(BE.Cancha cancha)
        {
            if (string.IsNullOrEmpty(cancha.Id_Cancha.ToString())) 
                throw new Exception(TraducirMensaje("msg_CanchaId_Cancha"));

            if (string.IsNullOrWhiteSpace(cancha.Tipo) || string.IsNullOrWhiteSpace(cancha.Material))
                throw new Exception("Falta completar un campo");
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_IdiomaDAL, msgTag);
        }
        
    }
}