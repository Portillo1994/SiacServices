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
	/// Service Contract Class - ReportesOperativosServiceContract
	/// </summary>
	[WCF::ServiceContract(Namespace = "http://abaseguros.com", Name = "ReportesOperativosServiceContract", SessionMode = WCF::SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None )]
	public partial interface IReportesOperativosServiceContract 
	{
		[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtieneHistorialRO", ProtectionLevel = ProtectionLevel.None)]
		Abaseguros.Finanzas.SIAC.MessageContracts.HistorialROResponse ObtieneHistorialRO(Abaseguros.Finanzas.SIAC.MessageContracts.HistorialRORequest request);
		
[WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "InsertaParametroReporte", ProtectionLevel = ProtectionLevel.None)]
		Abaseguros.Finanzas.SIAC.MessageContracts.ParametroReporteResponse InsertaParametroReporte(Abaseguros.Finanzas.SIAC.MessageContracts.ParametroReporteRequest request);
		
	}
}
