using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class Parametro
    {
        public int idParametro { get; set; }
        public string Descripcion { get; set; }
        public string vcValor { get; set; }
        public int iValor { get; set; }
        public double mValor { get; set; }
        public DateTime dValor { get; set; }
    }
}
