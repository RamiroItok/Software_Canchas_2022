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
                //this.menuIdioma.DropDownItems.Add(idiomaMenu);

                //idiomaMenu.Click += T_Click;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Usuarios gestion_Usuario = new Gestion_Usuarios(_iUsuario, _iTraductor);
            gestion_Usuario.MdiParent = this;
            gestion_Usuario.StartPosition = FormStartPosition.CenterScreen;
            gestion_Usuario.Show();
        }
    }
}
