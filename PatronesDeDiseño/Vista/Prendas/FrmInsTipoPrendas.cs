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

namespace PatronesDeDiseño.Vista.Prendas
{
    public partial class FrmInsTipoPrendas : Form
    {
        public FrmInsTipoPrendas()
        {
            InitializeComponent();
        }

        private void btnCerrarInsertTipPrenda_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertTipoPrenda_Click(object sender, EventArgs e)
        {
            ControlTipoDeprendas.InsertarPrenda(txtintTipPunt.Text.TrimStart().TrimEnd());
            if (ControlTipoDeprendas.Result)
            {
                MessageBox.Show(txtintTipPunt.Text + Consts.Inercionok, "Insercion correcta", MessageBoxButtons.OK);
                txtintTipPunt.Text = null;
            }
            else
            {
                MessageBox.Show(txtintTipPunt.Text + Consts.Inercionok, "Insercion Incorrecta", MessageBoxButtons.OK);
                MessageBox.Show(ControlTipoDeprendas.ResultException, "Insercion Incorrecta", MessageBoxButtons.OK);
            }
        }   
    }
}
