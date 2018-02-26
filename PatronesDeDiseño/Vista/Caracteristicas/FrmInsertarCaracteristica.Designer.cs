namespace PatronesDeDiseño.Vista.Caracteristicas
{
    partial class FrmInsertarCaracteristica
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
            this.btnCerrarInsertCaracteristica = new System.Windows.Forms.Button();
            this.btnInsertCaracteristica = new System.Windows.Forms.Button();
            this.txtintCaracteristica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarInsertCaracteristica
            // 
            this.btnCerrarInsertCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInsertCaracteristica.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnCerrarInsertCaracteristica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarInsertCaracteristica.Location = new System.Drawing.Point(234, 190);
            this.btnCerrarInsertCaracteristica.Name = "btnCerrarInsertCaracteristica";
            this.btnCerrarInsertCaracteristica.Size = new System.Drawing.Size(81, 40);
            this.btnCerrarInsertCaracteristica.TabIndex = 30;
            this.btnCerrarInsertCaracteristica.Text = "Salir";
            this.btnCerrarInsertCaracteristica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarInsertCaracteristica.UseVisualStyleBackColor = true;
            this.btnCerrarInsertCaracteristica.Click += new System.EventHandler(this.btnCerrarInsertCaracteristica_Click);
            // 
            // btnInsertCaracteristica
            // 
            this.btnInsertCaracteristica.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnInsertCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertCaracteristica.Image = global::PatronesDeDiseño.Properties.Resources.download;
            this.btnInsertCaracteristica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertCaracteristica.Location = new System.Drawing.Point(415, 141);
            this.btnInsertCaracteristica.Name = "btnInsertCaracteristica";
            this.btnInsertCaracteristica.Size = new System.Drawing.Size(135, 34);
            this.btnInsertCaracteristica.TabIndex = 29;
            this.btnInsertCaracteristica.Text = "Insertar Ahora";
            this.btnInsertCaracteristica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertCaracteristica.UseVisualStyleBackColor = false;
            this.btnInsertCaracteristica.Click += new System.EventHandler(this.btnInsertCaracteristica_Click);
            // 
            // txtintCaracteristica
            // 
            this.txtintCaracteristica.Location = new System.Drawing.Point(125, 146);
            this.txtintCaracteristica.Name = "txtintCaracteristica";
            this.txtintCaracteristica.Size = new System.Drawing.Size(264, 20);
            this.txtintCaracteristica.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Caracteristica";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(63, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 26;
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
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Insertar Caracteristica";
            // 
            // FrmInsertarCaracteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 235);
            this.Controls.Add(this.btnCerrarInsertCaracteristica);
            this.Controls.Add(this.btnInsertCaracteristica);
            this.Controls.Add(this.txtintCaracteristica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertarCaracteristica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertarCaracteristica";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarInsertCaracteristica;
        private System.Windows.Forms.Button btnInsertCaracteristica;
        private System.Windows.Forms.TextBox txtintCaracteristica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}