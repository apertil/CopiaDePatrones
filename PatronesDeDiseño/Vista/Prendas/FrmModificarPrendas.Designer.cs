﻿namespace PatronesDeDiseño.Vista.Prendas
{
    partial class FrmModificarPrendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirModificarLana = new System.Windows.Forms.Button();
            this.btnModificaTipoPrenda = new System.Windows.Forms.Button();
            this.btnBuscarTipoPrenda = new System.Windows.Forms.Button();
            this.txtBuscarTipoPrenda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridModifTipPrenda = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModifTipPrenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(169, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Modificar tipo de Prenda";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Knitting Project";
            // 
            // btnSalirModificarLana
            // 
            this.btnSalirModificarLana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirModificarLana.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirModificarLana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirModificarLana.Location = new System.Drawing.Point(227, 368);
            this.btnSalirModificarLana.Name = "btnSalirModificarLana";
            this.btnSalirModificarLana.Size = new System.Drawing.Size(88, 43);
            this.btnSalirModificarLana.TabIndex = 32;
            this.btnSalirModificarLana.Text = "Salir";
            this.btnSalirModificarLana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirModificarLana.UseVisualStyleBackColor = true;
            this.btnSalirModificarLana.Click += new System.EventHandler(this.btnSalirModificarLana_Click);
            // 
            // btnModificaTipoPrenda
            // 
            this.btnModificaTipoPrenda.Enabled = false;
            this.btnModificaTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaTipoPrenda.Image = global::PatronesDeDiseño.Properties.Resources.config1;
            this.btnModificaTipoPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificaTipoPrenda.Location = new System.Drawing.Point(335, 286);
            this.btnModificaTipoPrenda.Name = "btnModificaTipoPrenda";
            this.btnModificaTipoPrenda.Size = new System.Drawing.Size(197, 35);
            this.btnModificaTipoPrenda.TabIndex = 31;
            this.btnModificaTipoPrenda.Text = "Modificar Tipo de Prenda";
            this.btnModificaTipoPrenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificaTipoPrenda.UseVisualStyleBackColor = true;
            this.btnModificaTipoPrenda.Click += new System.EventHandler(this.btnModificaTipoPrenda_Click);
            // 
            // btnBuscarTipoPrenda
            // 
            this.btnBuscarTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipoPrenda.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnBuscarTipoPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTipoPrenda.Location = new System.Drawing.Point(336, 211);
            this.btnBuscarTipoPrenda.Name = "btnBuscarTipoPrenda";
            this.btnBuscarTipoPrenda.Size = new System.Drawing.Size(196, 34);
            this.btnBuscarTipoPrenda.TabIndex = 28;
            this.btnBuscarTipoPrenda.Text = "Buscar Tipo de Prenda";
            this.btnBuscarTipoPrenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTipoPrenda.UseVisualStyleBackColor = true;
            this.btnBuscarTipoPrenda.Click += new System.EventHandler(this.btnBuscarTipoPrenda_Click);
            // 
            // txtBuscarTipoPrenda
            // 
            this.txtBuscarTipoPrenda.Location = new System.Drawing.Point(296, 159);
            this.txtBuscarTipoPrenda.Name = "txtBuscarTipoPrenda";
            this.txtBuscarTipoPrenda.Size = new System.Drawing.Size(138, 20);
            this.txtBuscarTipoPrenda.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre de la prenda a buscar";
            // 
            // dataGridModifTipPrenda
            // 
            this.dataGridModifTipPrenda.AllowUserToAddRows = false;
            this.dataGridModifTipPrenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridModifTipPrenda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridModifTipPrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModifTipPrenda.Location = new System.Drawing.Point(73, 197);
            this.dataGridModifTipPrenda.Name = "dataGridModifTipPrenda";
            this.dataGridModifTipPrenda.Size = new System.Drawing.Size(242, 150);
            this.dataGridModifTipPrenda.TabIndex = 48;
            // 
            // FrmModificarPrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.dataGridModifTipPrenda);
            this.Controls.Add(this.btnSalirModificarLana);
            this.Controls.Add(this.btnModificaTipoPrenda);
            this.Controls.Add(this.btnBuscarTipoPrenda);
            this.Controls.Add(this.txtBuscarTipoPrenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarPrendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarPrendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModifTipPrenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirModificarLana;
        private System.Windows.Forms.Button btnModificaTipoPrenda;
        private System.Windows.Forms.Button btnBuscarTipoPrenda;
        private System.Windows.Forms.TextBox txtBuscarTipoPrenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridModifTipPrenda;
    }
}