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

namespace PatronesDeDiseño.Vista.TiposPunto
{
    public partial class FrmConsultaTiposPunto : Form
    {
        public FrmConsultaTiposPunto()
        {
            InitializeComponent();
        }

        private void btnBuscarTipoPunto_Click(object sender, EventArgs e)
        {
            DataTable table = ControlTipDeTejer.ConsultarTipoDetejer(txtConsTipPunto.Text);
            if (ControlTipDeTejer.Result)
            { 
            dataGridConsultaTipoPunto.AutoGenerateColumns = true;
            dataGridConsultaTipoPunto.DataSource = table;
            
            }
            else
            {
                MessageBox.Show(ControlTipDeTejer.ResultException, "Error en la busqueda", MessageBoxButtons.OK);
            }
}

        private void btnSalirConsulta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
