using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class ReporteMonitoreoPCW
    {
        public string Compania { get; set; }
        public string Archivo { get; set; }
        public int ProcesoId { get; set; }
        public int VoucherABA { get; set; }
        public DateTime FechaContable { get; set; }
        public string Sistema { get; set; }
        public string Plaza { get; set; }
        public string Estado { get; set; }
    }
}
