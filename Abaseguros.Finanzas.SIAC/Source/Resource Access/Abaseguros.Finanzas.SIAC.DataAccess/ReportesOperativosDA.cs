using System;
using System.Collections.Generic;
namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class ReportesOperativosDA
    {
        SIACModeloDataContext _dbContext = new SIACModeloDataContext();

        public List<BusinessEntities.HistorialRO> obtieneHistorialRO(DateTime? FechaValidacion)
        {
            List<BusinessEntities.HistorialRO> ListaHistorial = new List<BusinessEntities.HistorialRO>();
            var historial = _dbContext.spSelHistorialCargaRO(FechaValidacion);
            foreach (var his in historial)
            {
                BusinessEntities.HistorialRO hisObj = new BusinessEntities.HistorialRO()
                {
                    idRutasArchivos = his.idRutasArchivos,
                    TipoArchivo = his.TipoArchivo,
                    Nombre = his.Nombre,
                    Plaza = his.Plaza,
                    Sistema = his.Sistema,
                    Usuario = his.Usuario,
                    FechaModificacion = his.FechaModificacion,
                    Estatus = his.Estatus
                };
                ListaHistorial.Add(hisObj);
            }
            return (ListaHistorial);
        }

        public int InsertaParametroReporte(BusinessEntities.InsertaParametroReporte objInsertaParametroReporte)
        {
            System.Nullable<int> idSesion = 0;

            _dbContext.spInsertaParametroReportes(objInsertaParametroReporte.IdRutaArchivos, objInsertaParametroReporte.BusinessUnit, objInsertaParametroReporte.IdSistema, objInsertaParametroReporte.IdPlaza, objInsertaParametroReporte.FechaValidacion, objInsertaParametroReporte.Login, ref idSesion);
            return Convert.ToInt32(idSesion);
        }
    }
}
