using System;
using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class PreValidacionDA
    {
        SIACModeloDataContext _dbContext = new SIACModeloDataContext();

        public List<BusinessEntities.InformacionDashboardValidacion> ObtieneDashboardPreValidacion(int businessUnit, int idSistema, int idPlaza, int idPeriodo)
        {
            List<BusinessEntities.InformacionDashboardValidacion> lstDashboardPreValidacion = new List<BusinessEntities.InformacionDashboardValidacion>();
            BusinessEntities.InformacionDashboardValidacion objDashboardPreValidacion = null;
            var historialDashboard = _dbContext.spSelDashboardPreValidacion(businessUnit, idSistema, idPlaza, idPeriodo);
            foreach (var item in historialDashboard)
            {
                objDashboardPreValidacion = new BusinessEntities.InformacionDashboardValidacion();
                objDashboardPreValidacion.DiasMes = new BusinessEntities.DiasMes();

                objDashboardPreValidacion.idSistema = item.idSistema;
                objDashboardPreValidacion.idPlaza = item.idPlaza;
                objDashboardPreValidacion.SistemaPlaza = item.SistemaPlaza;
                objDashboardPreValidacion.Cuenta = item.Cuenta;
                objDashboardPreValidacion.Moneda = item.Moneda;
                objDashboardPreValidacion.DiasMes.D1 = item.D1.ToString();
                objDashboardPreValidacion.DiasMes.D2 = item.D2.ToString();
                objDashboardPreValidacion.DiasMes.D3 = item.D3.ToString();
                objDashboardPreValidacion.DiasMes.D4 = item.D4.ToString();
                objDashboardPreValidacion.DiasMes.D5 = item.D5.ToString();
                objDashboardPreValidacion.DiasMes.D6 = item.D6.ToString();
                objDashboardPreValidacion.DiasMes.D7 = item.D7.ToString();
                objDashboardPreValidacion.DiasMes.D8 = item.D8.ToString();
                objDashboardPreValidacion.DiasMes.D9 = item.D9.ToString();
                objDashboardPreValidacion.DiasMes.D10 = item.D10.ToString();
                objDashboardPreValidacion.DiasMes.D11 = item.D11.ToString();
                objDashboardPreValidacion.DiasMes.D12 = item.D12.ToString();
                objDashboardPreValidacion.DiasMes.D13 = item.D13.ToString();
                objDashboardPreValidacion.DiasMes.D14 = item.D14.ToString();
                objDashboardPreValidacion.DiasMes.D15 = item.D15.ToString();
                objDashboardPreValidacion.DiasMes.D16 = item.D16.ToString();
                objDashboardPreValidacion.DiasMes.D17 = item.D17.ToString();
                objDashboardPreValidacion.DiasMes.D18 = item.D18.ToString();
                objDashboardPreValidacion.DiasMes.D19 = item.D19.ToString();
                objDashboardPreValidacion.DiasMes.D20 = item.D20.ToString();
                objDashboardPreValidacion.DiasMes.D21 = item.D21.ToString();
                objDashboardPreValidacion.DiasMes.D22 = item.D22.ToString();
                objDashboardPreValidacion.DiasMes.D23 = item.D23.ToString();
                objDashboardPreValidacion.DiasMes.D24 = item.D24.ToString();
                objDashboardPreValidacion.DiasMes.D25 = item.D25.ToString();
                objDashboardPreValidacion.DiasMes.D26 = item.D26.ToString();
                objDashboardPreValidacion.DiasMes.D27 = item.D27.ToString();
                objDashboardPreValidacion.DiasMes.D28 = item.D28.ToString();
                objDashboardPreValidacion.DiasMes.D29 = item.D29.ToString();
                objDashboardPreValidacion.DiasMes.D30 = item.D30.ToString();
                objDashboardPreValidacion.DiasMes.D31 = item.D31.ToString();
                lstDashboardPreValidacion.Add(objDashboardPreValidacion);
            }
            return lstDashboardPreValidacion;
        }

        public string ProcesaPreValidacion(int businessUnit, int idSistema, int idPlaza, DateTime fechaValidacion, string login, int cargaRO)
        {
            string sError = "";
            _dbContext.spPrcPrevalidacion(businessUnit, idSistema, idPlaza, fechaValidacion, login, cargaRO, ref sError);

            return sError;
        }

        public List<BusinessEntities.ResultadosPrePosValidacion> ObtieneResultadosPreValidacion(int businessUnit, int idSistema, int idPlaza, DateTime FechaValidacion)
        {
            List<BusinessEntities.ResultadosPrePosValidacion> lstResultadosPrevalidacion = new List<BusinessEntities.ResultadosPrePosValidacion>();
            BusinessEntities.ResultadosPrePosValidacion objResultadosPrevalidacion = null;
            var historialDashboard = _dbContext.spSelResultadosPrevalidacion(businessUnit, idSistema, idPlaza, FechaValidacion);
            foreach (var item in historialDashboard)
            {
                objResultadosPrevalidacion = new BusinessEntities.ResultadosPrePosValidacion();
                objResultadosPrevalidacion.ValidacionId = item.ValidacionId;
                objResultadosPrevalidacion.FechaContable = item.FechaContable;
                objResultadosPrevalidacion.Moneda = item.Moneda;
                objResultadosPrevalidacion.MontoContabilidad = Convert.ToDouble(item.MontoContabilidad);
                objResultadosPrevalidacion.MontoSistema = Convert.ToDouble(item.MontoSistema);
                objResultadosPrevalidacion.CuentaAlterna = item.CuentaAlterna;
                objResultadosPrevalidacion.Tolerancia = item.Tolerancia;
                objResultadosPrevalidacion.Estado = item.Estado;
                objResultadosPrevalidacion.Diferencia = Convert.ToDouble(item.Diferencia);
                objResultadosPrevalidacion.Comentarios = item.Comentarios;
                objResultadosPrevalidacion.HabilitaAplicaRevision = item.HabilitaAplicaRevision.GetValueOrDefault(0);
                lstResultadosPrevalidacion.Add(objResultadosPrevalidacion);
            }
            return lstResultadosPrevalidacion;
        }

        public List<BusinessEntities.ResultadosPrePosValidacion> ObtieneHistorialPreValidacion(int businessUnit, int idSistema, int idPlaza, DateTime FechaValidacion)
        {
            List<BusinessEntities.ResultadosPrePosValidacion> lstResultadosPrevalidacion = new List<BusinessEntities.ResultadosPrePosValidacion>();
            BusinessEntities.ResultadosPrePosValidacion objResultadosPreValidacion = null;
            var historialDashboard = _dbContext.spSelHistorialPreValidacion(businessUnit, idSistema, idPlaza, FechaValidacion);
            foreach (var item in historialDashboard)
            {
                objResultadosPreValidacion = new BusinessEntities.ResultadosPrePosValidacion();

                objResultadosPreValidacion.ValidacionId = item.ValidacionId;
                objResultadosPreValidacion.RegistroId = item.RegistroId;
                objResultadosPreValidacion.FechaContable = item.FechaContable;
                objResultadosPreValidacion.Moneda = item.Moneda;
                objResultadosPreValidacion.MontoContabilidad = Convert.ToDouble(item.MontoContabilidad);
                objResultadosPreValidacion.MontoSistema = Convert.ToDouble(item.MontoSistema);
                objResultadosPreValidacion.CuentaAlterna = item.CuentaAlterna;
                objResultadosPreValidacion.Tolerancia = item.Tolerancia;
                objResultadosPreValidacion.Estado = item.Estado;
                objResultadosPreValidacion.Diferencia = Convert.ToDouble(item.Diferencia);
                objResultadosPreValidacion.Comentarios = item.Comentarios;
                lstResultadosPrevalidacion.Add(objResultadosPreValidacion);
            }
            return lstResultadosPrevalidacion;
        }

        public int ActualizaResultadosPrevalidacion(int ValidacionId, DateTime FechaContable, string CuentaAlterna, string Moneda, string Estado, string Comentarios)
        {
            int? Error = 0;
            _dbContext.spUpdResultadosPrevalidacion(ValidacionId, FechaContable, CuentaAlterna, Moneda, Estado, Comentarios, ref Error);

            return Error.GetValueOrDefault(0);
            
        }

        public BusinessEntities.RangoFechas ObtieneFechasAcumuladoSiniestros()
        {
            BusinessEntities.RangoFechas rango = new BusinessEntities.RangoFechas();
            var fechas = _dbContext.spSelFechasAcumuladoSiniestros();
            foreach (var fec in fechas)
            {
                rango.FechaInicial = fec.FechaDesde;
                rango.FechaFinal = fec.FechaHasta;
            }

            return rango;

        }
    }
}
