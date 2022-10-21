using System;
using Interfaces;
using Interfaces.Composite;
using Interfaces.Observer;
using Software_Canchas_2022;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.Observer;
using Servicios;

namespace Software_Canchas_2022
{
    public partial class Login : Form
    {
        private readonly IPermiso _iPermiso;
        private readonly ITraductor _iTraductor;
        private readonly IBitacora _iBitacora;
        private readonly ICancha _iCancha;
        private readonly ICliente _iCliente;
        private readonly IDigito_Verificador _IDigitoVerifivador;
        private readonly IEncriptar _iEncriptar;
        private readonly IUsuario _iUsuario;
        private readonly IReserva _iReserva;
        private readonly IBackUp _iBackup;
        private readonly IControlReserva _iControlReserva;

        public Login(IPermiso permiso, ITraductor traductor, ICancha cancha, ICliente cliente, IUsuario usuario, IReserva reserva, IBitacora bitacora, IBackUp backup, IControlReserva controlReserva)
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
            _iControlReserva = controlReserva;
            _IDigitoVerifivador = new BLL.DigitoVerificador();
            if(VerificarIntegridad() == false)
            {
                this.WindowState = FormWindowState.Minimized;
                btnIngresar.Enabled = false;
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                LogInSeguridad logInSeguridad = new LogInSeguridad(_iUsuario, _iTraductor, _iBackup, _IDigitoVerifivador, _iBitacora);
                logInSeguridad.Show();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                _iUsuario.Login(txtUser.Text.ToLower(), txtPass.Text);

                Limpiar();
                this.Hide();
                MessageBox.Show("Se ingresó correctamente");
                Menu formMenu = new Menu(_iPermiso, _iTraductor, _iCancha, _iCliente, _iUsuario, _iReserva, _iBitacora, _iBackup, _iControlReserva);
                formMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPass.Clear();
            }
        }

        private void Limpiar()
        {
            txtPass.Clear();
            txtUser.Clear();
        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Registro formRegistro = new Registro(_iPermiso, _iTraductor, _iBitacora, _iCancha, _iCliente, _IDigitoVerifivador, _iEncriptar, _iUsuario, _iReserva, _iBackup, _iControlReserva);
            formRegistro.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool VerificarIntegridad()
        {
            try
            {
                string mensaje = _IDigitoVerifivador.VerificarDV();
                if (mensaje != "true")
                {
                    MessageBox.Show(mensaje,"Error");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                throw new Exception();
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
