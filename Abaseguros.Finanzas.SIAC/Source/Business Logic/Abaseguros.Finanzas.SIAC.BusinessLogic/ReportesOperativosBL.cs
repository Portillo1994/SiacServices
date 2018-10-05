using System;
using System.Collections.Generic;
namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class ReportesOperativosBL
    {
        DataAccess.ReportesOperativosDA objReportesOperativosDA = new DataAccess.ReportesOperativosDA();

        public List<BusinessEntities.HistorialRO> obtieneHistorialRO(DateTime? FechaValidacion)
        {
            return objReportesOperativosDA.obtieneHistorialRO(FechaValidacion);
        }

        public int InsertaParametroReporte(BusinessEntities.InsertaParametroReporte objInsertaParametroReporte)
        {
            return objReportesOperativosDA.InsertaParametroReporte(objInsertaParametroReporte);
        }
    }
}
