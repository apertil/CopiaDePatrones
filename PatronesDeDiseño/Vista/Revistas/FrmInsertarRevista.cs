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

namespace PatronesDeDiseño.Vista.Revistas
{
    public partial class FrmInsertarRevista : Form
    {
        public FrmInsertarRevista()
        {
            InitializeComponent();
        }

        private void btnsalirRevistas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertarRevista_Click(object sender, EventArgs e)
        {
            ControlRevistas.InsertarRevista(txtNombreRevista.Text, txtAutorEnLaRevista.Text);
            if (ControlRevistas.Result)
            {
                MessageBox.Show(txtNombreRevista.Text + Consts.Inercionok, "Insercion correcta", MessageBoxButtons.OK);
                txtNombreRevista.Text = " ";
                txtAutorEnLaRevista.Text = " ";
            }
            else
            {
                MessageBox.Show(txtNombreRevista.Text + Consts.Inercionok, "Insercion correcta", MessageBoxButtons.OK);
                MessageBox.Show(ControlRevistas.ResultException, "Insercion Incorrecta", MessageBoxButtons.OK);
            }

        }
    }
}
