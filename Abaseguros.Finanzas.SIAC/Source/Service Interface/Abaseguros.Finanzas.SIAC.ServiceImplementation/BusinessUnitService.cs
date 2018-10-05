using System;
using WCF = global::System.ServiceModel;
using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.ServiceImplementation
{
    /// <summary>
    /// Service Class - BusinessUnitService
    /// </summary>
    [WCF::ServiceBehavior(Name = "BusinessUnitService",
        Namespace = "http://abaseguros.com",
        InstanceContextMode = WCF::InstanceContextMode.PerSession,
        ConcurrencyMode = WCF::ConcurrencyMode.Single)]
    public abstract class BusinessUnitServiceBase : Abaseguros.Finanzas.SIAC.ServiceContracts.IBusinessUnitServiceContract
    {
        #region BusinessUnitServiceContract Members

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.GetBusinessUnitsResponse GetBusinessUnits()
        {
            return null;
        }

        public virtual BusinessEntities.BusinessUnitObj AgregaBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit)
        {
            return null;
        }

        public virtual BusinessEntities.BusinessUnitObj ActualizaBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit)
        {
            return null;
        }

        public virtual BusinessEntities.SistemaObj[] ObtieneSistemas()
        {
            return null;
        }

        public virtual BusinessEntities.SistemaObj AgregaSistema(BusinessEntities.SistemaObj sistema)
        {
            return null;
        }

        public virtual BusinessEntities.SistemaObj ActualizaSistema(BusinessEntities.SistemaObj sistema)
        {
            return null;
        }

        public virtual void GuardaConfiguracionSistema(int BusinessUnit, int SistemaId, string Proceso, string SourceId, string ApplJrnlId, string Source) { }

        public virtual BusinessEntities.ConfiguracionSistemaObj[] ObtieneConfiguracionSistema(int BusinessUnit, int SistemaId)
        {
            return null;
        }

        public virtual BusinessEntities.SourceSistemaObj ObtieneSourceSistema(int BusinessUnit, int SistemaId)
        {
            return null;
        }
        #endregion

    }

    public partial class BusinessUnitService : BusinessUnitServiceBase
    {
        BusinessLogic.BusinessUnitBL _objBusinessUnitBL = new BusinessLogic.BusinessUnitBL();
        public override Abaseguros.Finanzas.SIAC.MessageContracts.GetBusinessUnitsResponse GetBusinessUnits()
        {
            MessageContracts.GetBusinessUnitsResponse msgGetBusinessUnitsResponse = new MessageContracts.GetBusinessUnitsResponse();
            List<BusinessEntities.BusinessUnitObj> lstBU = new List<BusinessEntities.BusinessUnitObj>();

            DataContracts.BusinessUnitDC objBUDC = null;
            DataContracts.BusinessUnitCollectionDC lstBUCollectionDC = new DataContracts.BusinessUnitCollectionDC();

            lstBU = _objBusinessUnitBL.GetBusinessUnits();
            foreach (BusinessEntities.BusinessUnitObj objBU in lstBU)
            {
                objBUDC = new DataContracts.BusinessUnitDC();
                objBUDC.BusinessUnit = objBU.BusinessUnit;
                objBUDC.Name = objBU.Name;
                objBUDC.Currency = objBU.Currency;
                objBUDC.BusinessUnitPS = objBU.BusinessUnitPS;

                lstBUCollectionDC.Add(objBUDC);
            }

            msgGetBusinessUnitsResponse.BusinessUnits = lstBUCollectionDC;
            return msgGetBusinessUnitsResponse;
        }

        public override BusinessEntities.BusinessUnitObj AgregaBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit)
        {
            BusinessEntities.BusinessUnitObj buAgregado = _objBusinessUnitBL.AgregarBusinessUnit(businessUnit);
            return buAgregado;
        }

        public override BusinessEntities.BusinessUnitObj ActualizaBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit)
        {
            BusinessEntities.BusinessUnitObj buActualizado = _objBusinessUnitBL.ActualizarBusinessUnit(businessUnit);
            return buActualizado;
        }

        public override BusinessEntities.SistemaObj[] ObtieneSistemas()
        {
            List<BusinessEntities.SistemaObj> lstSistemas = _objBusinessUnitBL.ObtieneSistemas();
            return lstSistemas.ToArray();
        }

        public override BusinessEntities.SistemaObj AgregaSistema(BusinessEntities.SistemaObj sistema)
        {
            BusinessEntities.SistemaObj sistemaAgregado = _objBusinessUnitBL.AgregarSistema(sistema);
            return sistemaAgregado;
        }

        public override BusinessEntities.SistemaObj ActualizaSistema(BusinessEntities.SistemaObj sistema)
        {
            BusinessEntities.SistemaObj sistemaActualizado = _objBusinessUnitBL.ActualizaSistema(sistema);
            return sistemaActualizado;
        }

        public override void GuardaConfiguracionSistema(int BusinessUnit, int SistemaId, string Proceso, string SourceId, string ApplJrnlId, string Source)
        {
            _objBusinessUnitBL.GuardaConfiguracionSistema(BusinessUnit, SistemaId, Proceso, SourceId, ApplJrnlId, Source);
        }

        public override BusinessEntities.ConfiguracionSistemaObj[] ObtieneConfiguracionSistema(int BusinessUnit, int SistemaId)
        {
            return _objBusinessUnitBL.ObtieneConfiguracionSistema(BusinessUnit, SistemaId).ToArray();
        }

        public override BusinessEntities.SourceSistemaObj ObtieneSourceSistema(int BusinessUnit, int SistemaId)
        {
            return _objBusinessUnitBL.ObtieneSourceSistema(BusinessUnit, SistemaId);
        }
    }

}

