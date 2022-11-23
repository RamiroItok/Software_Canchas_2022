using Interfaces;
using Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DigitoVerificador : IDigito_Verificador
    {
        private readonly DAL.Digito_Verificador _digitoVerificadorDAL;
        private readonly DAL.Observer.Idioma _IdiomaDAL;

        public DigitoVerificador()
        {
            _digitoVerificadorDAL = new DAL.Digito_Verificador();
            _IdiomaDAL = new DAL.Observer.Idioma();
        }

        public string VerificarDV()
        {
            try
            {
                return _digitoVerificadorDAL.Verificar_DV();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool RecalcularDV()
        {
            try
            {
                _digitoVerificadorDAL.Recalcular_DV();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ObtenerTabla(string tabla)
        {
            try
            {
                DataTable dt = _digitoVerificadorDAL.ObtenerTabla(tabla);
                return dt;
            }
            catch
            {
                throw new Exception(TraducirMensaje("msg_ErrorListar"));
            }
        }

        private string TraducirMensaje(string msgTag)
        {
            return Traductor.TraducirMensaje(_IdiomaDAL, msgTag);
        }
    }
}
