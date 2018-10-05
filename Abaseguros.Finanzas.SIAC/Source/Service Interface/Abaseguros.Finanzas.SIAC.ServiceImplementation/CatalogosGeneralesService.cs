//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using WCF = global::System.ServiceModel;
using System;

namespace Abaseguros.Finanzas.SIAC.ServiceImplementation
{
    /// <summary>
    /// Service Class - CatalogosGeneralesService
    /// </summary>
    [WCF::ServiceBehavior(Name = "CatalogosGeneralesService",
        Namespace = "http://abaseguros.com",
        InstanceContextMode = WCF::InstanceContextMode.PerSession,
        ConcurrencyMode = WCF::ConcurrencyMode.Single)]
    public abstract class CatalogosGeneralesServiceBase : Abaseguros.Finanzas.SIAC.ServiceContracts.ICatalogosGeneralesServiceContract
    {
        #region CatalogosGeneralesServiceContract Members

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.PlazaResponse ObtienePlaza(Abaseguros.Finanzas.SIAC.MessageContracts.ObtienePlazaRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.PlazasResponse ObtieneListadoPlazas()
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneParametroVarcharResponse ObtieneParametroVarchar(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneParametroVarcharRequest request)
        {
            return null;
        }

        public virtual Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneMonedasResponse ObtieneMonedas()
        {
            return null;
        }

        public virtual BusinessEntities.Moneda AgregaMoneda(BusinessEntities.Moneda moneda)
        {
            return null;
        }

        #endregion
    }

    public partial class CatalogosGeneralesService : CatalogosGeneralesServiceBase
    {
        #region CatalogosGeneralesServiceContract Members

        BusinessLogic.PlazaBL _objPlazaBL = new BusinessLogic.PlazaBL();
        BusinessLogic.MonedaBL _objMonedaBL = new BusinessLogic.MonedaBL();
        BusinessLogic.ParametroBL _objParametroBL = new BusinessLogic.ParametroBL();

        public override Abaseguros.Finanzas.SIAC.MessageContracts.PlazaResponse ObtienePlaza(Abaseguros.Finanzas.SIAC.MessageContracts.ObtienePlazaRequest request)
        {
            MessageContracts.PlazaResponse objPlazasResponse = new MessageContracts.PlazaResponse();
            DataContracts.PlazaDC objPlazaDC = new DataContracts.PlazaDC();
            BusinessEntities.Plaza objPlaza = new BusinessEntities.Plaza();

            objPlaza = _objPlazaBL.ObtienePlaza(request.PlazaId);

            objPlazaDC.IdPlaza = objPlaza.IdPlaza;
            objPlazaDC.Descripcion = objPlaza.Descripcion;
            objPlazasResponse.Plaza = objPlazaDC;

            return objPlazasResponse;
        }

        public override Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneMonedasResponse ObtieneMonedas()
        {
            MessageContracts.ObtieneMonedasResponse objResponse = new MessageContracts.ObtieneMonedasResponse();
            DataContracts.MonedaDC objMonedaDC = new DataContracts.MonedaDC();
            List<BusinessEntities.Moneda> objMonedas = new List<BusinessEntities.Moneda>();

            objMonedas = _objMonedaBL.ObtieneMonedas();
            DataContracts.MonedaCollectionDC lstMonedas = new DataContracts.MonedaCollectionDC();
            foreach (BusinessEntities.Moneda moneda in objMonedas)
            {
                objMonedaDC = new DataContracts.MonedaDC()
                {
                    idMoneda = moneda.idMoneda,
                    Nombre = moneda.Nombre,
                    cveMoneda = moneda.cveMoneda
                };
                lstMonedas.Add(objMonedaDC);
            }
            objResponse.Monedas = lstMonedas;
            return objResponse;
        }

        public override Abaseguros.Finanzas.SIAC.MessageContracts.PlazasResponse ObtieneListadoPlazas()
        {
            MessageContracts.PlazasResponse objPlazasResponse = new MessageContracts.PlazasResponse();
            List<BusinessEntities.Plaza> lstPlaza = new List<BusinessEntities.Plaza>();
            DataContracts.PlazaCollectionDC objPlazaCollectionDC = new DataContracts.PlazaCollectionDC();
            DataContracts.PlazaDC objPlazaDC = null;

            lstPlaza = _objPlazaBL.ObtienePlazas();

            foreach (BusinessEntities.Plaza objPlaza in lstPlaza)
            {
                objPlazaDC = new DataContracts.PlazaDC();
                objPlazaDC.IdPlaza = objPlaza.IdPlaza;
                objPlazaDC.Descripcion = objPlaza.Descripcion;

                objPlazaCollectionDC.Add(objPlazaDC);
            }

            objPlazasResponse.Plazas = objPlazaCollectionDC;

            return objPlazasResponse;
        }

        public override Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneParametroVarcharResponse ObtieneParametroVarchar(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneParametroVarcharRequest request)
        {
            string sValorVarchar = "";
            MessageContracts.ObtieneParametroVarcharResponse objObtieneParametroVarcharResponse = new MessageContracts.ObtieneParametroVarcharResponse();

            if (String.IsNullOrEmpty(request.Descripcion)) //Buscar por Id
                sValorVarchar = _objParametroBL.ObtieneParametroVarchar(request.idParametro);
            else
                sValorVarchar = _objParametroBL.ObtieneParametroVarchar(request.Descripcion);
            
            objObtieneParametroVarcharResponse.ValorVarchar = sValorVarchar;
            return objObtieneParametroVarcharResponse;
        }

        public override BusinessEntities.Moneda AgregaMoneda(BusinessEntities.Moneda moneda)
        {
            return _objMonedaBL.AgregaMoneda(moneda);
        }
        #endregion
    }
}