using Abaseguros.Finanzas.SIAC.DataContracts;

namespace Abaseguros.Finanzas.SIAC.MessageContracts
{
    using WCF = global::System.ServiceModel;

    [WCF::MessageContract(WrapperName = "VoucherInformationRequest", WrapperNamespace = "http://abaseguros.com")]
    public partial class VoucherInformationRequest
    {
        [WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "AccountingInformation")]
        public VoucherInformationDC AccountingInformation { get; set; }
    }

}
