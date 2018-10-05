using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class MensajesReportePosValidacion
    {
        public int ReportePosValidacionMensajesId { get; set; }
        public int ReportePosValidacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int Estatus { get; set; }
        public string Mensaje { get; set; }
        public string OrigenEstatus { get; set; }
    }
}
