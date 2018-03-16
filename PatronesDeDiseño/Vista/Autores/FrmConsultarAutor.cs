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

namespace PatronesDeDiseño.Vista.Autores
{
    public partial class FrmConsultarAutor : Form
    {
        public FrmConsultarAutor()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarAutor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarAutor_Click(object sender, EventArgs e)
        {
            DataTable table = ControlAutores.ConsultarAutor(txtConsultarAutor.Text.TrimStart().TrimEnd());
            if (ControlAutores.Result)
            {
                dataGridConsultaAutores.AutoGenerateColumns = false;
                dataGridConsultaAutores.DataSource = table;
                txtConsultarAutor.Text = " ";
            }
            else
            {
                MessageBox.Show(ControlAutores.ResultException, "Error en la busqueda", MessageBoxButtons.OK);
            }

        }
    }
}
