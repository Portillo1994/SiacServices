
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
	/// Service Contract Class - ObtieneMensajesReportePosValidacionResponse
	/// </summary>
	[WCF::MessageContract(WrapperName = "ObtieneMensajesReportePosValidacionResponse", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ObtieneMensajesReportePosValidacionResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.ReportePosValidacionMensajesCollectionDC reportePosValidacionMensajesCollectionDC;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "ReportePosValidacionMensajesCollectionDC")]
		public Abaseguros.Finanzas.SIAC.DataContracts.ReportePosValidacionMensajesCollectionDC ReportePosValidacionMensajesCollectionDC
		{
			get { return reportePosValidacionMensajesCollectionDC; }
			set { reportePosValidacionMensajesCollectionDC = value; }
		}
	}
}

