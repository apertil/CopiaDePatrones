using PatronesDeDiseño.Vista.Caracteristicas;
using PatronesDeDiseño.Vista.Lanas;
using PatronesDeDiseño.Vista.Prendas;
using PatronesDeDiseño.Vista.Revistas;
using PatronesDeDiseño.Vista.TiposPunto;
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
    public  partial class FrmPatronMain : Form
    {
        #region "1.- Variables privadas de la clase"
        
        #endregion

        #region "2.- Variables publicas de la clase"
       

        #endregion

        #region "3.- Constructor de la clase"

        public FrmPatronMain()
        {
            InitializeComponent();
        }
        #endregion

        #region "4.-Métodos de patrones"
        private void nuevoPatrónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        private void consultarPatronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        private void modificarPatrónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        #endregion  

        #region "5.- Metodos de lanas"
        /// <summary>
        /// Insertar Grosor de lana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmInsLana l = new FrmInsLana();
            l.ShowDialog();
          
        }

        /// <summary>
        /// Consultar Grosor de lanas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void busquedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaLanas con = new FrmConsultaLanas();
            con.Show();
            
            //MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Modificar Grosor de lanas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void modoficarGrosorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarLanas m = new FrmModificarLanas();
            m.Show();
            
            //MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);

        }

        private void borrarGrosorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorrarLana d = new FrmBorrarLana();
            d.ShowDialog();
            
            //MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        #endregion

        #region "6.- Metodos de tipos de punto"

        /// <summary>
        /// Insertar tipos de punto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsTiposPunto a = new FrmInsTiposPunto();
            a.Show();
            
        }

        /// <summary>
        /// Consultar Tipos de punto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaTiposPunto tipo = new FrmConsultaTiposPunto();
            tipo.Show();
            
        }

        /// <summary>
        /// Modificar tipos de punto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarTiposPunto modi = new FrmModificarTiposPunto();
            modi.Show();
           
        }
        /// <summary>
        /// Borrar tipos de punto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }


        #endregion

        #region "7.- Metodos de prendas"

        /// <summary>
        /// Nueva prenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevaPrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsTipoPrendas NuevaPrenda = new FrmInsTipoPrendas();
            NuevaPrenda.Show();
        }
        /// <summary>
        /// Consultar prenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarPrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPrendas CPren = new FrmConsultaPrendas();
            CPren.Show();
        }

        /// <summary>
        /// Modificar prenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void modificarPrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarPrendas modpr = new FrmModificarPrendas();
            modpr.Show();
        }

        /// <summary>
        /// Borrar prenda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarPrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorrarPrenda borprenda = new FrmBorrarPrenda();
            borprenda.Show();
        }

        #endregion

        #region "8.- Metodos de Caracteristicas"

        /// <summary>
        /// Nueva Caracteristica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevaCaracteristicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertarCaracteristica inscar = new FrmInsertarCaracteristica();
            inscar.Show();
        }

        /// <summary>
        /// Consultar característica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarCaracteristicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarCaracteristica consCaract = new FrmConsultarCaracteristica();
            consCaract.Show();
        }

        /// <summary>
        /// Modificar Característica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarCaracterisiticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Borrar caracteristica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarCaracteristicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }
        #endregion

        #region "9.- Metodos de revistas"

        /// <summary>
        /// Nueva Revista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void nuevaRevistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertarRevista insRevista = new FrmInsertarRevista();
            insRevista.Show();
        }

        /// <summary>
        /// Consultar revista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarRevista cnrevis = new FrmConsultarRevista();
            cnrevis.Show();
        }

        /// <summary>
        /// Modificar datos revistas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarRevistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarRevistas amodifRev = new FrmModificarRevistas();
            amodifRev.Show();
        }
        /// <summary>
        /// Borrar Revista de la BBDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void borrarRevistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarRevista elimRevis = new FrmEliminarRevista();
            elimRevis.Show();
        }
        #endregion

        #region "10.- Metodos de Autores de patrones"

        /// <summary>
        /// Nuevo autor de revista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void nuevoAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }


        /// <summary>
        /// Busqueda de autor de revista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void busquedaAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Modificar autor de revista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Borrar autor de revista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }


        #endregion

        #region "11.- Metodos de Genero Edad"

        /// <summary>
        /// Nuevo género edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Consulta genero edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultaGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Modficar género edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modificarGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Borrar Genero edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void borrarGeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion no implementada", "Paciencia", MessageBoxButtons.OK);
        }

        #endregion

        /// <summary>
        /// Cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abo = new AboutBox1();
            abo.Show();
        }

     
    }
}
