using Interfaces;
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
    public partial class LogInSeguridad : Form
    {
        private readonly IUsuario _iUsuario;
        private readonly ITraductor _iTraductor;
        private readonly IBackUp _iBackup;
        private readonly IDigito_Verificador _iVerificador;
        private readonly IBitacora _iBitacora;
        public LogInSeguridad(IUsuario usuario, ITraductor traductor, IBackUp backup, IDigito_Verificador digito_Verificador, IBitacora bitacora, string tabla)
        {
            InitializeComponent();
            _iUsuario = usuario;
            _iTraductor = traductor;
            _iBackup = backup;
            _iVerificador = digito_Verificador;
            _iBitacora = bitacora;
            lbl_Tabla.Text = tabla;
         }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _iUsuario.LoguearUsuarioTemporal(txt_Nombre_Usuario.Text, txt_Contraseña.Text);
                ErrorIntegridad errorIntegridad = new ErrorIntegridad(_iTraductor, _iBackup, _iVerificador, _iBitacora, lbl_Tabla.Text);
                this.Close();
                errorIntegridad.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Limpiar();
            }
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txt_Nombre_Usuario.Clear();
            txt_Contraseña.Clear();
        }
    }
}
