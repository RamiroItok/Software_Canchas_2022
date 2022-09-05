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
    public partial class Gestion_Usuarios : Form, IObserver
    {
        private readonly IUsuario _iUsuario;
        private readonly ITraductor _iTraductor;
        public Gestion_Usuarios(IUsuario usuario, ITraductor traductor)
        {
            _iUsuario = usuario;
            _iTraductor = traductor;
            InitializeComponent();
        }

        public void UpdateLanguage(IIdioma idioma)
        {
            Traducir(idioma);
        }

        private void Traducir(IIdioma idioma)
        {
            Traductor.Traducir(_iTraductor, idioma, this.Controls);
        }

        private void Gestion_Usuarios_Load(object sender, EventArgs e)
        {
            UpdateLanguage(Sesion.GetInstance().Idioma);
        }
    }
}
