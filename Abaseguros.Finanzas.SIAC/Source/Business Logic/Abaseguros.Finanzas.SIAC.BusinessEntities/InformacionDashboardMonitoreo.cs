
namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class InformacionDashboardMonitoreo
    {
        public int ProcesoId { get; set; }
        public string Aplicacion { get; set; }
        public int BusinessUnit { get; set; }
        public int ArchivoPCWId { get; set; }
        public BusinessEntities.DiasMes DiasMes { get; set; }
    }
}
