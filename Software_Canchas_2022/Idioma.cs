using BE.Observer;
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
    public partial class Idioma : Form
    {
        private readonly ITraductor _iTraductor;
        public Idioma(ITraductor traductor)
        {
            _iTraductor = traductor;
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            CargarIdiomas();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                BE.Observer.Idioma idioma = new BE.Observer.Idioma()
                {
                    Nombre = txt_Nombre.Text,
                };

                _iTraductor.AltaIdioma(idioma);

                CargarIdiomas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_IdiomaAlta"));
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
                if (lbl_Id.Text == "") throw new Exception(TraducirMensaje("msg_IdiomaNoSeleccionado"));

                BE.Observer.Idioma idioma = new BE.Observer.Idioma()
                {
                    Id = int.Parse(dataGirdIdioma.CurrentRow.Cells[0].Value.ToString()),
                    Nombre = txt_Nombre.Text,
                };

                _iTraductor.ModificarIdioma(idioma);

                CargarIdiomas();
                Limpiar();
                MessageBox.Show(TraducirMensaje("msg_IdiomaAlta"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarIdiomas()
        {
            IList<IIdioma> idiomas = _iTraductor.ObtenerIdiomas();

            dataGirdIdioma.DataSource = idiomas;
            dataGirdIdioma.Columns["Id"].Visible = false;
            dataGirdIdioma.Columns["Default"].Visible = false;
            dataGirdIdioma.ClearSelection();
            dataGirdIdioma.TabStop = false;
            dataGirdIdioma.ReadOnly = true;
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
            txt_Nombre.Clear();
            lbl_Id.Text = "";
        }

        private void dataGirdIdioma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Id.Text = dataGirdIdioma.CurrentRow.Cells["Id"].Value.ToString();
            txt_Nombre.Text = dataGirdIdioma.CurrentRow.Cells["Nombre"].Value.ToString();
        }
    }
}
