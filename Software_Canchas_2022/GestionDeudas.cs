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

        public GestionDeudas(ITraductor traductor, IDeudas deudas)
        {
            InitializeComponent();
            _iTraductor = traductor;
            _iDeudas = deudas;
        }

        private void GestionDeudas_Load(object sender, EventArgs e)
        {
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
