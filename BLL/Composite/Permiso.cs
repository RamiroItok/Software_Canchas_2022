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
using Interfaces;

namespace BLL.Composite
{
    public class Permiso : IPermiso
    {
        private readonly DAL.Composite.Permiso _permisoDAL;
        private readonly DAL.Observer.Idioma _IdiomaDAL;
        private readonly IBitacora _iBitacora;

        public Permiso()
        {
            _permisoDAL = new DAL.Composite.Permiso();
            _IdiomaDAL = new DAL.Observer.Idioma();
            _iBitacora = new BLL.Bitacora();
        }
        public void GuardarFamiliaCreada(Familia familia)
        {
            try
            {
                _permisoDAL.GuardarFamiliaCreada(familia);
                _iBitacora.AltaBitacora("Se realizaron modificaciones en la familia " + familia.Nombre + ".","ALTA");
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
                _permisoDAL.AltaFamiliaPatente(componente, familia);
                _iBitacora.AltaBitacora("Se agregó una familia a patente.","ALTA");
                return 1;
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
                _iBitacora.AltaBitacora("Se guardaron los permisos del usuario " + usuario.Nombre_Usuario + ".", "ALTA");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<Componente> TraerFamiliaPatentes(int familiaId)
        {
            try
            {
                IList<Componente> componentes = _permisoDAL.TraerFamiliaPatentes(familiaId);
                return componentes;
            }
            catch (Exception) { throw new Exception(TraducirMensaje("msg_ErrorObtenerComponentes")); }
        }

        public Componente ObtenerFamiliaArbol(int familiaId, Componente componenteOriginal, Componente componenteAgregar)
        {
            try
            {
                Componente comp = _permisoDAL.ObtenerFamiliaArbol(familiaId, componenteOriginal, componenteAgregar);
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

        public IList<Patente> ObtenerPatentes()
        {
            try
            {
                IList<Patente> patentes = _permisoDAL.ObtenerPatentes();
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

    }
}
