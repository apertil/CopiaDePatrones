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

namespace PatronesDeDiseño.Vista.Caracteristicas
{
    public partial class FrmInsertarCaracteristica : Form
    {
        public FrmInsertarCaracteristica()
        {
            InitializeComponent();
        }

        private void btnCerrarInsertCaracteristica_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertCaracteristica_Click(object sender, EventArgs e)
        {
            ControlCaracteristicas.InsertarCaracteristica(txtintCaracteristica.Text.TrimStart().TrimEnd());
            if (ControlCaracteristicas.Result)
            {
                MessageBox.Show(txtintCaracteristica.Text + " Insertada correctamente", "Inserción correcta", MessageBoxButtons.OK);
                txtintCaracteristica.Text = " ";
            }
            else
            {
                MessageBox.Show(ControlCaracteristicas.ResultException + "No se ha insertado " + txtintCaracteristica.Text, "Error en la inserción", MessageBoxButtons.OK);
            }
        }
    }
}
