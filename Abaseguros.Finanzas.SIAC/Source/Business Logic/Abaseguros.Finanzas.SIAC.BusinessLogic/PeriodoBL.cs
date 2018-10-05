using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class PeriodoBL
    {
        DataAccess.PeriodoDA _objPeriodoDA = new DataAccess.PeriodoDA();

        public List<BusinessEntities.Periodo> ObtienePeriodos(int BusinessUnit, int Anio)
        {
            return _objPeriodoDA.ObtienePeriodos(BusinessUnit, Anio);
        }

        public void actualizaPeriodo(int BusinessUnit, int Periodo, int Estado, string Usuario)
        {
            _objPeriodoDA.ActualizaPeriodo(BusinessUnit, Periodo, Estado, Usuario);
        }
    }
}
