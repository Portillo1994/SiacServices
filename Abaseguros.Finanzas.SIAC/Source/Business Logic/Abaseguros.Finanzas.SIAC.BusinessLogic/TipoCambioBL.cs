using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class TipoCambioBL
    {
        DataAccess.TipoCambioDA _objTipoCambioDA = new DataAccess.TipoCambioDA();

        public List<BusinessEntities.TipoCambio> ObtieneTipoCambio(int BusinessUnit, int Anio, int Mes, int Tipo, string Moneda)
        {
            return _objTipoCambioDA.ObtieneTipoCambio(BusinessUnit, Anio, Mes, Tipo, Moneda);
        }
    }
}
