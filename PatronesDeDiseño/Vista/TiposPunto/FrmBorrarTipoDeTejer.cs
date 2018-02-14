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
    public partial class FrmBorrarTipoDeTejer : Form
    {
        public FrmBorrarTipoDeTejer()
        {
            InitializeComponent();
        }

        private void btnBuscarBorrarTipo_Click(object sender, EventArgs e)
        {
            ControlTipDeTejer.BuscarExactoTipoDetejer(txtBorrarTipoTejido.Text.Trim());
            if (ControlTipDeTejer.Result)
            {
                btnBorraTipo.Enabled = true;
            }
            else
            {
                MessageBox.Show(Consts.Tptejer + Consts.ErrorTipoPunto, "No se ha encontrado", MessageBoxButtons.OK);
            }

        }

        private void btnBorraTipo_Click(object sender, EventArgs e)
        {
            ControlTipDeTejer.EliminarTipoDetejer(TipDeTejerViewModel.IdTipoDeTejer);
            if (ControlTipDeTejer.Result)
            {
                btnBorraTipo.Enabled = false;
                MessageBox.Show(Consts.Tptejer + Consts.BorradoTptejer, "Borrado Correcto", MessageBoxButtons.OK);
            }
            else
            {
                btnBorraTipo.Enabled = false;
                MessageBox.Show(Consts.Tptejer + Consts.BorradoErrorTptejer, "Borrado No Correcto", MessageBoxButtons.OK);
            }
        }
    }
}
