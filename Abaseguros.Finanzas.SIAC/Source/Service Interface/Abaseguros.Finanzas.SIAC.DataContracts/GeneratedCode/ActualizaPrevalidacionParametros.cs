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
	/// Data Contract Class - ActualizaPrevalidacionParametros
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "ActualizaPrevalidacionParametros")]
	public partial class ActualizaPrevalidacionParametros 
	{
		private int validacionId;
		private System.DateTime fechaContable;
		private string cuentaAlterna;
		private string moneda;
		private string estado;
		private string comentarios;
		private int nivelPosvalidacion;
		
		[WcfSerialization::DataMember(Name = "ValidacionId", IsRequired = false, Order = 0)]
		public int ValidacionId
		{
		  get { return validacionId; }
		  set { validacionId = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "FechaContable", IsRequired = false, Order = 1)]
		public System.DateTime FechaContable
		{
		  get { return fechaContable; }
		  set { fechaContable = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "CuentaAlterna", IsRequired = false, Order = 2)]
		public string CuentaAlterna
		{
		  get { return cuentaAlterna; }
		  set { cuentaAlterna = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Moneda", IsRequired = false, Order = 3)]
		public string Moneda
		{
		  get { return moneda; }
		  set { moneda = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Estado", IsRequired = false, Order = 4)]
		public string Estado
		{
		  get { return estado; }
		  set { estado = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Comentarios", IsRequired = false, Order = 5)]
		public string Comentarios
		{
		  get { return comentarios; }
		  set { comentarios = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "NivelPosvalidacion", IsRequired = false, Order = 6)]
		public int NivelPosvalidacion
		{
		  get { return nivelPosvalidacion; }
		  set { nivelPosvalidacion = value; }
		}				
	}
}

