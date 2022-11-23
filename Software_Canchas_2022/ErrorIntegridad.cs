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

        public ErrorIntegridad(ITraductor traductor, IBackUp backup, IDigito_Verificador digito_Verificador, IBitacora bitacora, string tabla)
        {
            InitializeComponent();
            _iTraductor = traductor;
            _iBackup = backup;
            _iDigito_Verificador = digito_Verificador;
            _iBitacora = bitacora;
            lbl_Tabla1.Text = tabla;
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
                    _iDigito_Verificador.RecalcularDV();
                    _iBitacora.AltaBitacora("Se recalcularon los digitos verificadores", "ALTA");
                    MessageBox.Show("Se recalcularon los digitos verificadores de manera correcta");
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ErrorIntegridad_Load(object sender, EventArgs e)
        {
            label1.Text = "La base de datos está corrupta.\nSe modificó la tabla " + lbl_Tabla1.Text + " de manera externa. \n¿Qué acción desea realizar?";
            CargarTabla();
        }

        private void CargarTabla()
        {
            dataGridTabla.DataSource = _iDigito_Verificador.ObtenerTabla(lbl_Tabla1.Text);
            dataGridTabla.Columns["DVH"].Visible = false;
            dataGridTabla.ClearSelection();
            dataGridTabla.TabStop = false;
            dataGridTabla.ReadOnly = true;
            dataGridTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
