﻿using Interfaces;
using Interfaces.Observer;
using Interfaces.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.Observer;
using BE.DTOs;
using BE.Observer;
using Servicios;

namespace Software_Canchas_2022
{
    public partial class Menu : Form, IObserver
    {
        private readonly IPermiso _iPermiso;
        private readonly ITraductor _iTraductor;
        private readonly IBitacora _iBitacora;
        private readonly ICancha _iCancha;
        private readonly ICliente _iCliente;
        private readonly IDigito_Verificador _iDV;
        private readonly IEncriptar _iEncriptar;
        private readonly IUsuario _iUsuario;

        private UsuarioDTO _usuarioDTO;
        private readonly IList<IIdioma> _idiomas;

        private bool mdiChildActivo = false;

        /*public Menu(IPermiso permiso, ITraductor traductor, IBitacora bitacora, ICancha cancha, ICliente cliente, IDigito_Verificador dv, IEncriptar encriptar, IUsuario usuario)
        {
            InitializeComponent();

            _iPermiso = permiso;
            _iTraductor = traductor;
            _iBitacora = bitacora;
            _iCancha = cancha;
            _iCliente = cliente;
            _iDV = dv;
            _iEncriptar = encriptar;
            _iUsuario = usuario;

            _usuarioDTO = Sesion.GetInstance();
            _idiomas = new List<IIdioma>();
        }*/

        public Menu(IPermiso permiso, ITraductor traductor, ICancha cancha, IUsuario usuario)
        {
            InitializeComponent();

            _iPermiso = permiso;
            _iTraductor = traductor;
            _iCancha = cancha;
            _iUsuario = usuario;

            _usuarioDTO = Sesion.GetInstance();
            _idiomas = new List<IIdioma>();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sesion.DesuscribirObservador(this);
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Sesion.SuscribirObservador(this);
            MostrarIdiomasDisponibles();
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void CargarPermisosMenu()
        {
            PermisoTool.HabilitarMenu(_usuarioDTO, reservaToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, listadoToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, gestionUsuariosToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, gestionCanchasToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, gestionClientesToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, informesToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, altaIdiomaToolStripMenuItem1);
            PermisoTool.HabilitarMenu(_usuarioDTO, recalcularDigitosVerificadoresToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, bitácoraToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, backUpToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, restoreToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, gestiónFamiliaToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, asignarPermisosToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, consultarPermisosToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, bloqueadosToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, cambiarContraseñaToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, salirToolStripMenuItem);

            OcultarMenu();
        }

        private void OcultarMenu()
        {
            // Menú Administrar negocio
            PermisoTool.OcultarMenuRaiz(canchaToolStripMenuItem);

            // Administración de ABM Usuarios/Cancha/Usuarios
            PermisoTool.OcultarMenuRaiz(gestiónToolStripMenuItem);
            PermisoTool.OcultarMenu(gestionUsuariosToolStripMenuItem);
            PermisoTool.OcultarMenu(gestionCanchasToolStripMenuItem);
            PermisoTool.OcultarMenu(gestionClientesToolStripMenuItem);

            // Menú informes
            PermisoTool.OcultarMenu(informesToolStripMenuItem);

            // Menú Idioma
            PermisoTool.OcultarMenuRaiz(informesToolStripMenuItem);

            // Menú Seguridad
            PermisoTool.OcultarMenuRaiz(seguridadToolStripMenuItem);
            PermisoTool.OcultarMenu(recalcularDigitosVerificadoresToolStripMenuItem);
            PermisoTool.OcultarMenu(bitácoraToolStripMenuItem);
            PermisoTool.OcultarMenu(backUpToolStripMenuItem);
            PermisoTool.OcultarMenu(restoreToolStripMenuItem);
            PermisoTool.OcultarMenu(rolesToolStripMenuItem);
            PermisoTool.OcultarMenu(seguridadUsuariosToolStripMenuItem);
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
            TraducirMenu(idioma);
        }

        private void TraducirMenu(IIdioma idioma)
        {
            Traductor.TraducirMenu(_iTraductor, idioma, menuStrip1);
        }

        private void Traducir(IIdioma idioma)
        {
            Traductor.Traducir(_iTraductor, idioma, this.Controls);
        }

        private void MostrarIdiomasDisponibles()
        {
            IList<IIdioma> idiomas = _iTraductor.ObtenerIdiomas();

            foreach (IIdioma idioma in idiomas)
            {
                _idiomas.Add(idioma);

                ToolStripMenuItem idiomaMenu = Traductor.AgregarIdiomaMenu(idioma);
                this.idiomaToolStripMenuItem.DropDownItems.Add(idiomaMenu);

                idiomaMenu.Click += T_Click;
            }
        }

        private void T_Click(object sender, EventArgs e)
        {
            Sesion.CambiarIdioma(((IIdioma)((ToolStripMenuItem)sender).Tag));
        }

        private void MostrarControles()
        {
            lblBienvenido.Visible = true;
        }

        private void OcultarControles()
        {
            lblBienvenido.Visible = false;
        }

        private void AgregarIdiomaMenu()
        {
            IList<IIdioma> idiomas = _iTraductor.ObtenerIdiomas();
            List<int> idiomasId = (from idio in idiomas select idio.Id).Except(_idiomas.Select(x => x.Id)).ToList();

            if (idiomasId.Count > 0 && idiomasId != null)
            {
                foreach (int idiomaId in idiomasId)
                {
                    IIdioma idioma = _iTraductor.ObtenerIdiomas().Where(x => x.Id == idiomaId).FirstOrDefault();
                    _idiomas.Add(idioma);

                    ToolStripMenuItem idiomaMenu = Traductor.AgregarIdiomaMenu(idioma);
                    this.idiomaToolStripMenuItem.DropDownItems.Add(idiomaMenu);

                    idiomaMenu.Click += T_Click;
                }
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Usuarios gestion_Usuario = new Gestion_Usuarios(_iUsuario, _iTraductor);
            gestion_Usuario.MdiParent = this;
            gestion_Usuario.StartPosition = FormStartPosition.CenterScreen;
            gestion_Usuario.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _iUsuario.Logout();
                Abrir_FormLLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Abrir_FormLLogin()
        {
            Login login = new Login(_iPermiso, _iTraductor, _iCancha, _iUsuario);
            login.Show();
        }

        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            Form formEvento = (Form)sender;
            CargarPermisosMenu();

            if (formEvento.ActiveMdiChild == null)
            {
                MostrarControles();
                mdiChildActivo = false;
                UpdateLanguage(Sesion.GetInstance().Idioma);
                AgregarIdiomaMenu();
            }
            else
            {
                OcultarControles();
                mdiChildActivo = true;
            }
        }
    }
}