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
    public partial class Restore : Form
    {
        private readonly IBackUp _iBackup;
        private readonly ITraductor _iTraductor;
        public Restore(IBackUp backup, ITraductor traductor)
        {
            InitializeComponent();
            _iBackup = backup;
            _iTraductor = traductor;
        }

        private void btn_explorador_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_explorador.Text = dlg.FileName;
            }
        }

        private void btn_RealizarRestore_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta = txt_explorador.Text;

                MessageBox.Show(_iBackup.Realizar_Restore(ruta));
                this.Close();
                MessageBox.Show("A continuación se cerrará el sistema para guardar los cambios.");
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
