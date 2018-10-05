using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Abaseguros.Finanzas.SIAC.DataContracts
{
    [WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "GetJournalValidationDC")]
    public partial class GetJournalValidationDC
    {
        /// <summary>
        /// Header of the Accounting Data.
        /// </summary>
        [WcfSerialization::DataMember(Name = "Header", IsRequired = true, Order = 0)]
        public Header Header { get; set; }
    }

    [WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "Header")]
    public class Header
    {
        /// <summary>
        /// Accounting date of the transactions
        /// </summary>
        [WcfSerialization::DataMember(Name = "AccountingDate", IsRequired = true, Order = 0)]
        public DateTime AccountingDate { get; set; }

        /// <summary>
        /// Source System a Catalog in SIAC
        /// </summary>
        [WcfSerialization::DataMember(Name = "SourceSystemId", IsRequired = true, Order = 1)]
        public int SourceSystemId { get; set; }

        /// <summary>
        /// If you have different Branch and want split the information
        /// </summary>
        [WcfSerialization::DataMember(Name = "Branch", IsRequired = false, Order = 2)]
        public int Branch { get; set; }

        /// <summary>
        /// BusinessUnit of the process
        /// </summary>
        [WcfSerialization::DataMember(Name = "BusinessUnit", IsRequired = true, Order = 3)]
        public int BusinessUnit { get; set; }

        /// <summary>
        /// PS - PeopleSoft
        /// </summary>
        [WcfSerialization::DataMember(Name = "RecordType", IsRequired = true, Order = 4)]
        public string RecordType { get; set; }

        /// <summary>
        /// Number of Registers
        /// </summary>
        [WcfSerialization::DataMember(Name = "RegisterCount", IsRequired = true, Order = 5)]
        public int RegisterCount { get; set; }
    }
}
