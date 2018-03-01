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
    public partial class FrmBorrarLana : Form
    {
        public FrmBorrarLana()
        {
            InitializeComponent();
        }

        private void btnSalirBorrarrLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarBorrarLana_Click(object sender, EventArgs e)
        {
             
            DataTable table =  ControlLanas.BuscarExactoGrosorDelana(txtBorrarLana.Text.TrimStart().TrimEnd());
            if (ControlLanas.Result)
            {
                dataGridBorrTipolana.AutoGenerateColumns = true;
                dataGridBorrTipolana.DataSource = table;
                btnBorraLana.Enabled = true;
            }
            else
            {
                MessageBox.Show(Consts.lanas + Consts.ErrorGrosorLana, "No se ha encontrado", MessageBoxButtons.OK);
            }
        }

        private void btnBorraLana_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estás segura de que quieres borrar el tipo de lana?", "Confirmacion", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            { 
                 ControlLanas.EliminarLana(LanasViewModel.IndiceBuscaLanas);
                if (ControlLanas.Result)
                {

                    btnBorraLana.Enabled = false;
                    dataGridBorrTipolana.DataSource = null;
                    MessageBox.Show(Consts.lanas + Consts.BorraLanaOk, "Borrado Correcto", MessageBoxButtons.OK);
                }
                else
                {
                    btnBorraLana.Enabled = false;
                    dataGridBorrTipolana.DataSource = null;
                    MessageBox.Show(Consts.lanas + Consts.BorraLanaNoOk, "Borrado Incorrecto", MessageBoxButtons.OK);
                }
            }
            else
            {
                btnBorraLana.Enabled = false;
                dataGridBorrTipolana.DataSource = null;
            }

        }
    }
}
