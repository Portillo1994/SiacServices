using Abaseguros.Finanzas.SIAC.DataContracts;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
    /// <summary>
    /// Data Contract Class - ErrorCollectionDC
    /// </summary>
    [WcfSerialization::CollectionDataContract(Namespace = "http://abaseguros.com")]
    public partial class ErrorCollectionDC : System.Collections.Generic.List<ErrorDC>
    {

    }
}
