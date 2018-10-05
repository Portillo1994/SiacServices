using Abaseguros.Finanzas.SIAC.DataContracts;

namespace Abaseguros.Finanzas.SIAC.MessageContracts
{
    using WCF = global::System.ServiceModel;

    [WCF::MessageContract(WrapperName = "GetJournalValidationRequest", WrapperNamespace = "http://abaseguros.com")]
    public partial class GetJournalValidationRequest
    {
        [WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "AccountingInformation")]
        public GetJournalValidationDC AccountingInformation { get; set; }
    }
}
