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

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_iTraductor, msgTag);
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
            dataGridUsuarios.Columns["Contraseña"].Visible = false;
            dataGridUsuarios.Columns["Estado"].Visible = false;
            dataGridUsuarios.Columns["DVH"].Visible = false;
            dataGridUsuarios.ClearSelection();
            dataGridUsuarios.TabStop = false;
            dataGridUsuarios.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtContraseña.Enabled = true;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtContraseña.Clear();
            txtPuesto.Clear();
            txtNombre_Usuario.Clear();
            cmbSexo.SelectedItem = null;
            cmbTipo.SelectedItem = null;
            txtMail.Clear();
            txtTelefono.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUsuarios.CurrentRow == null) throw new Exception(TraducirMensaje("msg_UsuarioNoSeleccionado"));

                Usuario usuario = new Usuario()
                {
                    Id_Usuario = int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString()),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Nombre_Usuario = txtNombre_Usuario.Text,
                    Puesto = txtPuesto.Text,
                    Dni = int.Parse(txtDni.Text),
                    Sexo = cmbSexo.Text,
                    Mail = txtMail.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    Tipo = cmbTipo.Text,
            };
                _iUsuario.ModificarUsuario(usuario);

                CargarUsuarios();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_UsuarioModificado"));
                txtContraseña.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtContraseña.Enabled = false;
            txtNombre.Text = dataGridUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dataGridUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            txtNombre_Usuario.Text = dataGridUsuarios.CurrentRow.Cells["Nombre_Usuario"].Value.ToString();
            txtPuesto.Text = dataGridUsuarios.CurrentRow.Cells["Puesto"].Value.ToString();
            txtDni.Text = dataGridUsuarios.CurrentRow.Cells["Dni"].Value.ToString();
            cmbSexo.Text = dataGridUsuarios.CurrentRow.Cells["Sexo"].Value.ToString();
            txtMail.Text = dataGridUsuarios.CurrentRow.Cells["Mail"].Value.ToString();
            txtTelefono.Text = dataGridUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            cmbTipo.Text = dataGridUsuarios.CurrentRow.Cells["Tipo"].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             try
            {
                if (dataGridUsuarios.CurrentRow == null) throw new Exception(TraducirMensaje("msg_UsuarioNoSeleccionado"));

                Usuario usuario = new Usuario()
                {
                    Id_Usuario = int.Parse(dataGridUsuarios.CurrentRow.Cells[0].Value.ToString()),
                };
                _iUsuario.BajaUsuario(usuario);

                CargarUsuarios();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_UsuarioEliminado"));
                txtContraseña.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
