using System;
using System.Net.Security;
using WCF = global::System.ServiceModel;

namespace Abaseguros.Finanzas.SIAC.ServiceContracts
{
	/// <summary>
	/// Service Contract Class - BusinessUnitServiceContract
	/// </summary>
	[WCF::ServiceContract(Namespace = "http://abaseguros.com", Name = "BusinessUnitServiceContract", SessionMode = WCF::SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None )]
	public partial interface IBusinessUnitServiceContract 
	{
		[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/GetBusinessUnits", ProtectionLevel = ProtectionLevel.None)]
        Abaseguros.Finanzas.SIAC.MessageContracts.GetBusinessUnitsResponse GetBusinessUnits();

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/AgregaBusinessUnit", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.BusinessUnitObj AgregaBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/ActualizaBusinessUnit", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.BusinessUnitObj ActualizaBusinessUnit(BusinessEntities.BusinessUnitObj businessUnit);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/ObtieneSistemas", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.SistemaObj[] ObtieneSistemas();

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/AgregaSistema", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.SistemaObj AgregaSistema(BusinessEntities.SistemaObj sistema);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/ActualizaSistema", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.SistemaObj ActualizaSistema(BusinessEntities.SistemaObj sistema);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/GuardaConfiguracionSistema", ProtectionLevel = ProtectionLevel.None)]
        void GuardaConfiguracionSistema(int BusinessUnit, int SistemaId, string Proceso, string SourceId, string ApplJrnlId, string Source);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/ObtieneConfiguracionSistema", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.ConfiguracionSistemaObj[] ObtieneConfiguracionSistema(int BusinessUnit, int SistemaId);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/BusinessUnitServiceContract/ObtieneSourceSistema", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.SourceSistemaObj ObtieneSourceSistema(int BusinessUnit, int SistemaId);
    }
}

