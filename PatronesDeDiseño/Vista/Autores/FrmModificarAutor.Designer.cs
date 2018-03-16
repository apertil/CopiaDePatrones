namespace PatronesDeDiseño.Vista.Autores
{
    partial class FrmModificarAutor
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
            this.dataGridAutores = new System.Windows.Forms.DataGridView();
            this.txtModificarAutores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModificarAutores = new System.Windows.Forms.Button();
            this.btnSalirConsultarAutores = new System.Windows.Forms.Button();
            this.btnBuscarModificarAutor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Modificar Autores";
            // 
            // dataGridAutores
            // 
            this.dataGridAutores.AllowUserToAddRows = false;
            this.dataGridAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAutores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutores.Location = new System.Drawing.Point(84, 202);
            this.dataGridAutores.Name = "dataGridAutores";
            this.dataGridAutores.Size = new System.Drawing.Size(269, 150);
            this.dataGridAutores.TabIndex = 54;
            // 
            // txtModificarAutores
            // 
            this.txtModificarAutores.BackColor = System.Drawing.Color.White;
            this.txtModificarAutores.Location = new System.Drawing.Point(151, 156);
            this.txtModificarAutores.Name = "txtModificarAutores";
            this.txtModificarAutores.Size = new System.Drawing.Size(215, 20);
            this.txtModificarAutores.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Autores";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(45, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Knitting Project";
            // 
            // btnModificarAutores
            // 
            this.btnModificarAutores.Enabled = false;
            this.btnModificarAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAutores.Image = global::PatronesDeDiseño.Properties.Resources.config1;
            this.btnModificarAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAutores.Location = new System.Drawing.Point(370, 273);
            this.btnModificarAutores.Name = "btnModificarAutores";
            this.btnModificarAutores.Size = new System.Drawing.Size(156, 38);
            this.btnModificarAutores.TabIndex = 56;
            this.btnModificarAutores.Text = "Modificar Autores";
            this.btnModificarAutores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarAutores.UseVisualStyleBackColor = true;
            this.btnModificarAutores.Click += new System.EventHandler(this.btnModificarAutores_Click);
            // 
            // btnSalirConsultarAutores
            // 
            this.btnSalirConsultarAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsultarAutores.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirConsultarAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsultarAutores.Location = new System.Drawing.Point(208, 369);
            this.btnSalirConsultarAutores.Name = "btnSalirConsultarAutores";
            this.btnSalirConsultarAutores.Size = new System.Drawing.Size(88, 42);
            this.btnSalirConsultarAutores.TabIndex = 53;
            this.btnSalirConsultarAutores.Text = "Salir";
            this.btnSalirConsultarAutores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirConsultarAutores.UseVisualStyleBackColor = true;
            this.btnSalirConsultarAutores.Click += new System.EventHandler(this.btnSalirConsultarAutores_Click);
            // 
            // btnBuscarModificarAutor
            // 
            this.btnBuscarModificarAutor.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBuscarModificarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarModificarAutor.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnBuscarModificarAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarModificarAutor.Location = new System.Drawing.Point(370, 202);
            this.btnBuscarModificarAutor.Name = "btnBuscarModificarAutor";
            this.btnBuscarModificarAutor.Size = new System.Drawing.Size(156, 34);
            this.btnBuscarModificarAutor.TabIndex = 51;
            this.btnBuscarModificarAutor.Text = "Buscar Autores";
            this.btnBuscarModificarAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarModificarAutor.UseVisualStyleBackColor = false;
            this.btnBuscarModificarAutor.Click += new System.EventHandler(this.btnBuscarModificarAutor_Click);
            // 
            // FrmModificarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.btnModificarAutores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridAutores);
            this.Controls.Add(this.btnSalirConsultarAutores);
            this.Controls.Add(this.txtModificarAutores);
            this.Controls.Add(this.btnBuscarModificarAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarAutor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarAutores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridAutores;
        private System.Windows.Forms.Button btnSalirConsultarAutores;
        private System.Windows.Forms.TextBox txtModificarAutores;
        private System.Windows.Forms.Button btnBuscarModificarAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}