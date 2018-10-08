using System;
using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class AccountingInformation
    {
        public Header Header { get; set; }
        public List<Detail> Detail { get; set; }
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
    public class Detail
    {
        /// <summary>
        /// Unique Id to identify the register
        /// </summary>

        public int RegisterId { get; set; }


        public string Ledger { get; set; }

        /// <summary>
        /// Branch Code where the transaction originated, this field will be provided by the Issuance.
        /// </summary>
 
        public string OperatingUnit { get; set; }

   
        public string DepId { get; set; }

        /// <summary>
        /// In this field, you will be sending the Product Code of PeopleSoft, it makes references to the line
        /// of business that is being affected and depends of the coverage, will be obtained from the information from Issuance.
        /// </summary>
       
        public string Product { get; set; }

        /// <summary>
        /// It is defined at the sponsor level or campaign level, at the level of the campaign it is optional,
        /// so if it is not defined at this level, it is taken from the Sponsor.
        /// </summary>
       
        public string Mcc { get; set; }

        /// <summary>
        /// Is the geographical code to identify the source of the transaction, the Mexico’s
        /// code is 48400, but the code will be sent by state, this information will be obtained from Issuance.
        /// </summary>
      
        public string Location { get; set; }

        /// <summary>
        /// This field is used to identify expense accounts.
        /// </summary>
     
        public string Function { get; set; }

        /// <summary>
        /// Reinsurance - Number of Affiliate if the Contract is affiliate select this number but if the contract is
        /// blank validate the Reinsurance and if the reinsurance is affiliate select this affiliate Number if not put blanks.
        /// </summary>
        
        public string Affiliate { get; set; }

        /// <summary>
        /// Name of Sponsor
        /// </summary>
        
        public string LineDescription { get; set; }

        /// <summary>
        /// Currency of the amount
        /// </summary>
       
        public string OriginalCurrency { get; set; }

        /// <summary>
        /// Original amount
        /// </summary>
  
        public decimal OriginalAmount { get; set; }

        /// <summary>
        /// The Distribution Channel Will be provided by Issuance
        /// </summary>
       
        public string DistributionChannel { get; set; }

        /// <summary>
        /// Campaign code
        /// </summary>
       
        public string JrnlLnRef { get; set; }

        /// <summary>
        /// It is the PeopleSoft Project ID code. In the case of ABA will be sent '300000' and will be provided by SIAC.
        /// </summary>
        
        public string ProjectId { get; set; }

        /// <summary>
        /// Transaction Year
        /// </summary>
        
        public int? Year { get; set; }

        /// <summary>
        /// Police Effective Date Year
        /// </summary>
        
        public int? PoliceYear { get; set; }

        /// <summary>
        /// National amount
        /// </summary>
        
        public decimal? MonetaryAmount { get; set; }

        /// <summary>
        /// In this case will be Type SolCost
        /// </summary>
        
        public string TransactionCode { get; set; }


        public string AltAccount { get; set; }

        /// <summary>
        /// Optional for validations
        /// </summary>

        public string PsAccount { get; set; }

    }
}
