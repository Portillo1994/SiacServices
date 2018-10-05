using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class PlazaDA
    {
        public List<BusinessEntities.Plaza> ObtienePlazas(int idPlaza)
        {
            List<BusinessEntities.Plaza> lstPlaza = new List<BusinessEntities.Plaza>();
            BusinessEntities.Plaza plObj = null;

            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var plazas = dbContext.spSelPlaza(idPlaza);
                foreach (var pl in plazas)
                {
                    plObj = new BusinessEntities.Plaza()
                    {
                        IdPlaza = pl.idPlaza,
                        Descripcion = pl.Descripcion
                    };
                    lstPlaza.Add(plObj);
                }
            }
            return (lstPlaza);
        }
    }
}
