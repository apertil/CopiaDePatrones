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
    public partial class FrmInsertarGener : Form
    {
        public FrmInsertarGener()
        {
            InitializeComponent();
        }

        private void btnCerrarInsertGenEdad_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertGenEdad_Click(object sender, EventArgs e)
        {
            ControlGeneroEdad.InsertarGeneroEdad(txtintGenEdad.Text.TrimStart().TrimEnd());

            if (ControlGeneroEdad.Result)
            {
                MessageBox.Show(txtintGenEdad.Text + " Insertada correctamente", "Inserción correcta", MessageBoxButtons.OK);
                txtintGenEdad.Text = " ";
            }
            else
            {
                MessageBox.Show(ControlGeneroEdad.ResultException + "No se ha insertado " + txtintGenEdad.Text, "Error en la inserción", MessageBoxButtons.OK);
            }
        }
    }
}
