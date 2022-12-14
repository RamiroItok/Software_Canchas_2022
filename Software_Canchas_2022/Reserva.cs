using BE.Observer;
using Interfaces;
using Interfaces.Observer;
using Servicios;
using Servicios.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private readonly IDeudas _iDeudas;

        public Reserva(IReserva reserva, ITraductor traductor, ICliente cliente, ICancha cancha, IDeudas deudas)
        {
            _iReserva = reserva;
            _iTraductor = traductor;
            _iCliente = cliente;
            _iCancha = cancha;
            _iDeudas = deudas;

            InitializeComponent();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            ComenzarTimer();
            CargarClientes();
            CargarTipoCancha();
            Sesion.SuscribirObservador(this);
            UpdateLanguage(Sesion.GetInstance().Idioma);
            CargarReservas();
            LlenarCmbHora();
            //PintarFila();
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
                    Id_Cliente = (int)cmb_Cliente1.SelectedValue,
                    Fecha = dtp_Fecha1.Value,
                    Hora = cmb_Hora1.Text,
                    Semana = chk_Semana.Checked,
                    Forma_Pago = cmb_FormaPago.Text,
                    Seña = float.Parse(txt_Seña.Text),
                    Total = float.Parse(txt_Total.Text),
                    Pagar = float.Parse(txt_Deuda.Text),
                    Pagado = txt_Pagado.Text
                };

                int id = _iReserva.AltaReserva(reserva);

                if (id == 0)
                {
                    MessageBox.Show(TraducirMensaje("msg_ClienteTieneDeudas"));
                }
                else
                {
                    if(reserva.Semana == true)
                    {
                        MessageBox.Show(TraducirMensaje("msg_ReservaAltaSemana"));
                    }
                    else
                    {
                        MessageBox.Show(TraducirMensaje("msg_ReservaAlta"));
                    }
                }


                CargarReservas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarIdCanchas();
            dtp_Fecha1.Value = DateTime.Now;
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
                if (lbl_IdReserva.Text == "") throw new Exception(TraducirMensaje("msg_ReservaNoSeleccionada"));

                BE.Reserva reserva = new BE.Reserva()
                {
                    Id = int.Parse(dataGridReservas.CurrentRow.Cells[0].Value.ToString()),
                    Id_Cancha = int.Parse(cmb_Cancha.Text),
                    Id_Cliente = int.Parse((cmb_Cliente1.SelectedValue).ToString()),
                    Fecha = dtp_Fecha1.Value,
                    Hora = cmb_Hora1.Text,
                    Semana = chk_Semana.Checked,
                    Forma_Pago = cmb_FormaPago.Text,
                    Seña = float.Parse(txt_Seña.Text),
                    Total = float.Parse(txt_Total.Text),
                    Pagar = float.Parse(txt_Deuda.Text),
                    Pagado = txt_Pagado.Text
                };

                _iReserva.ModificarReserva(reserva);

                CargarReservas();
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
            lbl_IdReserva.Text = dataGridReservas.CurrentRow.Cells["Id"].Value.ToString();
            cmb_Tipo.Text = dataGridReservas.CurrentRow.Cells["TipoCancha"].Value.ToString();
            cmb_Cancha.Text = dataGridReservas.CurrentRow.Cells["Cancha"].Value.ToString();
            cmb_Cliente1.Text = dataGridReservas.CurrentRow.Cells["Cliente"].Value.ToString();
            dtp_Fecha1.Text = dataGridReservas.CurrentRow.Cells["Fecha"].Value.ToString();
            cmb_Hora1.Items.Add(dataGridReservas.CurrentRow.Cells["Hora"].Value.ToString());
            cmb_Hora1.Text = dataGridReservas.CurrentRow.Cells["Hora"].Value.ToString();
            chk_Semana.Checked = Convert.ToBoolean(dataGridReservas.CurrentRow.Cells["Semana"].Value.ToString());
            cmb_FormaPago.Text = dataGridReservas.CurrentRow.Cells["Forma_Pago"].Value.ToString();
            txt_Seña.Text = dataGridReservas.CurrentRow.Cells["Seña"].Value.ToString();
            txt_Total.Text = dataGridReservas.CurrentRow.Cells["Total"].Value.ToString();
            txt_Deuda.Text = dataGridReservas.CurrentRow.Cells["Pagar"].Value.ToString();
            txt_Pagado.Text = dataGridReservas.CurrentRow.Cells["Pagado"].Value.ToString();
            rdb_Si.Checked = true;
        }

        private void btn_EliminarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_FormaPago.SelectedIndexChanged -= cmb_FormaPago_SelectedIndexChanged;
                if (lbl_IdReserva.Text == "") throw new Exception(TraducirMensaje("msg_ReservaNoSeleccionada"));

                if (chk_Semana.Checked)
                {
                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar la reserva para todas las semanas?", "Error", MessageBoxButtons.YesNo);
                    if (dialogResult.ToString() == "Yes")
                    {
                        BE.Reserva reserva = new BE.Reserva()
                        {
                            Id = int.Parse(dataGridReservas.CurrentRow.Cells[0].Value.ToString()),
                            Id_Cancha = int.Parse(cmb_Cancha.Text),
                            Id_Cliente = int.Parse((cmb_Cliente1.SelectedValue).ToString()),
                            Fecha = dtp_Fecha1.Value,
                            Hora = cmb_Hora1.Text,
                            Semana = chk_Semana.Checked,
                            Forma_Pago = cmb_FormaPago.Text,
                            Seña = float.Parse(txt_Seña.Text),
                            Total = float.Parse(txt_Total.Text),
                            Pagar = float.Parse(txt_Deuda.Text),
                            Pagado = txt_Pagado.Text
                        };
                        _iReserva.BajaReserva(reserva, true);

                    }
                    else
                    {
                        BE.Reserva reserva = new BE.Reserva()
                        {
                            Id = int.Parse(dataGridReservas.CurrentRow.Cells[0].Value.ToString()),
                            Id_Cancha = int.Parse(cmb_Cancha.Text),
                            Id_Cliente = int.Parse((cmb_Cliente1.SelectedValue).ToString()),
                            Fecha = dtp_Fecha1.Value,
                            Hora = cmb_Hora1.Text,
                            Semana = chk_Semana.Checked,
                            Forma_Pago = cmb_FormaPago.Text,
                            Seña = float.Parse(txt_Seña.Text),
                            Total = float.Parse(txt_Total.Text),
                            Pagar = float.Parse(txt_Deuda.Text),
                            Pagado = txt_Pagado.Text
                        };
                        _iReserva.BajaReserva(reserva, false);
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Está seguro que desea eliminar la reserva?", "Error", MessageBoxButtons.YesNo);
                    if (dialogResult.ToString() == "Yes")
                    {

                        BE.Reserva reserva = new BE.Reserva()
                        {
                            Id = int.Parse(dataGridReservas.CurrentRow.Cells[0].Value.ToString()),
                            Id_Cancha = int.Parse(cmb_Cancha.Text),
                            Id_Cliente = int.Parse((cmb_Cliente1.SelectedValue).ToString()),
                            Fecha = dtp_Fecha1.Value,
                            Hora = cmb_Hora1.Text,
                            Semana = chk_Semana.Checked,
                            Forma_Pago = cmb_FormaPago.Text,
                            Seña = float.Parse(txt_Seña.Text),
                            Total = float.Parse(txt_Total.Text),
                            Pagar = float.Parse(txt_Deuda.Text),
                            Pagado = txt_Pagado.Text
                        };
                        _iReserva.BajaReserva(reserva, false);

                    }
                    else
                    {
                        MessageBox.Show("Se cancela la baja de la reserva");
                    }
                }

                CargarReservas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_ReservaBaja"));
                cmb_FormaPago.SelectedIndexChanged += cmb_FormaPago_SelectedIndexChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Reserva reservaBLL = new BLL.Reserva();
                float seña = float.Parse(txt_Seña.Text);
                float total = float.Parse(txt_Total.Text);
                string formaPago = cmb_FormaPago.Text;
                txt_Deuda.Text = reservaBLL.CalcularDeuda(seña, total, formaPago).ToString();
                txt_Pagado.Text = reservaBLL.Pagado(int.Parse(txt_Deuda.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtp_Fecha_ValueChanged(object sender, EventArgs e)
        {
            LlenarCmbHora();
            string fecha = dtp_Fecha1.Value.ToString().Substring(0, 10);
            List<string> horas = _iReserva.ObtenerReservaHora(fecha, cmb_Cancha.Text);
            int contador = 0;
            for (int i = 0; i < cmb_Hora1.Items.Count; i++)
            {
                for (int j = 0; j < horas.Count; j++)
                {
                    if (horas[j].ToString() == cmb_Hora1.Items[i].ToString())
                    {
                        cmb_Hora1.Items.Remove(horas[j].ToString());
                        contador += 1;
                    }
                }
                if (contador == horas.Count)
                    break;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
            CargarReservas();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            if (chk_Fecha.Checked && chk_Cliente.Checked)
                CargarReservaFechaCliente();

            else if (chk_Fecha.Checked)
                CargarReservaFecha();

            else if (chk_Cliente.Checked)
                CargarReservaCliente();

            else
            {
                CargarReservas();
                LimpiarFiltros();
            }
        }

        private void cmb_Hora1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BLL.Reserva reservaBLL = new BLL.Reserva();
                int hora = int.Parse(cmb_Hora1.Text.Substring(0, 2));
                int total = int.Parse(_iCancha.ObtenerPrecio(cmb_Cancha.Text).ToString());
                txt_Total.Text = reservaBLL.CalcularTotalHora(hora, total).ToString();
                if(cmb_FormaPago.SelectedIndex != -1)
                    txt_Total.Text = reservaBLL.CalcularTotalTipoPago(hora, total, cmb_FormaPago.SelectedItem.ToString()).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_FormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BLL.Reserva reservaBLL = new BLL.Reserva();
                string formaPago = cmb_FormaPago.SelectedItem.ToString();
                int hora = int.Parse(cmb_Hora1.Text.Substring(0, 2));
                int total = int.Parse(_iCancha.ObtenerPrecio(cmb_Cancha.Text).ToString());
                txt_Total.Text = reservaBLL.CalcularTotalTipoPago(hora, total, formaPago).ToString();
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
            dataGridReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //PintarFila();

        }

        private void ComenzarTimer()
        {
            timerDeuda.Interval = int.Parse(ConfigurationManager.AppSettings["IntervaloTimerDeuda"]);
            timerDeuda.Start();
        }

        private void CargarReservaFecha()
        {
            dataGridReservas.DataSource = _iReserva.ObtenerReservaClienteFecha(dtp_Fecha2.Value.ToString().Substring(0, 10));
            dataGridReservas.ClearSelection();
            dataGridReservas.TabStop = false;
            dataGridReservas.ReadOnly = true;
            //PintarFila();
        }

        private void CargarReservaCliente()
        {
            dataGridReservas.DataSource = _iReserva.ObtenerReservaClienteCliente(cmb_Cliente2.Text);
            dataGridReservas.ClearSelection();
            dataGridReservas.TabStop = false;
            dataGridReservas.ReadOnly = true;
            //PintarFila();
        }

        private void CargarReservaFechaCliente()
        {
            dataGridReservas.DataSource = _iReserva.ObtenerReservaFechaCliente(dtp_Fecha2.Value.ToString().Substring(0, 10), cmb_Cliente2.Text);
            dataGridReservas.ClearSelection();
            dataGridReservas.TabStop = false;
            dataGridReservas.ReadOnly = true;
            //PintarFila();
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
            cmb_Cliente1.DataSource = _iCliente.ObtenerNombreClientes();
            cmb_Cliente1.DisplayMember = "Nombre";
            cmb_Cliente1.ValueMember = "Id";
            cmb_Cliente1.SelectedItem = null;
            cmb_Cliente2.DataSource = _iCliente.ObtenerNombreClientes();
            cmb_Cliente2.DisplayMember = "Nombre";
            cmb_Cliente2.ValueMember = "Id";
            cmb_Cliente2.SelectedItem = null;
        }

        private void PintarFila()
        {
            try
            {
                int filas = dataGridReservas.Rows.Count;
                for (int i = 0; i <= filas; i++)
                {
                    if (dataGridReservas.Rows[i].Cells[11].Value.ToString() == "Pagado")
                    {
                        dataGridReservas.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridReservas.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bloquear()
        {
            cmb_Cliente1.Enabled = false;
            dtp_Fecha1.Enabled = false;
            cmb_Hora1.Enabled = false;
            chk_Semana.Enabled = false;
            cmb_FormaPago.Enabled = false;
            txt_Seña.Enabled = false;
            btn_Calcular.Enabled = false;
            txt_Total.Enabled = false;
            txt_Deuda.Enabled = false;
            txt_Pagado.Enabled = false;
            btn_Reservar.Enabled = false;
            btn_ModificarReserva.Enabled = false;
            btn_EliminarReserva.Enabled = false;
            btn_AltaCliente.Enabled = true;
        }

        private void Desbloquear()
        {
            cmb_Cliente1.Enabled = true;
            dtp_Fecha1.Enabled = true;
            cmb_Hora1.Enabled = true;
            chk_Semana.Enabled = true;
            cmb_FormaPago.Enabled = true;
            txt_Seña.Enabled = true;
            btn_Calcular.Enabled = true;
            txt_Total.Enabled = true;
            txt_Deuda.Enabled = true;
            txt_Pagado.Enabled = true;
            btn_Reservar.Enabled = true;
            btn_ModificarReserva.Enabled = true;
            btn_EliminarReserva.Enabled = true;
            btn_AltaCliente.Enabled = false;
        }

        private void Limpiar()
        {
            cmb_FormaPago.SelectedIndexChanged -= cmb_FormaPago_SelectedIndexChanged;
            lbl_IdReserva.Text = "";
            cmb_Tipo.SelectedIndex = -1;
            cmb_Cancha.SelectedIndex = -1;
            cmb_Cliente1.SelectedIndex = -1;
            cmb_Hora1.SelectedIndex = -1;
            cmb_FormaPago.SelectedIndex = -1;
            rdb_No.Checked = false;
            rdb_Si.Checked = false;
            dtp_Fecha1.Value = DateTime.Now;
            txt_Seña.Clear();
            txt_Total.Clear();
            txt_Deuda.Clear();
            txt_Pagado.Clear();
            chk_Semana.Checked = false;
            cmb_FormaPago.SelectedIndexChanged -= cmb_FormaPago_SelectedIndexChanged;
            Desbloquear();
        }

        private void LimpiarFiltros()
        {
            dtp_Fecha1.Value = DateTime.Now;
            chk_Cliente.Checked = false;
            chk_Fecha.Checked = false;
            cmb_Cliente2.SelectedIndex = -1;
        }

        private void LlenarCmbHora()
        {
            cmb_Hora1.Items.Clear();
            if (dtp_Fecha1.Value.ToString().Substring(0, 10) == DateTime.Now.ToString().Substring(0, 10))
            {
                for (int i = 11; i < 24; i++)
                {
                    if (i > int.Parse(DateTime.Now.ToString("HH")))
                    {
                        cmb_Hora1.Items.Add($"{Convert.ToString(i)}:00");
                    }
                }
            }
            else
            {
                for (int i = 11; i < 24; i++)
                {
                    cmb_Hora1.Items.Add($"{Convert.ToString(i)}:00");
                }
            }
        }

        private void GenerarAltaDeuda()
        {
            DataTable reservas = _iReserva.ObtenerReservaVencida();
            if(reservas.Rows.Count > 0)
            {
                foreach(DataRow fila in reservas.Rows)
                {
                    DataTable deuda = _iDeudas.ObtenerDeudaCliente(int.Parse(fila[2].ToString()));
                    if(deuda.Rows.Count == 0)
                    {
                        _iDeudas.AltaDeuda(int.Parse(fila[0].ToString()), int.Parse(fila[2].ToString()), DateTime.Parse(fila[3].ToString()));
                    }
                }
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
        #endregion

        private void timerDeuda_Tick(object sender, EventArgs e)
        {
            try
            {
                GenerarAltaDeuda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorTimerDeuda"));
            }
        }
    }
}
