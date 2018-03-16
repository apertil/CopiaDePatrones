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

namespace PatronesDeDiseño.Vista.Genero
{
    public partial class FrmModificarGenero : Form
    {
        public FrmModificarGenero()
        {
            InitializeComponent();
        }

        private void btnSalirModificarGeneroEdad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarModificarGenero_Click(object sender, EventArgs e)
        {
            DataTable table = ControlGeneroEdad.ConsultarExactoGenEdad(txtModificarGenero.Text.TrimEnd().TrimStart());
            if (ControlGeneroEdad.Result)
            {
                dataGridGenero.AutoGenerateColumns = true;
                dataGridGenero.DataSource = table;
                btnBuscarModificarGenero.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtModificarGenero.Text + " No se ha podido encontrar", "Error en la busqueda", MessageBoxButtons.OK);
            }
        }

        private void btnModificarGenero_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridGenero.Rows)
            {
                GeneroEdadViewModel.NombreGeneroEdad = row.Cells[0].EditedFormattedValue.ToString();
                ControlGeneroEdad.ModificarGenEdad(GeneroEdadViewModel.IdGenEdad, GeneroEdadViewModel.NombreGeneroEdad);
               
            }
            if (ControlGeneroEdad.Result)
            {
                MessageBox.Show("Se ha modificado correctamente el Genero Edad", "Modificacion Correcta", MessageBoxButtons.OK);
                dataGridGenero.DataSource = null;
                btnBuscarModificarGenero.Enabled = false;
            }
            else
            {
                MessageBox.Show(ControlGeneroEdad.ResultException, "Modificacion InCorrecta", MessageBoxButtons.OK);
                btnBuscarModificarGenero.Enabled = false;
            }
        }
    }
}
