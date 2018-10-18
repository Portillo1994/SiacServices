

namespace Abaseguros.Finanzas.SIAC.MessageContracts
{
    using WCF = global::System.ServiceModel;

    [WCF::MessageContract(WrapperName = "VoucherInformationResponse", WrapperNamespace = "http://abaseguros.com")]
    public partial class VoucherInformationResponse
    {
        [WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "Error")]
        public Abaseguros.Finanzas.SIAC.DataContracts.ErrorCollectionDC Error { get; set; }
    }
}
