using PatronesDeDiseño.Modelo;
using PatronesDeDiseño.Negocio;
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
    public partial class FrmInsTiposPunto : Form
    {
       
        public FrmInsTiposPunto()
        {
            InitializeComponent();
        }

        private void btnCerrarInsertTipPunto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertTipoPunto_Click(object sender, EventArgs e)
        {

          ControlTipDeTejer.InsertarTiposDeTejer(txtintippunt.Text.TrimStart().TrimEnd());
            if (ControlTipDeTejer.Result)
            {
                MessageBox.Show(Consts.Tptejer + Consts.Inercionok, "Insercion correcta", MessageBoxButtons.OK);
                txtintippunt.Text = null;
            }
            else
            {
                MessageBox.Show(Consts.Tptejer + Consts.InercionNoOk, "Insercion incorrecta", MessageBoxButtons.OK);
                MessageBox.Show(ControlTipDeTejer.ResultException, "Insercion Incorrecta", MessageBoxButtons.OK);
            }
        }

    }
}
