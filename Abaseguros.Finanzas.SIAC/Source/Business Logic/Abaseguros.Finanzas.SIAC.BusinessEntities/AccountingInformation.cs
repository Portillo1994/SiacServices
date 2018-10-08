using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class AccountingInformation
    {
        public Header Header { get; set; }
    }


    public class Header
    {
        /// <summary>
        /// Accounting date of the transactions
        /// </summary>

        public DateTime AccountingDate { get; set; }

        /// <summary>
        /// Source System a Catalog in SIAC
        /// </summary>

        public int SourceSystemId { get; set; }

        /// <summary>
        /// If you have different Branch and want split the information
        /// </summary>

        public int Branch { get; set; }

        /// <summary>
        /// BusinessUnit of the process
        /// </summary>

        public int BusinessUnit { get; set; }

        /// <summary>
        /// PS - PeopleSoft
        /// </summary>

        public string RecordType { get; set; }

        /// <summary>
        /// Number of Registers
        /// </summary>

        public int RegisterCount { get; set; }
    }
}
