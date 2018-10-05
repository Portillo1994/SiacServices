using System.Collections.Generic;
using System;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class PosValidacionBL
    {
        DataAccess.PosValidacionDA _objPosValidacionDA = new DataAccess.PosValidacionDA();
        public List<BusinessEntities.InformacionDashboardValidacion> ObtieneDashboardPosValidadcion(int businessUnit, int idSistema, int idPlaza, int idPeriodo, int tipoValidacionId)
        {
            return _objPosValidacionDA.ObtieneDashboardPosValidacion(businessUnit, idSistema, idPlaza, idPeriodo, tipoValidacionId);
        }

        public string InsertaReportePosValidacion(string Archivo, int BusinessUnit, DateTime FechaValidacion, int TipoArchivo, int TipoValidacion, string Usuario)
        {
            return _objPosValidacionDA.InsertaReportePosValidacion(Archivo, BusinessUnit, FechaValidacion, TipoArchivo, TipoValidacion, Usuario);
        }

        public string ProcesaPosValidacion(int businessUnit, int idSistema, int idPlaza, DateTime fechaValidacion, string login, int cargaRO)
        {
            return _objPosValidacionDA.ProcesaPosValidacion(businessUnit, idSistema, idPlaza, fechaValidacion, login, cargaRO);
        }

        public List<BusinessEntities.ResultadosPosValidacion> ObtieneResultadosPosValidacion(int businessUnit, int idSistema, int idPlaza, DateTime FechaValidacion, int TipoValidacion, int ArchivoPosvalidacion)
        {
            return _objPosValidacionDA.ObtieneResultadosPosValidacion(businessUnit, idSistema, idPlaza, FechaValidacion, TipoValidacion, ArchivoPosvalidacion);
        }

        public List<BusinessEntities.ResultadosPrePosValidacion> ObtieneHistorialPosValidacion(int businessUnit, int idSistema, int idPlaza, DateTime FechaValidacion, int TipoValidacion)
        {
            return _objPosValidacionDA.ObtieneHistorialPosValidacion(businessUnit, idSistema, idPlaza, FechaValidacion, TipoValidacion);
        }

        public int ActualizaResultadosPosvalidacion(int ValidacionId, string CuentaAlterna, string Moneda, string Estado, string Comentarios, int NivelPosvalidacion)
        {
            return _objPosValidacionDA.ActualizaResultadosPosvalidacion(ValidacionId, CuentaAlterna, Moneda, Estado, Comentarios, NivelPosvalidacion);
        }

        public List<BusinessEntities.MensajesReportePosValidacion> ObtieneMensajesReportePosValidacion(int BusinessUnit, DateTime FechaValidacion, int TipoArchivo, int TipoValidacion)
        {
            return _objPosValidacionDA.ObtieneMensajesReportePosValidacion(BusinessUnit, FechaValidacion, TipoArchivo, TipoValidacion);
        }
    }
}
