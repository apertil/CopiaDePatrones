using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesDeDiseño.Vista
{
    public partial class FrmInsTiposPunto : Form
    {
        private PatronesEntities db = new PatronesEntities();

        public FrmInsTiposPunto()
        {
            InitializeComponent();
        }

        private void btnCerrarInsertTipPunto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertTipoPunto_Click(object sender, EventArgs e)
        {
            TiposDeTejer tiposdetejer = new TiposDeTejer();
            tiposdetejer.NombreDeTejer = txtintippunt.Text;
            db.TiposDeTejer.Add(tiposdetejer);
            db.SaveChanges();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
