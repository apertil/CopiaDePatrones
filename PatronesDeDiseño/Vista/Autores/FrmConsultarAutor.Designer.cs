namespace PatronesDeDiseño.Vista.Autores
{
    partial class FrmConsultarAutor
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
            this.dataGridConsultaAutores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirConsultarAutor = new System.Windows.Forms.Button();
            this.txtConsultarAutor = new System.Windows.Forms.TextBox();
            this.btnConsultarAutor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaAutores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Consultar Autores";
            // 
            // dataGridConsultaAutores
            // 
            this.dataGridConsultaAutores.AllowUserToAddRows = false;
            this.dataGridConsultaAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConsultaAutores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridConsultaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaAutores.Location = new System.Drawing.Point(120, 199);
            this.dataGridConsultaAutores.Name = "dataGridConsultaAutores";
            this.dataGridConsultaAutores.Size = new System.Drawing.Size(261, 150);
            this.dataGridConsultaAutores.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "*Para consultar todos los Autores dejar en blanco\r\n";
            // 
            // btnSalirConsultarAutor
            // 
            this.btnSalirConsultarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsultarAutor.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirConsultarAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsultarAutor.Location = new System.Drawing.Point(204, 365);
            this.btnSalirConsultarAutor.Name = "btnSalirConsultarAutor";
            this.btnSalirConsultarAutor.Size = new System.Drawing.Size(88, 42);
            this.btnSalirConsultarAutor.TabIndex = 44;
            this.btnSalirConsultarAutor.Text = "Salir";
            this.btnSalirConsultarAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirConsultarAutor.UseVisualStyleBackColor = true;
            this.btnSalirConsultarAutor.Click += new System.EventHandler(this.btnSalirConsultarAutor_Click);
            // 
            // txtConsultarAutor
            // 
            this.txtConsultarAutor.BackColor = System.Drawing.Color.White;
            this.txtConsultarAutor.Location = new System.Drawing.Point(155, 142);
            this.txtConsultarAutor.Name = "txtConsultarAutor";
            this.txtConsultarAutor.Size = new System.Drawing.Size(206, 20);
            this.txtConsultarAutor.TabIndex = 43;
            // 
            // btnConsultarAutor
            // 
            this.btnConsultarAutor.BackColor = System.Drawing.Color.White;
            this.btnConsultarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAutor.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnConsultarAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarAutor.Location = new System.Drawing.Point(386, 134);
            this.btnConsultarAutor.Name = "btnConsultarAutor";
            this.btnConsultarAutor.Size = new System.Drawing.Size(145, 34);
            this.btnConsultarAutor.TabIndex = 42;
            this.btnConsultarAutor.Text = "Buscar Autores";
            this.btnConsultarAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarAutor.UseVisualStyleBackColor = false;
            this.btnConsultarAutor.Click += new System.EventHandler(this.btnConsultarAutor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Autores";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(36, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 40;
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
            // FrmConsultarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridConsultaAutores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirConsultarAutor);
            this.Controls.Add(this.txtConsultarAutor);
            this.Controls.Add(this.btnConsultarAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarAutor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaAutores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridConsultaAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirConsultarAutor;
        private System.Windows.Forms.TextBox txtConsultarAutor;
        private System.Windows.Forms.Button btnConsultarAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}