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
	/// Data Contract Class - InformacionDashboardValidacionDC
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "InformacionDashboardValidacionDC")]
	public partial class InformacionDashboardValidacionDC 
	{
		private System.Nullable<int> idSistemaField;
		private System.Nullable<int> idPlazaField;
		private string sistemaPlaza;
		private string cuenta;
		private string moneda;
		private Abaseguros.Finanzas.SIAC.DataContracts.DiasMesDC diasMes;
		
		[WcfSerialization::DataMember(Name = "idSistema", IsRequired = false, Order = 0)]
		public System.Nullable<int> idSistema
		{
		  get { return idSistemaField; }
		  set { idSistemaField = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "idPlaza", IsRequired = false, Order = 1)]
		public System.Nullable<int> idPlaza
		{
		  get { return idPlazaField; }
		  set { idPlazaField = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "SistemaPlaza", IsRequired = false, Order = 2)]
		public string SistemaPlaza
		{
		  get { return sistemaPlaza; }
		  set { sistemaPlaza = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Cuenta", IsRequired = false, Order = 3)]
		public string Cuenta
		{
		  get { return cuenta; }
		  set { cuenta = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Moneda", IsRequired = false, Order = 4)]
		public string Moneda
		{
		  get { return moneda; }
		  set { moneda = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "DiasMes", IsRequired = false, Order = 5)]
		public Abaseguros.Finanzas.SIAC.DataContracts.DiasMesDC DiasMes
		{
		  get { return diasMes; }
		  set { diasMes = value; }
		}				
	}
}

