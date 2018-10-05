using Abaseguros.Finanzas.SIAC.BusinessEntities;
using System.Collections.Generic;

namespace Abaseguros.Finanzas.SIAC.DataAccess
{
    public class BusinessUnitDA
    {
        public List<BusinessEntities.BusinessUnitObj> GetBusinessUnits()
        {
            List<BusinessEntities.BusinessUnitObj> lstBU = new List<BusinessEntities.BusinessUnitObj>();
            BusinessEntities.BusinessUnitObj buObj = null;

            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var bus = dbContext.spSelBusinessUnits();
                foreach (var bu in bus)
                {
                    buObj = new BusinessUnitObj()
                    {
                        BusinessUnit = bu.BusinessUnit,
                        Name = bu.Name,
                        Currency = bu.Currency,
                        BusinessUnitPS = bu.BusinessUnitPS
                    };
                    lstBU.Add(buObj);
                }
            }
            return (lstBU);
        }

        public BusinessUnitObj AgregaBusinessUnit(BusinessUnitObj businessUnit)
        {
            BusinessUnitObj buObj = null;
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var bus = dbContext.spInsBusinessUnit(businessUnit.BusinessUnit, businessUnit.Name, businessUnit.Currency, businessUnit.BusinessUnitPS);
                foreach (var bu in bus)
                {
                    buObj = new BusinessUnitObj()
                    {
                        BusinessUnit = int.Parse(bu.Code),
                        Name = bu.Name,
                        Currency = bu.Currency_Code,
                        BusinessUnitPS = bu.BusinessUnitPS.GetValueOrDefault(0)
                    };
                }
            }
            return buObj;
        }

        public BusinessUnitObj ActualizaBusinessUnit(BusinessUnitObj businessUnit)
        {
            BusinessUnitObj buObj = null;
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var bus = dbContext.spUpdBusinessUnit(businessUnit.BusinessUnit, businessUnit.Name, businessUnit.Currency, businessUnit.BusinessUnitPS);
                foreach (var bu in bus)
                {
                    buObj = new BusinessUnitObj()
                    {
                        BusinessUnit = int.Parse(bu.Code),
                        Name = bu.Name,
                        Currency = bu.Currency_Code,
                        BusinessUnitPS = bu.BusinessUnitPS.GetValueOrDefault(0)
                    };
                }
            }
            return buObj;
        }

        public List<BusinessEntities.SistemaObj> obtenerSistemas()
        {
            List<BusinessEntities.SistemaObj> lstSistema = new List<BusinessEntities.SistemaObj>();
            BusinessEntities.SistemaObj sistemaObj = null;

            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var sistemas = dbContext.spSelSistemas();
                foreach (var sis in sistemas)
                {
                    sistemaObj = new SistemaObj()
                    {
                        idSistema = sis.idSistema,
                        Nombre = sis.Nombre
                    };
                    lstSistema.Add(sistemaObj);
                }
            }
            return (lstSistema);
        }

        public SistemaObj AgregaSistema(SistemaObj sistema)
        {
            SistemaObj sistemaObj = null;
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var sistemaAgregado = dbContext.spInsSistema(sistema.idSistema, sistema.Nombre);
                foreach (var sys in sistemaAgregado)
                {
                    sistemaObj = new SistemaObj()
                    {
                        idSistema = sys.idSistema,
                        Nombre = sys.Nombre
                    };
                }
            }
            return sistemaObj;
        }

        public SistemaObj ActualizaSistema(SistemaObj sistema)
        {
            SistemaObj sistemaObj = null;
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var sistemaActualizado = dbContext.spUpdSistema(sistema.idSistema, sistema.Nombre);
                foreach (var sys in sistemaActualizado)
                {
                    sistemaObj = new SistemaObj()
                    {
                        idSistema = sys.idSistema,
                        Nombre = sys.Nombre
                    };
                }
            }
            return sistemaObj;
        }

        public void GuardaConfiguracionSistema(int BusinessUnit, int SistemaId, string Proceso, string SourceId, string ApplJrnlId, string Source)
        {
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                dbContext.spUpdConfiguracionSistema(BusinessUnit, SistemaId, Proceso, SourceId, ApplJrnlId, Source);
            }
        }

        public List<ConfiguracionSistemaObj> ObtieneConfiguracionSistema(int BusinessUnit, int SistemaId)
        {
            List<ConfiguracionSistemaObj> lstConfiguraciones = new List<ConfiguracionSistemaObj>();
            ConfiguracionSistemaObj configuracionObj = null;
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var configuracionDB = dbContext.spSelConfiguracionSistema(BusinessUnit, SistemaId);
                foreach (var conf in configuracionDB)
                {
                    configuracionObj = new ConfiguracionSistemaObj()
                    {
                        BusinessUnit = conf.BusinessUnit.GetValueOrDefault(0),
                        SistemaId = conf.SistemaId.GetValueOrDefault(0),
                        Configuracion = conf.Configuracion.Trim(),
                        Valor = conf.Valor.Trim(),
                        Descripcion = conf.Descripcion.Trim()
                    };
                    lstConfiguraciones.Add(configuracionObj);
                }
            }
            return lstConfiguraciones;
        }

        public SourceSistemaObj ObtieneSourceSistema(int BusinessUnit, int SistemaId)
        {
            SourceSistemaObj sourceObj = null;
            using (SIACModeloDataContext dbContext = new SIACModeloDataContext())
            {
                var sourceDB = dbContext.spSelSourceApplJrnl(BusinessUnit, SistemaId);
                foreach (var conf in sourceDB)
                {
                    sourceObj = new SourceSistemaObj()
                    {
                        BusinessUnit = int.Parse(conf.BusinessUnit),
                        SistemaId = conf.idSistema,
                        SourceId = conf.SourceId.Trim(),
                        ApplJrnlId = conf.Appl_Jrnl_Id.Trim(),
                        Source = conf.Source.Trim()
                    };
                }
            }
            return sourceObj;
        }
    }
}