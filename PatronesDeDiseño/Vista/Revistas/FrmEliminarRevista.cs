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

namespace PatronesDeDiseño.Vista.Revistas
{
    public partial class FrmEliminarRevista : Form
    {
        public FrmEliminarRevista()
        {
            InitializeComponent();
        }

        private void btnSalirBorrarRevista_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsBorrarRevista_Click(object sender, EventArgs e)
        {
            DataTable table = ControlRevistas.ConsultarExactoRevista(txtBorrarRevista.Text.TrimStart().TrimEnd());
            if (ControlRevistas.Result)
            {
                dataGridRevistas.AutoGenerateColumns = true;
                dataGridRevistas.DataSource = table;
                btnEliminarRevista.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBorrarRevista.Text + "No se ha encontrado", "No se ha encontrado", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarRevista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás segura de que quieres borrar la revista?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ControlRevistas.EliminarRevista(RevistasViewModel.IdRevista);
                if (ControlRevistas.Result)
                {
                    btnEliminarRevista.Enabled = false;
                    MessageBox.Show(txtBorrarRevista.Text + "Borrada Correctamente", "Borrado Correcto", MessageBoxButtons.OK);
                    dataGridRevistas.DataSource = null;
                }
                else
                {
                    btnEliminarRevista.Enabled = false;
                    MessageBox.Show(txtBorrarRevista.Text + "No se ha borrado correctamente", "Borrado No Correcto", MessageBoxButtons.OK);
                    dataGridRevistas.DataSource = null;
                }
            }
            else  
            {
                btnEliminarRevista.Enabled = false;
                dataGridRevistas.DataSource = null;
            }
           
            
        }
    }
}
