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
    public partial class FrmConsultaPrendas : Form
    {
        public FrmConsultaPrendas()
        {
            InitializeComponent();
        }

        private void btnSalirConsulta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarTipoPunto_Click(object sender, EventArgs e)
        {
            DataTable table = ControlTipoDeprendas.ConsultarPrenda(txtConsTipPrenda.Text.Trim());
            if (ControlTipoDeprendas.Result)
            {
                dataGridConsultaTipoPrenda.AutoGenerateColumns = true;
                dataGridConsultaTipoPrenda.DataSource = table;
            }
            else
            {
                MessageBox.Show(ControlTipoDeprendas.ResultException, "Error en la busqueda", MessageBoxButtons.OK);
            }
        }
    }
}
