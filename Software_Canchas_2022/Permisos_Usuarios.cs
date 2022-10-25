using BE.Composite;
using BE.Observer;
using Interfaces;
using Interfaces.Composite;
using Interfaces.Observer;
using Servicios;
using Servicios.Observer;
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
    public partial class Permisos_Usuarios : Form, IObserver
    {
        private readonly IPermiso _iPermiso;
        private readonly IUsuario _iUsuario;
        private readonly ITraductor _iTraductor;

        private BE.DTOs.UsuarioDTO _usuarioSeleccionado;
        private BE.DTOs.UsuarioDTO _usuario;

        public Permisos_Usuarios(IPermiso permiso, IUsuario usuario, ITraductor traductor)
        {
            InitializeComponent();
            _iPermiso = permiso;
            _iUsuario = usuario;
            _iTraductor = traductor;
        }

        private void Permisos_Usuarios_Load(object sender, EventArgs e)
        {
            Sesion.SuscribirObservador(this);
            UpdateLanguage(Sesion.GetInstance().Idioma);
            CargarCombos();
        }

        private void CargarCombos()
        {
            try
            {
                cmb_Usuario.DataSource = _iUsuario.ObtenerUsuarioDTODesencriptado().Where(x => x.Id != Sesion.GetInstance().Id).ToList();
                cmb_Usuario.ValueMember = "Id";
                cmb_Usuario.DisplayMember = "Nombre_Usuario";
                cmb_Usuario.SelectedIndex = -1;

                cmb_Familia.DataSource = _iPermiso.ObtenerFamilias();
                cmb_Familia.ValueMember = "Id";
                cmb_Familia.DisplayMember = "Nombre";
                cmb_Familia.SelectedIndex = -1;

                cmb_Patente.DataSource = _iPermiso.ObtenerPatentes();
                cmb_Patente.ValueMember = "Id";
                cmb_Patente.DisplayMember = "Nombre";
                cmb_Patente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmb_Usuario.SelectedIndex != -1)
                {
                    _usuarioSeleccionado = (BE.DTOs.UsuarioDTO)cmb_Usuario.SelectedItem;
                    _usuario = new BE.DTOs.UsuarioDTO()
                    {
                        Id = _usuarioSeleccionado.Id,
                        Nombre_Usuario = _usuarioSeleccionado.Nombre_Usuario,
                    };

                    Componente _familia = new Familia();
                    Componente componente = new Familia();

                    _familia = _iPermiso.GetUsuarioArbol(_usuarioSeleccionado.Id, componente, null);
                    if(_familia.Hijos.Count > 0)
                    {
                        foreach(Componente permiso in _familia.Hijos)
                        {
                            _usuario.Permisos.Add(permiso);
                        }
                    }

                    ListarPermisosUsuario(_usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirMensaje("msg_UsuarioNoSeleccionado"));
            }
        }

        private void ListarPermisosUsuario(BE.DTOs.UsuarioDTO usuario)
        {
            try
            {
                treePermisos.Nodes.Clear();
                TreeNode rama = new TreeNode(usuario.Nombre_Usuario);
                foreach(var item in usuario.Permisos)
                {
                    MostrarTreeUsuario(rama, item);
                    treePermisos.Nodes.Add(rama);
                    treePermisos.ExpandAll();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorCargarArbol"));
            }
        }

        private void MostrarTreeUsuario(TreeNode padre, Componente componente)
        {
            try
            {
                TreeNode hijo = new TreeNode(componente.Nombre);
                hijo.Tag = componente;
                padre.Nodes.Add(hijo);
                foreach (var item in componente.Hijos)
                {
                    MostrarTreeUsuario(hijo, item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorCargarArbol"));
            }
        }

        private void btn_Agregar1_Click(object sender, EventArgs e)
        {
            try
            {
                bool tieneFamilia = false;
                if (_usuario != null)
                {
                    Familia familiaTemp = (Familia)cmb_Familia.SelectedItem;
                    if (familiaTemp != null)
                    {
                        Familia familia = new Familia();
                        familia.Id = familiaTemp.Id;
                        familia.Nombre = familiaTemp.Nombre;

                        if (familia != null)
                        {
                            foreach (var item in _usuario.Permisos)
                            {
                                if (_iPermiso.ExisteComponente(item, familia.Id)) tieneFamilia = true;
                            }
                        }

                        if (tieneFamilia)
                        {
                            MessageBox.Show(TraducirMensaje("msg_UsuarioFamiliaAsociada"));
                        }
                        else
                        {
                            Componente _familia = new Familia();
                            Componente componente = new Familia();
                            componente = familia;

                            _familia = _iPermiso.ObtenerFamiliaArbol(componente.Id, componente, null);

                            _usuario.Permisos.Add(_familia);
                            ListarPermisosUsuario(_usuario);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(TraducirMensaje("msg_UsuarioNoSeleccionado"));
                }
            }
            catch (Exception)
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorPermisosGuardados"));
            }
        }

        private void btn_Agregar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usuario != null)
                {
                    var patente = (Patente)cmb_Patente.SelectedItem;
                    if (patente != null)
                    {
                        bool tienePatente = false;
                        foreach (Componente item in _usuario.Permisos)
                        {
                            if (_iPermiso.ExisteComponente(item, patente.Id)) tienePatente = true;
                        }

                        if (tienePatente)
                        {
                            MessageBox.Show(TraducirMensaje("msg_PatenteYaAsociada"));
                        }
                        else
                        {
                            _usuario.Permisos.Add(patente);
                            ListarPermisosUsuario(_usuario);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorPermisosGuardados"));
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usuarioSeleccionado != null)
                {
                    _iPermiso.GuardarPermiso(_usuario);

                    MessageBox.Show(TraducirMensaje("msg_PermisosGuardados"));
                    _usuario = null;

                    treePermisos.Nodes.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorPermisosGuardados"));
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cmb_Usuario.SelectedIndex = -1;
            cmb_Familia.SelectedIndex = -1;
            cmb_Patente.SelectedIndex = -1;
            treePermisos.Nodes.Clear();
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma)
        {
            try
            {
                Traductor.Traducir(_iTraductor, idioma, this.Controls);
            }
            catch (Exception)
            {

            }
        }

        private string TraducirMensaje(string msgTag)
        {
            try
            {
                return Traductor.TraducirMensaje(_iTraductor, msgTag);
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void Permisos_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sesion.DesuscribirObservador(this);
            this.Dispose();
        }
    }

}
