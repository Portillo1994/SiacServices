using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Abaseguros.Finanzas.SIAC.BusinessEntities;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class ValidacionSiacDA
    {
        SIACModeloDataContext _dbContext = new SIACModeloDataContext();

        public List<BusinessEntities.ErrorObj> GetJournalValidation(AccountingInformation xmlJournal)
       {
            AccountingInformation accounting = xmlJournal;

            List<BusinessEntities.ErrorObj> lstErrorObjs = new List<BusinessEntities.ErrorObj>();
            BusinessEntities.ErrorObj objAccountingInformation = null;

           var stringWriter = new StringWriter();
           var serializer = new XmlSerializer(accounting.GetType());
           serializer.Serialize(stringWriter, accounting);

            var vResult = _dbContext.spGetSIACValidation(stringWriter.ToString());


            foreach (var item in vResult.ToList())
            {
                objAccountingInformation = new BusinessEntities.ErrorObj
                {
                    ProcessId = item.ProcessId,
                    ErrorDescription = item.ErrorDescription,
                    ValidationId = item.ValidationId,
                    RecordId = item.RecordId
                };
                lstErrorObjs.Add(objAccountingInformation);
            }

            return lstErrorObjs;

        }
        public List<BusinessEntities.ObtieneBitacora> ObtieneBitacora(int idTipoValidacion, int businessUnit, int idSistema, int idPlaza, DateTime fechaValidacion)
        {
            List<BusinessEntities.ObtieneBitacora> lstObtieneBitacora = new List<BusinessEntities.ObtieneBitacora>();
            BusinessEntities.ObtieneBitacora objObtieneBitacora = null;
            var vResultado = _dbContext.spSelBitacora(idTipoValidacion, businessUnit, idSistema, idPlaza, fechaValidacion);

            foreach (var item in vResultado)
            {
                objObtieneBitacora = new BusinessEntities.ObtieneBitacora();
                objObtieneBitacora.idMensaje = Convert.ToDouble(item.idMensaje);
                objObtieneBitacora.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                objObtieneBitacora.Mensaje = item.Mensaje;
                objObtieneBitacora.Estado = item.Estado;
                lstObtieneBitacora.Add(objObtieneBitacora);
            }

            return lstObtieneBitacora;
        }

        public List<BusinessEntities.ObtieneBitacoraHistorial> ObtieneBitacoraHistorial(int idTipoValidacion, int businessUnit, int idSistema, int idPlaza, DateTime fechaValidacion)
        {
            List<BusinessEntities.ObtieneBitacoraHistorial> lstObtieneBitacoraHistorial = new List<BusinessEntities.ObtieneBitacoraHistorial>();
            BusinessEntities.ObtieneBitacoraHistorial objObtieneBitacoraHistorial = null;
            BusinessEntities.ObtieneBitacora objObtieneBitacora = null;
            var vResultado = _dbContext.spSelBitacoraHistorial(idTipoValidacion, businessUnit, idSistema, idPlaza, fechaValidacion);

            foreach (var item in vResultado)
            {
                objObtieneBitacoraHistorial = new BusinessEntities.ObtieneBitacoraHistorial();
                objObtieneBitacora = new BusinessEntities.ObtieneBitacora();
                objObtieneBitacora.idMensaje = Convert.ToDouble(item.idMensaje);
                objObtieneBitacora.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                objObtieneBitacora.Mensaje = item.Mensaje;
                objObtieneBitacora.Estado = item.Estado;
                objObtieneBitacoraHistorial.ObtieneBitacora = objObtieneBitacora;
                objObtieneBitacoraHistorial.IdValidacion = Convert.ToInt32(item.idValidacion);
                lstObtieneBitacoraHistorial.Add(objObtieneBitacoraHistorial);
            }

            return lstObtieneBitacoraHistorial;
        }

        public List<BusinessEntities.ObtieneBitacora> ObtieneBitacoraCargaReporte(int businessUnit, int tipoArchivo, int tipoValidacion, DateTime fecha, string usuario)
        {
            List<BusinessEntities.ObtieneBitacora> lstObtieneBitacora = new List<BusinessEntities.ObtieneBitacora>();
            BusinessEntities.ObtieneBitacora objObtieneBitacora = null;
            var vResultado = _dbContext.spSelBitacoraCargaReporte(businessUnit, tipoArchivo, tipoValidacion, fecha, usuario);

            foreach (var item in vResultado)
            {
                objObtieneBitacora = new BusinessEntities.ObtieneBitacora();
                objObtieneBitacora.idMensaje = Convert.ToDouble(item.idMensaje);
                objObtieneBitacora.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                objObtieneBitacora.Mensaje = item.Mensaje;
                objObtieneBitacora.Estado = item.Estado;
                lstObtieneBitacora.Add(objObtieneBitacora);
            }

            return lstObtieneBitacora;
        }

        public string ObtieneConfiguracionXSistema(int businessUnit, int sistemaid, int plazaid, string configuracion)
        {
            var vResultado = _dbContext.spSelConfiguracionXSistema(businessUnit, sistemaid, plazaid, configuracion);

            string valor = "";
            foreach (var item in vResultado)
            {
                valor = item.Valor;
            }

            return valor;
        }

    }
}
