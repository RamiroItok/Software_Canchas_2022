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
    public partial class Reserva : Form, IObserver
    {
        private readonly IReserva _iReserva;
        private readonly ITraductor _iTraductor;
        private readonly ICliente _iCliente;
        private readonly ICancha _iCancha;

        public Reserva(IReserva reserva, ITraductor traductor, ICliente cliente, ICancha cancha)
        {
            _iReserva = reserva;
            _iTraductor = traductor;
            _iCliente = cliente;
            _iCancha = cancha;

            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            CargarReservas();
            CargarClientes();
            CargarTipoCancha();
            Sesion.SuscribirObservador(this);
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void btn_CancelarReserva_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_AltaCliente_Click(object sender, EventArgs e)
        {
            Gestion_Clientes cliente = new Gestion_Clientes(_iCliente, _iTraductor);
            this.Close();
            cliente.StartPosition = FormStartPosition.CenterScreen;
            cliente.Show();
        }

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Reserva reserva = new BE.Reserva()
                {
                    Id_Cancha = int.Parse(cmb_Cancha.Text),
                    Id_Cliente = (int)cmb_Cliente.SelectedValue,
                    Fecha = dtp_Fecha.Value,
                    Hora = cmb_Hora1.Text,
                    Forma_Pago = cmb_FormaPago.Text,
                    Seña = float.Parse(txt_Seña.Text),
                    Total = float.Parse(txt_Total.Text),
                    Deuda = float.Parse(txt_Deuda.Text),
                };

                _iReserva.AltaReserva(reserva);

                CargarReservas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_ReservaAlta"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarIdCanchas();
        }

        private void rdb_No_CheckedChanged(object sender, EventArgs e)
        {
            Bloquear();
        }

        private void rdb_Si_CheckedChanged(object sender, EventArgs e)
        {
            Desbloquear();
        }

        private void btn_ModificarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridReservas.CurrentRow == null) throw new Exception(TraducirMensaje("msg_ReservaNoSeleccionada"));

                BE.Reserva reserva = new BE.Reserva()
                {
                    Id = int.Parse(dataGridReservas.CurrentRow.Cells[0].Value.ToString()),
                    Id_Cancha = int.Parse(cmb_Cancha.Text),
                    Id_Cliente = int.Parse((cmb_Cliente.SelectedValue).ToString()),
                    Fecha = dtp_Fecha.Value,
                    Hora = cmb_Hora1.Text,
                    Forma_Pago = cmb_FormaPago.Text,
                    Seña = float.Parse(txt_Seña.Text),
                    Total = float.Parse(txt_Total.Text),
                    Deuda = float.Parse(txt_Deuda.Text),
                };

                _iReserva.ModificarReserva(reserva);

                CargarReservas();
                CargarClientes();
                CargarTipoCancha();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_ReservaModificada"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_Tipo.Text = dataGridReservas.CurrentRow.Cells["TipoCancha"].Value.ToString();
            cmb_Cancha.Text = dataGridReservas.CurrentRow.Cells["Cancha"].Value.ToString();
            cmb_Cliente.Text = dataGridReservas.CurrentRow.Cells["Cliente"].Value.ToString();
            dtp_Fecha.Text = dataGridReservas.CurrentRow.Cells["Fecha"].Value.ToString();
            cmb_Hora1.Text = dataGridReservas.CurrentRow.Cells["Hora"].Value.ToString();
            cmb_FormaPago.Text = dataGridReservas.CurrentRow.Cells["Forma_Pago"].Value.ToString();
            txt_Seña.Text = dataGridReservas.CurrentRow.Cells["Seña"].Value.ToString();
            txt_Total.Text = dataGridReservas.CurrentRow.Cells["Total"].Value.ToString();
            txt_Deuda.Text = dataGridReservas.CurrentRow.Cells["Deuda"].Value.ToString();
            rdb_Si.Checked = true;
        }

        private void btn_EliminarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridReservas.CurrentRow == null) throw new Exception(TraducirMensaje("msg_ReservaNoSeleccionado"));

                BE.Reserva reserva = new BE.Reserva()
                {
                    Id = int.Parse(dataGridReservas.CurrentRow.Cells[0].Value.ToString()),
                };
                _iReserva.BajaReserva(reserva);

                CargarReservas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_ReservaBaja"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Funciones
        private void CargarReservas()
        {
            dataGridReservas.DataSource = _iReserva.ObtenerReservaCliente();
            dataGridReservas.ClearSelection();
            dataGridReservas.TabStop = false;
            dataGridReservas.ReadOnly = true;
        }

        private void CargarTipoCancha()
        {
            cmb_Tipo.DataSource = _iCancha.ObtenerTipoCanchas();
            cmb_Tipo.DisplayMember = "Tipo";
            cmb_Tipo.ValueMember = null;
            cmb_Tipo.SelectedItem = -1;
        }

        private void CargarIdCanchas()
        {
            cmb_Cancha.DataSource = _iCancha.ObtenerIdCanchas(cmb_Tipo.Text);
            cmb_Cancha.DisplayMember = "Id";
            cmb_Cancha.ValueMember = null;
            cmb_Cancha.SelectedItem = null;
        }

        private void CargarClientes()
        {
            cmb_Cliente.DataSource = _iCliente.ObtenerNombreClientes();
            cmb_Cliente.DisplayMember = "Nombre";
            cmb_Cliente.ValueMember = "Id";
            cmb_Cliente.SelectedItem = null;
        }

        private void Bloquear()
        {
            cmb_Cliente.Enabled = false;
            dtp_Fecha.Enabled = false;
            cmb_Hora1.Enabled = false;
            cmb_FormaPago.Enabled = false;
            txt_Seña.Enabled = false;
            btn_Aceptar.Enabled = false;
            txt_Total.Enabled = false;
            txt_Deuda.Enabled = false;
            btn_Reservar.Enabled = false;
            btn_ModificarReserva.Enabled = false;
            btn_EliminarReserva.Enabled = false;
            btn_AltaCliente.Enabled = true;
        }

        private void Desbloquear()
        {
            cmb_Cliente.Enabled = true;
            dtp_Fecha.Enabled = true;
            cmb_Hora1.Enabled = true;
            cmb_FormaPago.Enabled = true;
            txt_Seña.Enabled = true;
            btn_Aceptar.Enabled = true;
            txt_Total.Enabled = true;
            txt_Deuda.Enabled = true;
            btn_Reservar.Enabled = true;
            btn_ModificarReserva.Enabled = true;
            btn_EliminarReserva.Enabled = true;
            btn_AltaCliente.Enabled = false;
        }

        private void Limpiar()
        {
            cmb_Tipo.SelectedIndex = -1;
            cmb_Cancha.SelectedIndex = -1;
            cmb_Cliente.SelectedIndex = -1;
            cmb_Hora1.SelectedIndex = -1;
            cmb_FormaPago.SelectedIndex = -1;
            rdb_No.Checked = false;
            rdb_Si.Checked = false;
            dtp_Fecha.Value = DateTime.Now;
            txt_Seña.Clear();
            txt_Total.Clear();
            txt_Deuda.Clear();
            Desbloquear();
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
        #endregion

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            BLL.Reserva reservaBLL = new BLL.Reserva();
            txt_Total.Text = (_iCancha.ObtenerPrecio(int.Parse(cmb_Cancha.Text))).ToString();
            float seña = float.Parse(txt_Seña.Text);
            int hora = int.Parse(cmb_Hora1.Text.Substring(0, 2));
            float total = float.Parse(txt_Total.Text);
            txt_Deuda.Text = (reservaBLL.CalcularDeuda(out float tot, seña, hora, total)).ToString();
            txt_Total.Text = tot.ToString();
            
        }
    }
}
