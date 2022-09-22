using DAL.Conexion;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Backup : Acceso, IBackUp
    {
        public string Realizar_Backup(string ruta, string nombre)
        {
            try
            {
                SelectCommandText = "USE[Canchas_2022] BACKUP DATABASE Canchas_2022 TO DISK = '" + ruta + nombre + ".bak' WITH FORMAT, MEDIANAME = 'SQLServerBackups', NAME = 'Full Backup of Canchas'";

                DataSet ds = ExecuteNonReader();
                return "La copia se ha creado correctamente en la ruta en" + ruta + ".";
            }
            catch
            {
                throw new Exception("Error al realizar la copia.");
            }
        }

        public string Realizar_Restore()
        {
            try
            {

                return "";
            }
            catch
            {
                throw new Exception("Error al realizar el restore.");
            }
        }
    }
}
