
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
	/// Service Contract Class - ObtienePlazaRequest
	/// </summary>
	[WCF::MessageContract(WrapperName = "ObtienePlazaRequest", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ObtienePlazaRequest
	{
		private int plazaId;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "PlazaId")]
		public int PlazaId
		{
			get { return plazaId; }
			set { plazaId = value; }
		}
	}
}

