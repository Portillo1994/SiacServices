using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abaseguros.Finanzas.SIAC.BusinessEntities
{
    public class Periodo
    {
        private int businessUnit;

        public int BusinessUnit
        {
            get { return businessUnit; }
            set { businessUnit = value; }
        }

        private int periodoId;

        public int PeriodoId
        {
            get { return periodoId; }
            set { periodoId = value; }
        }

        private int estadoId;

        public int EstadoId
        {
            get { return estadoId; }
            set { estadoId = value; }
        }

        private DateTime fechaModificacion;

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        private string usuarioModificacion;

        public string UsuarioModificacion
        {
            get { return usuarioModificacion; }
            set { usuarioModificacion = value; }
        }
    }
}
