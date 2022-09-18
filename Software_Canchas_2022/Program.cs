using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Canchas_2022
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inyecciones de dependencias
            BLL.Usuario usuario = new BLL.Usuario();
            BLL.Cancha cancha = new BLL.Cancha();
            BLL.Cliente cliente = new BLL.Cliente();
            BLL.Reserva reserva = new BLL.Reserva();
            BLL.Observer.Idioma traductor = new BLL.Observer.Idioma();
            BLL.Composite.Permiso permiso = new BLL.Composite.Permiso();

            Application.Run(new Login(permiso, traductor, cancha, cliente, usuario, reserva));
        }
    }
}
