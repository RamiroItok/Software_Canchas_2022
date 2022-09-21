using BE.DTOs;
using BE.Observer;
using Interfaces.Observer;
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
    public partial class Gestion_Etiquetas : Form
    {
        private readonly ITraductor _iTraductor;
        private List<TraduccionesDTO> _traduccionesDTO;
        public Gestion_Etiquetas(ITraductor traductor)
        {
            _iTraductor = traductor;
            _traduccionesDTO = new List<TraduccionesDTO>();

            InitializeComponent();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Etiqueta.SelectedValue == null) throw new Exception("Se debe elegir una etiqueta");
                if (string.IsNullOrWhiteSpace(txt_Traducciones.Text)) throw new Exception("Se debe completar la traducción");

                foreach (var item in _traduccionesDTO)
                {
                    if (item.Etiqueta == cmb_Etiqueta.Text)
                    {
                        Limpiar();
                        throw new Exception("Esa traducción ya está cargada.");
                    }
                }

                IIdioma idioma = _iTraductor.ObtenerIdiomas().Where(x => x.Id == (int)cmb_Idioma.SelectedValue).FirstOrDefault();
                Etiqueta etiqueta = _iTraductor.GetEtiquetas().Where(x => x.Id == (int)cmb_Etiqueta.SelectedValue).FirstOrDefault();

                Traduccion traduccion = new Traduccion()
                {
                    Etiqueta = etiqueta,
                    Texto = txt_Traducciones.Text,
                };

                _iTraductor.AltaTraduccion(idioma, traduccion);
                MessageBox.Show("Traducción cargada con éxito.");
                CargarTraducciones(idioma);
                Limpiar();
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
                if (cmb_Etiqueta.Text == "") throw new Exception("Se debe elegir una etiqueta");
                if (txt_Traducciones.Text == "") throw new Exception("Se debe completar la traducción");

                IIdioma idioma = _iTraductor.ObtenerIdiomas().Where(x => x.Id == (int)cmb_Idioma.SelectedValue).FirstOrDefault();
                Etiqueta etiqueta = _iTraductor.GetEtiquetas().Where(x => x.Id == (int)cmb_Etiqueta.SelectedValue).FirstOrDefault();

                Traduccion traduccion = new Traduccion()
                {
                    Id = int.Parse(lbl_Id.Text),
                    Texto = txt_Traducciones.Text,
                };

                _iTraductor.ModificarTraduccion(traduccion);
                MessageBox.Show("Traducción cargada con éxito.");
                CargarTraducciones(idioma);
                Limpiar();
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

        private void Gestion_Etiquetas_Load(object sender, EventArgs e)
        {
            CargarCmbIdioma();
            CargarCmbEtiquetas();
        }

        private void cmb_Idioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Idioma.SelectedIndex != -1)
            {
                IIdioma idioma = _iTraductor.ObtenerIdiomas().Where(i => i.Nombre == cmb_Idioma.Text).FirstOrDefault();
                CargarTraducciones(idioma);
            }
        }

        private void CargarTraducciones(IIdioma idioma)
        {
            if (idioma != null)
            {
                _traduccionesDTO = TraduccionesDTO.FillListDTO(_iTraductor.GetTraduccionesPorIdioma(idioma.Id));
                dataGridEtiquetas.DataSource = _traduccionesDTO;
                dataGridEtiquetas.ClearSelection();
                dataGridEtiquetas.TabStop = false;
                dataGridEtiquetas.ReadOnly = true;
                dataGridEtiquetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void CargarCmbIdioma()
        {
            cmb_Idioma.DataSource = _iTraductor.ObtenerIdiomas();
            cmb_Idioma.ValueMember = "Id";
            cmb_Idioma.DisplayMember = "Nombre";
        }

        private void CargarCmbEtiquetas()
        {
            cmb_Etiqueta.DataSource = _iTraductor.GetEtiquetas();
            cmb_Etiqueta.ValueMember = "Id";
            cmb_Etiqueta.DisplayMember = "Nombre";
            cmb_Etiqueta.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            cmb_Etiqueta.SelectedIndex = -1;
            txt_Traducciones.Clear();
            lbl_Id.Text = "";
        }

        private void dataGridEtiquetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Id.Text = dataGridEtiquetas.CurrentRow.Cells["Id"].Value.ToString();
            cmb_Etiqueta.Text = dataGridEtiquetas.CurrentRow.Cells["Etiqueta"].Value.ToString();
            txt_Traducciones.Text = dataGridEtiquetas.CurrentRow.Cells["Traduccion"].Value.ToString();
        }
    }
}
