using Interfaces;
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
        private readonly IReserva _iReserva;
        private readonly IBackUp _iBackup;
        private readonly IControlCliente _iControlCliente;
        private readonly IDeudas _iDeudas;
        private readonly IReporte _iReporte;

        private UsuarioDTO _usuarioDTO;
        private readonly IList<IIdioma> _idiomas;

        private bool mdiChildActivo = false;

        public Menu(IPermiso permiso, ITraductor traductor, ICancha cancha, ICliente cliente, IUsuario usuario, IReserva reserva, IBitacora bitacora, IBackUp backup, IControlCliente controlCliente, IDeudas deudas, IReporte reporte)
        {
            InitializeComponent();

            _iPermiso = permiso;
            _iTraductor = traductor;
            _iCancha = cancha;
            _iUsuario = usuario;
            _iCliente = cliente;
            _iReserva = reserva;
            _iBitacora = bitacora;
            _iBackup = backup;
            _iControlCliente = controlCliente;
            _iDeudas = deudas;
            _iReporte = reporte;

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
            CargarPermisosMenu();
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void CargarPermisosMenu()
        {
            PermisoTool.HabilitarMenu(_usuarioDTO, canchaToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, gestiónToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, informesToolStripMenuItem);
            PermisoTool.HabilitarMenu(_usuarioDTO, seguridadToolStripMenuItem);
            reservaToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Reserva);
            gestionUsuariosToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Gestion_Usuarios);
            gestionCanchasToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Gestion_Canchas);
            gestionClientesToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Gestion_Clientes);
            gestionIdiomaToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Gestion_Idioma);
            bitácoraToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Bitacora);
            backUpToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Backup);
            restoreToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Restore);
            rolesToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Roles);
            seguridadUsuariosToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Seguridad_Usuarios);
            deudasToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Deudas_Pendientes);
            helpToolStripMenuItem.Enabled = PermisoTool.TienePermiso(_usuarioDTO, BE.Composite.Permiso.Help);
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
            Login login = new Login(_iPermiso, _iTraductor, _iCancha, _iCliente, _iUsuario, _iReserva, _iBitacora, _iBackup, _iControlCliente, _iDeudas, _iReporte);
            login.Show();
        }

        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            Form formEvento = (Form)sender;
            CargarPermisosMenu();

            if (formEvento.ActiveMdiChild == null)
            {
                mdiChildActivo = false;
                UpdateLanguage(Sesion.GetInstance().Idioma);
                AgregarIdiomaMenu();
            }
            else
            {
                mdiChildActivo = true;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Usuarios gestion_Usuario = new Gestion_Usuarios(_iUsuario, _iTraductor);
            gestion_Usuario.MdiParent = this;
            gestion_Usuario.StartPosition = FormStartPosition.CenterScreen;
            gestion_Usuario.Show();
        }
        private void gestionCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Canchas gestion_Canchas = new Gestion_Canchas(_iCancha, _iTraductor, _iReserva);
            gestion_Canchas.MdiParent = this;
            gestion_Canchas.StartPosition = FormStartPosition.CenterScreen;
            gestion_Canchas.Show();
        }

        private void gestionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Clientes gestion_Clientes = new Gestion_Clientes(_iCliente, _iTraductor);
            gestion_Clientes.MdiParent = this;
            gestion_Clientes.StartPosition = FormStartPosition.CenterScreen;
            gestion_Clientes.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva(_iReserva, _iTraductor, _iCliente, _iCancha, _iDeudas);
            reserva.MdiParent = this;
            reserva.StartPosition = FormStartPosition.CenterScreen;
            reserva.Show();
        }

        private void altaIdiomaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Idioma idioma = new Idioma(_iTraductor);
            idioma.MdiParent = this;
            idioma.StartPosition = FormStartPosition.CenterScreen;
            idioma.Show();
        }

        private void cargarEtiquetasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gestion_Etiquetas etiquetas = new Gestion_Etiquetas(_iTraductor);
            etiquetas.MdiParent = this;
            etiquetas.StartPosition = FormStartPosition.CenterScreen;
            etiquetas.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(_iBitacora, _iTraductor, _iUsuario);
            bitacora.MdiParent = this;
            bitacora.StartPosition = FormStartPosition.CenterScreen;
            bitacora.Show();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup(_iBackup, _iTraductor);
            backup.MdiParent = this;
            backup.StartPosition = FormStartPosition.CenterScreen;
            backup.Show();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore restore = new Restore(_iBackup, _iTraductor);
            restore.MdiParent = this;
            restore.StartPosition = FormStartPosition.CenterScreen;
            restore.Show();
        }

        private void gestiónFamiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionFamilia familia = new GestionFamilia(_iPermiso, _iTraductor);
            familia.MdiParent = this;
            familia.StartPosition = FormStartPosition.CenterScreen;
            familia.Show();
        }

        private void bloqueadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios_Bloqueados usuarios_Bloqueados = new Usuarios_Bloqueados(_iUsuario, _iTraductor);
            usuarios_Bloqueados.MdiParent = this;
            usuarios_Bloqueados.StartPosition = FormStartPosition.CenterScreen;
            usuarios_Bloqueados.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambiar_Contraseña cambiar_Contraseña = new Cambiar_Contraseña(_iUsuario, _iTraductor);
            cambiar_Contraseña.MdiParent = this;
            cambiar_Contraseña.StartPosition = FormStartPosition.CenterScreen;
            cambiar_Contraseña.Show();
        }

        private void controlDeCambiosDeReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCliente controlCliente = new ControlCliente(_iControlCliente, _iTraductor, _iCliente);
            controlCliente.MdiParent = this;
            controlCliente.StartPosition = FormStartPosition.CenterScreen;
            controlCliente.Show();
        }

        private void gestionFamiliasYPatentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Familia_Patente gestion_Familia_Patente = new Gestion_Familia_Patente(_iPermiso, _iTraductor);
            gestion_Familia_Patente.MdiParent = this;
            gestion_Familia_Patente.StartPosition = FormStartPosition.CenterScreen;
            gestion_Familia_Patente.Show();
        }

        private void permisosAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permisos_Usuarios permisos_Usuarios = new Permisos_Usuarios(_iPermiso, _iUsuario, _iTraductor);
            permisos_Usuarios.MdiParent = this;
            permisos_Usuarios.StartPosition = FormStartPosition.CenterScreen;
            permisos_Usuarios.Show();
        }

        private void deudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDeudas gestionDeudas = new GestionDeudas(_iTraductor, _iDeudas, _iCliente, _iReserva);
            gestionDeudas.MdiParent = this;
            gestionDeudas.StartPosition = FormStartPosition.CenterScreen;
            gestionDeudas.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "F:/Universidad/3er año/Diploma/Software/Software_Canchas_2022/Manual/Manual de Ayuda.chm");
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes informes = new Informes(_iReporte, _iTraductor);
            informes.MdiParent = this;
            informes.StartPosition = FormStartPosition.CenterScreen;
            informes.Show();
        }
    }
}
