
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
	/// Service Contract Class - ActualizaEstadoPeriodoRequest
	/// </summary>
	[WCF::MessageContract(WrapperName = "ActualizaEstadoPeriodoRequest", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ActualizaEstadoPeriodoRequest
	{
		private int businessUnit;
	 	private int periodo;
	 	private int estado;
	 	private string usuario;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "BusinessUnit")]
		public int BusinessUnit
		{
			get { return businessUnit; }
			set { businessUnit = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Periodo")]
		public int Periodo
		{
			get { return periodo; }
			set { periodo = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Estado")]
		public int Estado
		{
			get { return estado; }
			set { estado = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Usuario")]
		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}
	}
}
