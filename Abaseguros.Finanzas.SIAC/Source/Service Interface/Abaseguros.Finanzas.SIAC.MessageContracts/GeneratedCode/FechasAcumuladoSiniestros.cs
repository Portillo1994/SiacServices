
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
	/// Service Contract Class - FechasAcumuladoSiniestros
	/// </summary>
	[WCF::MessageContract(WrapperName = "FechasAcumuladoSiniestros", WrapperNamespace = "http://abaseguros.com")] 
	public partial class FechasAcumuladoSiniestros
	{
		private System.DateTime fechaInicial;
	 	private System.DateTime fechaFinal;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "FechaInicial")]
		public System.DateTime FechaInicial
		{
			get { return fechaInicial; }
			set { fechaInicial = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "FechaFinal")]
		public System.DateTime FechaFinal
		{
			get { return fechaFinal; }
			set { fechaFinal = value; }
		}
	}
}

