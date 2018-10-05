using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class PeriodoDA
    {
        public List<BusinessEntities.Periodo> ObtienePeriodos(int BusinessUnit, int Anio)
        {
            List<BusinessEntities.Periodo> lstPeriodo = new List<BusinessEntities.Periodo>();
            BusinessEntities.Periodo perObj = null;

            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var periodos = dbContext.spSelPeriodos(BusinessUnit, Anio);
                foreach (var per in periodos)
                {
                    perObj = new BusinessEntities.Periodo()
                    {
                        BusinessUnit = per.BusinessUnit,
                        PeriodoId = per.idPeriodo,
                        EstadoId = per.idEstado.GetValueOrDefault(),
                        FechaModificacion = per.FechaModificacion,
                        UsuarioModificacion = per.UsuarioModificacion
                    };
                    lstPeriodo.Add(perObj);
                }
            }
            return (lstPeriodo);
        }

        public void ActualizaPeriodo(int BusinessUnit, int Periodo, int Estado, string Usuario)
        {
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                dbContext.spUpdPeriodo(BusinessUnit, Periodo, Estado, Usuario);
            }
        }
    }
}
