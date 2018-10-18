using System;
using System.Collections.Generic;
using Abaseguros.Finanzas.SIAC.BusinessEntities;

namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class ValidacionSiacBL
    {
        DataAccess.ValidacionSiacDA _objValidacionSiacDA = new DataAccess.ValidacionSiacDA();
        public List<BusinessEntities.ObtieneBitacora> ObtieneBitacora(int idTipoValidacion, int businessUnit, int idSistema, int idPlaza, DateTime fechaValidacion)
        {
            return _objValidacionSiacDA.ObtieneBitacora(idTipoValidacion, businessUnit, idSistema, idPlaza, fechaValidacion);
        }

        public List<BusinessEntities.ObtieneBitacoraHistorial> ObtieneBitacoraHistorial(int idTipoValidacion, int businessUnit, int idSistema, int idPlaza, DateTime fechaValidacion)
        {
            return _objValidacionSiacDA.ObtieneBitacoraHistorial(idTipoValidacion, businessUnit, idSistema, idPlaza, fechaValidacion);
        }

        public List<BusinessEntities.ObtieneBitacora> ObtieneBitacoraCargaReporte(int businessUnit, int tipoArchivo, int tipoValidacion, DateTime fecha, string usuario)
        {
            return _objValidacionSiacDA.ObtieneBitacoraCargaReporte(businessUnit, tipoArchivo, tipoValidacion, fecha, usuario);
        }

        public List<BusinessEntities.ErrorObj> GetJournalValidation(AccountingInformation xmlJournal)
        {
            return _objValidacionSiacDA.GetVocuherValidation(xmlJournal);
        }

        public string ObtieneConfiguracionXSistema(int businessUnit, int sistemaid, int plazaid, string configuracion)
        {
            return _objValidacionSiacDA.ObtieneConfiguracionXSistema(businessUnit, sistemaid, plazaid, configuracion);
        }

    }
}
