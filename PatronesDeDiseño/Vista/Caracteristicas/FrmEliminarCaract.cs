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
    public partial class FrmEliminarCaract : Form
    {
        public FrmEliminarCaract()
        {
            InitializeComponent();
        }

        private void btnSalirBorrarCaract_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsBorrarCaract_Click(object sender, EventArgs e)
        {
            DataTable table = ControlCaracteristicas.ConsultarExactoCaracteristica(txtBorrarCaract.Text.TrimStart().TrimEnd());
            if (ControlCaracteristicas.Result)
            {
                dataGridBorrCaract.AutoGenerateColumns = true;
                dataGridBorrCaract.DataSource = table;
                btnEliminarCaract.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBorrarCaract.Text + "No se ha encontrado", "Error en la busqueda", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarCaract_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Estás segura de que quieres borrar la característica?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ControlCaracteristicas.EliminarCaracteristica(TCaractViewModel.IdTipCar);
                if (ControlCaracteristicas.Result)
                {
                    btnEliminarCaract.Enabled = false;
                    MessageBox.Show(txtBorrarCaract.Text + "Borrada Correctamente", "Borrado Correcto", MessageBoxButtons.OK);
                    dataGridBorrCaract.DataSource = null;

                }
                else
                {
                    btnEliminarCaract.Enabled = false;
                    MessageBox.Show(txtBorrarCaract.Text + "No se ha borrado correctamente", "Borrado No Correcto", MessageBoxButtons.OK);
                    dataGridBorrCaract.DataSource = null;
                }
            }
            else
            {
                btnEliminarCaract.Enabled = false;
                dataGridBorrCaract.DataSource = null;
            }
        }
    }
}
