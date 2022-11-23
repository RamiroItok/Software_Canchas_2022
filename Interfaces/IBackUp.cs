using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBackUp
    {
        string Realizar_Backup(string ruta, string nombre);
        string Realizar_Restore(string ruta);
        bool CrearBaseDeDatos();
    }
}
