using Interfaces;
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
    public partial class ControlReserva : Form
    {
        private readonly IControlReserva _iControlReserva;
        public ControlReserva(IControlReserva controlReserva)
        {
            InitializeComponent();
            _iControlReserva = controlReserva;
        }

        private void ControlReserva_Load(object sender, EventArgs e)
        {
            CargarControl();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarControl()
        {
            dataGridControl.DataSource = _iControlReserva.ObtenerControlReservas();
            dataGridControl.Columns["DVH"].Visible = false;
            dataGridControl.ClearSelection();
            dataGridControl.TabStop = false;
            dataGridControl.ReadOnly = true;
            dataGridControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
