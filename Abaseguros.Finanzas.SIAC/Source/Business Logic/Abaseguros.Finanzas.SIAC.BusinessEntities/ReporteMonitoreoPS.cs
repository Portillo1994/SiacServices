using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class ReporteMonitoreoPS
    {
        public string BusinessUnit { get; set; }
        public string Sistema { get; set; }
        public int ProcesoId { get; set; }
        public string JournalId { get; set; }
        public DateTime FechaContable { get; set; }
        public string Plaza { get; set; }
        public string Estado { get; set; }
        public string Archivo { get; set; }
        public string Ledger { get; set; }
    }
}
