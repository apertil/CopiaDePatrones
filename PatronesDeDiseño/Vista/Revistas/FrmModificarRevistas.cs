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
    public partial class FrmModificarRevistas : Form
    {
        public FrmModificarRevistas()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarRevista_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarRevista_Click(object sender, EventArgs e)
        {
            DataTable table = ControlRevistas.ConsultarExactoRevista(txtConsultarRevista.Text.TrimStart().TrimEnd());
            if (ControlRevistas.Result)
            {
                dataGridRevistas.AutoGenerateColumns = true;
                dataGridRevistas.DataSource = table;
                btnModificarRevista.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtConsultarRevista.Text + " No se ha podido encontrar", "Error en la busqueda", MessageBoxButtons.OK);
            }
        }

        private void btnModificarRevista_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridRevistas.Rows)
            {
                RevistasViewModel.NombRevist = row.Cells[0].EditedFormattedValue.ToString();
                RevistasViewModel.AutRevist = row.Cells[1].EditedFormattedValue.ToString();
                ControlRevistas.ModificarRevista(RevistasViewModel.IdRevista, RevistasViewModel.NombRevist, RevistasViewModel.AutRevist);
            }
            if (ControlRevistas.Result)
            {
                MessageBox.Show("Se ha modificado correctamente la revita y/o el autor", "Modificacion Correcta", MessageBoxButtons.OK);
                dataGridRevistas.DataSource = null;
            }
            else
            {
                MessageBox.Show(ControlRevistas.ResultException, "Modificacion InCorrecta", MessageBoxButtons.OK);
            }
        }
    }
}
