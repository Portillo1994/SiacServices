using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
   public class ProcesaPreValidacion
    {
        public int BusinessUnit { get; set; }
        public int IdSistema { get; set; }
        public int IdPlaza { get; set; }
        public DateTime FechaValidacion { get; set; }
        public string Login { get; set; }
        public int CargaRO { get; set; }
    }
}
