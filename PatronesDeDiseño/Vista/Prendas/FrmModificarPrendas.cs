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

namespace PatronesDeDiseño.Vista.Prendas
{
    public partial class FrmModificarPrendas : Form
    {
        public FrmModificarPrendas()
        {
            InitializeComponent();
        }

        private void btnSalirModificarLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarTipoPrenda_Click(object sender, EventArgs e)
        {
            DataTable table = ControlTipoDeprendas.BuscarExactoPrenda(txtBuscarTipoPrenda.Text.TrimStart().TrimEnd());
            if (ControlTipoDeprendas.Result)
            {
                dataGridModifTipPrenda.AutoGenerateColumns = true;
                dataGridModifTipPrenda.DataSource = table;
                btnModificaTipoPrenda.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBuscarTipoPrenda.Text + Consts.ErrorTipoPrenda, "No se ha encontrado", MessageBoxButtons.OK);
                txtBuscarTipoPrenda.Text = " ";
                
            }
        }

        private void btnModificaTipoPrenda_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridModifTipPrenda.Rows)
            {
                PrendasViewModel.NombrePren = row.Cells[0].EditedFormattedValue.ToString();
                ControlTipoDeprendas.ModificarPrenda(PrendasViewModel.IdPren, PrendasViewModel.NombrePren.TrimStart().TrimEnd());
            }
            
            if (ControlTipoDeprendas.Result)
            {
                MessageBox.Show(PrendasViewModel.NombrePren + Consts.ModificaPrenda, "Modificacion Correcta", MessageBoxButtons.OK);
                dataGridModifTipPrenda.DataSource = null;
                btnModificaTipoPrenda.Enabled = false;

            }
            else
            {
                MessageBox.Show(PrendasViewModel.NombrePren + Consts.ModificaErrorPrenda, "Modificacion NO Correcta", MessageBoxButtons.OK);

                btnModificaTipoPrenda.Enabled = false;

            }
        }
    }
}
