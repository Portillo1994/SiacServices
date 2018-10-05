using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
	/// <summary>
	/// Data Contract Class - MonedaDC
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "MonedaDC")]
	public partial class MonedaDC 
	{
		private int idmoneda;
		private string nombre;
		private string cvemoneda;
		
		[WcfSerialization::DataMember(Name = "idMoneda", IsRequired = true, Order = 0)]
		public int idMoneda
		{
		  get { return idmoneda; }
		  set { idmoneda = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Nombre", IsRequired = false, Order = 1)]
		public string Nombre
		{
		  get { return nombre; }
		  set { nombre = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "cveMoneda", IsRequired = true, Order = 2)]
		public string cveMoneda
		{
		  get { return cvemoneda; }
		  set { cvemoneda = value; }
		}
	}
}

