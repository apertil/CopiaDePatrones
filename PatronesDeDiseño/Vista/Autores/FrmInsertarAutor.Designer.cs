namespace PatronesDeDiseño.Vista.Autores
{
    partial class FrmInsertarAutor
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
            this.txtintAutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarInsertAutor = new System.Windows.Forms.Button();
            this.btnInsertAutor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtintAutor
            // 
            this.txtintAutor.Location = new System.Drawing.Point(127, 144);
            this.txtintAutor.Name = "txtintAutor";
            this.txtintAutor.Size = new System.Drawing.Size(264, 20);
            this.txtintAutor.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Autor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(65, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 32;
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
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Insertar Autor";
            // 
            // btnCerrarInsertAutor
            // 
            this.btnCerrarInsertAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarInsertAutor.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnCerrarInsertAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarInsertAutor.Location = new System.Drawing.Point(236, 188);
            this.btnCerrarInsertAutor.Name = "btnCerrarInsertAutor";
            this.btnCerrarInsertAutor.Size = new System.Drawing.Size(81, 40);
            this.btnCerrarInsertAutor.TabIndex = 36;
            this.btnCerrarInsertAutor.Text = "Salir";
            this.btnCerrarInsertAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarInsertAutor.UseVisualStyleBackColor = true;
            this.btnCerrarInsertAutor.Click += new System.EventHandler(this.btnCerrarInsertAutor_Click);
            // 
            // btnInsertAutor
            // 
            this.btnInsertAutor.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnInsertAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertAutor.Image = global::PatronesDeDiseño.Properties.Resources.download;
            this.btnInsertAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertAutor.Location = new System.Drawing.Point(417, 139);
            this.btnInsertAutor.Name = "btnInsertAutor";
            this.btnInsertAutor.Size = new System.Drawing.Size(135, 34);
            this.btnInsertAutor.TabIndex = 35;
            this.btnInsertAutor.Text = "Insertar Ahora";
            this.btnInsertAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertAutor.UseVisualStyleBackColor = false;
            this.btnInsertAutor.Click += new System.EventHandler(this.btnInsertAutor_Click);
            // 
            // FrmInsertarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(573, 235);
            this.Controls.Add(this.btnCerrarInsertAutor);
            this.Controls.Add(this.btnInsertAutor);
            this.Controls.Add(this.txtintAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInsertarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertarAutor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarInsertAutor;
        private System.Windows.Forms.Button btnInsertAutor;
        private System.Windows.Forms.TextBox txtintAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}