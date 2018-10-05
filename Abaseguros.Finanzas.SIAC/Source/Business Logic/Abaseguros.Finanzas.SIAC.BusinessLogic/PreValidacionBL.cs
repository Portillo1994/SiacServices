using System;
using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class PreValidacionBL
    {
        DataAccess.PreValidacionDA _objPreValidacionDA = new DataAccess.PreValidacionDA();
        public List<BusinessEntities.InformacionDashboardValidacion> ObtieneDashboardPreValidacion(int businessUnit, int idSistema, int idPlaza, int idPeriodo)
        {
            return _objPreValidacionDA.ObtieneDashboardPreValidacion(businessUnit, idSistema, idPlaza, idPeriodo);
        }

        public string ProcesaPreValidacion(int businessUnit, int idSistema, int idPlaza, System.DateTime fechaValidacion, string login, int cargaRO)
        {
            return _objPreValidacionDA.ProcesaPreValidacion(businessUnit, idSistema, idPlaza, fechaValidacion, login, cargaRO);
        }

        public List<BusinessEntities.ResultadosPrePosValidacion> ObtieneResultadosPreValidacion(int businessUnit, int idSistema, int idPlaza, DateTime FechaValidacion)
        {
            return _objPreValidacionDA.ObtieneResultadosPreValidacion(businessUnit, idSistema, idPlaza, FechaValidacion);
        }

        public List<BusinessEntities.ResultadosPrePosValidacion> ObtieneHistorialPreValidacion(int businessUnit, int idSistema, int idPlaza, DateTime FechaValidacion)
        {
            return _objPreValidacionDA.ObtieneHistorialPreValidacion(businessUnit, idSistema, idPlaza, FechaValidacion);
        }

        public int ActualizaResultadosPrevalidacion(int ValidacionId, DateTime FechaContable, string CuentaAlterna, string Moneda, string Estado, string Comentarios)
        {
            return _objPreValidacionDA.ActualizaResultadosPrevalidacion(ValidacionId, FechaContable, CuentaAlterna, Moneda, Estado, Comentarios);
        }

        public BusinessEntities.RangoFechas ObtieneFechasAcumuladoSiniestros()
        {
            return _objPreValidacionDA.ObtieneFechasAcumuladoSiniestros();
        }
    }
}
