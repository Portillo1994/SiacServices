
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
	/// Service Contract Class - ObtieneReporteMonitoreoPSResponse
	/// </summary>
	[WCF::MessageContract(WrapperName = "ObtieneReporteMonitoreoPSResponse", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ObtieneReporteMonitoreoPSResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.ReporteMonitoreoPSCollectionDC reporteMonitoreoPS;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "ReporteMonitoreoPS")]
		public Abaseguros.Finanzas.SIAC.DataContracts.ReporteMonitoreoPSCollectionDC ReporteMonitoreoPS
		{
			get { return reporteMonitoreoPS; }
			set { reporteMonitoreoPS = value; }
		}
	}
}

