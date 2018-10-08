using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
    [WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "ErrorDC")]
    public class ErrorDC
    {
        [WcfSerialization::DataMember(Name = "ProcessId", IsRequired = true, Order = 0)]
        public int ProcessId { get; set; }

        [WcfSerialization::DataMember(Name = "RecordId", IsRequired = true, Order = 1)]
        public int RecordId { get; set; }

        [WcfSerialization::DataMember(Name = "ValidationId", IsRequired = true, Order = 1)]
        public int ValidationId { get; set; }

        [WcfSerialization::DataMember(Name = "ErrorDescription", IsRequired = true, Order = 1)]
        public string ErrorDescription { get; set; }
    }
}
