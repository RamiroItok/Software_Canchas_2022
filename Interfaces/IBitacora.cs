using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBitacora
    {
        int AltaBitacora(string descripcion, string criticidad);
        int BajaBitacora(string fechaIni, string fechaFin);
        List<BE.Bitacora> ListarEventos();
        DataTable Listar_Evento_Between(string fecha_ini, string fecha_fin);
        DataTable Listar_Evento_Between_Usuario(string fecha_ini, string fecha_fin, string nombre_usuario);
        DataTable Listar_Evento_Usuario(string nombre_usuario);
        DataTable Listar_Evento_Between_Critic(string fecha_ini, string fecha_fin, string critic);
        DataTable Listar_Evento_Crit(string critic);
        DataTable Listar_Evento_Crit_Usu(string nombre_usuario, string crit);
        DataTable Listar_Evento_Fecha_Usu_Crit(string fecha_ini, string fecha_fin, string nombre_usuario, string crit);
    }
}
