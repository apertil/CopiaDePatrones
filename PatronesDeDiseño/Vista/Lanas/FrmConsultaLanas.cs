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

namespace PatronesDeDiseño.Vista.Lanas
{
    public partial class FrmConsultaLanas : Form
    {
        public FrmConsultaLanas()
        {
            InitializeComponent();
        }

        private void btnSalirConsultarLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarLana_Click(object sender, EventArgs e)
        {
           
            
            Modelo.ModelEntidades.ListaLanas = ControlLanas.ConsultarGrosorLana(txtConsultarLana.Text);
            dataGridLanas.DataSource = Modelo.ModelEntidades.ListaLanas;

        }
    }
}
