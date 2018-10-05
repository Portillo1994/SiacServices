using System.Collections.Generic;
using System;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class PosValidacionDA
    {
        SIACModeloDataContext _dbContext = new SIACModeloDataContext();

        public List<BusinessEntities.InformacionDashboardValidacion> ObtieneDashboardPosValidacion(int businessUnit, int idSistema, int idPlaza, int idPeriodo, int tipoValidacionId)
        {
            List<BusinessEntities.InformacionDashboardValidacion> lstInformacionDashboardValidacion = new List<BusinessEntities.InformacionDashboardValidacion>();
            BusinessEntities.InformacionDashboardValidacion objInformacionDashboardValidacion = null;
            var vResultado = _dbContext.spSelDashboardPosValidacion(businessUnit, idSistema, idPlaza, idPeriodo, tipoValidacionId);

            foreach (var item in vResultado)
            {
                objInformacionDashboardValidacion = new BusinessEntities.InformacionDashboardValidacion();
                objInformacionDashboardValidacion.DiasMes = new BusinessEntities.DiasMes();

                objInformacionDashboardValidacion.idSistema = item.idSistema;
                objInformacionDashboardValidacion.idPlaza = item.idPlaza;
                objInformacionDashboardValidacion.SistemaPlaza = item.SistemaPlaza;
                objInformacionDashboardValidacion.Cuenta = item.Cuenta;
                objInformacionDashboardValidacion.Moneda = item.Moneda;
                objInformacionDashboardValidacion.DiasMes.D1 = item.D1.ToString();
                objInformacionDashboardValidacion.DiasMes.D2 = item.D2.ToString();
                objInformacionDashboardValidacion.DiasMes.D3 = item.D3.ToString();
                objInformacionDashboardValidacion.DiasMes.D4 = item.D4.ToString();
                objInformacionDashboardValidacion.DiasMes.D5 = item.D5.ToString();
                objInformacionDashboardValidacion.DiasMes.D6 = item.D6.ToString();
                objInformacionDashboardValidacion.DiasMes.D7 = item.D7.ToString();
                objInformacionDashboardValidacion.DiasMes.D8 = item.D8.ToString();
                objInformacionDashboardValidacion.DiasMes.D9 = item.D9.ToString();
                objInformacionDashboardValidacion.DiasMes.D10 = item.D10.ToString();
                objInformacionDashboardValidacion.DiasMes.D11 = item.D11.ToString();
                objInformacionDashboardValidacion.DiasMes.D12 = item.D12.ToString();
                objInformacionDashboardValidacion.DiasMes.D13 = item.D13.ToString();
                objInformacionDashboardValidacion.DiasMes.D14 = item.D14.ToString();
                objInformacionDashboardValidacion.DiasMes.D15 = item.D15.ToString();
                objInformacionDashboardValidacion.DiasMes.D16 = item.D16.ToString();
                objInformacionDashboardValidacion.DiasMes.D17 = item.D17.ToString();
                objInformacionDashboardValidacion.DiasMes.D18 = item.D18.ToString();
                objInformacionDashboardValidacion.DiasMes.D19 = item.D19.ToString();
                objInformacionDashboardValidacion.DiasMes.D20 = item.D20.ToString();
                objInformacionDashboardValidacion.DiasMes.D21 = item.D21.ToString();
                objInformacionDashboardValidacion.DiasMes.D22 = item.D22.ToString();
                objInformacionDashboardValidacion.DiasMes.D23 = item.D23.ToString();
                objInformacionDashboardValidacion.DiasMes.D24 = item.D24.ToString();
                objInformacionDashboardValidacion.DiasMes.D25 = item.D25.ToString();
                objInformacionDashboardValidacion.DiasMes.D26 = item.D26.ToString();
                objInformacionDashboardValidacion.DiasMes.D27 = item.D27.ToString();
                objInformacionDashboardValidacion.DiasMes.D28 = item.D28.ToString();
                objInformacionDashboardValidacion.DiasMes.D29 = item.D29.ToString();
                objInformacionDashboardValidacion.DiasMes.D30 = item.D30.ToString();
                objInformacionDashboardValidacion.DiasMes.D31 = item.D31.ToString();
                lstInformacionDashboardValidacion.Add(objInformacionDashboardValidacion);
            }

            return lstInformacionDashboardValidacion;
        }

        public string InsertaReportePosValidacion(string Archivo, int BusinessUnit, DateTime FechaValidacion, int TipoArchivo, int TipoValidacion, string Usuario)
        {
            string sError = "";
            _dbContext.spInsertaReportePosValidacion(Archivo, BusinessUnit, FechaValidacion, TipoArchivo, TipoValidacion, Usuario, ref sError);
            return sError;
        }

        public string ProcesaPosValidacion(int businessUnit, int idSistema, int idPlaza, DateTime fechaValidacion, string login, int cargaRO)
        {
            string sError = "";
            _dbContext.spPrcPosvalidacion(businessUnit, idSistema, idPlaza, fechaValidacion, login, cargaRO, ref sError);

            return sError;
        }

        public List<BusinessEntities.ResultadosPosValidacion> ObtieneResultadosPosValidacion(int businessUnit, int idSistema, int idPlaza, 
            DateTime FechaValidacion, int TipoValidacion, int ArchivoPosvalidacion)
        {
            List<BusinessEntities.ResultadosPosValidacion> lstResultadosPosvalidacion = new List<BusinessEntities.ResultadosPosValidacion>();
            BusinessEntities.ResultadosPosValidacion objResultadosPosvalidacion = null;
            var historialDashboard = _dbContext.spSelResultadosPosvalidacion(businessUnit, idSistema, idPlaza, FechaValidacion, TipoValidacion, ArchivoPosvalidacion);
            foreach (var item in historialDashboard)
            {
                objResultadosPosvalidacion = new BusinessEntities.ResultadosPosValidacion();
                objResultadosPosvalidacion.ValidacionId = item.ValidacionId;
                objResultadosPosvalidacion.EstadoValidacion = item.EstadoValidacion.GetValueOrDefault(0);
                objResultadosPosvalidacion.CuentaAlterna = item.CuentaAlterna;
                objResultadosPosvalidacion.Moneda = item.CveMoneda;
                objResultadosPosvalidacion.MontoStagging = Convert.ToDouble(item.MontoStagging);
                objResultadosPosvalidacion.MontoCrawley = Convert.ToDouble(item.MontoCrawley);
                objResultadosPosvalidacion.MontoPS = Convert.ToDouble(item.MontoPS);
                objResultadosPosvalidacion.MontoSistema = Convert.ToDouble(item.MontoSistema);
                objResultadosPosvalidacion.DiferenciaSisSta = Convert.ToDouble(item.DiferenciaSisSta);
                objResultadosPosvalidacion.DiferenciaStaCra = Convert.ToDouble(item.DiferenciaStaCra);
                objResultadosPosvalidacion.DiferenciaCraPs = Convert.ToDouble(item.DiferenciaCraPs);
                objResultadosPosvalidacion.DiferenciaSisPs = Convert.ToDouble(item.DiferenciaSisPs);
                objResultadosPosvalidacion.Tolerancia = Convert.ToDouble(item.Tolerancia);
                objResultadosPosvalidacion.Estado = item.Estado;
                objResultadosPosvalidacion.Comentarios = item.Comentarios;
                lstResultadosPosvalidacion.Add(objResultadosPosvalidacion);
            }
            return lstResultadosPosvalidacion;
        }

        public List<BusinessEntities.ResultadosPrePosValidacion> ObtieneHistorialPosValidacion(int businessUnit, int idSistema, int idPlaza, DateTime FechaValidacion, int TipoValidacion)
        {
            List<BusinessEntities.ResultadosPrePosValidacion> lstResultadosPrevalidacion = new List<BusinessEntities.ResultadosPrePosValidacion>();
            BusinessEntities.ResultadosPrePosValidacion objResultadosPreValidacion = null;
            var historialDashboard = _dbContext.spSelHistorialPosValidacion(businessUnit, idSistema, idPlaza, FechaValidacion, TipoValidacion);
            foreach (var item in historialDashboard)
            {
                objResultadosPreValidacion = new BusinessEntities.ResultadosPrePosValidacion();

                objResultadosPreValidacion.ValidacionId = item.ValidacionId;
                objResultadosPreValidacion.RegistroId = item.RegistroId;
                objResultadosPreValidacion.Moneda = item.Moneda;
                objResultadosPreValidacion.MontoContabilidad = Convert.ToDouble(item.MontoContabilidad);
                objResultadosPreValidacion.MontoSistema = Convert.ToDouble(item.MontoSistema);
                objResultadosPreValidacion.CuentaAlterna = item.Cuenta;
                objResultadosPreValidacion.Tolerancia = item.Tolerancia;
                objResultadosPreValidacion.Estado = item.Estado;
                objResultadosPreValidacion.Diferencia = Convert.ToDouble(item.Diferencia);
                objResultadosPreValidacion.Comentarios = item.Comentarios;
                lstResultadosPrevalidacion.Add(objResultadosPreValidacion);
            }
            return lstResultadosPrevalidacion;
        }

        public int ActualizaResultadosPosvalidacion(int ValidacionId, string CuentaAlterna, string Moneda, string Estado, string Comentarios, int NivelPosvalidacion)
        {
            int? Error = 0;
            _dbContext.spUpdResultadosPosvalidacion(ValidacionId, CuentaAlterna, Moneda, Estado, Comentarios, NivelPosvalidacion, ref Error);

            return Error.GetValueOrDefault(0);
        }

        public List<BusinessEntities.MensajesReportePosValidacion> ObtieneMensajesReportePosValidacion(int BusinessUnit, DateTime FechaValidacion, int TipoArchivo, int TipoValidacion)
        {
            List<BusinessEntities.MensajesReportePosValidacion> lstMensajesReportePosValidacion = new List<BusinessEntities.MensajesReportePosValidacion>();
            BusinessEntities.MensajesReportePosValidacion objMensajesReportePosValidacion = null;

            var vResultado = _dbContext.spObtieneMensajesReportePosValidacion(BusinessUnit, FechaValidacion, TipoArchivo, TipoValidacion);
            foreach (var item in vResultado)
            {
                objMensajesReportePosValidacion = new BusinessEntities.MensajesReportePosValidacion();
                objMensajesReportePosValidacion.ReportePosValidacionMensajesId = item.ReportePosValidacionMensajesId;
                objMensajesReportePosValidacion.ReportePosValidacionId = item.ReportePosValidacionId;
                objMensajesReportePosValidacion.FechaModificacion = item.FechaModificacion;
                objMensajesReportePosValidacion.Estatus = item.Estatus;
                objMensajesReportePosValidacion.Mensaje = item.Mensaje;
                objMensajesReportePosValidacion.OrigenEstatus = item.OrigenEstatus;
                lstMensajesReportePosValidacion.Add(objMensajesReportePosValidacion);
            }

            return lstMensajesReportePosValidacion;
        }
    }
}
