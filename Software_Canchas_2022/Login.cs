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

namespace Software_Canchas_2022
{
    public partial class Login : Form
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

        /*public Login(IPermiso permiso, ITraductor traductor, IBitacora bitacora, ICancha cancha, ICliente cliente, IDigito_Verificador dv, IEncriptar encriptar, IUsuario usuario)
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
        }*/

        public Login(IPermiso permiso, ITraductor traductor, ICancha cancha, ICliente cliente, IUsuario usuario, IReserva reserva)
        {
            InitializeComponent();
            _iPermiso = permiso;
            _iTraductor = traductor;
            _iCancha = cancha;
            _iUsuario = usuario;
            _iCliente = cliente;
            _iReserva = reserva;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                _iUsuario.Login(txtUser.Text.ToLower(), txtPass.Text);

                Limpiar();
                this.Hide();
                MessageBox.Show("Se ingresó correctamente");
                Menu formMenu = new Menu(_iPermiso, _iTraductor, _iCancha, _iCliente, _iUsuario, _iReserva);
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

            Registro formRegistro = new Registro(_iPermiso, _iTraductor, _iBitacora, _iCancha, _iCliente, _iDV, _iEncriptar, _iUsuario, _iReserva);
            formRegistro.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
