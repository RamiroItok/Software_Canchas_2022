using DAL.Conexion;
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
        private const string ALTA_CANCHA = "INSERT INTO Cancha (Tipo, Material, PrecioBase) OUTPUT inserted.Id Values (@parTipo, @parMaterial, @parPrecioBase)";
        private const string MODIFICAR_CANCHA = "UPDATE Cancha SET Tipo = @parTipo, Material = @parMaterial, PrecioBase = @parPrecioBase OUTPUT inserted.Id WHERE Id = @parId";
        private const string BAJA_CANCHA = "DELETE FROM Cancha WHERE Id = @parId";
        private const string OBTENER_CANCHAS = "SELECT * FROM Cancha";
        private const string OBTENER_TIPO_CANCHAS = "SELECT Tipo FROM Cancha group by Tipo";
        #endregion

        public int AltaCancha(BE.Cancha cancha)
        {
            try
            {
                ExecuteCommandText = ALTA_CANCHA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parTipo", cancha.Tipo);
                ExecuteParameters.Parameters.AddWithValue("@parMaterial", cancha.Material);
                ExecuteParameters.Parameters.AddWithValue("@parPrecioBase", cancha.PrecioBase);

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

                ExecuteParameters.Parameters.AddWithValue("@parId", cancha.Id);
                ExecuteParameters.Parameters.AddWithValue("@parTipo", cancha.Tipo);
                ExecuteParameters.Parameters.AddWithValue("@parMaterial", cancha.Material);
                ExecuteParameters.Parameters.AddWithValue("@parPrecioBase", cancha.PrecioBase);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public void BajaCancha(BE.Cancha cancha)
        {
            try
            {   
                ExecuteCommandText = BAJA_CANCHA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", cancha.Id);

                ExecuteNonQuery();
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

        public DataTable ObtenerTipoCanchas()
        {
            try
            {
                string consulta = OBTENER_TIPO_CANCHAS;
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public DataTable ObtenerIdCanchas(string tipo)
        {
            try
            {
                string consulta = $@"SELECT Id FROM Cancha WHERE Tipo = '{tipo}'";
                DataTable dt = GenerarConsulta(consulta);
                return dt;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public float ObtenerPrecio(string id)
        {
            try
            {
                float precio = 0;
                string consulta = $@"SELECT TOP 1 PrecioBase FROM Cancha WHERE Id = '{id}'";
                DataTable dt = GenerarConsulta(consulta);
                precio = float.Parse(dt.Rows[0][0].ToString());
                return precio;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }
    }
}
