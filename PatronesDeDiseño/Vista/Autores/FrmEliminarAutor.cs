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
    public partial class FrmEliminarAutor : Form
    {
        public FrmEliminarAutor()
        {
            InitializeComponent();
        }

        private void btnSalirBorrarAutor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsBorrarAutor_Click(object sender, EventArgs e)
        {
            DataTable table = ControlAutores.ConsultarExactoAutores(txtBorrarAutor.Text.TrimStart().TrimEnd());
            if (ControlAutores.Result)
            {
                dataGridBorrAutor.AutoGenerateColumns = true;
                dataGridBorrAutor.DataSource = table;
                btnEliminarAutor.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBorrarAutor.Text + "No se ha encontrado", "Error en la busqueda", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás segura de que quieres borrar el autor?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ControlAutores.EliminarAutor(AutorViewModel.IdAutPatron);
                if (ControlAutores.Result)
                {
                    btnEliminarAutor.Enabled = false;
                    MessageBox.Show(txtBorrarAutor.Text + "Borrada Correctamente", "Borrado Correcto", MessageBoxButtons.OK);
                    dataGridBorrAutor.DataSource = null;

                }
                else
                {
                    btnEliminarAutor.Enabled = false;
                    MessageBox.Show(txtBorrarAutor.Text + "No se ha borrado correctamente", "Borrado No Correcto", MessageBoxButtons.OK);
                    dataGridBorrAutor.DataSource = null;
                }
            }
            else
            {
                btnEliminarAutor.Enabled = false;
                dataGridBorrAutor.DataSource = null;
            }
        }
    }
}
