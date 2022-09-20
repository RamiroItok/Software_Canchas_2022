using BE.Observer;
using Interfaces.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Observer
{
    public class Idioma : ITraductor
    {
        #region Inyección de dependencias
        private readonly DAL.Observer.Idioma _idiomaDAL;

        public Idioma()
        {
            _idiomaDAL = new DAL.Observer.Idioma();
        }
        #endregion

        #region Métodos CRUD
        public int AltaIdioma(BE.Observer.Idioma idioma)
        {
            try
            {
                ValidarIdioma(idioma);
                return _idiomaDAL.AltaIdioma(idioma);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarIdioma(BE.Observer.Idioma idioma)
        {
            try
            {
                ValidarIdioma(idioma);
                return _idiomaDAL.ModificarIdioma(idioma);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AltaTraduccion(IIdioma idioma, BE.Observer.Traduccion traduccion)
        {
            try
            {
                ValidarIdioma(idioma);
                ValidarTraduccion(traduccion);
                return _idiomaDAL.AltaTraduccion(idioma, traduccion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int ModificarTraduccion(BE.Observer.Traduccion traduccion)
        {
            try
            {
                ValidarTraduccion(traduccion);
                return _idiomaDAL.ModificarTraduccion(traduccion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Métodos View
        public IList<IIdioma> ObtenerIdiomas()
        {
            try
            {
                IList<IIdioma> idiomas = _idiomaDAL.ObtenerIdiomas();

                return idiomas;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener los idiomas."); }
        }

        public IIdioma ObtenerIdiomaDefault()
        {
            try
            {
                IIdioma idioma = _idiomaDAL.ObtenerIdiomaDefault();

                return idioma;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener los idiomas."); }
        }

        public IDictionary<string, ITraduccion> ObtenerTraducciones(IIdioma idioma)
        {
            try
            {
                IDictionary<string, ITraduccion> traducciones = _idiomaDAL.ObtenerTraducciones(idioma);

                return traducciones;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener las traducciones."); }
        }

        public List<BE.Observer.Etiqueta> GetEtiquetas()
        {
            try
            {
                List<BE.Observer.Etiqueta> etiquetas = _idiomaDAL.GetEtiquetas();
                return etiquetas;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener las etiquetas."); }
        }

        public List<BE.Observer.Traduccion> GetTraduccionesPorIdioma(int idiomaId)
        {
            try
            {
                List<BE.Observer.Traduccion> traducciones = _idiomaDAL.GetTraduccionesPorIdioma(idiomaId);
                return traducciones;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener los idiomas."); }
        }

        public BE.Observer.Traduccion GetTraduccionId(int traduccionId)
        {
            try
            {
                BE.Observer.Traduccion traduccion = _idiomaDAL.GetTraduccionId(traduccionId);
                return traduccion;
            }
            catch (Exception) { throw new Exception("Hubo un error al querer obtener la traducción."); }
        }
        #endregion

        #region Tools
        private void ValidarTraduccion(BE.Observer.Traduccion traduccion)
        {
            if (string.IsNullOrWhiteSpace(traduccion.Texto)) throw new Exception("La traducción no puede estar vacía.");
        }

        private void ValidarIdioma(BE.Observer.IIdioma idioma)
        {
            if (string.IsNullOrWhiteSpace(idioma.Nombre)) throw new Exception("El idioma no puede estar vacío.");
        }
        #endregion
    }
}
