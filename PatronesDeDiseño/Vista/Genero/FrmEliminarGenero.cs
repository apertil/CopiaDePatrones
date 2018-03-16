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
    public partial class FrmEliminarGenero : Form
    {
        public FrmEliminarGenero()
        {
            InitializeComponent();
        }

        private void btnSalirBorrarGeneroEdad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsBorrarGeneroEdad_Click(object sender, EventArgs e)
        {
            DataTable table = ControlGeneroEdad.ConsultarExactoGenEdad(txtBorrarGeneroEdad.Text.TrimStart().TrimEnd());
            if (ControlGeneroEdad.Result)
            {
                dataGridBorrGeneroEdad.AutoGenerateColumns = true;
                dataGridBorrGeneroEdad.DataSource = table;
                btnEliminarGeneroEdad.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBorrarGeneroEdad.Text + "No se ha encontrado", "Error en la busqueda", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarGeneroEdad_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás segura de que quieres borrar el GeneroEdad?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ControlGeneroEdad.EliminarGenEdad(GeneroEdadViewModel.IdGenEdad);
                if (ControlGeneroEdad.Result)
                {
                    btnEliminarGeneroEdad.Enabled = false;
                    MessageBox.Show(txtBorrarGeneroEdad.Text + "Borrada Correctamente", "Borrado Correcto", MessageBoxButtons.OK);
                    dataGridBorrGeneroEdad.DataSource = null;
                }
                else
                {
                    MessageBox.Show(txtBorrarGeneroEdad.Text + "No ha sido Borrada Correctamente", "Borrado InCorrecto", MessageBoxButtons.OK);
                    btnEliminarGeneroEdad.Enabled = false;
                    dataGridBorrGeneroEdad.DataSource = null;
                }
            }
            else
            {
                btnEliminarGeneroEdad.Enabled = false;
                dataGridBorrGeneroEdad.DataSource = null;
            }
        }
    }
}
