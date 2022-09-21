using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDigito_Verificador
    {
        string VerificarDV();
        bool RecalcularDV();
        void LoginSeguridad(string nombre_usuario, string contraseña);
    }
}
