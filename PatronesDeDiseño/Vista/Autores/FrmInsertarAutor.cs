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
    public partial class FrmInsertarAutor : Form
    {
        public FrmInsertarAutor()
        {
            InitializeComponent();
        }

        private void btnCerrarInsertAutor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertAutor_Click(object sender, EventArgs e)
        {
            ControlAutores.InsertarAutor(txtintAutor.Text.TrimStart().TrimEnd());

            if (ControlAutores.Result)
            {
                MessageBox.Show(txtintAutor.Text + " Insertada correctamente", "Inserción correcta", MessageBoxButtons.OK);
                txtintAutor.Text = " ";
            }
            else
            {
                MessageBox.Show(ControlAutores.ResultException + "No se ha insertado " + txtintAutor.Text, "Error en la inserción", MessageBoxButtons.OK);
            }
        }
    }
}
