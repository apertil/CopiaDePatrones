using PatronesDeDiseño.Modelo;
using PatronesDeDiseño.Negocio;
using PatronesDeDiseño.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesDeDiseño.Vista.Prendas
{
    public partial class FrmBorrarPrenda : Form
    {
        public FrmBorrarPrenda()
        {
            InitializeComponent();
        }

        private void btnSalirBorrarPrenda_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarBorrarTipoPrenda_Click(object sender, EventArgs e)
        {
            ControlTipoDeprendas.BuscarExactoPrenda(txtBorrarTipoPrenda.Text.TrimStart().TrimEnd());
            if (ControlTipDeTejer.Result)
            {
               btnBorraTipoPrenda.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBorrarTipoPrenda.Text + Consts.ErrorTipoPrenda, "No se ha encontrado", MessageBoxButtons.OK);
            }
        }

        private void btnBorraTipoPrenda_Click(object sender, EventArgs e)
        {
            ControlTipoDeprendas.EliminarPrenda(PrendasViewModel.IdPren);
            if (ControlTipDeTejer.Result)
            {
                btnBorraTipoPrenda.Enabled = false;
                MessageBox.Show(txtBorrarTipoPrenda.Text + Consts.BorradoPrenda, "Borrado Correcto", MessageBoxButtons.OK);
            }
            else
            {
                btnBorraTipoPrenda.Enabled = false;
                MessageBox.Show(txtBorrarTipoPrenda.Text + Consts.BorradoErrorPrenda, "Borrado No Correcto", MessageBoxButtons.OK);
            }

        }
    }
}
