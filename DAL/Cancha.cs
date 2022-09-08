﻿using DAL.Conexion;
using DAL.Tools;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cancha : Acceso, ICancha
    {
        #region Inyección de dependencias
        private readonly Fill _fill;
        public Cancha()
        {
            _fill = new Fill();
        }
        #endregion

        #region Querys
        private const string ALTA_CANCHA = "INSERT INTO Cancha (Tipo, Material) OUTPUT inserted.Id_Cancha Values (@parTipo, @parMaterial)";
        private const string MODIFICAR_CANCHA = "UPDATE Cancha SET Tipo = @parTipo, Material = @parMaterial WHERE Id_Cancha = @parId_Cancha";
        private const string BAJA_CANCHA = "DELETE FROM Cancha WHERE Id_Cancha = {0}";
        private const string OBTENER_CANCHAS = "SELECT * FROM Cancha";
        #endregion

        public int AltaCancha(BE.Cancha cancha)
        {
            try
            {
                ExecuteCommandText = ALTA_CANCHA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parTipo", cancha.Tipo);
                ExecuteParameters.Parameters.AddWithValue("@parMaterial", cancha.Material);


                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int ModificarCancha(BE.Cancha cancha)
        {
            try
            {
                ExecuteCommandText = MODIFICAR_CANCHA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Cancha", cancha.Id_Cancha);
                ExecuteParameters.Parameters.AddWithValue("@parTipo", cancha.Tipo);
                ExecuteParameters.Parameters.AddWithValue("@parMaterial", cancha.Material);


                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int BajaCancha(int id_cancha)
        {
            try
            {   
                ExecuteCommandText = BAJA_CANCHA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Cancha", id_cancha);


                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.Cancha> ObtenerCanchas()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_CANCHAS);
                DataSet ds = ExecuteNonReader();

                List<BE.Cancha> canchas = new List<BE.Cancha>();

                if (ds.Tables[0].Rows.Count > 0)
                    canchas = _fill.FillListCancha(ds);

                return canchas;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }
    }
}