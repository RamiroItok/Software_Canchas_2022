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
    public partial class GestionDeudas : Form, IObserver
    {
        private readonly ITraductor _iTraductor;
        private readonly IDeudas _iDeudas;
        private readonly ICliente _iCliente;
        private readonly IReserva _iReserva;

        public GestionDeudas(ITraductor traductor, IDeudas deudas, ICliente cliente, IReserva reserva)
        {
            InitializeComponent();
            _iTraductor = traductor;
            _iDeudas = deudas;
            _iCliente = cliente;
            _iReserva = reserva;
        }

        private void GestionDeudas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarDeudas();
        }

        private void CargarDeudas()
        {
            dataGridDeudas.DataSource = _iDeudas.ListarDeudas();
            dataGridDeudas.ClearSelection();
            dataGridDeudas.TabStop = false;
            dataGridDeudas.ReadOnly = true;
            dataGridDeudas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarClientes()
        {
            cmb_Cliente.DataSource = _iCliente.ObtenerNombreClientes();
            cmb_Cliente.DisplayMember = "Nombre";
            cmb_Cliente.ValueMember = "Id";
            cmb_Cliente.SelectedItem = null;
        }

        private void CargarDeudaCliente()
        {
            dataGridDeudas.DataSource = _iDeudas.ListarDeudaCliente(cmb_Cliente.Text);
            dataGridDeudas.ClearSelection();
            dataGridDeudas.TabStop = false;
            dataGridDeudas.ReadOnly = true;
            dataGridDeudas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            CargarDeudaCliente();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cmb_Cliente.SelectedIndex = -1;
            CargarDeudas();
        }

        private void btn_PagarDeuda_Click(object sender, EventArgs e)
        {
            try
            {
                int idReserva = int.Parse(dataGridDeudas.CurrentRow.Cells["Reserva"].Value.ToString());
                float seña = float.Parse(dataGridDeudas.CurrentRow.Cells["Seña"].Value.ToString());
                float deuda = float.Parse(dataGridDeudas.CurrentRow.Cells["Pagar"].Value.ToString());

                int id = _iReserva.PagarDeudaCliente(idReserva, seña, deuda);

                MessageBox.Show(TraducirMensaje("msg_DeudaPagada"));
                CargarDeudas();
            }
            catch
            {
                MessageBox.Show(TraducirMensaje("msg_ErrorPagarDeuda"));
            }
        }

        private void dataGridDeudas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_IdReserva.Text = dataGridDeudas.CurrentRow.Cells["Reserva"].Value.ToString();
        }

        private void btn_Cancelar2_Click(object sender, EventArgs e)
        {
            lbl_IdReserva.Text = "";
            dataGridDeudas.ClearSelection();
        }
    }
}
