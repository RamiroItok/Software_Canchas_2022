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

                ExecuteNonReader();
                return "La copia se ha creado correctamente en la ruta en" + ruta + ".";
            }
            catch
            {
                throw new Exception("Error al realizar la copia.");
            }
        }

        public string Realizar_Restore(string ruta)
        {
            try
            {
                SelectCommandText = $@"ALTER DATABASE[Canchas_2022] SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE MASTER RESTORE DATABASE[Canchas_2022] FROM DISK = '{ruta}' WITH REPLACE ALTER DATABASE [Canchas_2022] SET MULTI_USER";
                ExecuteNonReader();

                return "Se restauró el sistema de manera correcta.";
            }
            catch
            {
                throw new Exception("Error al realizar el restore.");
            }
        }
    }
}
