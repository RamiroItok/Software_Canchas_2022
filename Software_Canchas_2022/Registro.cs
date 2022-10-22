using Interfaces;
using Interfaces.Observer;
using Interfaces.Composite;
using BE;
using BE.DTOs;
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
    public partial class Registro : Form
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

        public Registro(IPermiso permiso, ITraductor traductor, IBitacora bitacora, ICancha cancha, ICliente cliente, IDigito_Verificador dv, IEncriptar encriptar, IUsuario usuario, IReserva reserva, IBackUp backup, IControlCliente controlCliente)
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
            _iReserva = reserva;
            _iBackup = backup;
            _iControlCliente = controlCliente;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iUsuario.ObtenerUsuarioDTODesencriptado().Where(x => x.Nombre_Usuario == txtNombre_Usuario.Text.ToLower()).Any())
                    throw new Exception("Ese nombre de usuario está siendo utilizado");

                Usuario usuario = new Usuario()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Nombre_Usuario = txtNombre_Usuario.Text,
                    Contraseña = txtContraseña.Text,
                    Puesto = txtPuesto.Text,
                    Dni = int.Parse(txtDni.Text),
                    Sexo = cmbSexo.Text,
                    Mail = txtMail.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    Tipo = cmbTipo.Text,
                };

                _iUsuario.AltaUsuario(usuario);

                MessageBox.Show("El usuario se dió de alta correctamente");
                Limpiar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar(){
            txtApellido.Clear();
            txtContraseña.Clear();
            txtDni.Clear();
            txtMail.Clear();
            txtNombre.Clear();
            txtNombre_Usuario.Clear();
            txtPuesto.Clear();
            txtTelefono.Clear();
            cmbSexo.Text = "";
            cmbTipo.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login formLogin = new Login(_iPermiso, _iTraductor, _iCancha, _iCliente, _iUsuario, _iReserva, _iBitacora, _iBackup, _iControlCliente);
            formLogin.Show();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login formLogin = new Login(_iPermiso, _iTraductor, _iCancha, _iCliente, _iUsuario, _iReserva, _iBitacora, _iBackup, _iControlCliente);
            formLogin.Show();
        }
    }
}
