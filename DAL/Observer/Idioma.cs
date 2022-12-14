using DAL.Conexion;
using DAL.Tools;
using Interfaces.Observer;
using BE.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Observer
{
    public class Idioma : Acceso, ITraductor
    {
        //Inyección de dependencias
        private readonly Fill _fill;
        public Idioma()
        {
            _fill = new Fill();
        }

        //Querys
        private const string OBTENER_IDIOMAS = "SELECT * FROM Idioma";
        private const string OBTENER_TRADUCCIONES= "SELECT t.Id, t.Traduccion as Traduccion, e.Id, e.Nombre as Nombre_Etiqueta " +
                                                    "FROM TRADUCCION t INNER JOIN Etiqueta e on t.EtiquetaId = e.Id WHERE t.IdiomaId = {0}";
        private const string ALTA_IDIOMA = "INSERT INTO Idioma (Nombre, [Default]) OUTPUT inserted.Id VALUES (@parNombre, 0)";
        private const string MODIFICAR_IDIOMA = "UPDATE Idioma SET Nombre = @parNombre OUTPUT inserted.Id WHERE Id = @parId";
        private const string ALTA_TRADUCCION = "INSERT INTO Traduccion (IdiomaId, EtiquetaId, Traduccion) OUTPUT inserted.Id VALUES (@parIdiomaId, @parEtiquetaId, @parTraduccion)";
        private const string MODIFICAR_TRADUCCION = "UPDATE Traduccion SET Traduccion = @parTraduccion OUTPUT inserted.Id WHERE Id = @parId";
        private const string GET_ETIQUETAS = "SELECT * FROM Etiqueta";
        private const string GET_ETIQUETA = "SELECT * FROM Etiqueta WHERE Id = {0}";
        private const string GET_TRADUCCIONES_POR_IDIOMA= "SELECT * FROM Traduccion WHERE IdiomaId = {0}";
        private const string GET_TRADUCCIONES_POR_ID = "SELECT * FROM Traduccion WHERE Id = {0}";

        public IList<IIdioma> ObtenerIdiomas()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_IDIOMAS);
                DataSet ds = ExecuteNonReader();

                IList<IIdioma> _idiomas = new List<IIdioma>();

                if (ds.Tables[0].Rows.Count > 0)
                    _idiomas = _fill.FillListIdioma(ds);

                return _idiomas;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public IIdioma ObtenerIdiomaDefault()
        {
            return ObtenerIdiomas().Where(i => i.Default).FirstOrDefault();
        }

        public IDictionary<string, ITraduccion> ObtenerTraducciones(IIdioma idioma)
        {
            try
            {
                //si no hay idioma definido, traigo el idioma por default (que es el español)
                if (idioma == null) idioma = ObtenerIdiomaDefault();

                IDictionary<string, ITraduccion> _traducciones = new Dictionary<string, ITraduccion>(); // Traigo las traducciones del idioma seleccionado.
                //IList<ITraduccion> _traducciones = new List<ITraduccion>();

                SelectCommandText = String.Format(OBTENER_TRADUCCIONES, idioma.Id);
                DataSet ds = ExecuteNonReader();

                if (ds.Tables[0].Rows.Count > 0)
                    _traducciones = _fill.FillTraducciones(ds);

                return _traducciones;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int AltaIdioma(BE.Observer.Idioma idioma)
        {
            try
            {
                ExecuteCommandText = ALTA_IDIOMA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parNombre", idioma.Nombre);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }


        public int ModificarIdioma(BE.Observer.Idioma idioma)
        {
            try
            {
                ExecuteCommandText = MODIFICAR_IDIOMA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", idioma.Id);
                ExecuteParameters.Parameters.AddWithValue("@parNombre", idioma.Nombre);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int AltaTraduccion(IIdioma idioma, BE.Observer.Traduccion traduccion)
        {
            try
            {
                ExecuteCommandText = ALTA_TRADUCCION;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parIdiomaId", idioma.Id);
                ExecuteParameters.Parameters.AddWithValue("@parEtiquetaId", traduccion.Etiqueta.Id);
                ExecuteParameters.Parameters.AddWithValue("@parTraduccion", traduccion.Texto);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public int ModificarTraduccion(BE.Observer.Traduccion traduccion)
        {
            try
            {
                ExecuteCommandText = MODIFICAR_TRADUCCION;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parTraduccion", traduccion.Texto);
                ExecuteParameters.Parameters.AddWithValue("@parId", traduccion.Id);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.Observer.Etiqueta> GetEtiquetas()
        {
            try
            {
                SelectCommandText = String.Format(GET_ETIQUETAS);
                DataSet ds = ExecuteNonReader();

                List<BE.Observer.Etiqueta> etiquetas = new List<BE.Observer.Etiqueta>();

                if (ds.Tables[0].Rows.Count > 0)
                    etiquetas = _fill.FillListEtiqueta(ds);

                return etiquetas;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public BE.Observer.Etiqueta GetEtiqueta(int Id_Etiqueta)
        {
            try
            {
                SelectCommandText = String.Format(GET_ETIQUETA, Id_Etiqueta);

                DataSet ds = ExecuteNonReader();
                BE.Observer.Etiqueta etiqueta = ds.Tables[0].Rows.Count <= 0 ? null : _fill.FillObjectEtiqueta(ds.Tables[0].Rows[0]);

                return etiqueta;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.Observer.Traduccion> GetTraduccionesPorIdioma(int Id_Idioma)
        {
            try
            {
                SelectCommandText = String.Format(GET_TRADUCCIONES_POR_IDIOMA, Id_Idioma);
                DataSet ds = ExecuteNonReader();

                List<BE.Observer.Traduccion> traducciones = new List<BE.Observer.Traduccion>();

                if (ds.Tables[0].Rows.Count > 0)
                    traducciones = _fill.FillListGridTraduccion(ds);

                return traducciones;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public BE.Observer.Traduccion GetTraduccionId(int Id_Traduccion)
        {
            try
            {
                SelectCommandText = String.Format(GET_TRADUCCIONES_POR_ID, Id_Traduccion);

                DataSet ds = ExecuteNonReader();
                BE.Observer.Traduccion traduccion = ds.Tables[0].Rows.Count <= 0 ? null : _fill.FillGridTraduccion(ds.Tables[0].Rows[0]);

                return traduccion;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        
    }
}
