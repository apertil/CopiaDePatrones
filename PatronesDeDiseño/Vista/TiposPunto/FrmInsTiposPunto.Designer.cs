namespace PatronesDeDiseño.Vista.TiposPunto
{
    partial class FrmInsTiposPunto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInsTiposPunto));
            this.label2 = new System.Windows.Forms.Label();
            this.txtintippunt = new System.Windows.Forms.TextBox();
            this.btnCerrarInsertTipPunto = new System.Windows.Forms.Button();
            this.btnInsertTipoPunto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Punto";
            // 
            // txtintippunt
            // 
            this.txtintippunt.Location = new System.Drawing.Point(119, 146);
            this.txtintippunt.Name = "txtintippunt";
            this.txtintippunt.Size = new System.Drawing.Size(264, 20);
            this.txtintippunt.TabIndex = 6;
            // 
            // btnCerrarInsertTipPunto
            // 
            this.btnCerrarInsertTipPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInsertTipPunto.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnCerrarInsertTipPunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarInsertTipPunto.Location = new System.Drawing.Point(228, 190);
            this.btnCerrarInsertTipPunto.Name = "btnCerrarInsertTipPunto";
            this.btnCerrarInsertTipPunto.Size = new System.Drawing.Size(81, 40);
            this.btnCerrarInsertTipPunto.TabIndex = 7;
            this.btnCerrarInsertTipPunto.Text = "Salir";
            this.btnCerrarInsertTipPunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarInsertTipPunto.UseVisualStyleBackColor = true;
            this.btnCerrarInsertTipPunto.Click += new System.EventHandler(this.btnCerrarInsertTipPunto_Click);
            // 
            // btnInsertTipoPunto
            // 
            this.btnInsertTipoPunto.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnInsertTipoPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertTipoPunto.Image = global::PatronesDeDiseño.Properties.Resources.download;
            this.btnInsertTipoPunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertTipoPunto.Location = new System.Drawing.Point(409, 141);
            this.btnInsertTipoPunto.Name = "btnInsertTipoPunto";
            this.btnInsertTipoPunto.Size = new System.Drawing.Size(135, 34);
            this.btnInsertTipoPunto.TabIndex = 8;
            this.btnInsertTipoPunto.Text = "Insertar Ahora";
            this.btnInsertTipoPunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertTipoPunto.UseVisualStyleBackColor = false;
            this.btnInsertTipoPunto.Click += new System.EventHandler(this.btnInsertTipoPunto_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(57, 38);
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
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Insertar Tipos de punto";
            // 
            // FrmInsTiposPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(573, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInsertTipoPunto);
            this.Controls.Add(this.btnCerrarInsertTipPunto);
            this.Controls.Add(this.txtintippunt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInsTiposPunto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar Tipos de Punto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtintippunt;
        private System.Windows.Forms.Button btnCerrarInsertTipPunto;
        private System.Windows.Forms.Button btnInsertTipoPunto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}