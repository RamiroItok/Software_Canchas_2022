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
    public partial class ErrorIntegridad : Form
    {
        private readonly ITraductor _iTraductor;
        private readonly IBackUp _iBackup;
        private readonly IDigito_Verificador _iDigito_Verificador;
        private readonly IBitacora _iBitacora;

        public ErrorIntegridad(ITraductor traductor, IBackUp backup, IDigito_Verificador digito_Verificador, IBitacora bitacora)
        {
            _iTraductor = traductor;
            _iBackup = backup;
            _iDigito_Verificador = digito_Verificador;
            _iBitacora = bitacora;
            InitializeComponent();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            Restore restore = new Restore(_iBackup, _iTraductor);
            restore.StartPosition = FormStartPosition.CenterScreen;
            restore.Show();
        }

        private void btn_RecalcularDV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea recalcular los digitos verificadores?", "Recalcular Digitos", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                try
                {
                    _iBitacora.AltaBitacora("Se recalcularon los digitos verificadores", "ALTA");
                    _iDigito_Verificador.RecalcularDV();
                    MessageBox.Show("Se recalcularon los digitos verificadores de manera correcta");
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
