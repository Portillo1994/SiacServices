using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class ResultadosPrePosValidacion
    {
        public int ValidacionId { get; set; }
        public int RegistroId { get; set; }
        public DateTime FechaContable { get; set; }
        public string Moneda { get; set; }
        public double MontoContabilidad { get; set; }
        public double MontoSistema { get; set; }
        public string CuentaAlterna { get; set; }
        public double Tolerancia { get; set; }
        public string Estado { get; set; }
        public double Diferencia { get; set; }
        public string Comentarios { get; set; }
        public int HabilitaAplicaRevision { get; set; }
    }
}
