using BE;
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
    public partial class Gestion_Clientes : Form, IObserver
    {
        private readonly ICliente _iCliente;
        private readonly ITraductor _iTraductor;
        public Gestion_Clientes(ICliente cliente, ITraductor traductor)
        {
            _iCliente = cliente;
            _iTraductor = traductor;
            InitializeComponent();
        }

        private void Gestion_Clientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            Sesion.SuscribirObservador(this);
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente()
                {
                    Nombre = txt_Nombre.Text,
                    Apellido = txt_Apellido.Text,
                    Telefono = int.Parse(txt_Telefono.Text)
                };

                _iCliente.AltaCliente(cliente);

                CargarClientes();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_ClienteAlta"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridClientes.CurrentRow == null) throw new Exception(TraducirMensaje("msg_ClienteNoSeleccionada"));

                Cliente cliente = new Cliente()
                {
                    Id_Cliente = int.Parse(dataGridClientes.CurrentRow.Cells[0].Value.ToString()),
                    Nombre = txt_Nombre.Text,
                    Apellido = txt_Apellido.Text,
                    Telefono = int.Parse(txt_Telefono.Text)
                };
                _iCliente.ModificarCliente(cliente);

                CargarClientes();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_ClienteModificado"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridClientes.CurrentRow == null) throw new Exception(TraducirMensaje("msg_CanchaNoSeleccionada"));

                Cliente cliente = new Cliente()
                {
                    Id_Cliente = int.Parse(dataGridClientes.CurrentRow.Cells[0].Value.ToString()),
                };
                _iCliente.BajaCliente(cliente);

                CargarClientes();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_ClienteBaja"));
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

        private void CargarClientes()
        {
            dataGridClientes.DataSource = _iCliente.ObtenerClientes();
            dataGridClientes.ClearSelection();
            dataGridClientes.TabStop = false;
            dataGridClientes.ReadOnly = true;
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


        private void Limpiar()
        {
            txt_Apellido.Clear();
            txt_Nombre.Clear();
            txt_Telefono.Clear();
        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Nombre.Text = dataGridClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            txt_Apellido.Text = dataGridClientes.CurrentRow.Cells["Apellido"].Value.ToString();
            txt_Telefono.Text = dataGridClientes.CurrentRow.Cells["Telefono"].Value.ToString();
        }
    }
}
