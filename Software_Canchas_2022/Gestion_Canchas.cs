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
    public partial class Gestion_Canchas : Form, IObserver
    {
        private readonly ICancha _iCancha;
        private readonly ITraductor _iTraductor;
        public Gestion_Canchas(ICancha cancha, ITraductor traductor)
        {
            _iCancha = cancha;
            _iTraductor = traductor;
            InitializeComponent();
        }

        private void Gestion_Canchas_Load(object sender, EventArgs e)
        {
            CargarCanchas();
            Sesion.SuscribirObservador(this);
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridCanchas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Id_Cancha.Text = dataGridCanchas.CurrentRow.Cells["Id"].Value.ToString();
            cmbTipo.Text = dataGridCanchas.CurrentRow.Cells["Tipo"].Value.ToString();
            cmbMaterial.Text = dataGridCanchas.CurrentRow.Cells["Material"].Value.ToString();
            txt_Precio.Text = dataGridCanchas.CurrentRow.Cells["PrecioBase"].Value.ToString();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Cancha cancha = new Cancha()
                {
                    Material = cmbMaterial.Text,
                    Tipo = cmbTipo.Text,
                    PrecioBase = float.Parse(txt_Precio.Text)
                };

                _iCancha.AltaCancha(cancha);

                CargarCanchas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_CanchaAlta"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCanchas.CurrentRow == null) throw new Exception(TraducirMensaje("msg_CanchaNoSeleccionada"));

                Cancha cancha = new Cancha()
                {
                    Id = int.Parse(dataGridCanchas.CurrentRow.Cells[0].Value.ToString()),
                    Material = cmbMaterial.Text,
                    Tipo = cmbTipo.Text,
                    PrecioBase = float.Parse(txt_Precio.Text)
                };
                _iCancha.ModificarCancha(cancha);

                CargarCanchas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_CanchaModificada"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridCanchas.CurrentRow == null) throw new Exception(TraducirMensaje("msg_CanchaNoSeleccionada"));

                Cancha cancha = new Cancha()
                {
                    Id = int.Parse(dataGridCanchas.CurrentRow.Cells[0].Value.ToString()),
                };
                _iCancha.BajaCancha(cancha);

                CargarCanchas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_CanchaBaja"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCanchas()
        {
            dataGridCanchas.DataSource = _iCancha.ObtenerCanchas();
            dataGridCanchas.ClearSelection();
            dataGridCanchas.TabStop = false;
            dataGridCanchas.ReadOnly = true;
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
            cmbMaterial.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            lbl_Id_Cancha.Text = "";
            txt_Precio.Clear();
        }
    }
}
