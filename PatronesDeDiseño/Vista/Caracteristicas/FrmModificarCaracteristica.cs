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

namespace PatronesDeDiseño.Vista.Caracteristicas
{
    public partial class FrmModificarCaracteristica : Form
    {
        public FrmModificarCaracteristica()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarCaract_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarCaract_Click(object sender, EventArgs e)
        {
            DataTable table = ControlCaracteristicas.ConsultarExactoCaracteristica(txtConsultarCaract.Text.TrimStart().TrimEnd());
            if (ControlCaracteristicas.Result)
            {
                dataGridCaract.AutoGenerateColumns = true;
                dataGridCaract.DataSource = table;
                btnModificarCaract.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtConsultarCaract.Text + " No se ha podido encontrar", "Error en la busqueda", MessageBoxButtons.OK);
            }
        }

        private void btnModificarCaract_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCaract.Rows)
            {
                TCaractViewModel.NombreTCarac = row.Cells[0].EditedFormattedValue.ToString();

                ControlCaracteristicas.ModificarCaracteristica(TCaractViewModel.IdTipCar, TCaractViewModel.NombreTCarac);
            }
            if (ControlCaracteristicas.Result)
            {
                MessageBox.Show("Se ha modificado correctamente la Caracteristica", "Modificacion Correcta", MessageBoxButtons.OK);
                dataGridCaract.DataSource = null;
                btnModificarCaract.Enabled = false;
            }
            else
            {
                MessageBox.Show(ControlCaracteristicas.ResultException, "Modificacion InCorrecta", MessageBoxButtons.OK);
                btnModificarCaract.Enabled = false;
            }
        }
    }
}
