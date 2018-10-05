using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class MonedaDA
    {
        public List<BusinessEntities.Moneda> ObtieneMonedas()
        {
            List<BusinessEntities.Moneda> lstMonedas = new List<BusinessEntities.Moneda>();
            BusinessEntities.Moneda monedaObj = null;

            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var monedas = dbContext.spSelMonedas();
                foreach (var moneda in monedas)
                {
                    monedaObj = new BusinessEntities.Moneda()
                    {
                        idMoneda = moneda.idMoneda,
                        Nombre = moneda.Nombre,
                        cveMoneda = moneda.cveMoneda
                    };
                    lstMonedas.Add(monedaObj);
                }
            }
            return (lstMonedas);
        }

        public BusinessEntities.Moneda AgregaMoneda(BusinessEntities.Moneda moneda)
        {
            BusinessEntities.Moneda monedaObj = null;
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var monedas = dbContext.spInsMoneda(moneda.cveMoneda, moneda.Nombre);
                foreach (var mon in monedas)
                {
                    monedaObj = new BusinessEntities.Moneda()
                    {
                        idMoneda = mon.idMoneda,
                        Nombre = mon.Nombre,
                        cveMoneda = mon.cveMoneda
                    };
                }
            }
            return (monedaObj);
        }
    }
}
