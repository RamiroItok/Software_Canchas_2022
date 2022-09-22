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
    public partial class Backup : Form
    {
        private readonly IBackUp _iBackup;
        private readonly ITraductor _iTraductor;
        public Backup(IBackUp backup, ITraductor traductor)
        {
            InitializeComponent();
            _iBackup = backup;
            _iTraductor = traductor;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" +
                System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + "Soft_Cancha");
                string ruta = txt_Explorador.Text + "\\";

                MessageBox.Show(_iBackup.Realizar_Backup(ruta, nombre));
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_Explorador_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_Explorador.Text = dlg.SelectedPath;
            }
        }
    }
}
