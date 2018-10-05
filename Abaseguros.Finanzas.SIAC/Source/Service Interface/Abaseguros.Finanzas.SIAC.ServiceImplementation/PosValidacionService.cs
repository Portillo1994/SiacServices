//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using WCF = global::System.ServiceModel;

namespace Abaseguros.Finanzas.SIAC.ServiceImplementation
{
    /// <summary>
    /// Service Class - PosValidacionService
    /// </summary>
    [WCF::ServiceBehavior(Name = "PosValidacionService",
        Namespace = "http://abaseguros.com",
        InstanceContextMode = WCF::InstanceContextMode.PerSession,
        ConcurrencyMode = WCF::ConcurrencyMode.Single)]
    public abstract class PosValidacionServiceBase : Abaseguros.Finanzas.SIAC.ServiceContracts.IPosValidacionServiceContract
    {
        #region PosValidacionServiceContract Members

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneDashboardPosValidacionResponse ObtieneDashboardPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneDashboardPosValidacionRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.InsertaReportePorValidacionResponse InsertarReportePosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.InsertarReportePosValidacionRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionResponse ObtieneResultadoPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionResponse ObtieneHistorialPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ProcesaPosValidacionResponse ProcesaPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ProcesaPosValidacionRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ActualizaResultadosPosvalidacionResponse ActualizaResultadosPosvalidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ActualizaResultadosPosvalidacionRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneMensajesReportePosValidacionResponse ObtieneMensajesReportePosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneMensajesReportePosValidacionRequest request)
        {
            return null;
        }

        #endregion
    }

    public partial class PosValidacionService : PosValidacionServiceBase
    {
        BusinessLogic.PosValidacionBL _objPosValidacionBL = new BusinessLogic.PosValidacionBL();
        private DataContracts.ResultadosPosValidacionCollectionDC ObtienePosValidacion(List<BusinessEntities.ResultadosPosValidacion> lstResultadosPrePosValidacion)
        {
            DataContracts.ResultadosPosValidacionCollectionDC objResultadosPosValidacionCollectionDC = new DataContracts.ResultadosPosValidacionCollectionDC();
            DataContracts.ResultadosPosValidacionDC objResultadosPosValidacionDC = null;

            foreach (BusinessEntities.ResultadosPosValidacion objResultadoPrePosValidacion in lstResultadosPrePosValidacion)
            {
                objResultadosPosValidacionDC = new DataContracts.ResultadosPosValidacionDC();
                objResultadosPosValidacionDC.ValidacionId = objResultadoPrePosValidacion.ValidacionId;
                objResultadosPosValidacionDC.EstadoValidacion = objResultadoPrePosValidacion.EstadoValidacion;
                objResultadosPosValidacionDC.Moneda = objResultadoPrePosValidacion.Moneda;
                objResultadosPosValidacionDC.CuentaAlterna = objResultadoPrePosValidacion.CuentaAlterna;
                objResultadosPosValidacionDC.MontoStagging = objResultadoPrePosValidacion.MontoStagging;
                objResultadosPosValidacionDC.MontoCrawley = objResultadoPrePosValidacion.MontoCrawley;
                objResultadosPosValidacionDC.MontoPS = objResultadoPrePosValidacion.MontoPS;
                objResultadosPosValidacionDC.MontoSistema = objResultadoPrePosValidacion.MontoSistema;
                objResultadosPosValidacionDC.DiferenciaSisSta = objResultadoPrePosValidacion.DiferenciaSisSta;
                objResultadosPosValidacionDC.DiferenciaStaCra = objResultadoPrePosValidacion.DiferenciaStaCra;
                objResultadosPosValidacionDC.DiferenciaCraPs = objResultadoPrePosValidacion.DiferenciaCraPs;
                objResultadosPosValidacionDC.DiferenciaSisPs = objResultadoPrePosValidacion.DiferenciaSisPs;
                objResultadosPosValidacionDC.Tolerancia = objResultadoPrePosValidacion.Tolerancia;
                objResultadosPosValidacionDC.Estado = objResultadoPrePosValidacion.Estado;
                objResultadosPosValidacionDC.Comentarios = objResultadoPrePosValidacion.Comentarios;
                objResultadosPosValidacionCollectionDC.Add(objResultadosPosValidacionDC);
            }

            return objResultadosPosValidacionCollectionDC;
        }

        public override Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneDashboardPosValidacionResponse ObtieneDashboardPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneDashboardPosValidacionRequest request)
        {
            MessageContracts.ObtieneDashboardPosValidacionResponse objObtieneDashboardPosValidacionResponse = new MessageContracts.ObtieneDashboardPosValidacionResponse();
            DataContracts.InformacionDashboardValidacionCollectionDC lstInformacionDashboardValidacionCollectionDC = new DataContracts.InformacionDashboardValidacionCollectionDC();
            DataContracts.InformacionDashboardValidacionDC objInformacionDashboardValidacionDC = null;
            List<BusinessEntities.InformacionDashboardValidacion> lstInformacionDashboardValidacion;

            lstInformacionDashboardValidacion = _objPosValidacionBL.ObtieneDashboardPosValidadcion(request.Request_BU_Sistema_Plaza_Periodo.BusinessUnit,
                                                                                                  request.Request_BU_Sistema_Plaza_Periodo.idSistema,
                                                                                                  request.Request_BU_Sistema_Plaza_Periodo.idPlaza,
                                                                                                  request.Request_BU_Sistema_Plaza_Periodo.PeriodoId,
                                                                                                  request.TipoValidacionId);

            foreach (BusinessEntities.InformacionDashboardValidacion objInformacionDashboardValidacion in lstInformacionDashboardValidacion)
            {
                objInformacionDashboardValidacionDC = new DataContracts.InformacionDashboardValidacionDC();
                objInformacionDashboardValidacionDC.DiasMes = new DataContracts.DiasMesDC();

                objInformacionDashboardValidacionDC.idSistema = objInformacionDashboardValidacion.idSistema;
                objInformacionDashboardValidacionDC.idPlaza = objInformacionDashboardValidacion.idPlaza;
                objInformacionDashboardValidacionDC.SistemaPlaza = objInformacionDashboardValidacion.SistemaPlaza;
                objInformacionDashboardValidacionDC.Cuenta = objInformacionDashboardValidacion.Cuenta;
                objInformacionDashboardValidacionDC.Moneda = objInformacionDashboardValidacion.Moneda;
                objInformacionDashboardValidacionDC.DiasMes.D1 = objInformacionDashboardValidacion.DiasMes.D1;
                objInformacionDashboardValidacionDC.DiasMes.D2 = objInformacionDashboardValidacion.DiasMes.D2;
                objInformacionDashboardValidacionDC.DiasMes.D3 = objInformacionDashboardValidacion.DiasMes.D3;
                objInformacionDashboardValidacionDC.DiasMes.D4 = objInformacionDashboardValidacion.DiasMes.D4;
                objInformacionDashboardValidacionDC.DiasMes.D5 = objInformacionDashboardValidacion.DiasMes.D5;
                objInformacionDashboardValidacionDC.DiasMes.D6 = objInformacionDashboardValidacion.DiasMes.D6;
                objInformacionDashboardValidacionDC.DiasMes.D7 = objInformacionDashboardValidacion.DiasMes.D7;
                objInformacionDashboardValidacionDC.DiasMes.D8 = objInformacionDashboardValidacion.DiasMes.D8;
                objInformacionDashboardValidacionDC.DiasMes.D9 = objInformacionDashboardValidacion.DiasMes.D9;
                objInformacionDashboardValidacionDC.DiasMes.D10 = objInformacionDashboardValidacion.DiasMes.D10;
                objInformacionDashboardValidacionDC.DiasMes.D11 = objInformacionDashboardValidacion.DiasMes.D11;
                objInformacionDashboardValidacionDC.DiasMes.D12 = objInformacionDashboardValidacion.DiasMes.D12;
                objInformacionDashboardValidacionDC.DiasMes.D13 = objInformacionDashboardValidacion.DiasMes.D13;
                objInformacionDashboardValidacionDC.DiasMes.D14 = objInformacionDashboardValidacion.DiasMes.D14;
                objInformacionDashboardValidacionDC.DiasMes.D15 = objInformacionDashboardValidacion.DiasMes.D15;
                objInformacionDashboardValidacionDC.DiasMes.D16 = objInformacionDashboardValidacion.DiasMes.D16;
                objInformacionDashboardValidacionDC.DiasMes.D17 = objInformacionDashboardValidacion.DiasMes.D17;
                objInformacionDashboardValidacionDC.DiasMes.D18 = objInformacionDashboardValidacion.DiasMes.D18;
                objInformacionDashboardValidacionDC.DiasMes.D19 = objInformacionDashboardValidacion.DiasMes.D19;
                objInformacionDashboardValidacionDC.DiasMes.D20 = objInformacionDashboardValidacion.DiasMes.D20;
                objInformacionDashboardValidacionDC.DiasMes.D21 = objInformacionDashboardValidacion.DiasMes.D21;
                objInformacionDashboardValidacionDC.DiasMes.D22 = objInformacionDashboardValidacion.DiasMes.D22;
                objInformacionDashboardValidacionDC.DiasMes.D23 = objInformacionDashboardValidacion.DiasMes.D23;
                objInformacionDashboardValidacionDC.DiasMes.D24 = objInformacionDashboardValidacion.DiasMes.D24;
                objInformacionDashboardValidacionDC.DiasMes.D25 = objInformacionDashboardValidacion.DiasMes.D25;
                objInformacionDashboardValidacionDC.DiasMes.D26 = objInformacionDashboardValidacion.DiasMes.D26;
                objInformacionDashboardValidacionDC.DiasMes.D27 = objInformacionDashboardValidacion.DiasMes.D27;
                objInformacionDashboardValidacionDC.DiasMes.D28 = objInformacionDashboardValidacion.DiasMes.D28;
                objInformacionDashboardValidacionDC.DiasMes.D29 = objInformacionDashboardValidacion.DiasMes.D29;
                objInformacionDashboardValidacionDC.DiasMes.D30 = objInformacionDashboardValidacion.DiasMes.D30;
                objInformacionDashboardValidacionDC.DiasMes.D31 = objInformacionDashboardValidacion.DiasMes.D31;

                lstInformacionDashboardValidacionCollectionDC.Add(objInformacionDashboardValidacionDC);
            }

            objObtieneDashboardPosValidacionResponse.InformacionDashboardValidacion = lstInformacionDashboardValidacionCollectionDC;
            return objObtieneDashboardPosValidacionResponse;
        }
        public override Abaseguros.Finanzas.SIAC.MessageContracts.InsertaReportePorValidacionResponse InsertarReportePosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.InsertarReportePosValidacionRequest request)
        {
            MessageContracts.InsertaReportePorValidacionResponse objInsertaReportePorValidacionResponse = new MessageContracts.InsertaReportePorValidacionResponse();
            objInsertaReportePorValidacionResponse.Error = _objPosValidacionBL.InsertaReportePosValidacion(request.Archivo,
                                                                                                             request.BusinessUnit,
                                                                                                             request.FechaValidacion,
                                                                                                             request.TipoArchivo,
                                                                                                             request.TipoValidacion,
                                                                                                             request.Usuario);
            return objInsertaReportePorValidacionResponse;
        }
        public override Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionResponse ObtieneResultadoPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionRequest request)
        {
            MessageContracts.ResultadoPosValidacionResponse objResultadoPosValidacionResponse = new MessageContracts.ResultadoPosValidacionResponse();
            List<BusinessEntities.ResultadosPosValidacion> lstResultadosPosValidacion = null;
            lstResultadosPosValidacion = _objPosValidacionBL.ObtieneResultadosPosValidacion(request.BU_Sistema_Plaza_FechaValDC.BusinessUnit,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.idSistema,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.idPlaza,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.FechaValidacion,
                                                                                                request.TipoValidacionId,
                                                                                                request.ArchivoPosvalidacionId);

            objResultadoPosValidacionResponse.ResultadosPosValidacionCollectionDC = this.ObtienePosValidacion(lstResultadosPosValidacion);
            return objResultadoPosValidacionResponse;
        }
        /*public override Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionResponse ObtieneHistorialPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ResultadoPosValidacionRequest request)
        {
            MessageContracts.ResultadoPosValidacionResponse objResultadoPosValidacionResponse = new MessageContracts.ResultadoPosValidacionResponse();
            List<BusinessEntities.ResultadosPosValidacion> lstResultadosPosValidacion = null;

            lstResultadosPosValidacion = _objPosValidacionBL.ObtieneHistorialPosValidacion(request.BU_Sistema_Plaza_FechaValDC.BusinessUnit,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.idSistema,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.idPlaza,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.FechaValidacion,
                                                                                                request.TipoValidacionId);

            objResultadoPosValidacionResponse.ResultadosPosValidacionCollectionDC = this.ObtienePosValidacion(lstResultadosPosValidacion);
            return objResultadoPosValidacionResponse;
        }*/
        public override Abaseguros.Finanzas.SIAC.MessageContracts.ProcesaPosValidacionResponse ProcesaPosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ProcesaPosValidacionRequest request)
        {
            MessageContracts.ProcesaPosValidacionResponse objProcesaPosValidacionResponse = new MessageContracts.ProcesaPosValidacionResponse();
            objProcesaPosValidacionResponse.Error = _objPosValidacionBL.ProcesaPosValidacion(request.BU_Sistema_Plaza_FechaValDC.BusinessUnit,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.idSistema,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.idPlaza,
                                                                                                request.BU_Sistema_Plaza_FechaValDC.FechaValidacion,
                                                                                                request.Login,
                                                                                                request.CargaRO);
            return objProcesaPosValidacionResponse;
        }
        public override Abaseguros.Finanzas.SIAC.MessageContracts.ActualizaResultadosPosvalidacionResponse ActualizaResultadosPosvalidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ActualizaResultadosPosvalidacionRequest request)
        {
            MessageContracts.ActualizaResultadosPosvalidacionResponse objActualizaResultadosPosvalidacionResponse = new MessageContracts.ActualizaResultadosPosvalidacionResponse();
            bool aceptado = false;
            bool rechazado = false;
            bool error = false;
            int resultado;

            try
            {
                foreach (DataContracts.ActualizaPrevalidacionParametros par in request.parametros)
                {
                    resultado = _objPosValidacionBL.ActualizaResultadosPosvalidacion(par.ValidacionId,
                        par.CuentaAlterna, par.Moneda, par.Estado, par.Comentarios, par.NivelPosvalidacion);
                    switch (resultado)
                    {
                        case 1:
                            aceptado = true;
                            rechazado = false;
                            break;
                        case 2:
                            aceptado = false;
                            rechazado = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                error = true;
            }

            if (error)
            {
                objActualizaResultadosPosvalidacionResponse.Error = "Error al actualizar los datos, favor de internarlo m�s tarde";
            }
            else
            {
                if (rechazado)
                {
                    objActualizaResultadosPosvalidacionResponse.Error = "Posvalidaci�n rechazada";
                }
                else
                {
                    if (aceptado)
                    {
                        objActualizaResultadosPosvalidacionResponse.Error = "Posvalidaci�n confirmada";
                    }
                }
            }
            return objActualizaResultadosPosvalidacionResponse;
        }

        public override Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneMensajesReportePosValidacionResponse ObtieneMensajesReportePosValidacion(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneMensajesReportePosValidacionRequest request)
        {
            MessageContracts.ObtieneMensajesReportePosValidacionResponse objObtieneMensajesReportePosValidacionResponse = new MessageContracts.ObtieneMensajesReportePosValidacionResponse();
            DataContracts.ReportePosValidacionMensajesCollectionDC objReportePosValidacionMensajesCollectionDC = new DataContracts.ReportePosValidacionMensajesCollectionDC();
            DataContracts.ReportePosValidacionMensajesDC objReportePosValidacionMensajesDC = null;
            List<BusinessEntities.MensajesReportePosValidacion> lstMensajesReportePosValidacion = _objPosValidacionBL.ObtieneMensajesReportePosValidacion(request.BusinessUnit, request.FechaValidacion, request.TipoArchivo, request.TipoValidacion);
            foreach (BusinessEntities.MensajesReportePosValidacion objMensajesReportePosValidacion in lstMensajesReportePosValidacion)
            {
                objReportePosValidacionMensajesDC = new DataContracts.ReportePosValidacionMensajesDC();
                objReportePosValidacionMensajesDC.ReportePosValidacionMensajesId = objMensajesReportePosValidacion.ReportePosValidacionMensajesId;
                objReportePosValidacionMensajesDC.ReportePosValidacionId = objMensajesReportePosValidacion.ReportePosValidacionId;
                objReportePosValidacionMensajesDC.FechaModificacion = objMensajesReportePosValidacion.FechaModificacion;
                objReportePosValidacionMensajesDC.Estatus = objMensajesReportePosValidacion.Estatus;
                objReportePosValidacionMensajesDC.Mensaje = objMensajesReportePosValidacion.Mensaje;
                objReportePosValidacionMensajesDC.OrigenEstatus = objMensajesReportePosValidacion.OrigenEstatus;

                objReportePosValidacionMensajesCollectionDC.Add(objReportePosValidacionMensajesDC);
            }

            objObtieneMensajesReportePosValidacionResponse.ReportePosValidacionMensajesCollectionDC = objReportePosValidacionMensajesCollectionDC;
            return objObtieneMensajesReportePosValidacionResponse;
        }

    }
}
