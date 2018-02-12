using PatronesDeDiseño.Modelo;
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

namespace PatronesDeDiseño.Vista.Lanas
{
    public partial class FrmModificarLanas : Form
    {
        public FrmModificarLanas()
        {
            InitializeComponent();
        }

        private void btnSalirModificarLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarLana_Click(object sender, EventArgs e)
        {
            ControlLanas.BuscarGrosorDelana(txtBuscarLana.Text);
            if (ControlLanas.Result)
            {
                btnModificalana.Enabled = true;
                
            }
            else
            {
                MessageBox.Show(Consts.lanas + Consts.ErrorGrosorLana, "No se ha encontrado", MessageBoxButtons.OK);
            }
                 
           
        }

        private void btnModificalana_Click(object sender, EventArgs e)
        {

            ControlLanas.ModificarGrosorDelana(LanasViewModel.IndiceBuscaLanas, txtModificaLana.Text);
            if (ControlLanas.Result)
            {
                MessageBox.Show(Consts.lanas + Consts.Inercionok, "Modificacion Correcta", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(Consts.lanas + Consts.InercionNoOk, "Modificacion NO Correcta", MessageBoxButtons.OK);
            }
        }
    }
}
