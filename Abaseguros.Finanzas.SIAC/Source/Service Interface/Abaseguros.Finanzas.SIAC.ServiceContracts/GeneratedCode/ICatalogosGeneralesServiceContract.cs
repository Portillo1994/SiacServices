//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net.Security;
using WCF = global::System.ServiceModel;

namespace Abaseguros.Finanzas.SIAC.ServiceContracts
{
	/// <summary>
	/// Service Contract Class - CatalogosGeneralesServiceContract
	/// </summary>
	[WCF::ServiceContract(Namespace = "http://abaseguros.com", Name = "CatalogosGeneralesServiceContract", SessionMode = WCF::SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None )]
	public partial interface ICatalogosGeneralesServiceContract 
	{
		[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://abaseguros.com/CatalogosGeneralesServiceContract/ObtienePlaza", ProtectionLevel = ProtectionLevel.None)]
		Abaseguros.Finanzas.SIAC.MessageContracts.PlazaResponse ObtienePlaza(Abaseguros.Finanzas.SIAC.MessageContracts.ObtienePlazaRequest request);
		
[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtieneListadoPlazas", ProtectionLevel = ProtectionLevel.None)]
		Abaseguros.Finanzas.SIAC.MessageContracts.PlazasResponse ObtieneListadoPlazas();
		
[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtieneParametroVarchar", ProtectionLevel = ProtectionLevel.None)]
		Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneParametroVarcharResponse ObtieneParametroVarchar(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneParametroVarcharRequest request);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtieneMonedas", ProtectionLevel = ProtectionLevel.None)]
        Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneMonedasResponse ObtieneMonedas();

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "AgregaMoneda", ProtectionLevel = ProtectionLevel.None)]
        BusinessEntities.Moneda AgregaMoneda(BusinessEntities.Moneda moneda);


    }
}

