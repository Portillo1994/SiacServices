
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
	/// Service Contract Class - ActualizaResultadosPrevalidacionResponse
	/// </summary>
	[WCF::MessageContract(WrapperName = "ActualizaResultadosPrevalidacionResponse", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ActualizaResultadosPrevalidacionResponse
	{
		private string error;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Error")]
		public string Error
		{
			get { return error; }
			set { error = value; }
		}
	}
}

