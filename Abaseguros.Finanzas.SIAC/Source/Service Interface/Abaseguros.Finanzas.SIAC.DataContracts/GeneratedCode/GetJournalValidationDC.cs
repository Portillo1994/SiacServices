using System;
using System.Collections.Generic;
using System.ServiceModel;
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

        /// <summary>
        /// Detail list of the Accounting Data.
        /// </summary>
        [WcfSerialization::DataMember(Name = "AccountingDetail", IsRequired = false, Order = 1)]
        public List<Detail> AccountingDetail { get; set; }
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

    [WcfSerialization::DataContract(Namespace = "http://abaseguros.com", Name = "Detail")]
    public class Detail
    {
        private string _originalCurrency;

        /// <summary>
        /// Unique Id to identify the register
        /// </summary>
        [WcfSerialization::DataMember(Name = "RegisterId", IsRequired = true, Order = 0)]
        public int RegisterId { get; set; }

        [WcfSerialization::DataMember(Name = "Ledger", IsRequired = false, Order = 1)]
        public string Ledger { get; set; }

        /// <summary>
        /// Branch Code where the transaction originated, this field will be provided by the Issuance.
        /// </summary>
        [WcfSerialization::DataMember(Name = "OperatingUnit", IsRequired = false, Order = 2)]
        public string OperatingUnit { get; set; }

        [WcfSerialization::DataMember(Name = "DepId", IsRequired = false, Order = 3)]
        public string DepId { get; set; }

        /// <summary>
        /// In this field, you will be sending the Product Code of PeopleSoft, it makes references to the line
        /// of business that is being affected and depends of the coverage, will be obtained from the information from Issuance.
        /// </summary>
        [WcfSerialization::DataMember(Name = "Product", IsRequired = false, Order = 4)]
        public string Product { get; set; }

        /// <summary>
        /// It is defined at the sponsor level or campaign level, at the level of the campaign it is optional,
        /// so if it is not defined at this level, it is taken from the Sponsor.
        /// </summary>
        [WcfSerialization::DataMember(Name = "Mcc", IsRequired = false, Order = 5)]
        public string Mcc { get; set; }

        /// <summary>
        /// Is the geographical code to identify the source of the transaction, the Mexico’s
        /// code is 48400, but the code will be sent by state, this information will be obtained from Issuance.
        /// </summary>
        [WcfSerialization::DataMember(Name = "Location", IsRequired = false, Order = 6)]
        public string Location { get; set; }

        /// <summary>
        /// This field is used to identify expense accounts.
        /// </summary>
        [WcfSerialization::DataMember(Name = "Function", IsRequired = false, Order = 7)]
        public string Function { get; set; }

        /// <summary>
        /// Reinsurance - Number of Affiliate if the Contract is affiliate select this number but if the contract is
        /// blank validate the Reinsurance and if the reinsurance is affiliate select this affiliate Number if not put blanks.
        /// </summary>
        [WcfSerialization::DataMember(Name = "Affiliate", IsRequired = false, Order = 8)]
        public string Affiliate { get; set; }

        /// <summary>
        /// Name of Sponsor
        /// </summary>
        [WcfSerialization::DataMember(Name = "LineDescription", IsRequired = false, Order = 9)]
        public string LineDescription { get; set; }

        /// <summary>
        /// Currency of the amount
        /// </summary>
        [WcfSerialization::DataMember(Name = "OriginalCurrency", IsRequired = false, Order = 10)]
        public string OriginalCurrency
        {
            get => _originalCurrency;
            set
            {
                if (value.Length > 3)
                    throw new FaultException("The OriginalCurrency field must not contain more than 3 characters.");
                _originalCurrency = value;
            }
        }

        /// <summary>
        /// Original amount
        /// </summary>
        [WcfSerialization::DataMember(Name = "OriginalAmount", IsRequired = false, Order = 11)]
        public decimal OriginalAmount { get; set; }

        /// <summary>
        /// The Distribution Channel Will be provided by Issuance
        /// </summary>
        [WcfSerialization::DataMember(Name = "DistributionChannel", IsRequired = false, Order = 12)]
        public string DistributionChannel { get; set; }

        /// <summary>
        /// Campaign code
        /// </summary>
        [WcfSerialization::DataMember(Name = "JrnlLnRef", IsRequired = false, Order = 13)]
        public string JrnlLnRef { get; set; }

        /// <summary>
        /// It is the PeopleSoft Project ID code. In the case of ABA will be sent '300000' and will be provided by SIAC.
        /// </summary>
        [WcfSerialization::DataMember(Name = "ProjectId", IsRequired = false, Order = 14)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Transaction Year
        /// </summary>
        [WcfSerialization::DataMember(Name = "Year", IsRequired = false, Order = 15)]
        public int? Year { get; set; }

        /// <summary>
        /// Police Effective Date Year
        /// </summary>
        [WcfSerialization::DataMember(Name = "PoliceYear", IsRequired = false, Order = 16)]
        public int? PoliceYear { get; set; }

        /// <summary>
        /// National amount
        /// </summary>
        [WcfSerialization::DataMember(Name = "MonetaryAmount", IsRequired = false, Order = 17)]
        public decimal? MonetaryAmount { get; set; }

        /// <summary>
        /// In this case will be Type SolCost
        /// </summary>
        [WcfSerialization::DataMember(Name = "TransactionCode", IsRequired = true, Order = 18)]
        public string TransactionCode { get; set; }

        /// <summary>
        /// Optional for validations
        /// </summary>
        [WcfSerialization::DataMember(Name = "AltAccount", IsRequired = false, Order = 19)]
        public string AltAccount { get; set; }

        /// <summary>
        /// Optional for validations
        /// </summary>
        [WcfSerialization::DataMember(Name = "PsAccount", IsRequired = false, Order = 20)]
        public string PsAccount { get; set; }


    }
}
