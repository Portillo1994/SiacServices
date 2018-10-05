using System;
using WCF = global::System.ServiceModel;

namespace Abaseguros.Finanzas.SIAC.MessageContracts
{
	/// <summary>
	/// Service Contract Class - ObtieneMonedasResponse
	/// </summary>
	[WCF::MessageContract(IsWrapped = false)] 
	public partial class ObtieneMonedasResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.MonedaCollectionDC monedas;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "ObtieneMonedasResponse")]
		public Abaseguros.Finanzas.SIAC.DataContracts.MonedaCollectionDC Monedas
		{
			get { return monedas; }
			set { monedas = value; }
		}
	}
}

