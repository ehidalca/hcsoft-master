namespace HCSoft.POS.WinApp
{
    partial class FrmDialogProductos
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.GrillaProducto = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBusqueda.Location = new System.Drawing.Point(428, 52);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(246, 29);
            this.txtBusqueda.TabIndex = 2;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // GrillaProducto
            // 
            this.GrillaProducto.AllowUserToAddRows = false;
            this.GrillaProducto.BackgroundColor = System.Drawing.Color.White;
            this.GrillaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen,
            this.Codigo,
            this.Categoria,
            this.id,
            this.nombreImagen});
            this.GrillaProducto.GridColor = System.Drawing.Color.White;
            this.GrillaProducto.Location = new System.Drawing.Point(17, 116);
            this.GrillaProducto.Name = "GrillaProducto";
            this.GrillaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaProducto.Size = new System.Drawing.Size(699, 310);
            this.GrillaProducto.TabIndex = 1;
            this.GrillaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProducto_CellClick);
            this.GrillaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProducto_CellContentClick);
            this.GrillaProducto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrillaProducto_CellFormatting);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 25);
            this.label9.TabIndex = 40;
            this.label9.Text = "Buscador de Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ingrese palabra para buscar;";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Seleccionar";
            this.dataGridViewImageColumn1.Image = global::WindowsPOS.Properties.Resources.lupa;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.BackColor = System.Drawing.Color.White;
            this.btnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductos.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarProductos.Image = global::WindowsPOS.Properties.Resources.buscar_grilla;
            this.btnBuscarProductos.Location = new System.Drawing.Point(680, 52);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(35, 33);
            this.btnBuscarProductos.TabIndex = 14;
            this.btnBuscarProductos.UseVisualStyleBackColor = false;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // Imagen
            // 
            this.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Imagen.MinimumWidth = 100;
            this.Imagen.Name = "Imagen";
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.Categoria.HeaderText = "Producto";
            this.Categoria.Name = "Categoria";
            this.Categoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Categoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Categoria.Width = 250;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // nombreImagen
            // 
            this.nombreImagen.DataPropertyName = "imagen";
            this.nombreImagen.HeaderText = "nombreImagen";
            this.nombreImagen.Name = "nombreImagen";
            this.nombreImagen.Visible = false;
            // 
            // FrmDialogProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.GrillaProducto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialogProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscador de Productos";
            this.Load += new System.EventHandler(this.FrmDialogProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView GrillaProducto;
        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreImagen;
    }
}