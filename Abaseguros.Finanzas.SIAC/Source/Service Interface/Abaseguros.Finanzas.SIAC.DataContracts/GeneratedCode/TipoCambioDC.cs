//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
	/// <summary>
	/// Data Contract Class - TipoCambioDC
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "TipoCambioDC")]
	public partial class TipoCambioDC 
	{
		private int businessUnit;
		private System.DateTime fecha;
		private decimal tipoCambio;
		private System.DateTime fechaModificacion;
		
		[WcfSerialization::DataMember(Name = "BusinessUnit", IsRequired = false, Order = 0)]
		public int BusinessUnit
		{
		  get { return businessUnit; }
		  set { businessUnit = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Fecha", IsRequired = false, Order = 1)]
		public System.DateTime Fecha
		{
		  get { return fecha; }
		  set { fecha = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "TipoCambio", IsRequired = false, Order = 2)]
		public decimal TipoCambio
		{
		  get { return tipoCambio; }
		  set { tipoCambio = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "FechaModificacion", IsRequired = false, Order = 3)]
		public System.DateTime FechaModificacion
		{
		  get { return fechaModificacion; }
		  set { fechaModificacion = value; }
		}				
	}
}

