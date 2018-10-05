using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abaseguros.Finanzas.SIAC.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            PeriodoServiceContractClient proxyPeriodo = new PeriodoServiceContractClient();
            List<Abaseguros.Finanzas.SIAC.BusinessEntities.Periodo> listaPeriodos = new List<Abaseguros.Finanzas.SIAC.BusinessEntities.Periodo>();
            Abaseguros.Finanzas.SIAC.BusinessEntities.Periodo objPeriodo;
            var resultado = proxyPeriodo.ObtienePeriodos();
            foreach (var periodo in resultado)
            {
                objPeriodo = new Abaseguros.Finanzas.SIAC.BusinessEntities.Periodo()
                {
                    IdPeriodo = periodo.IdPeriodo,
                    IdEstado = periodo.IdEstado,
                    FechaModificacion = periodo.FechaModificacion
                };
                listaPeriodos.Add(objPeriodo);
            }
            SearchText.Text = listaPeriodos.Count.ToString();
        }
    }
}