using System;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class ParametroDA
    {
        SIACModeloDataContext _dbContext = new SIACModeloDataContext();
        public string ObtieneParametroVarchar(string sDescripcion)
        {
            BusinessEntities.Parametro objParametro = this.ObtieneParametro(sDescripcion, null);
            return objParametro.vcValor;
        }
        public string ObtieneParametroVarchar(int ParametroId)
        {
            string sValor = "";
            BusinessEntities.Parametro objParametro = this.ObtieneParametro(null, ParametroId);
            return sValor;
        }

        private BusinessEntities.Parametro ObtieneParametro(string descripcion, int? parametroId)
        {
            BusinessEntities.Parametro objParametro = new BusinessEntities.Parametro();
            var vResultado = _dbContext.spObtieneParametro(descripcion, parametroId);

            foreach (var item in vResultado)
            {
                objParametro.idParametro = item.idParametro;
                objParametro.Descripcion = item.Descripcion;
                objParametro.vcValor = item.vcValor;
                objParametro.iValor = item.iValor == null ? 0 : Convert.ToInt32(item.iValor);
                objParametro.mValor = item.mValor == null ? 0 : Convert.ToDouble(item.mValor);
                objParametro.dValor = item.dValor == null ? new DateTime() : Convert.ToDateTime(item.dValor);

                break;
            }

            return objParametro;
        }
    }
}
