using Abaseguros.Finanzas.SIAC.DataContracts;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
    /// <summary>
    /// Data Contract Class - GetJournalValidationCollectionDC
    /// </summary>
    [WcfSerialization::CollectionDataContract(Namespace = "http://abaseguros.com")]
    public partial class GetJournalValidationCollectionDC : System.Collections.Generic.List<ErrorDC>
    {

    }
}
