using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
   public class MonitoreoPCWBL
    {
       DataAccess.MonitoreoPCWDA _objMonitoreoPCWDA = new DataAccess.MonitoreoPCWDA();
       public List<BusinessEntities.InformacionDashboardMonitoreo> ObtieneDashboardMonitoreoPCW(int businessUnit, int idArchivo, int idPeriodo, int estatus)
       {
           return _objMonitoreoPCWDA.ObtieneDashboardMonitoreoPCW(businessUnit, idArchivo, idPeriodo, estatus);
       }

       public List<BusinessEntities.ReporteMonitoreoPCW> ObtieneReporteMonitoreoPCW(int idArchivo, int dia)
       {
           return _objMonitoreoPCWDA.ObtieneReporteMonitoreoPCW(idArchivo, dia);
       }

       public List<BusinessEntities.ReporteCalendarioPCW> ObtieneReporteCalendarioPCW(int idArchivo, int dia)
       {
           return _objMonitoreoPCWDA.ObtieneReporteCalendarioPCW(idArchivo, dia);
       }
    }
}
