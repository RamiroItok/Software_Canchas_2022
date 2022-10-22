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
    public partial class ControlCliente : Form
    {
        private readonly IControlCliente _iControlCliente;
        private readonly ITraductor _iTraductor;
        public ControlCliente(IControlCliente controlCliente, ITraductor traductor)
        {
            InitializeComponent();
            _iControlCliente = controlCliente;
            _iTraductor = traductor;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarControl()
        {
            dataGridControl.DataSource = _iControlCliente.ObtenerControlCliente();
            dataGridControl.ClearSelection();
            dataGridControl.TabStop = false;
            dataGridControl.ReadOnly = true;
            dataGridControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ControlCliente_Load(object sender, EventArgs e)
        {
            CargarControl();
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridControl.CurrentRow == null) throw new Exception(TraducirMensaje("msg_ClienteNoSeleccionado"));

                Cliente cliente = new Cliente()
                {
                    Id = int.Parse(dataGridControl.CurrentRow.Cells[1].Value.ToString()),
                    Nombre = dataGridControl.CurrentRow.Cells[2].Value.ToString(),
                    Apellido = dataGridControl.CurrentRow.Cells[3].Value.ToString(),
                    Telefono = int.Parse(dataGridControl.CurrentRow.Cells[4].Value.ToString())
                };
                _iControlCliente.RestaurarCliente(cliente);

                CargarControl();
                MessageBox.Show(TraducirMensaje("msg_RestaurarCliente"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
