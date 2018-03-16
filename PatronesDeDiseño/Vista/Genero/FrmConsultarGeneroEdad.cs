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

namespace PatronesDeDiseño.Vista.Genero
{
    public partial class FrmConsultarGeneroEdad : Form
    {
        public FrmConsultarGeneroEdad()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarGeneroEdad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarGeneroEdad_Click(object sender, EventArgs e)
        {
            DataTable table = ControlGeneroEdad.ConsultarGenEdad(txtConsultarGeneroEdad.Text.TrimStart().TrimEnd());

            if (ControlGeneroEdad.Result)
            { 
                dataGridConsultarGeneroEdad.AutoGenerateColumns = false;
                dataGridConsultarGeneroEdad.DataSource = table;
            }
            else
            {
                MessageBox.Show(ControlGeneroEdad.ResultException, "Error en la busqueda", MessageBoxButtons.OK);
            }

        }
    }
}
