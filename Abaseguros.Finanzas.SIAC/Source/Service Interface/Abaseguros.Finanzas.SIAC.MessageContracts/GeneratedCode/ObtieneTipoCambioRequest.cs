
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
	/// Service Contract Class - ObtieneTipoCambioRequest
	/// </summary>
	[WCF::MessageContract(WrapperName = "ObtieneTipoCambioRequest", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ObtieneTipoCambioRequest
	{
		private int businessUnit;
	 	private int anio;
	 	private int mes;
	 	private int tipo;
	 	private string moneda;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "BusinessUnit")]
		public int BusinessUnit
		{
			get { return businessUnit; }
			set { businessUnit = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Anio")]
		public int Anio
		{
			get { return anio; }
			set { anio = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Mes")]
		public int Mes
		{
			get { return mes; }
			set { mes = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Tipo")]
		public int Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Moneda")]
		public string Moneda
		{
			get { return moneda; }
			set { moneda = value; }
		}
	}
}

