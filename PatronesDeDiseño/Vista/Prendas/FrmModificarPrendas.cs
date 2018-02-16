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
    public partial class FrmModificarPrendas : Form
    {
        public FrmModificarPrendas()
        {
            InitializeComponent();
        }

        private void btnSalirModificarLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarTipoPrenda_Click(object sender, EventArgs e)
        {
            ControlTipoDeprendas.BuscarExactoPrenda(txtBuscarTipoPrenda.Text.TrimStart().TrimEnd());
            if (ControlTipoDeprendas.Result)
            {
                btnModificaTipoPrenda.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBuscarTipoPrenda.Text + Consts.ErrorTipoPrenda, "No se ha encontrado", MessageBoxButtons.OK);
                txtBuscarTipoPrenda.Text = " ";
                txtModificaTipoPrenda.Text = " ";
            }
        }

        private void btnModificaTipoPrenda_Click(object sender, EventArgs e)
        {
            ControlTipoDeprendas.ModificarPrenda(PrendasViewModel.IdPren, txtModificaTipoPrenda.Text.TrimStart().TrimEnd());
            if (ControlTipoDeprendas.Result)
            {
                MessageBox.Show(txtModificaTipoPrenda.Text + Consts.ModificaPrenda, "Modificacion Correcta", MessageBoxButtons.OK);
                txtBuscarTipoPrenda.Text = " ";
                txtModificaTipoPrenda.Text = " ";
                btnModificaTipoPrenda.Enabled = false;

            }
            else
            {
                MessageBox.Show(txtModificaTipoPrenda.Text + Consts.ModificaErrorPrenda, "Modificacion NO Correcta", MessageBoxButtons.OK);
                txtBuscarTipoPrenda.Text = " ";
                txtModificaTipoPrenda.Text = " ";
                // btnModificaTipoTejer.Enabled = false;

            }
        }
    }
}
