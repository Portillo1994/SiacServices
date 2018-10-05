using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
   public class ReporteDeSeguimientoValoresIniciales
    {
       public int? BusinessUnit { get; set; }
       public int? Sistema { get; set; }
       public int? Estatus { get; set; }
       public DateTime? FechaInicial { get; set; }
       public DateTime? FechaFinal { get; set; }
    }
}
