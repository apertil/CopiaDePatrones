namespace PatronesDeDiseño.Vista.TiposPunto
{
    partial class FrmModificarTiposPunto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarTipoTejer = new System.Windows.Forms.TextBox();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.btnModificaTipoTejer = new System.Windows.Forms.Button();
            this.btnSalirModificarLana = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridModifTipPunto = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModifTipPunto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(82, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 15;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo de punto a buscar";
            // 
            // txtBuscarTipoTejer
            // 
            this.txtBuscarTipoTejer.Location = new System.Drawing.Point(292, 151);
            this.txtBuscarTipoTejer.Name = "txtBuscarTipoTejer";
            this.txtBuscarTipoTejer.Size = new System.Drawing.Size(138, 20);
            this.txtBuscarTipoTejer.TabIndex = 17;
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipo.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnBuscarTipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTipo.Location = new System.Drawing.Point(360, 197);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(181, 34);
            this.btnBuscarTipo.TabIndex = 18;
            this.btnBuscarTipo.Text = "Buscar Tipo de punto";
            this.btnBuscarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
            // 
            // btnModificaTipoTejer
            // 
            this.btnModificaTipoTejer.Enabled = false;
            this.btnModificaTipoTejer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaTipoTejer.Image = global::PatronesDeDiseño.Properties.Resources.config1;
            this.btnModificaTipoTejer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificaTipoTejer.Location = new System.Drawing.Point(360, 274);
            this.btnModificaTipoTejer.Name = "btnModificaTipoTejer";
            this.btnModificaTipoTejer.Size = new System.Drawing.Size(181, 35);
            this.btnModificaTipoTejer.TabIndex = 21;
            this.btnModificaTipoTejer.Text = "Modificar Tipo de punto";
            this.btnModificaTipoTejer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificaTipoTejer.UseVisualStyleBackColor = true;
            this.btnModificaTipoTejer.Click += new System.EventHandler(this.btnModificaTipoTejer_Click);
            // 
            // btnSalirModificarLana
            // 
            this.btnSalirModificarLana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirModificarLana.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirModificarLana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirModificarLana.Location = new System.Drawing.Point(234, 369);
            this.btnSalirModificarLana.Name = "btnSalirModificarLana";
            this.btnSalirModificarLana.Size = new System.Drawing.Size(88, 42);
            this.btnSalirModificarLana.TabIndex = 22;
            this.btnSalirModificarLana.Text = "Salir";
            this.btnSalirModificarLana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirModificarLana.UseVisualStyleBackColor = true;
            this.btnSalirModificarLana.Click += new System.EventHandler(this.btnSalirModificarLana_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Modificar Tipo de Punto";
            // 
            // dataGridModifTipPunto
            // 
            this.dataGridModifTipPunto.AllowUserToAddRows = false;
            this.dataGridModifTipPunto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridModifTipPunto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridModifTipPunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModifTipPunto.Location = new System.Drawing.Point(71, 197);
            this.dataGridModifTipPunto.Name = "dataGridModifTipPunto";
            this.dataGridModifTipPunto.Size = new System.Drawing.Size(269, 150);
            this.dataGridModifTipPunto.TabIndex = 47;
            // 
            // FrmModificarTiposPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.dataGridModifTipPunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalirModificarLana);
            this.Controls.Add(this.btnModificaTipoTejer);
            this.Controls.Add(this.btnBuscarTipo);
            this.Controls.Add(this.txtBuscarTipoTejer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarTiposPunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarTiposPunto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModifTipPunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarTipoTejer;
        private System.Windows.Forms.Button btnBuscarTipo;
        private System.Windows.Forms.Button btnModificaTipoTejer;
        private System.Windows.Forms.Button btnSalirModificarLana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridModifTipPunto;
    }
}