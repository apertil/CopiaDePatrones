namespace PatronesDeDiseño.Vista.Lanas
{
    partial class FrmConsultaLanas
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsultarLana = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarLana = new System.Windows.Forms.Button();
            this.btnSalirConsultarLana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridLanas = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(52, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 16;
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
            // txtConsultarLana
            // 
            this.txtConsultarLana.BackColor = System.Drawing.Color.White;
            this.txtConsultarLana.Location = new System.Drawing.Point(171, 146);
            this.txtConsultarLana.Name = "txtConsultarLana";
            this.txtConsultarLana.Size = new System.Drawing.Size(170, 20);
            this.txtConsultarLana.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Lana";
            // 
            // btnConsultarLana
            // 
            this.btnConsultarLana.BackColor = System.Drawing.Color.White;
            this.btnConsultarLana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarLana.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnConsultarLana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarLana.Location = new System.Drawing.Point(393, 138);
            this.btnConsultarLana.Name = "btnConsultarLana";
            this.btnConsultarLana.Size = new System.Drawing.Size(122, 34);
            this.btnConsultarLana.TabIndex = 18;
            this.btnConsultarLana.Text = "Buscar Lana";
            this.btnConsultarLana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarLana.UseVisualStyleBackColor = false;
            this.btnConsultarLana.Click += new System.EventHandler(this.btnConsultarLana_Click);
            // 
            // btnSalirConsultarLana
            // 
            this.btnSalirConsultarLana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsultarLana.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirConsultarLana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirConsultarLana.Location = new System.Drawing.Point(220, 369);
            this.btnSalirConsultarLana.Name = "btnSalirConsultarLana";
            this.btnSalirConsultarLana.Size = new System.Drawing.Size(88, 42);
            this.btnSalirConsultarLana.TabIndex = 20;
            this.btnSalirConsultarLana.Text = "Salir";
            this.btnSalirConsultarLana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirConsultarLana.UseVisualStyleBackColor = true;
            this.btnSalirConsultarLana.Click += new System.EventHandler(this.btnSalirConsultarLana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "*Para consultar todas las lanas dejar en blanco";
            // 
            // dataGridLanas
            // 
            this.dataGridLanas.AutoGenerateColumns = false;
            this.dataGridLanas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLanas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridLanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLanas.DataSource = this.bindingSource1;
            this.dataGridLanas.Location = new System.Drawing.Point(136, 203);
            this.dataGridLanas.Name = "dataGridLanas";
            this.dataGridLanas.Size = new System.Drawing.Size(261, 150);
            this.dataGridLanas.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Consulta Tipos de lana";
            // 
            // FrmConsultaLanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridLanas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirConsultarLana);
            this.Controls.Add(this.txtConsultarLana);
            this.Controls.Add(this.btnConsultarLana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaLanas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Stock Lanas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConsultarLana;
        private System.Windows.Forms.Button btnConsultarLana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalirConsultarLana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridLanas;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
    }
}