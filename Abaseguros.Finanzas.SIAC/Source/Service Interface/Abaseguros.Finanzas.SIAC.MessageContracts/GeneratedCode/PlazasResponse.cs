
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
	/// Service Contract Class - PlazasResponse
	/// </summary>
	[WCF::MessageContract(WrapperName = "PlazasResponse", WrapperNamespace = "http://abaseguros.com")] 
	public partial class PlazasResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.PlazaCollectionDC plazas;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Plazas")]
		public Abaseguros.Finanzas.SIAC.DataContracts.PlazaCollectionDC Plazas
		{
			get { return plazas; }
			set { plazas = value; }
		}
	}
}

