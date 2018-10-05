using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class BusinessUnitBL
    {
        DataAccess.BusinessUnitDA _objBusinessUnitDA = new DataAccess.BusinessUnitDA();

        public List<BusinessEntities.BusinessUnitObj> GetBusinessUnits()
        {
            return _objBusinessUnitDA.GetBusinessUnits();
        }

        public BusinessEntities.BusinessUnitObj AgregarBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit)
        {
            return _objBusinessUnitDA.AgregaBusinessUnit(businessUnit);
        }

        public BusinessEntities.BusinessUnitObj ActualizarBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit)
        {
            return _objBusinessUnitDA.ActualizaBusinessUnit(businessUnit);
        }

        public List<BusinessEntities.SistemaObj> ObtieneSistemas()
        {
            return _objBusinessUnitDA.obtenerSistemas();
        }

        public BusinessEntities.SistemaObj AgregarSistema(BusinessEntities.SistemaObj sistema)
        {
            return _objBusinessUnitDA.AgregaSistema(sistema);
        }

        public BusinessEntities.SistemaObj ActualizaSistema(BusinessEntities.SistemaObj sistema)
        {
            return _objBusinessUnitDA.ActualizaSistema(sistema);
        }

        public void GuardaConfiguracionSistema(int BusinessUnit, int SistemaId, string Proceso, string SourceId, string ApplJrnlId, string Source)
        {
            _objBusinessUnitDA.GuardaConfiguracionSistema(BusinessUnit, SistemaId, Proceso, SourceId, ApplJrnlId, Source);
        }

        public List<BusinessEntities.ConfiguracionSistemaObj> ObtieneConfiguracionSistema(int BusinessUnit, int SistemaId)
        {
            return _objBusinessUnitDA.ObtieneConfiguracionSistema(BusinessUnit, SistemaId);
        }

        public BusinessEntities.SourceSistemaObj ObtieneSourceSistema(int BusinessUnit, int SistemaId)
        {
            return _objBusinessUnitDA.ObtieneSourceSistema(BusinessUnit, SistemaId);
        }
    }
}
