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
    public partial class FrmModificarTiposPunto : Form
    {
        public FrmModificarTiposPunto()
        {
            InitializeComponent();
        }

        private void btnSalirModificarLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            DataTable table = ControlTipDeTejer.BuscarExactoTipoDetejer(txtBuscarTipoTejer.Text.TrimStart().TrimEnd());

            if (ControlTipDeTejer.Result)
            {
                dataGridModifTipPunto.AutoGenerateColumns = true;
                dataGridModifTipPunto.DataSource = table;
                btnModificaTipoTejer.Enabled = true;
            }

            else
            {
                MessageBox.Show(txtBuscarTipoTejer.Text + Consts.ErrorTipoPunto, "No se ha encontrado", MessageBoxButtons.OK);
                txtBuscarTipoTejer.Text = " ";
                
                
            }
        }

        private void btnModificaTipoTejer_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridModifTipPunto.Rows)
            {
                TipDeTejerViewModel.NombreTipoDeTejer = row.Cells[0].EditedFormattedValue.ToString();
                ControlTipDeTejer.ModificarTiposDeTejer(TipDeTejerViewModel.IdTipoDeTejer, TipDeTejerViewModel.NombreTipoDeTejer.TrimStart().TrimEnd());
            }
            
            if (ControlTipDeTejer.Result)
            {
                MessageBox.Show(TipDeTejerViewModel.NombreTipoDeTejer + Consts.ModificaTptejer, "Modificacion Correcta", MessageBoxButtons.OK);
                txtBuscarTipoTejer.Text = " ";
                dataGridModifTipPunto.DataSource = null;
                btnModificaTipoTejer.Enabled = false;
               
            }
            else
            {
                MessageBox.Show(TipDeTejerViewModel.NombreTipoDeTejer + Consts.ModificaErrorTptejer, "Modificacion NO Correcta", MessageBoxButtons.OK);
                txtBuscarTipoTejer.Text = " ";
                btnModificaTipoTejer.Enabled = false;
                // btnModificaTipoTejer.Enabled = false;

            }
        }
    }
}
