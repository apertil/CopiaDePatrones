namespace PatronesDeDiseño.Vista.Revistas
{
    partial class FrmInsertarRevista
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsalirRevistas = new System.Windows.Forms.Button();
            this.btnInsertarRevista = new System.Windows.Forms.Button();
            this.txtNombreRevista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutorEnLaRevista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Insertar Revistas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(58, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 59);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Knitting Project";
            // 
            // btnsalirRevistas
            // 
            this.btnsalirRevistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirRevistas.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnsalirRevistas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirRevistas.Location = new System.Drawing.Point(236, 257);
            this.btnsalirRevistas.Name = "btnsalirRevistas";
            this.btnsalirRevistas.Size = new System.Drawing.Size(86, 42);
            this.btnsalirRevistas.TabIndex = 23;
            this.btnsalirRevistas.Text = "Salir";
            this.btnsalirRevistas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalirRevistas.UseVisualStyleBackColor = true;
            this.btnsalirRevistas.Click += new System.EventHandler(this.btnsalirRevistas_Click);
            // 
            // btnInsertarRevista
            // 
            this.btnInsertarRevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarRevista.Image = global::PatronesDeDiseño.Properties.Resources.download;
            this.btnInsertarRevista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertarRevista.Location = new System.Drawing.Point(418, 175);
            this.btnInsertarRevista.Name = "btnInsertarRevista";
            this.btnInsertarRevista.Size = new System.Drawing.Size(150, 34);
            this.btnInsertarRevista.TabIndex = 22;
            this.btnInsertarRevista.Text = "Insertar Revista";
            this.btnInsertarRevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertarRevista.UseVisualStyleBackColor = true;
            this.btnInsertarRevista.Click += new System.EventHandler(this.btnInsertarRevista_Click);
            // 
            // txtNombreRevista
            // 
            this.txtNombreRevista.Location = new System.Drawing.Point(172, 151);
            this.txtNombreRevista.Name = "txtNombreRevista";
            this.txtNombreRevista.Size = new System.Drawing.Size(221, 20);
            this.txtNombreRevista.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre Revista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Autor en la  Revista*";
            // 
            // txtAutorEnLaRevista
            // 
            this.txtAutorEnLaRevista.Location = new System.Drawing.Point(172, 205);
            this.txtAutorEnLaRevista.Name = "txtAutorEnLaRevista";
            this.txtAutorEnLaRevista.Size = new System.Drawing.Size(221, 20);
            this.txtAutorEnLaRevista.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "*Este campo puede estar vacio";
            // 
            // FrmInsertarRevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(601, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAutorEnLaRevista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsalirRevistas);
            this.Controls.Add(this.btnInsertarRevista);
            this.Controls.Add(this.txtNombreRevista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertarRevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertarRevista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsalirRevistas;
        private System.Windows.Forms.Button btnInsertarRevista;
        private System.Windows.Forms.TextBox txtNombreRevista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutorEnLaRevista;
        private System.Windows.Forms.Label label5;
    }
}