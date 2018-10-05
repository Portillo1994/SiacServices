using System.Collections.Generic;
using System;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class MonitoreoPSDA
    {
        SIACModeloDataContext _dbContext = new SIACModeloDataContext();

        public List<BusinessEntities.InformacionDashboardMonitoreo> ObtieneDashboardMonitoreoPS(int businessUnit, int idSistema, int idPeriodo, int estatus)
        {
            List<BusinessEntities.InformacionDashboardMonitoreo> lstInformacionDashboardMonitoreo = new List<BusinessEntities.InformacionDashboardMonitoreo>();
            BusinessEntities.InformacionDashboardMonitoreo objInformacionDashboardMonitoreo = null;
            
            var vResultado = _dbContext.spSelDashboardMonitoreoPS(businessUnit, idSistema, idPeriodo, estatus);

            foreach (var item in vResultado)
            {
                objInformacionDashboardMonitoreo = new BusinessEntities.InformacionDashboardMonitoreo();
                objInformacionDashboardMonitoreo.DiasMes = new BusinessEntities.DiasMes();

                objInformacionDashboardMonitoreo.ProcesoId = item.ProcesoId.GetValueOrDefault(0);
                objInformacionDashboardMonitoreo.Aplicacion = item.Aplicacion;
                objInformacionDashboardMonitoreo.BusinessUnit = Convert.ToInt32(item.BusinessUnit);
                objInformacionDashboardMonitoreo.DiasMes.D1 = item.D1;
                objInformacionDashboardMonitoreo.DiasMes.D2 = item.D2;
                objInformacionDashboardMonitoreo.DiasMes.D3 = item.D3;
                objInformacionDashboardMonitoreo.DiasMes.D4 = item.D4;
                objInformacionDashboardMonitoreo.DiasMes.D5 = item.D5;
                objInformacionDashboardMonitoreo.DiasMes.D6 = item.D6;
                objInformacionDashboardMonitoreo.DiasMes.D7 = item.D7;
                objInformacionDashboardMonitoreo.DiasMes.D8 = item.D8;
                objInformacionDashboardMonitoreo.DiasMes.D9 = item.D9;
                objInformacionDashboardMonitoreo.DiasMes.D10 = item.D10;
                objInformacionDashboardMonitoreo.DiasMes.D11 = item.D11;
                objInformacionDashboardMonitoreo.DiasMes.D12 = item.D12;
                objInformacionDashboardMonitoreo.DiasMes.D13 = item.D13;
                objInformacionDashboardMonitoreo.DiasMes.D14 = item.D14;
                objInformacionDashboardMonitoreo.DiasMes.D15 = item.D15;
                objInformacionDashboardMonitoreo.DiasMes.D16 = item.D16;
                objInformacionDashboardMonitoreo.DiasMes.D17 = item.D17;
                objInformacionDashboardMonitoreo.DiasMes.D18 = item.D18;
                objInformacionDashboardMonitoreo.DiasMes.D19 = item.D19;
                objInformacionDashboardMonitoreo.DiasMes.D20 = item.D20;
                objInformacionDashboardMonitoreo.DiasMes.D21 = item.D21;
                objInformacionDashboardMonitoreo.DiasMes.D22 = item.D22;
                objInformacionDashboardMonitoreo.DiasMes.D23 = item.D23;
                objInformacionDashboardMonitoreo.DiasMes.D24 = item.D24;
                objInformacionDashboardMonitoreo.DiasMes.D25 = item.D25;
                objInformacionDashboardMonitoreo.DiasMes.D26 = item.D26;
                objInformacionDashboardMonitoreo.DiasMes.D27 = item.D27;
                objInformacionDashboardMonitoreo.DiasMes.D28 = item.D28;
                objInformacionDashboardMonitoreo.DiasMes.D29 = item.D29;
                objInformacionDashboardMonitoreo.DiasMes.D30 = item.D30;
                objInformacionDashboardMonitoreo.DiasMes.D31 = item.D31;


                lstInformacionDashboardMonitoreo.Add(objInformacionDashboardMonitoreo);
            }

            return lstInformacionDashboardMonitoreo;
        }

        public List<BusinessEntities.ReporteMonitoreoPS> ObtieneReporteMonitoreoPS(int procesoId, int dia)
        {
            List<BusinessEntities.ReporteMonitoreoPS> lstReporteMonitoreoPS = new List<BusinessEntities.ReporteMonitoreoPS>();
            BusinessEntities.ReporteMonitoreoPS objReporteMonitoreoPS = null;
            var vResultado = _dbContext.spSelReporteMonitoreoPS(procesoId, dia);

            foreach (var item in vResultado)
            {
                objReporteMonitoreoPS = new BusinessEntities.ReporteMonitoreoPS();

                objReporteMonitoreoPS.BusinessUnit = item.BusinessUnit;
                objReporteMonitoreoPS.Sistema = item.Sistema;
                objReporteMonitoreoPS.ProcesoId = Convert.ToInt32(item.ProcesoId);
                objReporteMonitoreoPS.JournalId = item.JournalId;
                objReporteMonitoreoPS.Ledger = item.Ledger;
                objReporteMonitoreoPS.FechaContable = Convert.ToDateTime(item.FechaContable);
                objReporteMonitoreoPS.Plaza = item.Plaza;
                objReporteMonitoreoPS.Estado = item.Estado;
                objReporteMonitoreoPS.Archivo = item.Archivo;
                lstReporteMonitoreoPS.Add(objReporteMonitoreoPS);
            }

            return lstReporteMonitoreoPS;
        }

        public BusinessEntities.ReporteDeSeguimientoValoresIniciales ObtenerReporteDeSeguimientoValoresIniciales(string sLoginUsuario)
        {
            BusinessEntities.ReporteDeSeguimientoValoresIniciales objResult = new BusinessEntities.ReporteDeSeguimientoValoresIniciales();
            var vResultado = _dbContext.spObtenerValoresInicialesRptControlEnvio(sLoginUsuario);

            //Siempre regresa un registro
            foreach (var item in vResultado)
            {
                objResult.BusinessUnit = item.BusinessUnit;
                objResult.Sistema = item.Sistema;
                objResult.Estatus = item.Estatus;
                objResult.FechaInicial = item.FechaInicial;
                objResult.FechaFinal = item.FechaFinal;
            }

            return objResult;
        }
    }
}
