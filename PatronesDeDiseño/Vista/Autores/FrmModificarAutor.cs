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

namespace PatronesDeDiseño.Vista.Autores
{
    public partial class FrmModificarAutor : Form
    {
        public FrmModificarAutor()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarAutores_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarModificarAutor_Click(object sender, EventArgs e)
        {
            DataTable table = ControlAutores.ConsultarExactoAutores(txtModificarAutores.Text.TrimStart().TrimEnd());
            if (ControlAutores.Result)
            {
                dataGridAutores.AutoGenerateColumns = false;
                dataGridAutores.DataSource = table;
                btnBuscarModificarAutor.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtModificarAutores.Text + " No se ha podido encontrar", "Error en la busqueda", MessageBoxButtons.OK);
            }
        }

        private void btnModificarAutores_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridAutores.Rows)
            {
                AutorViewModel.NombreAutPatron = row.Cells[0].EditedFormattedValue.ToString();
                ControlAutores.ModificarAutor(AutorViewModel.IdAutPatron, AutorViewModel.NombreAutPatron);

            }
            if (ControlAutores.Result)
            {
                MessageBox.Show("Se ha modificado correctamente la Caracteristica", "Modificacion Correcta", MessageBoxButtons.OK);
                dataGridAutores.DataSource = null;
                btnBuscarModificarAutor.Enabled = false;
            }
            else
            {
                MessageBox.Show(ControlAutores.ResultException, "Modificacion InCorrecta", MessageBoxButtons.OK);
                btnBuscarModificarAutor.Enabled = false;
            }
        }
    }
}
