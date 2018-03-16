namespace PatronesDeDiseño.Vista.Genero
{
    partial class FrmInsertarGener
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
            this.txtintGenEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarInsertGenEdad = new System.Windows.Forms.Button();
            this.btnInsertGenEdad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtintGenEdad
            // 
            this.txtintGenEdad.Location = new System.Drawing.Point(141, 143);
            this.txtintGenEdad.Name = "txtintGenEdad";
            this.txtintGenEdad.Size = new System.Drawing.Size(236, 20);
            this.txtintGenEdad.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Genero-Edad";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(51, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 38;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Insertar Genero-Edad";
            // 
            // btnCerrarInsertGenEdad
            // 
            this.btnCerrarInsertGenEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInsertGenEdad.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnCerrarInsertGenEdad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarInsertGenEdad.Location = new System.Drawing.Point(222, 187);
            this.btnCerrarInsertGenEdad.Name = "btnCerrarInsertGenEdad";
            this.btnCerrarInsertGenEdad.Size = new System.Drawing.Size(81, 40);
            this.btnCerrarInsertGenEdad.TabIndex = 42;
            this.btnCerrarInsertGenEdad.Text = "Salir";
            this.btnCerrarInsertGenEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarInsertGenEdad.UseVisualStyleBackColor = true;
            this.btnCerrarInsertGenEdad.Click += new System.EventHandler(this.btnCerrarInsertGenEdad_Click);
            // 
            // btnInsertGenEdad
            // 
            this.btnInsertGenEdad.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnInsertGenEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertGenEdad.Image = global::PatronesDeDiseño.Properties.Resources.download;
            this.btnInsertGenEdad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertGenEdad.Location = new System.Drawing.Point(403, 138);
            this.btnInsertGenEdad.Name = "btnInsertGenEdad";
            this.btnInsertGenEdad.Size = new System.Drawing.Size(135, 34);
            this.btnInsertGenEdad.TabIndex = 41;
            this.btnInsertGenEdad.Text = "Insertar Ahora";
            this.btnInsertGenEdad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertGenEdad.UseVisualStyleBackColor = false;
            this.btnInsertGenEdad.Click += new System.EventHandler(this.btnInsertGenEdad_Click);
            // 
            // FrmInsertarGener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(573, 235);
            this.Controls.Add(this.btnCerrarInsertGenEdad);
            this.Controls.Add(this.btnInsertGenEdad);
            this.Controls.Add(this.txtintGenEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertarGener";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertarGener";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarInsertGenEdad;
        private System.Windows.Forms.Button btnInsertGenEdad;
        private System.Windows.Forms.TextBox txtintGenEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}