namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class InsertaParametroReporte
    {
        public string IdRutaArchivos { get; set; }
        public System.Nullable<int> BusinessUnit { get; set; }
        public System.Nullable<int> IdSistema { get; set; }
        public System.Nullable<int> IdPlaza { get; set; }
        public System.DateTime FechaValidacion { get; set; }
        public string Login { get; set; }
    }
}
