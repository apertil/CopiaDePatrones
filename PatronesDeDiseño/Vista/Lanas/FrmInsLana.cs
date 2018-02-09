using PatronesDeDiseño.Modelo;
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
    public partial class FrmInsLana : Form
    {
        public FrmInsLana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlLanas.InsertarGrosorDelana(txtGrosorLana.Text);
            if (ControlLanas.Result)
            {
                MessageBox.Show(Consts.lanas + Consts.Inercionok, "Insercion correcta", MessageBoxButtons.OK);
                txtGrosorLana.Text = null;
            }
            else
            {
                MessageBox.Show(Consts.lanas + Consts.InercionNoOk, "Insercion Incorrecta", MessageBoxButtons.OK);
                MessageBox.Show(ControlLanas.ResultException, "Insercion Incorrecta", MessageBoxButtons.OK);
            }
           
        }

        private void btnsalirlanas_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
