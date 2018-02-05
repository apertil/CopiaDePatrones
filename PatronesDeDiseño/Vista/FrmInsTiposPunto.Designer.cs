namespace PatronesDeDiseño.Vista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtintippunt = new System.Windows.Forms.TextBox();
            this.btnCerrarInsertTipPunto = new System.Windows.Forms.Button();
            this.btnInsertTipoPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "The Knitting Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Insertar Tipo de Punto";
            // 
            // txtintippunt
            // 
            this.txtintippunt.Location = new System.Drawing.Point(165, 142);
            this.txtintippunt.Name = "txtintippunt";
            this.txtintippunt.Size = new System.Drawing.Size(409, 20);
            this.txtintippunt.TabIndex = 6;
            // 
            // btnCerrarInsertTipPunto
            // 
            this.btnCerrarInsertTipPunto.Location = new System.Drawing.Point(233, 262);
            this.btnCerrarInsertTipPunto.Name = "btnCerrarInsertTipPunto";
            this.btnCerrarInsertTipPunto.Size = new System.Drawing.Size(141, 30);
            this.btnCerrarInsertTipPunto.TabIndex = 7;
            this.btnCerrarInsertTipPunto.Text = "Cerrar";
            this.btnCerrarInsertTipPunto.UseVisualStyleBackColor = true;
            this.btnCerrarInsertTipPunto.Click += new System.EventHandler(this.btnCerrarInsertTipPunto_Click);
            // 
            // btnInsertTipoPunto
            // 
            this.btnInsertTipoPunto.Location = new System.Drawing.Point(243, 182);
            this.btnInsertTipoPunto.Name = "btnInsertTipoPunto";
            this.btnInsertTipoPunto.Size = new System.Drawing.Size(122, 53);
            this.btnInsertTipoPunto.TabIndex = 8;
            this.btnInsertTipoPunto.Text = "Insertar Tipo de Punto";
            this.btnInsertTipoPunto.UseVisualStyleBackColor = true;
            this.btnInsertTipoPunto.Click += new System.EventHandler(this.btnInsertTipoPunto_Click);
            // 
            // FrmInsTiposPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 314);
            this.Controls.Add(this.btnInsertTipoPunto);
            this.Controls.Add(this.btnCerrarInsertTipPunto);
            this.Controls.Add(this.txtintippunt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInsTiposPunto";
            this.Text = "Insertar Tipos de Punto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtintippunt;
        private System.Windows.Forms.Button btnCerrarInsertTipPunto;
        private System.Windows.Forms.Button btnInsertTipoPunto;
    }
}