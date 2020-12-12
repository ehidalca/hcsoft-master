namespace WindowsPOS
{
    partial class FrmSedes
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
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridSedes = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSedes)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sedes";
            // 
            // DataGridSedes
            // 
            this.DataGridSedes.AllowUserToAddRows = false;
            this.DataGridSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSedes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.Codigo,
            this.Categoria,
            this.IdCategoria});
            this.DataGridSedes.Location = new System.Drawing.Point(33, 101);
            this.DataGridSedes.Name = "DataGridSedes";
            this.DataGridSedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSedes.Size = new System.Drawing.Size(810, 323);
            this.DataGridSedes.TabIndex = 8;
            this.DataGridSedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSedes_CellClick);
            this.DataGridSedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSedes_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccionar";
            this.Seleccion.Image = global::WindowsPOS.Properties.Resources.lupa;
            this.Seleccion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Nombre";
            this.Categoria.HeaderText = "Nombre";
            this.Categoria.Name = "Categoria";
            this.Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Categoria.Width = 250;
            // 
            // IdCategoria
            // 
            this.IdCategoria.DataPropertyName = "Id";
            this.IdCategoria.HeaderText = "Column1";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(710, 52);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 43);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Añadir";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(878, 507);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.DataGridSedes);
            this.Controls.Add(this.label3);
            this.Name = "FrmSedes";
            this.Text = "Mantenedor Sedes";
            this.Load += new System.EventHandler(this.FrmSedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSedes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridSedes;
        private System.Windows.Forms.DataGridViewImageColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.Button btnNuevo;
    }
}