namespace PatronesDeDiseño.Vista.Revistas
{
    partial class FrmEliminarRevista
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
            this.txtBorrarRevista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarRevista = new System.Windows.Forms.Button();
            this.btnSalirBorrarRevista = new System.Windows.Forms.Button();
            this.btnConsBorrarRevista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevistas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Eliminar Revistas";
            // 
            // dataGridRevistas
            // 
            this.dataGridRevistas.AllowUserToAddRows = false;
            this.dataGridRevistas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRevistas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridRevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRevistas.Location = new System.Drawing.Point(83, 205);
            this.dataGridRevistas.Name = "dataGridRevistas";
            this.dataGridRevistas.Size = new System.Drawing.Size(269, 150);
            this.dataGridRevistas.TabIndex = 55;
            // 
            // txtBorrarRevista
            // 
            this.txtBorrarRevista.BackColor = System.Drawing.Color.White;
            this.txtBorrarRevista.Location = new System.Drawing.Point(201, 150);
            this.txtBorrarRevista.Name = "txtBorrarRevista";
            this.txtBorrarRevista.Size = new System.Drawing.Size(170, 20);
            this.txtBorrarRevista.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Nombre Revista";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(31, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 50;
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
            // btnEliminarRevista
            // 
            this.btnEliminarRevista.Enabled = false;
            this.btnEliminarRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRevista.Image = global::PatronesDeDiseño.Properties.Resources.config1;
            this.btnEliminarRevista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRevista.Location = new System.Drawing.Point(375, 276);
            this.btnEliminarRevista.Name = "btnEliminarRevista";
            this.btnEliminarRevista.Size = new System.Drawing.Size(149, 38);
            this.btnEliminarRevista.TabIndex = 57;
            this.btnEliminarRevista.Text = "Eliminar Revista";
            this.btnEliminarRevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRevista.UseVisualStyleBackColor = true;
            this.btnEliminarRevista.Click += new System.EventHandler(this.btnEliminarRevista_Click);
            // 
            // btnSalirBorrarRevista
            // 
            this.btnSalirBorrarRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirBorrarRevista.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirBorrarRevista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirBorrarRevista.Location = new System.Drawing.Point(211, 365);
            this.btnSalirBorrarRevista.Name = "btnSalirBorrarRevista";
            this.btnSalirBorrarRevista.Size = new System.Drawing.Size(88, 42);
            this.btnSalirBorrarRevista.TabIndex = 54;
            this.btnSalirBorrarRevista.Text = "Salir";
            this.btnSalirBorrarRevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirBorrarRevista.UseVisualStyleBackColor = true;
            this.btnSalirBorrarRevista.Click += new System.EventHandler(this.btnSalirBorrarRevista_Click);
            // 
            // btnConsBorrarRevista
            // 
            this.btnConsBorrarRevista.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnConsBorrarRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsBorrarRevista.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnConsBorrarRevista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsBorrarRevista.Location = new System.Drawing.Point(375, 205);
            this.btnConsBorrarRevista.Name = "btnConsBorrarRevista";
            this.btnConsBorrarRevista.Size = new System.Drawing.Size(149, 34);
            this.btnConsBorrarRevista.TabIndex = 52;
            this.btnConsBorrarRevista.Text = "Buscar Revista";
            this.btnConsBorrarRevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsBorrarRevista.UseVisualStyleBackColor = false;
            this.btnConsBorrarRevista.Click += new System.EventHandler(this.btnConsBorrarRevista_Click);
            // 
            // FrmEliminarRevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(550, 414);
            this.Controls.Add(this.btnEliminarRevista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridRevistas);
            this.Controls.Add(this.btnSalirBorrarRevista);
            this.Controls.Add(this.txtBorrarRevista);
            this.Controls.Add(this.btnConsBorrarRevista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarRevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEliminarRevista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRevistas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarRevista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridRevistas;
        private System.Windows.Forms.Button btnSalirBorrarRevista;
        private System.Windows.Forms.TextBox txtBorrarRevista;
        private System.Windows.Forms.Button btnConsBorrarRevista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}