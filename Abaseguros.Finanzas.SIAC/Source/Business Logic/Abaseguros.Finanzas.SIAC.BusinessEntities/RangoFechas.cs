using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class RangoFechas
    {
        private DateTime fechaInicial;

        public DateTime FechaInicial
        {
            get { return fechaInicial; }
            set { fechaInicial = value; }
        }

        private DateTime fechaFinal;

        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }
    }
}
