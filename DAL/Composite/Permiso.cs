using BE.Composite;
using BE.DTOs;
using DAL.Conexion;
using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Composite
{
    public class Permiso : Acceso
    {
        private readonly Fill _fill;
        public Permiso()
        {
            _fill = new Fill();
        }

        private const string ALTA_FAMILIA_PATENTE = "INSERT INTO Permiso (Nombre, Permiso) OUTPUT inserted.Id VALUES (@parNombre, @parPermiso)";
        private const string BORRAR_FAMILIA = "DELETE FROM FamiliaPatente WHERE PadreId = @parId";
        private const string GUARDAR_FAMILIA = "INSERT INTO FamiliaPatente (PadreId, HijoId) VALUES (@parPadreId, @parHijoId)";
        private const string OBTENER_FAMILIA = "SELECT * FROM Permiso WHERE Permiso IS NULL";
        private const string OBTENER_PATENTES = "SELECT * FROM Permiso WHERE Permiso IS NOT NULL";
        private const string GET_FAMILIA_PATENTE = "WITH RECURSIVO AS (SELECT fp.PadreId, fp.HijoId FROM FamiliaPatente fp WHERE fp.PadreId = {0}" +
                                                    " UNION ALL SELECT fp2.PadreId, fp2.HijoId FROM FamiliaPatente fp2 INNER JOIN RECURSIVO r on r.HijoId = fp2.PadreId) " +
                                                    " SELECT r.PadreId, r.HijoId, p.Id as PermisoId, p.Nombre, p.Permiso FROM RECURSIVO r INNER JOIN Permiso p on r.HijoId = p.Id" +
                                                     " group by r.PadreId, r.HijoId, p.Id, p.Nombre, p.Permiso ";
        private const string GET_USUARIO_PERMISO = "SELECT p.* FROM UsuarioPermiso up INNER JOIN Permiso p on p.Id = up.PatenteId WHERE UsuarioId = {0}";
        private const string BORRAR_PERMISO_USUARIO = "DELETE FROM UsuarioPermiso WHERE UsuarioId = @parUsuarioId";
        private const string GUARDAR_PERMISO_USUARIO = "INSERT INTO UsuarioPermiso (UsuarioId, PatenteId) VALUES (@parUsuarioId, @parPatenteId)";
        private const string GET_FAMILIA_VALIDACION = "SELECT p.Id, p.Nombre FROM FamiliaPatente fm INNER JOIN Permiso p ON p.Id = fm.PadreId INNER JOIN Permiso p2 ON p2.Id = fm.HijoId WHERE fm.HijoId = {0}";

        private const string OBTENER_PATENTES_FAMILIA = "SELECT Id as PermisoId, Nombre, Permiso, PadreId, HijoId FROM Permiso p INNER JOIN FamiliaPatente fm on fm.HijoId = p.Id WHERE PadreId = {0} ORDER BY Permiso DESC";
        private const string GET_PERMISOS_USUARIO = "SELECT Id as PermisoId, Nombre, Permiso FROM Permiso p INNER JOIN UsuarioPermiso up on up.PatenteId = p.Id WHERE up.UsuarioId = {0} ORDER BY Permiso DESC";
        public int AltaFamiliaPatente(Componente componente, bool familia)
        {
            try
            {
                ExecuteCommandText = ALTA_FAMILIA_PATENTE;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parNombre", componente.Nombre);
                if (familia) ExecuteParameters.Parameters.AddWithValue("@parPermiso", DBNull.Value);
                else ExecuteParameters.Parameters.AddWithValue("@parPermiso", componente.Permiso.ToString());

                return ExecuteNonEscalar();
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public void GuardarFamiliaCreada(Familia familia)
        {
            try
            {
                ExecuteCommandText = BORRAR_FAMILIA;
                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId", familia.Id);

                ExecuteNonQuery();

                foreach (Componente item in familia.Hijos)
                {
                    ExecuteCommandText = GUARDAR_FAMILIA;
                    ExecuteParameters.Parameters.Clear();

                    ExecuteParameters.Parameters.AddWithValue("@parPadreId", familia.Id);
                    ExecuteParameters.Parameters.AddWithValue("@parHijoId", item.Id);
                    ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public void GuardarPermiso(UsuarioDTO usuario)
        {
            try
            {
                ExecuteCommandText = BORRAR_PERMISO_USUARIO;
                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parUsuarioId", usuario.Id);

                ExecuteNonQuery();

                foreach (Componente item in usuario.Permisos)
                {
                    ExecuteCommandText = GUARDAR_PERMISO_USUARIO;
                    ExecuteParameters.Parameters.Clear();

                    ExecuteParameters.Parameters.AddWithValue("@parUsuarioId", usuario.Id);
                    ExecuteParameters.Parameters.AddWithValue("@parPatenteId", item.Id);
                    ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public IList<Familia> ObtenerFamilias()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_FAMILIA);
                DataSet ds = ExecuteNonReader();

                IList<BE.Composite.Familia> familias = new List<BE.Composite.Familia>();

                if (ds.Tables[0].Rows.Count > 0)
                    familias = _fill.FillListFamilia(ds);

                return familias;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public IList<Patente> ObtenerPatentes()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_PATENTES);
                DataSet ds = ExecuteNonReader();

                IList<BE.Composite.Patente> patentes = new List<BE.Composite.Patente>();

                if (ds.Tables[0].Rows.Count > 0)
                    patentes = _fill.FillListPatente(ds);

                return patentes;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public IList<BE.Composite.Componente> TraerFamiliaPatentes(int Id_Familia)
        {
            try
            {
                SelectCommandText = String.Format(GET_FAMILIA_PATENTE, Id_Familia);
                DataSet ds = ExecuteNonReader();
                DataTable dt = ds.Tables[0];


                List<Componente> componentes = new List<Componente>();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow rows in dt.Rows)
                    {
                        int padreId = 0;
                        if (rows["PadreId"] != DBNull.Value)
                        {
                            padreId = int.Parse(rows["PadreId"].ToString());
                        }

                        int Id = int.Parse(rows["PermisoId"].ToString());
                        string nombre = rows["Nombre"].ToString();
                        string permiso = string.Empty;
                        if (rows["Permiso"] != DBNull.Value) permiso = rows["Permiso"].ToString();

                        Componente componente;
                        if (string.IsNullOrEmpty(permiso)) componente = new Familia();
                        else componente = new Patente();

                        componente.Id = Id;
                        componente.Nombre = nombre;
                        if (!string.IsNullOrEmpty(permiso)) componente.Permiso = (BE.Composite.Permiso)Enum.Parse(typeof(BE.Composite.Permiso), permiso);

                        Componente padre = GetComponente(padreId, componentes);
                        if (padre == null) componentes.Add(componente);
                        else padre.AgregarHijo(componente);
                    }
                }
                return componentes;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public Componente ObtenerFamiliaArbol(int familiaId, Componente componenteOriginal, Componente componenteAgregar)
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_PATENTES_FAMILIA, familiaId);
                DataSet ds = ExecuteNonReader();
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow rows in dt.Rows)
                    {
                        int Id = int.Parse(rows["PermisoId"].ToString());
                        string nombre = rows["Nombre"].ToString();
                        string permiso = string.Empty;
                        if (rows["Permiso"] != DBNull.Value) permiso = rows["Permiso"].ToString();

                        Componente componente;
                        if (string.IsNullOrEmpty(permiso)) componente = new Familia();
                        else componente = new Patente();

                        componente.Id = Id;
                        componente.Nombre = nombre;
                        if (!string.IsNullOrEmpty(permiso)) componente.Permiso = (BE.Composite.Permiso)Enum.Parse(typeof(BE.Composite.Permiso), permiso);

                        if (componenteAgregar != null)
                        {
                            if (componente.GetType() == typeof(Patente)) componenteAgregar.AgregarHijo(componente);
                            else if (componente.GetType() == typeof(Familia)) LlenarComponenteFamilia(componente, componenteOriginal, componenteAgregar);
                        }
                        else
                        {
                            if (componente.GetType() == typeof(Patente)) componenteOriginal.AgregarHijo(componente);
                            else if (componente.GetType() == typeof(Familia)) LlenarComponenteFamilia(componente, componenteOriginal, componenteOriginal);
                        }
                    }
                }

                return componenteOriginal;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public Componente GetUsuarioArbol(int usuarioId, Componente componenteOriginal, Componente componenteAgregar)
        {
            try
            {
                SelectCommandText = String.Format(GET_PERMISOS_USUARIO, usuarioId);
                DataSet ds = ExecuteNonReader();
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow rows in dt.Rows)
                    {
                        int Id = int.Parse(rows["PermisoId"].ToString());
                        string nombre = rows["Nombre"].ToString();
                        string permiso = string.Empty;
                        if (rows["Permiso"] != DBNull.Value) permiso = rows["Permiso"].ToString();

                        Componente componente;
                        if (string.IsNullOrEmpty(permiso)) componente = new Familia();
                        else componente = new Patente();

                        componente.Id = Id;
                        componente.Nombre = nombre;
                        if (!string.IsNullOrEmpty(permiso)) componente.Permiso = (BE.Composite.Permiso)Enum.Parse(typeof(BE.Composite.Permiso), permiso);

                        if (componenteAgregar != null)
                        {
                            if (componente.GetType() == typeof(Patente)) componenteAgregar.AgregarHijo(componente);
                            else if (componente.GetType() == typeof(Familia)) LlenarComponenteFamilia(componente, componenteOriginal, componenteAgregar);
                        }
                        else
                        {
                            if (componente.GetType() == typeof(Patente)) componenteOriginal.AgregarHijo(componente);
                            else if (componente.GetType() == typeof(Familia)) LlenarComponenteFamilia(componente, componenteOriginal, componenteOriginal);
                        }
                    }
                }

                return componenteOriginal;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public IList<Familia> GetFamiliasValidacion(int familiaId)
        {
            try
            {
                SelectCommandText = String.Format(GET_FAMILIA_VALIDACION, familiaId);
                DataSet ds = ExecuteNonReader();

                IList<BE.Composite.Familia> familias = new List<BE.Composite.Familia>();

                if (ds.Tables[0].Rows.Count > 0)
                    familias = _fill.FillListFamilia(ds);

                return familias;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        private Componente GetComponente(int id, IList<Componente> lista)
        {
            try
            {
                Componente componente = lista != null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

                if (componente == null && lista != null)
                {
                    foreach (var item in lista)
                    {
                        var _lista = GetComponente(id, item.Hijos);
                        if (_lista != null && _lista.Id == id) return _lista;
                        else if (_lista != null) return GetComponente(id, _lista.Hijos);
                    }
                }
                return componente;
            }
            catch (Exception) { throw new Exception("Error al obtener los componentes."); }
        }

        public void GetComponenteUsuario(UsuarioDTO usuario)
        {
            try
            {
                SelectCommandText = String.Format(GET_USUARIO_PERMISO, usuario.Id);
                DataSet ds = ExecuteNonReader();
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow rows in dt.Rows)
                    {
                        int id = int.Parse(rows["Id"].ToString());
                        string nombre = rows["Nombre"].ToString();
                        string permiso = String.Empty;
                        if (rows["Permiso"].ToString() != String.Empty) permiso = rows["Permiso"].ToString();

                        Componente componente;
                        if (!String.IsNullOrEmpty(permiso))
                        {
                            componente = new Patente();
                            componente.Id = id;
                            componente.Nombre = nombre;
                            componente.Permiso = (BE.Composite.Permiso)Enum.Parse(typeof(BE.Composite.Permiso), permiso);
                            usuario.Permisos.Add(componente);
                        }
                        else
                        {
                            componente = new Familia();
                            componente.Id = id;
                            componente.Nombre = nombre;

                            var familia = TraerFamiliaPatentes(id);
                            foreach (var f in familia)
                            {
                                componente.AgregarHijo(f);
                            }

                            usuario.Permisos.Add(componente);
                        }
                    }
                }
            }
            catch (Exception) { throw new Exception("Hubo un error al obtener los permisos del usuario."); }
        }

        public void GetComponenteFamilia(Familia familia)
        {
            familia.VaciarHijos();
            foreach (Componente item in TraerFamiliaPatentes(familia.Id))
            {
                familia.AgregarHijo(item);
            }
        }

        private void LlenarComponenteFamilia(Componente componente, Componente componenteOriginal, Componente componenteRaiz)
        {
            Componente familia = new Familia();
            familia = componente;

            componenteRaiz.AgregarHijo(familia);

            ObtenerFamiliaArbol(componente.Id, componenteOriginal, familia);
        }

    }
}
