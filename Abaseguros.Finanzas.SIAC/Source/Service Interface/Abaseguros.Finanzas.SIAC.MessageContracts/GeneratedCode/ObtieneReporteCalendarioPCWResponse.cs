
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
	/// Service Contract Class - ObtieneReporteCalendarioPCWResponse
	/// </summary>
	[WCF::MessageContract(WrapperName = "ObtieneReporteCalendarioPCWResponse", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ObtieneReporteCalendarioPCWResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.ReporteCalendarioPCWCollectionDC reporteCalendarioPCW;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "ReporteCalendarioPCW")]
		public Abaseguros.Finanzas.SIAC.DataContracts.ReporteCalendarioPCWCollectionDC ReporteCalendarioPCW
		{
			get { return reporteCalendarioPCW; }
			set { reporteCalendarioPCW = value; }
		}
	}
}

