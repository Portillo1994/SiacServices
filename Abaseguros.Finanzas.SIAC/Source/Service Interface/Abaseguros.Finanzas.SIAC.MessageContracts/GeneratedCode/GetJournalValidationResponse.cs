

namespace Abaseguros.Finanzas.SIAC.MessageContracts
{
    using WCF = global::System.ServiceModel;

    [WCF::MessageContract(WrapperName = "GetJournalValidationResponse", WrapperNamespace = "http://abaseguros.com")]
    public partial class GetJournalValidationResponse
    {
        private Abaseguros.Finanzas.SIAC.DataContracts.GetJournalValidationCollectionDC _getJournalValidation;

        [WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "GetJournalValidation")]
        public Abaseguros.Finanzas.SIAC.DataContracts.GetJournalValidationCollectionDC GetJournalValidation
        {
            get { return _getJournalValidation; }
            set { _getJournalValidation = value; }
        }


    }
}
