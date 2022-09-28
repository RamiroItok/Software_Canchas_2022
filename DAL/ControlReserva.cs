using DAL.Conexion;
using DAL.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ControlReserva : Acceso
    {
        private readonly Fill _fill;
        public ControlReserva()
        {
            _fill = new Fill();
        }

        private const string ALTA_CONTROL_RESERVA = "INSERT INTO ControlReserva (Id_Cancha, Id_Cliente, Fecha, Hora, Forma_Pago, Seña, Total, Deuda, Fecha_Modificacion, Id_Usuario, Descripcion, DVH) OUTPUT inserted.Id VALUES (@parId_Cancha, @parId_Cliente, @parFecha, @parHora, @parForma_Pago, @parSeña, @parTotal, @parDeuda, @parFecha_Modificacion, @parId_Usuario, @parDescripcion, @parDVH)";
        private const string OBTENER_CONTROL_RESERVA = "SELECT * FROM ControlReserva ORDER BY Fecha_Modificacion desc";

        public int AltaControlReserva(BE.ControlReserva controlReserva)
        {
            try
            {
                ExecuteCommandText = ALTA_CONTROL_RESERVA;

                ExecuteParameters.Parameters.Clear();

                ExecuteParameters.Parameters.AddWithValue("@parId_Cancha", controlReserva.Id_Cancha);
                ExecuteParameters.Parameters.AddWithValue("@parId_Cliente", controlReserva.Id_Cliente);
                ExecuteParameters.Parameters.AddWithValue("@parFecha", controlReserva.Fecha);
                ExecuteParameters.Parameters.AddWithValue("@parHora", controlReserva.Hora);
                ExecuteParameters.Parameters.AddWithValue("@parForma_Pago", controlReserva.Forma_Pago);
                ExecuteParameters.Parameters.AddWithValue("@parSeña", controlReserva.Seña);
                ExecuteParameters.Parameters.AddWithValue("@parTotal", controlReserva.Total);
                ExecuteParameters.Parameters.AddWithValue("@parDeuda", controlReserva.Deuda);
                ExecuteParameters.Parameters.AddWithValue("@parFecha_Modificacion", controlReserva.Fecha_Modificacion);
                ExecuteParameters.Parameters.AddWithValue("@parId_Usuario", controlReserva.Id_Usuario);
                ExecuteParameters.Parameters.AddWithValue("@parDescripcion", controlReserva.Descripcion);
                ExecuteParameters.Parameters.AddWithValue("@parDVH", 0);

                return ExecuteNonEscalar();
            }
            catch
            {
                throw new Exception("Error en la base de datos.");
            }
        }

        public List<BE.ControlReserva> ObtenerControlReserva()
        {
            try
            {
                SelectCommandText = String.Format(OBTENER_CONTROL_RESERVA);
                DataSet ds = ExecuteNonReader();

                List<BE.ControlReserva> controlReserva = new List<BE.ControlReserva>();

                if (ds.Tables[0].Rows.Count > 0)
                    controlReserva = _fill.FillListControlReserva(ds);

                return controlReserva;
            }
            catch (Exception)
            {
                throw new Exception("Error en la base de datos.");
            }
        }

    }
}
