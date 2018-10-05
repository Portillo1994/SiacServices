using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class ReporteCalendarioPCW
    {
        public string Compania { get; set; }
        public string Archivo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int Semana { get; set; }
        public int PeriodoId { get; set; }
    }
}
