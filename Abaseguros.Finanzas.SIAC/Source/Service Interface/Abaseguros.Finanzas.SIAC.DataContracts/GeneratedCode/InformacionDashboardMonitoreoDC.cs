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
	/// Data Contract Class - InformacionDashboardMonitoreoDC
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "InformacionDashboardMonitoreoDC")]
	public partial class InformacionDashboardMonitoreoDC 
	{
		private int procesoId;
		private string aplicacion;
		private int businessUnit;
		private int numeroProcesos;
		private int archivoPCWId;
		private Abaseguros.Finanzas.SIAC.DataContracts.DiasMesDC diasMes;
		
		[WcfSerialization::DataMember(Name = "ProcesoId", IsRequired = false, Order = 0)]
		public int ProcesoId
		{
		  get { return procesoId; }
		  set { procesoId = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Aplicacion", IsRequired = false, Order = 1)]
		public string Aplicacion
		{
		  get { return aplicacion; }
		  set { aplicacion = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "BusinessUnit", IsRequired = false, Order = 2)]
		public int BusinessUnit
		{
		  get { return businessUnit; }
		  set { businessUnit = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "NumeroProcesos", IsRequired = false, Order = 3)]
		public int NumeroProcesos
		{
		  get { return numeroProcesos; }
		  set { numeroProcesos = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "ArchivoPCWId", IsRequired = false, Order = 4)]
		public int ArchivoPCWId
		{
		  get { return archivoPCWId; }
		  set { archivoPCWId = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "DiasMes", IsRequired = false, Order = 5)]
		public Abaseguros.Finanzas.SIAC.DataContracts.DiasMesDC DiasMes
		{
		  get { return diasMes; }
		  set { diasMes = value; }
		}				
	}
}

