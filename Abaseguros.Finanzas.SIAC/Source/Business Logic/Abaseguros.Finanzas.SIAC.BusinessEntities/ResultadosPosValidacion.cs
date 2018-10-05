using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class ResultadosPosValidacion
    {
        public int ValidacionId { get; set; }
        public int EstadoValidacion { get; set; }
        public string CuentaAlterna { get; set; }
        public string Moneda { get; set; }
        public double MontoStagging { get; set; }
        public double MontoCrawley { get; set; }
        public double MontoPS { get; set; }
        public double MontoSistema { get; set; }
        public double DiferenciaSisSta { get; set; }
        public double DiferenciaStaCra { get; set; }
        public double DiferenciaCraPs { get; set; }
        public double DiferenciaSisPs { get; set; }
        public double Tolerancia { get; set; }
        public string Estado { get; set; }
        public string Comentarios { get; set; }
    }
}
