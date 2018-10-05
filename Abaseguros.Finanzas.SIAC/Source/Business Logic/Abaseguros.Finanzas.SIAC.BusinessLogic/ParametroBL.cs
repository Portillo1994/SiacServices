
namespace Abaseguros.Finanzas.SIAC.BusinessLogic
{
    public class ParametroBL
    {
        DataAccess.ParametroDA _objParametroDA = new DataAccess.ParametroDA();
        public string ObtieneParametroVarchar(string sDescripcion)
        {
            return _objParametroDA.ObtieneParametroVarchar(sDescripcion);
        }
        public string ObtieneParametroVarchar(int ParametroId)
        {
            return _objParametroDA.ObtieneParametroVarchar(ParametroId);
        }
    }
}
