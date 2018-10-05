using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
	/// <summary>
	/// Data Contract Class - BusinessUnitDC
	/// </summary>	
	[WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "BusinessUnitDC")]
	public partial class BusinessUnitDC 
	{
		private int businessUnit;
		private string name;
		private string currency;
		private int businessUnitPS;
		
		[WcfSerialization::DataMember(Name = "BusinessUnit", IsRequired = true, Order = 0)]
		public int BusinessUnit
		{
		  get { return businessUnit; }
		  set { businessUnit = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Name", IsRequired = false, Order = 1)]
		public string Name
		{
		  get { return name; }
		  set { name = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "Currency", IsRequired = true, Order = 2)]
		public string Currency
		{
		  get { return currency; }
		  set { currency = value; }
		}				
		
		[WcfSerialization::DataMember(Name = "BusinessUnitPS", IsRequired = true, Order = 3)]
		public int BusinessUnitPS
		{
		  get { return businessUnitPS; }
		  set { businessUnitPS = value; }
		}		
	}
}

