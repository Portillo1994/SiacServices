using System.Collections.Generic;
using System;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class TipoCambioDA
    {
        public List<BusinessEntities.TipoCambio> ObtieneTipoCambio(int BusinessUnit, int Anio, int Mes, int Tipo, String Moneda)
        {
            List<BusinessEntities.TipoCambio> lstTipoCambio = new List<BusinessEntities.TipoCambio>();
            BusinessEntities.TipoCambio tcObj = null;

            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var tiposcambio = dbContext.spSelTipoCambio(BusinessUnit, Anio, Mes, Tipo, Moneda);
                foreach (var tc in tiposcambio)
                {
                    tcObj = new BusinessEntities.TipoCambio()
                    {
                        BusinessUnit = Convert.ToInt32(tc.BusinessUnit),
                        Fecha = tc.ExchangeRateDate,
                        TipoCambioValor = tc.ExchangeRate.GetValueOrDefault(0),
                        FechaModificacion = tc.LastModified.GetValueOrDefault(DateTime.MinValue)
                    };
                    lstTipoCambio.Add(tcObj);
                }
            }
            return (lstTipoCambio);
        }

    }
}
