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

namespace PatronesDeDiseño.Vista
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

          ControlTipDeTejer.ModificarTiposDeTejer(txtintippunt.Text);
          txtintippunt.Text = null;

        }

    }
}
