using System;
using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class MonitoreoPCWDA
    {
        SIACModeloDataContext _dbContext = new SIACModeloDataContext();

        public List<BusinessEntities.InformacionDashboardMonitoreo> ObtieneDashboardMonitoreoPCW(int businessUnit, int idArchivo, int idPeriodo, int estatus)
        {
            List<BusinessEntities.InformacionDashboardMonitoreo> lstInformacionDashboardMonitoreo = new List<BusinessEntities.InformacionDashboardMonitoreo>();
            BusinessEntities.InformacionDashboardMonitoreo objInformacionDashboardMonitoreo = null;
            var vResultado = _dbContext.spSelDashboardMonitoreoPCW(businessUnit, idArchivo, idPeriodo, estatus);

            foreach (var item in vResultado)
            {
                objInformacionDashboardMonitoreo = new BusinessEntities.InformacionDashboardMonitoreo();
                objInformacionDashboardMonitoreo.DiasMes = new BusinessEntities.DiasMes();

                objInformacionDashboardMonitoreo.ProcesoId = Convert.ToInt32(item.RelacionProcesoPCWId);
                objInformacionDashboardMonitoreo.Aplicacion = item.ArchivoPCW;
                objInformacionDashboardMonitoreo.BusinessUnit = Convert.ToInt32(item.BusinessUnit);
                objInformacionDashboardMonitoreo.ArchivoPCWId = Convert.ToInt32(item.ArchivoPCWId);
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

        public List<BusinessEntities.ReporteMonitoreoPCW> ObtieneReporteMonitoreoPCW(int idArchivo, int dia)
        {
            List<BusinessEntities.ReporteMonitoreoPCW> lstReporteMonitoreoPCW = new List<BusinessEntities.ReporteMonitoreoPCW>();
            BusinessEntities.ReporteMonitoreoPCW objReporteMonitoreoPCW = null;
            var vResultado = _dbContext.spSelReporteMonitoreoPCW(idArchivo, dia);

            foreach (var item in vResultado)
            {
                objReporteMonitoreoPCW = new BusinessEntities.ReporteMonitoreoPCW();

                objReporteMonitoreoPCW.Compania = item.Compania;
                objReporteMonitoreoPCW.Archivo = item.Archivo;
                objReporteMonitoreoPCW.ProcesoId = item.ProcesoId;
                objReporteMonitoreoPCW.VoucherABA = item.VoucherABA;
                objReporteMonitoreoPCW.FechaContable = item.FechaContable;
                objReporteMonitoreoPCW.Sistema = item.Sistema;
                objReporteMonitoreoPCW.Plaza = item.Plaza;
                objReporteMonitoreoPCW.Estado = item.Estado;
                lstReporteMonitoreoPCW.Add(objReporteMonitoreoPCW);
            }

            return lstReporteMonitoreoPCW;
        }

        public List<BusinessEntities.ReporteCalendarioPCW> ObtieneReporteCalendarioPCW(int idArchivo, int dia)
        {
            List<BusinessEntities.ReporteCalendarioPCW> lstReporteCalendarioPCW = new List<BusinessEntities.ReporteCalendarioPCW>();
            BusinessEntities.ReporteCalendarioPCW objReporteCalendarioPCW = null;
            var vResultado = _dbContext.spSelReporteCalendarioPCW(idArchivo, dia);

            foreach (var item in vResultado)
            {
                objReporteCalendarioPCW = new BusinessEntities.ReporteCalendarioPCW();

                objReporteCalendarioPCW.Compania = item.Compania;
                objReporteCalendarioPCW.Archivo = item.Archivo;
                objReporteCalendarioPCW.FechaInicio = Convert.ToDateTime(item.FechaInicio);
                objReporteCalendarioPCW.FechaFin = Convert.ToDateTime(item.FechaFin);
                objReporteCalendarioPCW.Semana = item.Semana;
                objReporteCalendarioPCW.PeriodoId = item.PeriodoId;
                lstReporteCalendarioPCW.Add(objReporteCalendarioPCW);
            }

            return lstReporteCalendarioPCW;
        }
    }
}
