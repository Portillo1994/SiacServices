
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
	/// Service Contract Class - ObtieneDashboardPreValidacionResponse
	/// </summary>
	[WCF::MessageContract(WrapperName = "ObtieneDashboardPreValidacionResponse", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ObtieneDashboardPreValidacionResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.InformacionDashboardValidacionCollectionDC informacionDashboardValidacion;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "InformacionDashboardValidacion")]
		public Abaseguros.Finanzas.SIAC.DataContracts.InformacionDashboardValidacionCollectionDC InformacionDashboardValidacion
		{
			get { return informacionDashboardValidacion; }
			set { informacionDashboardValidacion = value; }
		}
	}
}

