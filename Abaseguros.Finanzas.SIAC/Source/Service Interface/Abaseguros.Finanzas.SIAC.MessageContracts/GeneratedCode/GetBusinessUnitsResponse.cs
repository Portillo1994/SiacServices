using System;
using WCF = global::System.ServiceModel;

namespace Abaseguros.Finanzas.SIAC.MessageContracts
{
	/// <summary>
	/// Service Contract Class - GetBusinessUnitsResponse
	/// </summary>
	[WCF::MessageContract(IsWrapped = false)] 
	public partial class GetBusinessUnitsResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.BusinessUnitCollectionDC businessunits;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "GetBusinessUnitsResponse")]
		public Abaseguros.Finanzas.SIAC.DataContracts.BusinessUnitCollectionDC BusinessUnits
		{
			get { return businessunits; }
			set { businessunits = value; }
		}
	}
}

