using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Canchas_2022
{
    internal static class Program
    {
        [DllImport("user32")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instanceCountOne = false;

            using (Mutex mutex = new Mutex(true, Process.GetCurrentProcess().ProcessName, out instanceCountOne))
            {
                if (instanceCountOne)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    // Inyecciones de dependencias
                    BLL.Usuario usuario = new BLL.Usuario();
                    BLL.Cancha cancha = new BLL.Cancha();
                    BLL.Cliente cliente = new BLL.Cliente();
                    BLL.Reserva reserva = new BLL.Reserva();
                    BLL.Bitacora bitacora = new BLL.Bitacora();
                    BLL.ControlCliente controlCliente = new BLL.ControlCliente();
                    BLL.Backup backup = new BLL.Backup();
                    BLL.Observer.Idioma traductor = new BLL.Observer.Idioma();
                    BLL.Composite.Permiso permiso = new BLL.Composite.Permiso();
                    BLL.Deudas deudas = new BLL.Deudas();
                    BLL.Reporte reporte = new BLL.Reporte();

                    Application.Run(new Login(permiso, traductor, cancha, cliente, usuario, reserva, bitacora, backup, controlCliente, deudas, reporte));
                    mutex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("La aplicación ya se encuentra en uso.");
                    var processes = Process.GetProcessesByName("Software_Canchas_2022");
                    foreach (var process in processes.Where(p => p.MainWindowHandle != IntPtr.Zero))
                    {
                        BringWindowToTop(process.MainWindowTitle);
                    }
                    Application.Exit();
                }
            }
        }

        private static bool BringWindowToTop(string windowName)
        {
            int hWnd = FindWindow(null, windowName);
            if (hWnd != 0)
            {
                return SetForegroundWindow((IntPtr)hWnd);
            }
            return false;
        }
    }
}
