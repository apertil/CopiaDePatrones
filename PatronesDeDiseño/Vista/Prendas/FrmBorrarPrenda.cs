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
    public partial class FrmBorrarPrenda : Form
    {
        public FrmBorrarPrenda()
        {
            InitializeComponent();
        }

        private void btnSalirBorrarPrenda_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarBorrarTipoPrenda_Click(object sender, EventArgs e)
        {
            DataTable table = ControlTipoDeprendas.BuscarExactoPrenda(txtBorrarTipoPrenda.Text.TrimStart().TrimEnd());
            if (ControlTipDeTejer.Result)
            {
                dataGridBorrPrenda.AutoGenerateColumns = true;
                dataGridBorrPrenda.DataSource = table;
                btnBorraTipoPrenda.Enabled = true;
            }
            else
            {
                MessageBox.Show(txtBorrarTipoPrenda.Text + Consts.ErrorTipoPrenda, "No se ha encontrado", MessageBoxButtons.OK);
            }
        }

        private void btnBorraTipoPrenda_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás segura de que quieres borrar la Prenda?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                ControlTipoDeprendas.EliminarPrenda(PrendasViewModel.IdPren);
           
                
                if (ControlTipDeTejer.Result)
                {
                    btnBorraTipoPrenda.Enabled = false;
                    MessageBox.Show(txtBorrarTipoPrenda.Text + Consts.BorradoPrenda, "Borrado Correcto", MessageBoxButtons.OK);
                    dataGridBorrPrenda.DataSource = null;
                }
                else
                {
                    btnBorraTipoPrenda.Enabled = false;
                    MessageBox.Show(txtBorrarTipoPrenda.Text + Consts.BorradoErrorPrenda, "Borrado No Correcto", MessageBoxButtons.OK);
                    dataGridBorrPrenda.DataSource = null;
                }
            }
            else
            {
                btnBorraTipoPrenda.Enabled = false;
                dataGridBorrPrenda.DataSource = null;
            }

        }
    }
}
