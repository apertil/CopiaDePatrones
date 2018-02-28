namespace PatronesDeDiseño.Vista.Lanas
{
    partial class FrmModificarLanas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarLanas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarLana = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalirModificarLana = new System.Windows.Forms.Button();
            this.btnModificalana = new System.Windows.Forms.Button();
            this.btnBuscarLana = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridModifLana = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModifLana)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "The Knitting Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de la lana a buscar";
            // 
            // txtBuscarLana
            // 
            this.txtBuscarLana.Location = new System.Drawing.Point(231, 148);
            this.txtBuscarLana.Name = "txtBuscarLana";
            this.txtBuscarLana.Size = new System.Drawing.Size(138, 20);
            this.txtBuscarLana.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(83, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 84);
            this.panel1.TabIndex = 14;
            // 
            // btnSalirModificarLana
            // 
            this.btnSalirModificarLana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirModificarLana.Image = global::PatronesDeDiseño.Properties.Resources.exit;
            this.btnSalirModificarLana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirModificarLana.Location = new System.Drawing.Point(217, 360);
            this.btnSalirModificarLana.Name = "btnSalirModificarLana";
            this.btnSalirModificarLana.Size = new System.Drawing.Size(88, 42);
            this.btnSalirModificarLana.TabIndex = 13;
            this.btnSalirModificarLana.Text = "Salir";
            this.btnSalirModificarLana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirModificarLana.UseVisualStyleBackColor = true;
            this.btnSalirModificarLana.Click += new System.EventHandler(this.btnSalirModificarLana_Click);
            // 
            // btnModificalana
            // 
            this.btnModificalana.Enabled = false;
            this.btnModificalana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificalana.Image = global::PatronesDeDiseño.Properties.Resources.config1;
            this.btnModificalana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificalana.Location = new System.Drawing.Point(441, 263);
            this.btnModificalana.Name = "btnModificalana";
            this.btnModificalana.Size = new System.Drawing.Size(122, 35);
            this.btnModificalana.TabIndex = 12;
            this.btnModificalana.Text = "Modifica lana";
            this.btnModificalana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificalana.UseVisualStyleBackColor = true;
            this.btnModificalana.Click += new System.EventHandler(this.btnModificalana_Click);
            // 
            // btnBuscarLana
            // 
            this.btnBuscarLana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLana.Image = global::PatronesDeDiseño.Properties.Resources.find;
            this.btnBuscarLana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLana.Location = new System.Drawing.Point(441, 182);
            this.btnBuscarLana.Name = "btnBuscarLana";
            this.btnBuscarLana.Size = new System.Drawing.Size(122, 34);
            this.btnBuscarLana.TabIndex = 9;
            this.btnBuscarLana.Text = "Buscar Lana";
            this.btnBuscarLana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLana.UseVisualStyleBackColor = true;
            this.btnBuscarLana.Click += new System.EventHandler(this.btnBuscarLana_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Modificar Lana";
            // 
            // dataGridModifLana
            // 
            this.dataGridModifLana.AllowUserToAddRows = false;
            this.dataGridModifLana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridModifLana.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridModifLana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModifLana.Location = new System.Drawing.Point(113, 182);
            this.dataGridModifLana.Name = "dataGridModifLana";
            this.dataGridModifLana.Size = new System.Drawing.Size(269, 150);
            this.dataGridModifLana.TabIndex = 47;
            // 
            // FrmModificarLanas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(652, 429);
            this.Controls.Add(this.dataGridModifLana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalirModificarLana);
            this.Controls.Add(this.btnModificalana);
            this.Controls.Add(this.btnBuscarLana);
            this.Controls.Add(this.txtBuscarLana);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarLanas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Lanas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModifLana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarLana;
        private System.Windows.Forms.Button btnBuscarLana;
        private System.Windows.Forms.Button btnModificalana;
        private System.Windows.Forms.Button btnSalirModificarLana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridModifLana;
    }
}