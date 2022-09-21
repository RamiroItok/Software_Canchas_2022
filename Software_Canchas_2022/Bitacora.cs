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
    public partial class Bitacora : Form, IObserver
    {
        private readonly IUsuario _iUsuario;
        private readonly ITraductor _iTraductor;
        private readonly IBitacora _iBitacora;
        public Bitacora(IBitacora bitacora, ITraductor traductor, IUsuario usuario)
        {
            _iBitacora = bitacora;
            _iUsuario = usuario;
            _iTraductor = traductor;
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarEventos();
            Sesion.SuscribirObservador(this);
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (chk_Fecha.Checked && chk_Usuario.Checked && chk_Criticidad.Checked)
                CargarEventosFechaUsuarioCriticidad();

            else if (chk_Fecha.Checked && chk_Usuario.Checked)
                CargarEventosBetweenUsuario();

            else if (chk_Fecha.Checked && chk_Criticidad.Checked)
                CargarEventosBetweenCriticidad();

            else if (chk_Usuario.Checked && chk_Criticidad.Checked)
                CargarEventosUsuarioCriticidad();

            else if (chk_Fecha.Checked)
                CargarEventosBetween();

            else if (chk_Usuario.Checked)
                CargarEventosUsuario();

            else if (chk_Criticidad.Checked)
                CargarEventosCritic();

            else
                CargarEventos();
        }

        private void btn_Cancelar1_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaDesde = dtp_FechaDesde2.Value.ToString().Substring(0, 10);
                string fechaHasta = dtp_FechaHasta2.Value.ToString().Substring(0, 10);
                _iBitacora.BajaBitacora(fechaDesde, fechaHasta);
                CargarEventos();
                MessageBox.Show(TraducirMensaje("msg_BitacoraBaja"));
            }
            catch (Exception ex) { }
        }

        private void btn_Cancelar2_Click(object sender, EventArgs e)
        {
            LimpiarEliminar();
        }

        private void CargarUsuarios()
        {
            cmb_Usuarios.DataSource = _iUsuario.ObtenerUsuarioDesencriptado();
            cmb_Usuarios.DisplayMember = "Nombre_Usuario";
            cmb_Usuarios.ValueMember = "Id";
            cmb_Usuarios.SelectedItem = null;
        }

        private void CargarEventos()
        {
            dataGridBitacora.DataSource = _iBitacora.ListarEventos();
            dataGridBitacora.Columns["DVH"].Visible = false;
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarEventosUsuario()
        {
            dataGridBitacora.DataSource = _iBitacora.Listar_Evento_Usuario(cmb_Usuarios.Text);
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarEventosCritic()
        {
            dataGridBitacora.DataSource = _iBitacora.Listar_Evento_Crit(cmb_Criticidad.Text);
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarEventosBetween()
        {
            dataGridBitacora.DataSource = _iBitacora.Listar_Evento_Between(dtp_FechaDesde1.Value.ToString().Substring(0,10), dtp_FechaHasta1.Value.ToString().Substring(0, 10));
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarEventosBetweenUsuario()
        {
            dataGridBitacora.DataSource = _iBitacora.Listar_Evento_Between_Usuario(dtp_FechaDesde1.Value.ToString().Substring(0, 10), dtp_FechaHasta1.Value.ToString().Substring(0, 10), cmb_Usuarios.Text);
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarEventosBetweenCriticidad()
        {
            dataGridBitacora.DataSource = _iBitacora.Listar_Evento_Between_Critic(dtp_FechaDesde1.Value.ToString().Substring(0, 10), dtp_FechaHasta1.Value.ToString().Substring(0, 10), cmb_Criticidad.Text);
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarEventosUsuarioCriticidad()
        {
            dataGridBitacora.DataSource = _iBitacora.Listar_Evento_Crit_Usu(cmb_Usuarios.Text, cmb_Criticidad.Text);
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarEventosFechaUsuarioCriticidad()
        {
            dataGridBitacora.DataSource = _iBitacora.Listar_Evento_Fecha_Usu_Crit(dtp_FechaDesde1.Value.ToString().Substring(0, 10), dtp_FechaHasta1.Value.ToString().Substring(0, 10), cmb_Usuarios.Text, cmb_Criticidad.Text);
            dataGridBitacora.ClearSelection();
            dataGridBitacora.TabStop = false;
            dataGridBitacora.ReadOnly = true;
            dataGridBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void LimpiarFiltros()
        {
            chk_Fecha.Checked = false;
            dtp_FechaDesde1.Value = DateTime.Now;
            dtp_FechaHasta1.Value = DateTime.Now;
            chk_Usuario.Checked = false;
            cmb_Usuarios.SelectedIndex = -1;
            chk_Criticidad.Checked = false;
            cmb_Criticidad.SelectedIndex = -1;
        }

        private void LimpiarEliminar()
        {
            dtp_FechaDesde2.Value = DateTime.Now;
            dtp_FechaHasta2.Value = DateTime.Now;
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
