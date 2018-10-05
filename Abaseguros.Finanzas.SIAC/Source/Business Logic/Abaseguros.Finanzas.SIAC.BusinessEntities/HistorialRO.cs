using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class HistorialRO
    {
        public int idRutasArchivos { get; set; }
        public string TipoArchivo { get; set; }
        public string Nombre { get; set; }
        public string Plaza { get; set; }
        public string Sistema { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? Estatus { get; set; }
    }
}
