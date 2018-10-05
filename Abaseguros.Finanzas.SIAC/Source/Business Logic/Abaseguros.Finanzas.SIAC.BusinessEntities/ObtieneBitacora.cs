using System;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
   public class ObtieneBitacora
    {
        public double idMensaje { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Mensaje { get; set; }
        public string Estado { get; set; }
    }
}
