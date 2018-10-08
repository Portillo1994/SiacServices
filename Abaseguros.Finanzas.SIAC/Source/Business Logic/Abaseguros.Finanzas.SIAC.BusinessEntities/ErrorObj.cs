using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
   public class ErrorObj
    {
        public int ProcessId { get; set; }
        public int RecordId { get; set; }
        public int ValidationId { get; set; }
        public string ErrorDescription { get; set; }    
    }
}
