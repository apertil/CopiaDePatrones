namespace PatronesDeDiseño.Vista.Prendas
{
    partial class FrmInsTipoPrendas
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtintTipPunt = new System.Windows.Forms.TextBox();
            this.btnInsertTipoPrenda = new System.Windows.Forms.Button();
            this.btnCerrarInsertTipPrenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Insertar Tipos de prendas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(57, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 20;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tipo de Prenda";
            // 
            // txtintTipPunt
            // 
            this.txtintTipPunt.Location = new System.Drawing.Point(119, 146);
            this.txtintTipPunt.Name = "txtintTipPunt";
            this.txtintTipPunt.Size = new System.Drawing.Size(264, 20);
            this.txtintTipPunt.TabIndex = 22;
            // 
            // btnInsertTipoPrenda
            // 
            this.btnInsertTipoPrenda.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnInsertTipoPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertTipoPrenda.Image = global::PatronesDeDiseño.Properties.Resources.download;
            this.btnInsertTipoPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertTipoPrenda.Location = new System.Drawing.Point(409, 141);
            this.btnInsertTipoPrenda.Name = "btnInsertTipoPrenda";
            this.btnInsertTipoPrenda.Size = new System.Drawing.Size(135, 34);
            this.btnInsertTipoPrenda.TabIndex = 23;
            this.btnInsertTipoPrenda.Text = "Insertar Ahora";
            this.btnInsertTipoPrenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertTipoPrenda.UseVisualStyleBackColor = false;
            this.btnInsertTipoPrenda.Click += new System.EventHandler(this.btnInsertTipoPrenda_Click);
            // 
            // btnCerrarInsertTipPrenda
            // 
            this.btnCerrarInsertTipPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInsertTipPrenda.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnCerrarInsertTipPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarInsertTipPrenda.Location = new System.Drawing.Point(228, 190);
            this.btnCerrarInsertTipPrenda.Name = "btnCerrarInsertTipPrenda";
            this.btnCerrarInsertTipPrenda.Size = new System.Drawing.Size(81, 40);
            this.btnCerrarInsertTipPrenda.TabIndex = 24;
            this.btnCerrarInsertTipPrenda.Text = "Salir";
            this.btnCerrarInsertTipPrenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarInsertTipPrenda.UseVisualStyleBackColor = true;
            this.btnCerrarInsertTipPrenda.Click += new System.EventHandler(this.btnCerrarInsertTipPrenda_Click);
            // 
            // FrmInsTipoPrendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(573, 235);
            this.Controls.Add(this.btnCerrarInsertTipPrenda);
            this.Controls.Add(this.btnInsertTipoPrenda);
            this.Controls.Add(this.txtintTipPunt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsTipoPrendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsTipoPrendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtintTipPunt;
        private System.Windows.Forms.Button btnInsertTipoPrenda;
        private System.Windows.Forms.Button btnCerrarInsertTipPrenda;
    }
}