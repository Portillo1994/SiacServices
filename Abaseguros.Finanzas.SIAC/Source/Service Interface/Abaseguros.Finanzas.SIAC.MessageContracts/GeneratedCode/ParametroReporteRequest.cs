
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using WCF = global::System.ServiceModel;

namespace Abaseguros.Finanzas.SIAC.MessageContracts
{
	/// <summary>
	/// Service Contract Class - ParametroReporteRequest
	/// </summary>
	[WCF::MessageContract(WrapperName = "ParametroReporteRequest", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ParametroReporteRequest
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.InsertaParametroReporteDC insertaParametroReporte;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "InsertaParametroReporte")]
		public Abaseguros.Finanzas.SIAC.DataContracts.InsertaParametroReporteDC InsertaParametroReporte
		{
			get { return insertaParametroReporte; }
			set { insertaParametroReporte = value; }
		}
	}
}

