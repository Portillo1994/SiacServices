using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using WCF = global::System.ServiceModel;


namespace Abaseguros.Finanzas.SIAC.MessageContracts.GeneratedCode
{
    [WCF::MessageContract(WrapperName = "GetSiacValidationRequest", WrapperNamespace = "http://abaseguros.com")]
    class GetSiacValidationRequest
    {
        private string _xmlJournal;

        [WCF::MessageBodyMember(Namespace = "http://abaseguros.com", Name = "XmlJournal")]
        // ReSharper disable once ConvertToAutoProperty
        public string XmlJournal
        {
            get => _xmlJournal;
            set => _xmlJournal = value;
        }

    }
}
