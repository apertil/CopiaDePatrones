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

namespace PatronesDeDiseño.Vista.TiposPunto
{
    public partial class FrmBorrarTipoDeTejer : Form
    {
        public FrmBorrarTipoDeTejer()
        {
            InitializeComponent();
        }

        private void btnBuscarBorrarTipo_Click(object sender, EventArgs e)
        {
            DataTable table = ControlTipDeTejer.BuscarExactoTipoDetejer(txtBorrarTipoTejido.Text.TrimStart().TrimEnd());
            if (ControlTipDeTejer.Result)
            {
                dataGridBorrtejido.AutoGenerateColumns = true;
                dataGridBorrtejido.DataSource = table;
                btnBorraTipo.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBorrarTipoTejido.Text + Consts.ErrorTipoPunto, "No se ha encontrado", MessageBoxButtons.OK);
            }

        }

        private void btnBorraTipo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás segura de que quieres borrar la característica?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                ControlTipDeTejer.EliminarTipoDetejer(TipDeTejerViewModel.IdTipoDeTejer);
                if (ControlTipDeTejer.Result)
                {
                    btnBorraTipo.Enabled = false;
                    MessageBox.Show(txtBorrarTipoTejido.Text + Consts.BorradoTptejer, "Borrado Correcto", MessageBoxButtons.OK);
                    dataGridBorrtejido.DataSource = null;
                }
                else
                {
                    btnBorraTipo.Enabled = false;
                    MessageBox.Show(txtBorrarTipoTejido.Text + Consts.BorradoErrorTptejer, "Borrado No Correcto", MessageBoxButtons.OK);
                    dataGridBorrtejido.DataSource = null;
                }
            }
            else
            {
                btnBorraTipo.Enabled = false;
                dataGridBorrtejido.DataSource = null;
            }
        }

        private void btnSalirBorrarrTipo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
