//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using WCF = global::System.ServiceModel;
using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.ServiceImplementation
{	
	/// <summary>
	/// Service Class - TipoCambioService
	/// </summary>
	[WCF::ServiceBehavior(Name = "TipoCambioService", 
		Namespace = "http://abaseguros.com", 
		InstanceContextMode = WCF::InstanceContextMode.PerSession, 
		ConcurrencyMode = WCF::ConcurrencyMode.Single )]
	public abstract class TipoCambioServiceBase : Abaseguros.Finanzas.SIAC.ServiceContracts.ITipoCambioServiceContract
	{
		#region TipoCambioServiceContract Members

		public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneTipoCambioResponse ObtieneTipoCambio(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneTipoCambioRequest request)
		{
			return null;
		}

		#endregion		
		
	}
	
	public partial class TipoCambioService : TipoCambioServiceBase
	{
        BusinessLogic.TipoCambioBL _objTipoCambioBL = new BusinessLogic.TipoCambioBL();
        public override Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneTipoCambioResponse ObtieneTipoCambio(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneTipoCambioRequest request)
        {
            MessageContracts.ObtieneTipoCambioResponse msgObtieneTipoCambioResponse = new MessageContracts.ObtieneTipoCambioResponse();
            List<BusinessEntities.TipoCambio> lstTipoCambio = new List<BusinessEntities.TipoCambio>();

            DataContracts.TipoCambioDC objTipoCambioDC = null;
            DataContracts.TipoCambioCollectionDC lstTipoCambioCollectionDC = new DataContracts.TipoCambioCollectionDC();

            lstTipoCambio = _objTipoCambioBL.ObtieneTipoCambio(request.BusinessUnit, request.Anio, request.Mes, request.Tipo, request.Moneda);
            foreach (BusinessEntities.TipoCambio objTipoCambio in lstTipoCambio)
            {
                objTipoCambioDC = new DataContracts.TipoCambioDC();
                objTipoCambioDC.BusinessUnit = objTipoCambio.BusinessUnit;
                objTipoCambioDC.Fecha = objTipoCambio.Fecha;
                objTipoCambioDC.TipoCambio = objTipoCambio.TipoCambioValor;
                objTipoCambioDC.FechaModificacion = objTipoCambio.FechaModificacion;
                lstTipoCambioCollectionDC.Add(objTipoCambioDC);
            }

            msgObtieneTipoCambioResponse.TiposCambio = lstTipoCambioCollectionDC;
            return msgObtieneTipoCambioResponse;
        }

	}
	
}

