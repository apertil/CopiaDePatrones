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

namespace PatronesDeDiseño.Vista.Revistas
{
    public partial class FrmConsultarRevista : Form
    {
        public FrmConsultarRevista()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarRevista_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarRevista_Click(object sender, EventArgs e)
        {
           
            DataTable table = ControlRevistas.ConsultarRevista(txtConsultarRevista.Text.TrimStart().TrimEnd());
            if (ControlRevistas.Result)
            {
                dataGridRevistas.AutoGenerateColumns = true;
                dataGridRevistas.DataSource = table;
                txtConsultarRevista.Text = " ";
            }
            else
            {
                MessageBox.Show(ControlRevistas.ResultException, "Error en la busqueda", MessageBoxButtons.OK);

            }
        }
    }
}
