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

namespace PatronesDeDiseño.Vista.Patrones
{
    public partial class FrmInsertarPatron : Form
    {
        public FrmInsertarPatron()
        {
            InitializeComponent();
            CargaComboAut();
            CargaComboLana();
            CargaComboTipoPrenda();
            CargaComboRevista();
            CargaComboTipoPrenda();
            CargaComboCaract();
            CargaComboTipoTej();
            CargaComboGeneroEdad();
        }
        #region "1._Eventos del formulario"
        private void btnsalirinsertarpatron_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
        #region "2._Funciones privadas de la clase"
        private void CargaComboAut()
        {
            CmbAutPat.DataSource = ControlPatrones.CargaComboAutor();
            CmbAutPat.DisplayMember = "NombreAutor";
            CmbAutPat.ValueMember = "IdAutorPatron";
        }

        private void CargaComboLana()
        {
            CmbGrLan.DataSource = ControlPatrones.CargaComboLanas();
            CmbGrLan.DisplayMember = "NombreLana";
            CmbGrLan.ValueMember = "IdLana";
        }

        private void CargaComboTipoPrenda()
        {
            CmbTipPrenda.DataSource = ControlPatrones.CargaComboPrendas();
            CmbTipPrenda.DisplayMember = "NombrePrendas";
            CmbTipPrenda.ValueMember = "IdPrendas";

        }
        
        private void CargaComboRevista()
        {
            CmbRevista.DataSource = ControlPatrones.CargaComboRevistas();
            CmbRevista.DisplayMember = "NombreAutor";
            CmbRevista.ValueMember = "IdRevistas";
        }

        private void CargaComboCaract()
        {
            CmbCaract.DataSource = ControlPatrones.CargaComboCaracteristicas();
            CmbCaract.DisplayMember = "NombreCaracteristicas";
            CmbCaract.ValueMember = "IdTiposCaract";
        }

        private void CargaComboTipoTej()
        {
            CmbTipoTejido.DataSource = ControlPatrones.CargaComboTipodeTejer();
            CmbTipoTejido.DisplayMember = "NombreDeTejer";
            CmbTipoTejido.ValueMember = "IdTiposTejer";
        }

        private void CargaComboGeneroEdad()
        {
            CmbGenEdad.DataSource = ControlPatrones.CargaComboGeneroEdad();
            CmbGenEdad.DisplayMember = "GenEdad";
            CmbGenEdad.ValueMember = "IdGenEd";
        }


        #endregion

        private void btnBuscarPatron_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPG (*.jpg,*.jpeg)|*.jpg;*.jpeg|PDF (*.PDF,*.pdf)|*.PDF;*.pdf|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string ruta = openFileDialog1.FileName;
                txtBuscarPatron.Text = ruta;
            }

        }
    }
}
