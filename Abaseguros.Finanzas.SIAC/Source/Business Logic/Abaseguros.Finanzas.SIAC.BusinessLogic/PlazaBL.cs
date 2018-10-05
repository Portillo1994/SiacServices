using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class PlazaBL
    {
        DataAccess.PlazaDA _objPlazaDA = new DataAccess.PlazaDA();

        public List<BusinessEntities.Plaza> ObtienePlazas()
        {
            return _objPlazaDA.ObtienePlazas(-1);
        }

        public BusinessEntities.Plaza ObtienePlaza(int idPlaza)
        {
            List<BusinessEntities.Plaza> lstPlaza = new List<BusinessEntities.Plaza>();
            BusinessEntities.Plaza objPlaza = new BusinessEntities.Plaza();
            
            lstPlaza = _objPlazaDA.ObtienePlazas(idPlaza);

            foreach (BusinessEntities.Plaza objPlazaAux in lstPlaza)
            {
                objPlaza.IdPlaza = objPlazaAux.IdPlaza;
                objPlaza.Descripcion = objPlazaAux.Descripcion;
            }

            return objPlaza;
        }
    }
}
