namespace PatronesDeDiseño.Vista.Caracteristicas
{
    partial class FrmConsultarCaracteristica
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
            this.dataGridCaracteristicas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultarCaract = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalirConsultarCaracteristica = new System.Windows.Forms.Button();
            this.btnConsultarCaracteristica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaracteristicas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Consulta Tipos de Características";
            // 
            // dataGridCaracteristicas
            // 
            this.dataGridCaracteristicas.AllowUserToAddRows = false;
            this.dataGridCaracteristicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCaracteristicas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCaracteristicas.Location = new System.Drawing.Point(136, 203);
            this.dataGridCaracteristicas.Name = "dataGridCaracteristicas";
            this.dataGridCaracteristicas.Size = new System.Drawing.Size(261, 150);
            this.dataGridCaracteristicas.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "*Para consultar todas las Revistas dejar en blanco\r\n";
            // 
            // txtConsultarCaract
            // 
            this.txtConsultarCaract.BackColor = System.Drawing.Color.White;
            this.txtConsultarCaract.Location = new System.Drawing.Point(171, 146);
            this.txtConsultarCaract.Name = "txtConsultarCaract";
            this.txtConsultarCaract.Size = new System.Drawing.Size(170, 20);
            this.txtConsultarCaract.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Características";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(52, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Knitting Project";
            // 
            // btnSalirConsultarCaracteristica
            // 
            this.btnSalirConsultarCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsultarCaracteristica.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirConsultarCaracteristica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsultarCaracteristica.Location = new System.Drawing.Point(220, 369);
            this.btnSalirConsultarCaracteristica.Name = "btnSalirConsultarCaracteristica";
            this.btnSalirConsultarCaracteristica.Size = new System.Drawing.Size(88, 42);
            this.btnSalirConsultarCaracteristica.TabIndex = 36;
            this.btnSalirConsultarCaracteristica.Text = "Salir";
            this.btnSalirConsultarCaracteristica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirConsultarCaracteristica.UseVisualStyleBackColor = true;
            this.btnSalirConsultarCaracteristica.Click += new System.EventHandler(this.btnSalirConsultarCaracteristica_Click);
            // 
            // btnConsultarCaracteristica
            // 
            this.btnConsultarCaracteristica.BackColor = System.Drawing.Color.White;
            this.btnConsultarCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCaracteristica.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnConsultarCaracteristica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCaracteristica.Location = new System.Drawing.Point(373, 138);
            this.btnConsultarCaracteristica.Name = "btnConsultarCaracteristica";
            this.btnConsultarCaracteristica.Size = new System.Drawing.Size(174, 34);
            this.btnConsultarCaracteristica.TabIndex = 34;
            this.btnConsultarCaracteristica.Text = "Buscar Caracteristica";
            this.btnConsultarCaracteristica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarCaracteristica.UseVisualStyleBackColor = false;
            this.btnConsultarCaracteristica.Click += new System.EventHandler(this.btnConsultarCaracteristica_Click);
            // 
            // FrmConsultarCaracteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridCaracteristicas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirConsultarCaracteristica);
            this.Controls.Add(this.txtConsultarCaract);
            this.Controls.Add(this.btnConsultarCaracteristica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarCaracteristica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarCaracteristica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCaracteristicas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridCaracteristicas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirConsultarCaracteristica;
        private System.Windows.Forms.TextBox txtConsultarCaract;
        private System.Windows.Forms.Button btnConsultarCaracteristica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}