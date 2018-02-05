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


    public partial class FrmPatronMain : Form
    {
        #region "1.- Variables privadas de la clase"
        /// <summary>
        /// Mensaje de la Excepción Generada
        /// </summary>

        internal string cResultException;

        /// <summary>
        /// Indica el Resultado de la Operación Actual
        /// </summary>
        internal bool cSuccessful;

        #endregion

        #region "2.- Variables publicas de la clase"
        /// <summary>
        /// Propiedad con el Mensaje del Error o de la Excepción Generada
        /// </summary>
        /// <returns>El Mensaje del Error o de la Excepción Generada</returns>
        public string ResultException
        {

            get { return cResultException; }
        }
        /// <summary>
        /// Propiedad que Indica si el Proceso ha Finalizado Correctamente
        /// </summary>
        /// <returns>True si el Proceso ha Finalizado Correctamente - False en caso Contrario</returns>
        public bool Result
        {

            get { return cSuccessful; }
        }

        #endregion

        #region "3.- Constructor de la clase"

        public FrmPatronMain()
        {
            InitializeComponent();
        }
        #endregion

        #region "5.- Metodos públicos de la clase"


        #endregion

        #region "6.- Eventos privados de la clase"
        /// <summary>
        /// Cierra el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
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
        #endregion

        #region "7.- Metodos privados de la clase"


        #endregion


    }
}
