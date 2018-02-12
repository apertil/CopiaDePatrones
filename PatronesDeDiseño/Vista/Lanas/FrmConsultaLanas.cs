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
using static PatronesDeDiseño.ViewModel.LanasViewModel;

namespace PatronesDeDiseño.Vista.Lanas
{
    public partial class FrmConsultaLanas : Form
    {
        public static List<string> hastalapolla = new List<string>();
        public static List<PatronesDeDiseño.Lanas> ficherolana;
       
        public FrmConsultaLanas()
        {
            InitializeComponent();
            //contexto contexto = new contexto();
            //bindingSource1.DataSource = (from a in contexto.Lanas
            //                             where a.NombreLana.Contains(txtConsultarLana.Text.Trim())
            //                             select a).ToList();
            //dataGridLanas.DataSource = bindingSource1;
            //dataGridLanas.Refresh();
        }

        private void btnSalirConsultarLana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultarLana_Click(object sender, EventArgs e)
        {
           
            try
            {

                DataTable table = ControlLanas.ConsultarGrosorLana(txtConsultarLana.Text);
                dataGridLanas.AutoGenerateColumns = true;
                dataGridLanas.DataSource = table;

            }
            catch (Exception )
            {

               

            }

            
        }
    }
}
