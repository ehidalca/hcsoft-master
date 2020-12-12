namespace HCSoft.POS.WinApp
{
    partial class FrmConfiguracion
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
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnUnidadesMedida = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnFolios = new System.Windows.Forms.Button();
            this.btnCajas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.pnlFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.btnSucursales);
            this.pnlFormulario.Controls.Add(this.btnUsuarios);
            this.pnlFormulario.Controls.Add(this.btnUnidadesMedida);
            this.pnlFormulario.Controls.Add(this.btnProductos);
            this.pnlFormulario.Controls.Add(this.btnCategorias);
            this.pnlFormulario.Controls.Add(this.btnFolios);
            this.pnlFormulario.Controls.Add(this.btnCajas);
            this.pnlFormulario.Location = new System.Drawing.Point(9, 53);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(1124, 695);
            this.pnlFormulario.TabIndex = 6;
            this.pnlFormulario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormulario_Paint);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(627, 15);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(116, 92);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnUnidadesMedida
            // 
            this.btnUnidadesMedida.BackColor = System.Drawing.Color.Orange;
            this.btnUnidadesMedida.FlatAppearance.BorderSize = 0;
            this.btnUnidadesMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidadesMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidadesMedida.Location = new System.Drawing.Point(505, 15);
            this.btnUnidadesMedida.Name = "btnUnidadesMedida";
            this.btnUnidadesMedida.Size = new System.Drawing.Size(116, 92);
            this.btnUnidadesMedida.TabIndex = 4;
            this.btnUnidadesMedida.Text = "Unidades de Medida";
            this.btnUnidadesMedida.UseVisualStyleBackColor = false;
            this.btnUnidadesMedida.Click += new System.EventHandler(this.btnUnidadesMedida_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.LightBlue;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(261, 15);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(116, 92);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Location = new System.Drawing.Point(383, 15);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(116, 92);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnFolios
            // 
            this.btnFolios.BackColor = System.Drawing.Color.Olive;
            this.btnFolios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolios.Location = new System.Drawing.Point(139, 15);
            this.btnFolios.Name = "btnFolios";
            this.btnFolios.Size = new System.Drawing.Size(116, 92);
            this.btnFolios.TabIndex = 1;
            this.btnFolios.Text = "Folios";
            this.btnFolios.UseVisualStyleBackColor = false;
            this.btnFolios.Click += new System.EventHandler(this.btnFolios_Click_1);
            // 
            // btnCajas
            // 
            this.btnCajas.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCajas.Location = new System.Drawing.Point(17, 113);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(116, 92);
            this.btnCajas.TabIndex = 0;
            this.btnCajas.Text = "Cajas";
            this.btnCajas.UseVisualStyleBackColor = false;
            this.btnCajas.Click += new System.EventHandler(this.btnCajas_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Configuración";
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSucursales.FlatAppearance.BorderSize = 0;
            this.btnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucursales.Location = new System.Drawing.Point(17, 15);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(116, 92);
            this.btnSucursales.TabIndex = 6;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = false;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFormulario);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.pnlFormulario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Button btnCajas;
        private System.Windows.Forms.Button btnFolios;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUnidadesMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnSucursales;
    }
}