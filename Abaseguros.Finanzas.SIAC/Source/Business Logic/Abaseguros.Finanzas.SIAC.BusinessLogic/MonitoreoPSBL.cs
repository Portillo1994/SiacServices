using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class MonitoreoPSBL
    {
        DataAccess.MonitoreoPSDA _objMonitoreoPSDA = new DataAccess.MonitoreoPSDA();
        public List<BusinessEntities.InformacionDashboardMonitoreo> ObtieneDashboardMonitoreoPS(int businessUnit, int idSistema, int idPeriodo, int estatus)
        {
            return _objMonitoreoPSDA.ObtieneDashboardMonitoreoPS(businessUnit, idSistema, idPeriodo, estatus);
        }

        public List<BusinessEntities.ReporteMonitoreoPS> ObtieneReporteMonitoreoPS(int procesoId, int dia)
        {
            return _objMonitoreoPSDA.ObtieneReporteMonitoreoPS(procesoId, dia);
        }

        public BusinessEntities.ReporteDeSeguimientoValoresIniciales ObtenerReporteDeSeguimientoValoresIniciales(string sLoginUsuario)
        {
            return _objMonitoreoPSDA.ObtenerReporteDeSeguimientoValoresIniciales(sLoginUsuario);
        }

    }
}
