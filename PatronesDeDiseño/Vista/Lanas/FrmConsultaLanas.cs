﻿using PatronesDeDiseño.Negocio;
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
