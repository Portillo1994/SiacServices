
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
	/// Service Contract Class - ObtieneReporteMonitoreoPCWRequest
	/// </summary>
	[WCF::MessageContract(WrapperName = "ObtieneReporteMonitoreoPCWRequest", WrapperNamespace = "http://abaseguros.com")] 
	public partial class ObtieneReporteMonitoreoPCWRequest
	{
		private int archivoId;
	 	private int dia;
	 		
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "ArchivoId")]
		public int ArchivoId
		{
			get { return archivoId; }
			set { archivoId = value; }
		}
			
		[WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Dia")]
		public int Dia
		{
			get { return dia; }
			set { dia = value; }
		}
	}
}

