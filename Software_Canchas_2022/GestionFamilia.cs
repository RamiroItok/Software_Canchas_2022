using BE.Composite;
using BE.Observer;
using Interfaces.Composite;
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
    public partial class GestionFamilia : Form
    {
        private readonly IPermiso _iPermiso;
        private readonly ITraductor _iTraductor;
        public GestionFamilia(IPermiso permiso, ITraductor traductor)
        {
            InitializeComponent();
            _iPermiso = permiso;
            _iTraductor = traductor;
         }

        private void GestionFamilia_Load(object sender, EventArgs e)
        {
            CargarFamilia();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_Familia.Text))
                {
                    bool existeFamilia = _iPermiso.ObtenerFamilias().Where(x => x.Nombre.ToUpper() == txt_Familia.Text.ToUpper()).Any();
                    if (existeFamilia == true)
                    {
                        Limpiar();
                        throw new Exception(TraducirMensaje("msg_FamiliaExiste"));
                    }

                    Familia familia = new Familia()
                    {
                        Nombre = txt_Familia.Text,
                    };

                    _iPermiso.AltaFamiliaPatente(familia, true);

                    MessageBox.Show(TraducirMensaje("msg_FamiliaCreada"));
                    CargarFamilia();
                    Limpiar();
                }
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

        private void Limpiar()
        {
            txt_Familia.Clear();
        }

        private void CargarFamilia()
        {
            dataGridFamilia.DataSource = _iPermiso.ObtenerFamilias();
            dataGridFamilia.Columns["Hijos"].Visible = false;
            dataGridFamilia.Columns["Permiso"].Visible = false;
            dataGridFamilia.ClearSelection();
            dataGridFamilia.TabStop = false;
            dataGridFamilia.ReadOnly = true;
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
