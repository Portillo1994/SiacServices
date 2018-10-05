
namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class InformacionDashboardValidacion
    {
        public System.Nullable<int> idSistema { get; set; }
        public System.Nullable<int> idPlaza { get; set; }
        public string SistemaPlaza { get; set; }
        public string Cuenta { get; set; }
        public string Moneda { get; set; }
        public BusinessEntities.DiasMes DiasMes { get; set; }
    }
}
