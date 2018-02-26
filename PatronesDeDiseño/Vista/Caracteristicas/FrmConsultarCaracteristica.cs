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

namespace PatronesDeDiseño.Vista.Caracteristicas
{
    public partial class FrmConsultarCaracteristica : Form
    {
        public FrmConsultarCaracteristica()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarCaracteristica_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarCaracteristica_Click(object sender, EventArgs e)
        {
            DataTable table = ControlCaracteristicas.ConsultarCaracteristica(txtConsultarCaract.Text.TrimStart().TrimEnd());
            if (ControlCaracteristicas.Result)
            {
                dataGridCaracteristicas.AutoGenerateColumns = true;
                dataGridCaracteristicas.DataSource = table;
                txtConsultarCaract.Text = " ";
            }
            else
            {
                MessageBox.Show(ControlRevistas.ResultException, "Error en la busqueda", MessageBoxButtons.OK);

            }
        }
    }
}
