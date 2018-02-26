namespace PatronesDeDiseño.Vista.Revistas
{
    partial class FrmConsultarRevista
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
            this.dataGridRevistas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultarRevista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalirConsultarRevista = new System.Windows.Forms.Button();
            this.btnConsultarRevista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevistas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Consulta Tipos de Revista";
            // 
            // dataGridRevistas
            // 
            this.dataGridRevistas.AllowUserToAddRows = false;
            this.dataGridRevistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRevistas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridRevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRevistas.Location = new System.Drawing.Point(136, 199);
            this.dataGridRevistas.Name = "dataGridRevistas";
            this.dataGridRevistas.Size = new System.Drawing.Size(261, 150);
            this.dataGridRevistas.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "*Para consultar todas las Revistas dejar en blanco\r\n";
            // 
            // txtConsultarRevista
            // 
            this.txtConsultarRevista.BackColor = System.Drawing.Color.White;
            this.txtConsultarRevista.Location = new System.Drawing.Point(171, 142);
            this.txtConsultarRevista.Name = "txtConsultarRevista";
            this.txtConsultarRevista.Size = new System.Drawing.Size(170, 20);
            this.txtConsultarRevista.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre Revista";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(52, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 24;
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
            // btnSalirConsultarRevista
            // 
            this.btnSalirConsultarRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsultarRevista.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirConsultarRevista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsultarRevista.Location = new System.Drawing.Point(220, 365);
            this.btnSalirConsultarRevista.Name = "btnSalirConsultarRevista";
            this.btnSalirConsultarRevista.Size = new System.Drawing.Size(88, 42);
            this.btnSalirConsultarRevista.TabIndex = 28;
            this.btnSalirConsultarRevista.Text = "Salir";
            this.btnSalirConsultarRevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirConsultarRevista.UseVisualStyleBackColor = true;
            this.btnSalirConsultarRevista.Click += new System.EventHandler(this.btnSalirConsultarRevista_Click);
            // 
            // btnConsultarRevista
            // 
            this.btnConsultarRevista.BackColor = System.Drawing.Color.White;
            this.btnConsultarRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarRevista.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnConsultarRevista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarRevista.Location = new System.Drawing.Point(393, 134);
            this.btnConsultarRevista.Name = "btnConsultarRevista";
            this.btnConsultarRevista.Size = new System.Drawing.Size(138, 34);
            this.btnConsultarRevista.TabIndex = 26;
            this.btnConsultarRevista.Text = "Buscar Revista";
            this.btnConsultarRevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarRevista.UseVisualStyleBackColor = false;
            this.btnConsultarRevista.Click += new System.EventHandler(this.btnConsultarRevista_Click);
            // 
            // FrmConsultarRevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridRevistas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirConsultarRevista);
            this.Controls.Add(this.txtConsultarRevista);
            this.Controls.Add(this.btnConsultarRevista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarRevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarRevista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevistas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridRevistas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirConsultarRevista;
        private System.Windows.Forms.TextBox txtConsultarRevista;
        private System.Windows.Forms.Button btnConsultarRevista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}