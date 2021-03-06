//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Net.Security;
using WCF = global::System.ServiceModel;

namespace Abaseguros.Finanzas.SIAC.ServiceContracts
{
    /// <summary>
    /// Service Contract Class - ValidacionesSiacServiceContract
    /// </summary>
    [WCF::ServiceContract(Namespace = "http://abaseguros.com", Name = "ValidacionesSiacServiceContract", SessionMode = WCF::SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public partial interface IValidacionesSiacServiceContract
    {
        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtieneBitacora", ProtectionLevel = ProtectionLevel.None)]
        Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneBitacoraResponse ObtieneBitacora(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneBitacoraRequest request);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtieneBitacoraHistorial", ProtectionLevel = ProtectionLevel.None)]
        Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneBitacoraHistorialResponse ObtieneBitacoraHistorial(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneBitacoraRequest request);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtieneBitacoraCargaReporte", ProtectionLevel = ProtectionLevel.None)]
        Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneBitacoraResponse ObtieneBitacoraCargaReporte(Abaseguros.Finanzas.SIAC.MessageContracts.ObtieneBitacoraReporteRequest request);

        [WCF::OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "AccountingInformation", ProtectionLevel = ProtectionLevel.None)]
        Abaseguros.Finanzas.SIAC.MessageContracts.VoucherInformationResponse GetVoucherValidation(
            Abaseguros.Finanzas.SIAC.MessageContracts.VoucherInformationRequest request);


    }
}

