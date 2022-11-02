using BE.DTOs;
using BE.Observer;
using Interfaces;
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
    public partial class Cambiar_Contraseña : Form
    {
        private UsuarioDTO _usuarioDTO;
        private readonly ITraductor _iTraductor;
        private readonly IUsuario _iUsuario;

        public Cambiar_Contraseña(IUsuario usuario, ITraductor traductor)
        {
            InitializeComponent();
            _iUsuario = usuario;
            _iTraductor = traductor;
            _usuarioDTO = Sesion.GetInstance();
        }

        private void Cambiar_Contraseña_Load(object sender, EventArgs e)
        {
            txt_Usuario.Text = $"{_usuarioDTO.Id} - {_usuarioDTO.Nombre} {_usuarioDTO.Apellido}";
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string contraseña_Actual = txt_ContraseñaActual.Text;
                string contraseña_Nueva = txt_NuevaContraseña.Text;
                string contraseña_Repetida = txt_ConfirmarContraseñaNueva.Text;
                if (contraseña_Nueva != contraseña_Repetida) throw new Exception(TraducirMensaje("msg_PasswordNoCoindice"));
                _iUsuario.CambiarContraseña(_usuarioDTO, contraseña_Actual, contraseña_Nueva);
                MessageBox.Show(TraducirMensaje("msg_CambioContraseña"));
                this.Close();
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
            txt_ContraseñaActual.Clear();
            txt_NuevaContraseña.Clear();
            txt_ConfirmarContraseñaNueva.Clear();
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
