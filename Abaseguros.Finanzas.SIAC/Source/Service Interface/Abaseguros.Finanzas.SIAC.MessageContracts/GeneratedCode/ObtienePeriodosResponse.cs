
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
	/// Service Contract Class - ObtienePeriodosResponse
	/// </summary>
	[WCF::MessageContract(IsWrapped = false)] 
	public partial class ObtienePeriodosResponse
	{
		private Abaseguros.Finanzas.SIAC.DataContracts.PeriodoCollectionDC periodos;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Periodos")]
		public Abaseguros.Finanzas.SIAC.DataContracts.PeriodoCollectionDC Periodos
		{
			get { return periodos; }
			set { periodos = value; }
		}
	}
}
