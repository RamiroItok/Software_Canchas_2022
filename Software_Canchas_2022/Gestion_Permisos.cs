using BE.Composite;
using BE.Observer;
using Interfaces.Composite;
using Interfaces.Observer;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Canchas_2022
{
    public partial class Gestion_Permisos : Form
    {
        private Familia _seleccionFamilia;
        private List<Familia> _familiaComparacion;
        private readonly IPermiso _iPermiso;
        private readonly ITraductor _iTraductor;
        public Gestion_Permisos(IPermiso permiso, ITraductor traductor)
        {
            InitializeComponent();
            _iPermiso = permiso;
            _iTraductor = traductor;
        }

        private void Gestion_Permisos_Load(object sender, EventArgs e)
        {
            CargarFamilias();
            CargarPatentes();
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            try
            {
                Familia tempFamilia = (Familia)cmb_Familia1.SelectedItem;
                if (tempFamilia != null)
                {
                    _seleccionFamilia = new Familia();
                    _seleccionFamilia.Id = tempFamilia.Id;
                    _seleccionFamilia.Nombre = tempFamilia.Nombre;

                    CargarTreeFamilia(true);
                }
            }
            catch (Exception)
            {
                throw new Exception(TraducirMensaje("msg_ErrorCargarArbol"));
            }
        }

        private void btn_AgregarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                if (_seleccionFamilia != null)
                {
                    Patente patente = (Patente)cmb_Patentes.SelectedItem;
                    if (patente != null)
                    {
                        bool existeComponente = _iPermiso.ExisteComponente(_seleccionFamilia, patente.Id);

                        if (existeComponente)
                            MessageBox.Show(TraducirMensaje("msg_PatenteYaCargada"));

                        else
                        {
                            _seleccionFamilia.AgregarHijo(patente);
                            CargarTreeFamilia(false);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorCargarPatente"));
            }
        }

        private void btn_AgregarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                if (_seleccionFamilia != null)
                {
                    ValidarArbol();

                    Familia familia = (Familia)cmb_Familia2.SelectedItem;

                    Componente _familia = new Familia();
                    Componente componente = new Familia();

                    _familia = _iPermiso.ObtenerFamiliaArbol(familia.Id, componente, null);

                    foreach (var item in _familia.Hijos)
                    {
                        familia.AgregarHijo(item);
                    }

                    if (familia != null)
                    {
                        bool existeComponente = _iPermiso.ExisteComponente(_seleccionFamilia, familia.Id);

                        if (existeComponente)
                            MessageBox.Show(TraducirMensaje("msg_PatenteYaCargada"));

                        else
                        {
                            _seleccionFamilia.AgregarHijo(familia);
                            CargarTreeFamilia(false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_seleccionFamilia != null)
                {
                    _iPermiso.GuardarFamiliaCreada(_seleccionFamilia);

                    treePatenteFamilia.Nodes.Clear();
                    MessageBox.Show(TraducirMensaje("msg_FamiliaGuardadaExito"));
                    CargarFamilias();
                    CargarPatentes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_EliminarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                if (treePatenteFamilia.SelectedNode != null)
                {
                    IList<Componente> familia;
                    familia = _seleccionFamilia.Hijos;

                    foreach (var item in familia)
                    {
                        if (treePatenteFamilia.SelectedNode.Text == item.Nombre)
                        {
                            _seleccionFamilia.BorrarHijo(item);
                        }
                    }

                    CargarTreeFamilia(false);
                    MessageBox.Show(TraducirMensaje("msg_PatenteEliminada"));
                    MessageBox.Show(TraducirMensaje("msg_DebeGuardarCambios"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            cmb_Familia1.SelectedIndex = -1;
            cmb_Familia2.SelectedIndex = -1;
            cmb_Patentes.SelectedIndex = -1;
            treePatenteFamilia.Nodes.Clear();
        }

        private void CargarFamilias()
        {
            cmb_Familia1.DataSource = _iPermiso.ObtenerFamilias();
            cmb_Familia1.DisplayMember = "Nombre";
            cmb_Familia1.ValueMember = "Id";
            cmb_Familia1.SelectedItem = null;

            cmb_Familia2.DataSource = _iPermiso.ObtenerFamilias();
            cmb_Familia2.DisplayMember = "Nombre";
            cmb_Familia2.ValueMember = "Id";
            cmb_Familia2.SelectedItem = null;
        }

        private void CargarPatentes()
        {
            cmb_Patentes.DataSource = _iPermiso.ObtenerPatentes();
            cmb_Patentes.DisplayMember = "Nombre";
            cmb_Patentes.ValueMember = "Id";
            cmb_Patentes.SelectedItem = null;
        }

        private void CargarTreeFamilia(bool familia)
        {
            try
            {
                if (_seleccionFamilia == null) return;

                Componente _familia = new Familia();
                Componente componente = new Familia();

                if (familia)
                {
                    _familia = _iPermiso.ObtenerFamiliaArbol(_seleccionFamilia.Id, componente, null);

                    foreach (var i in _familia.Hijos) _seleccionFamilia.AgregarHijo(i);
                }
                else
                {
                    _familia = _seleccionFamilia;
                }

                treePatenteFamilia.Nodes.Clear();
                TreeNode root = new TreeNode(_seleccionFamilia.Nombre);
                root.Tag = _seleccionFamilia;
                treePatenteFamilia.Nodes.Add(root);

                foreach (var item in _familia.Hijos)
                {
                    MostrarEnTreePatenteFamilia(root, item);
                }
                treePatenteFamilia.ExpandAll();
            }
            catch (Exception)
            {
                throw new Exception(TraducirMensaje("msg_ErrorCargarArbol"));
            }
        }

        private void ValidarArbol()
        {
            try
            {
                _familiaComparacion = new List<Familia>();

                Familia familia = _seleccionFamilia;
                Familia familiaSeleccionada = (Familia)cmb_Familia2.SelectedItem;

                _familiaComparacion.AddRange(_iPermiso.GetFamiliasValidacion(familia.Id));
                List<Familia> familiaCopia = new List<Familia>(_familiaComparacion);

                familiaCopia.ForEach(f => FillFamilia(f.Id));
                _familiaComparacion = LimpiarLista(_familiaComparacion);

                ValidarFamilias(_familiaComparacion, familiaSeleccionada);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FillFamilia(int familiaId)
        {
            try
            {
                IList<Familia> listaFlia = _iPermiso.GetFamiliasValidacion(familiaId);

                if (listaFlia.Count > 0)
                {
                    _familiaComparacion.AddRange(listaFlia);

                    foreach (Familia familia in listaFlia)
                    {
                        FillFamilia(familia.Id);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception(TraducirMensaje("msg_ErrorCargarArbol"));
            }
        }

        private List<Familia> LimpiarLista(List<Familia> familias)
        {
            try
            {
                List<Familia> listaFlia = new List<Familia>();

                foreach (Familia familia in familias)
                {
                    if (!listaFlia.Where(f => f.Id == familia.Id).Any())
                    {
                        listaFlia.Add(familia);
                    }
                }

                return listaFlia;
            }
            catch (Exception)
            {
                throw new Exception(TraducirMensaje("msg_ErrorCargarArbol"));
            }
        }

        private void ValidarFamilias(List<Familia> familias, Familia familiaAgregada)
        {
            try
            {
                foreach (Familia familia in familias)
                {
                    if (familia.Id == familiaAgregada.Id) throw new Exception(TraducirMensaje("msg_Recursividad"));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void MostrarEnTreePatenteFamilia(TreeNode treeNode, Componente componente)
        {
            try
            {
                TreeNode nodo = new TreeNode(componente.Nombre);
                treeNode.Tag = componente;
                treeNode.Nodes.Add(nodo);

                if (componente.Hijos != null)
                {
                    foreach (var item in componente.Hijos)
                    {
                        MostrarEnTreePatenteFamilia(nodo, item);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception(TraducirMensaje("msg_ErrorCargarArbol"));
            }
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma)
        {
            Traductor.Traducir(_iTraductor, idioma, this.Controls);
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_iTraductor, msgTag);
        }
    }
}
