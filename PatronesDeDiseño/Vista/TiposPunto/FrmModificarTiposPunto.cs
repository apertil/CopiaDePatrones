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

namespace PatronesDeDiseño.Vista.TiposPunto
{
    public partial class FrmModificarTiposPunto : Form
    {
        public FrmModificarTiposPunto()
        {
            InitializeComponent();
        }

        private void btnSalirModificarLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            ControlTipDeTejer.BuscarExactoTipoDetejer(txtBuscarTipoTejer.Text.TrimStart().TrimEnd());

            if (ControlTipDeTejer.Result)
            {
                btnModificaTipoTejer.Enabled = true;
            }

            else
            {
                MessageBox.Show(txtBuscarTipoTejer.Text + Consts.ErrorTipoPunto, "No se ha encontrado", MessageBoxButtons.OK);
                txtBuscarTipoTejer.Text = " ";
                txtModificaTipoTejer.Text = " ";
                
            }
        }

        private void btnModificaTipoTejer_Click(object sender, EventArgs e)
        {
            ControlTipDeTejer.ModificarTiposDeTejer(TipDeTejerViewModel.IdTipoDeTejer, txtModificaTipoTejer.Text.TrimStart().TrimEnd());
            if (ControlTipDeTejer.Result)
            {
                MessageBox.Show(txtModificaTipoTejer.Text + Consts.ModificaTptejer, "Modificacion Correcta", MessageBoxButtons.OK);
                txtBuscarTipoTejer.Text = " ";
                txtModificaTipoTejer.Text = " ";
                btnModificaTipoTejer.Enabled = false;
               
            }
            else
            {
                MessageBox.Show(txtModificaTipoTejer.Text + Consts.ModificaErrorTptejer, "Modificacion NO Correcta", MessageBoxButtons.OK);
                txtBuscarTipoTejer.Text = " ";
                txtModificaTipoTejer.Text = " ";
                // btnModificaTipoTejer.Enabled = false;
              
            }
        }
    }
}
