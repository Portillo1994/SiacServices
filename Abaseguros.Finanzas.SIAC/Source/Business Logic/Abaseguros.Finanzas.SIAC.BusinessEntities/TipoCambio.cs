using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class TipoCambio
    {
        private int businessUnit;

        public int BusinessUnit
        {
            get { return businessUnit; }
            set { businessUnit = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private decimal tipoCambioValor;

        public decimal TipoCambioValor
        {
            get { return tipoCambioValor; }
            set { tipoCambioValor = value; }
        }

        private DateTime fechaModificacion;

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }
    }
}
