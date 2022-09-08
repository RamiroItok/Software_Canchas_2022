using BE;
using BE.DTOs;
using BE.Observer;
using Interfaces;
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
    public partial class Gestion_Usuarios : Form, IObserver
    {
        private readonly IUsuario _iUsuario;
        private readonly ITraductor _iTraductor;
        public Gestion_Usuarios(IUsuario usuario, ITraductor traductor)
        {
            _iUsuario = usuario;
            _iTraductor = traductor;
            InitializeComponent();
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma)
        {
            Traductor.Traducir(_iTraductor, idioma, this.Controls);
        }

        private void Gestion_Usuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            Sesion.SuscribirObservador(this);
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void CargarUsuarios()
        {
            dataGridUsuarios.DataSource = _iUsuario.ObtenerUsuarioDesencriptado();
            dataGridUsuarios.Columns["Id_Usuario"].Visible = false;
            dataGridUsuarios.Columns["Idioma"].Visible = false;
            dataGridUsuarios.ClearSelection();
            dataGridUsuarios.TabStop = false;
            dataGridUsuarios.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtContraseña.Clear();
            txtPuesto.Clear();
            txtNombre_Usuario.Clear();
            cmbSexo.Text = "";
            cmbTipo.Text = "";
            txtMail.Clear();
            txtTelefono.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_iUsuario.ObtenerUsuarioDesencriptado().Where(x => x.Nombre_Usuario == txtNombre_Usuario.Text.ToLower()).Any())
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
    }
}
