
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
	/// Service Contract Class - ObtenerReporteDeSeguimientoValoresInicialesResponse
	/// </summary>
	[WCF::MessageContract(IsWrapped = false)] 
	public partial class ObtenerReporteDeSeguimientoValoresInicialesResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.ValoresInicialesReporteSeguimiento valoresIniciales;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "ValoresIniciales")]
		public Abaseguros.Finanzas.SIAC.DataContracts.ValoresInicialesReporteSeguimiento ValoresIniciales
		{
			get { return valoresIniciales; }
			set { valoresIniciales = value; }
		}
	}
}
