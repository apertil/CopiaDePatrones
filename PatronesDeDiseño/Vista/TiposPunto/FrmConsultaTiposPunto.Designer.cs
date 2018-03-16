namespace PatronesDeDiseño.Vista.TiposPunto
{
    partial class FrmConsultaTiposPunto
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsTipPunto = new System.Windows.Forms.TextBox();
            this.btnBuscarTipoPunto = new System.Windows.Forms.Button();
            this.dataGridConsultaTipoPunto = new System.Windows.Forms.DataGridView();
            this.btnSalirConsulta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaTipoPunto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(52, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Knitting Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Consultar Tipos de punto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tipo de punto ";
            // 
            // txtConsTipPunto
            // 
            this.txtConsTipPunto.Location = new System.Drawing.Point(171, 146);
            this.txtConsTipPunto.Name = "txtConsTipPunto";
            this.txtConsTipPunto.Size = new System.Drawing.Size(170, 20);
            this.txtConsTipPunto.TabIndex = 20;
            // 
            // btnBuscarTipoPunto
            // 
            this.btnBuscarTipoPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipoPunto.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnBuscarTipoPunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTipoPunto.Location = new System.Drawing.Point(393, 138);
            this.btnBuscarTipoPunto.Name = "btnBuscarTipoPunto";
            this.btnBuscarTipoPunto.Size = new System.Drawing.Size(122, 34);
            this.btnBuscarTipoPunto.TabIndex = 21;
            this.btnBuscarTipoPunto.Text = "Buscar Tipo";
            this.btnBuscarTipoPunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTipoPunto.UseVisualStyleBackColor = true;
            this.btnBuscarTipoPunto.Click += new System.EventHandler(this.btnBuscarTipoPunto_Click);
            // 
            // dataGridConsultaTipoPunto
            // 
            this.dataGridConsultaTipoPunto.AllowUserToAddRows = false;
            this.dataGridConsultaTipoPunto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConsultaTipoPunto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridConsultaTipoPunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaTipoPunto.Location = new System.Drawing.Point(136, 203);
            this.dataGridConsultaTipoPunto.Name = "dataGridConsultaTipoPunto";
            this.dataGridConsultaTipoPunto.Size = new System.Drawing.Size(261, 150);
            this.dataGridConsultaTipoPunto.TabIndex = 22;
            // 
            // btnSalirConsulta
            // 
            this.btnSalirConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsulta.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsulta.Location = new System.Drawing.Point(220, 369);
            this.btnSalirConsulta.Name = "btnSalirConsulta";
            this.btnSalirConsulta.Size = new System.Drawing.Size(88, 42);
            this.btnSalirConsulta.TabIndex = 23;
            this.btnSalirConsulta.Text = "Salir";
            this.btnSalirConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirConsulta.UseVisualStyleBackColor = true;
            this.btnSalirConsulta.Click += new System.EventHandler(this.btnSalirConsulta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "*Para consultar todos  los tipos dejar en blanco";
            // 
            // FrmConsultaTiposPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalirConsulta);
            this.Controls.Add(this.dataGridConsultaTipoPunto);
            this.Controls.Add(this.btnBuscarTipoPunto);
            this.Controls.Add(this.txtConsTipPunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaTiposPunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaTiposPunto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaTipoPunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsTipPunto;
        private System.Windows.Forms.Button btnBuscarTipoPunto;
        private System.Windows.Forms.DataGridView dataGridConsultaTipoPunto;
        private System.Windows.Forms.Button btnSalirConsulta;
        private System.Windows.Forms.Label label4;
    }
}