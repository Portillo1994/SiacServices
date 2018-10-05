using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
	/// <summary>
	/// Data Contract Class - MonedaCollectionDC
	/// </summary>
	[WcfSerialization::CollectionDataContract(Namespace = "http://abaseguros.com")]
	public partial class MonedaCollectionDC : System.Collections.Generic.List<MonedaDC>
	{
	}
}

