using BE;
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
    public partial class Usuarios_Bloqueados : Form
    {
        private readonly IUsuario _iUsuario;
        private readonly ITraductor _iTraductor;

        public Usuarios_Bloqueados(IUsuario usuario, ITraductor traductor)
        {
            InitializeComponent();
            _iUsuario = usuario;
            _iTraductor = traductor;
        }

        private void Usuarios_Bloqueados_Load(object sender, EventArgs e)
        {
            CargarUsuariosBloqueados();
        }

        private void btn_DesbloquearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUsuarios.CurrentRow == null) throw new Exception(TraducirMensaje("msg_UsuarioNoSeleccionado"));

                _iUsuario.Desbloquear(dataGridUsuarios.CurrentRow.Cells[1].Value.ToString());
                CargarUsuariosBloqueados();
                MessageBox.Show(TraducirMensaje("msg_UsuarioDesbloqueado"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarUsuariosBloqueados()
        {
            dataGridUsuarios.DataSource = _iUsuario.ListarBloqueados();
            dataGridUsuarios.ClearSelection();
            dataGridUsuarios.Columns["Idioma"].Visible = false;
            dataGridUsuarios.TabStop = false;
            dataGridUsuarios.ReadOnly = true;
            dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
