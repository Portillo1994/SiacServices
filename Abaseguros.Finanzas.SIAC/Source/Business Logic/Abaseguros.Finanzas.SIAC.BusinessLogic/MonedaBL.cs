using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class MonedaBL
    {
        DataAccess.MonedaDA _objMonedaDA = new DataAccess.MonedaDA();

        public List<BusinessEntities.Moneda> ObtieneMonedas()
        {
            return _objMonedaDA.ObtieneMonedas();
        }

        public BusinessEntities.Moneda AgregaMoneda(BusinessEntities.Moneda moneda)
        {
            return _objMonedaDA.AgregaMoneda(moneda);
        }
    }
}
