using Interfaces.Composite;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Composite;
using BE.DTOs;
using Servicios;

namespace BLL.Composite
{
    public class Permiso : IPermiso
    {
        #region Inyección de dependencias
        private readonly DAL.Composite.Permiso _permisoDAL;
        private readonly DAL.Observer.Idioma _IdiomaDAL;

        public Permiso()
        {
            _permisoDAL = new DAL.Composite.Permiso();
            _IdiomaDAL = new DAL.Observer.Idioma();
        }
        #endregion

        #region Métodos CRUD
        public void GuardarFamiliaCreada(Familia familia)
        {
            try
            {
                _permisoDAL.GuardarFamiliaCreada(familia);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int AltaFamiliaPatente(Componente componente, bool familia)
        {
            try
            {
                return _permisoDAL.AltaFamiliaPatente(componente, familia);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GuardarPermiso(UsuarioDTO usuario)
        {
            try
            {
                _permisoDAL.GuardarPermiso(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Métodos View
        public IList<Componente> TraerFamiliaPatentes(int familiaId)
        {
            try
            {
                IList<Componente> componentes = _permisoDAL.TraerFamiliaPatentes(familiaId);
                return componentes;
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerComponentes")); }
        }

        public Componente GetFamiliaArbol(int familiaId, Componente componenteOriginal, Componente componenteAgregar)
        {
            try
            {
                Componente comp = _permisoDAL.GetFamiliaArbol(familiaId, componenteOriginal, componenteAgregar);
                return comp;
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerComponentes")); }
        }

        public Componente GetUsuarioArbol(int usuarioId, Componente componenteOriginal, Componente componenteAgregar)
        {
            try
            {
                Componente comp = _permisoDAL.GetUsuarioArbol(usuarioId, componenteOriginal, componenteAgregar);
                return comp;
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerComponentes")); }
        }

        public IList<Familia> ObtenerFamilias()
        {
            try
            {
                IList<Familia> familias = _permisoDAL.ObtenerFamilias();
                return familias;
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerFamilias")); }
        }

        public IList<Patente> GetPatentes()
        {
            try
            {
                IList<Patente> patentes = _permisoDAL.GetPatentes();
                return patentes;
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerPatentes")); }
        }

        public Array TraerPermisos()
        {
            try
            {
                return Enum.GetValues(typeof(BE.Composite.Permiso));
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerPermisos")); }
        }

        public IList<Familia> GetFamiliasValidacion(int familiaId)
        {
            try
            {
                IList<Familia> familias = _permisoDAL.GetFamiliasValidacion(familiaId);
                return familias;
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerFamilias")); }
        }
        #endregion

        #region Tools
        public bool ExisteComponente(Componente componente, int Id)
        {
            bool existeComponente = false;

            if (componente.Id.Equals(Id))
                existeComponente = true;

            else
            {
                foreach (var item in componente.Hijos)
                {
                    existeComponente = ExisteComponente(item, Id);
                    if (existeComponente) return true;
                }
            }

            return existeComponente;
        }

        public void GetComponenteUsuario(UsuarioDTO usuario)
        {
            try
            {
                _permisoDAL.GetComponenteUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GetComponenteFamilia(Familia familia)
        {
            try
            {
                _permisoDAL.GetComponenteFamilia(familia);
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
        #endregion
    }
}
