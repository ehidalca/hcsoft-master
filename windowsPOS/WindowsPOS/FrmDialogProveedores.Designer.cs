namespace HCSoft.POS.WinApp
{
    partial class FrmDialogProveedores
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
            this.btnBusquedaProveedores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GrillaProducto = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusquedaProveedores
            // 
            this.btnBusquedaProveedores.BackColor = System.Drawing.Color.White;
            this.btnBusquedaProveedores.FlatAppearance.BorderSize = 0;
            this.btnBusquedaProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaProveedores.Image = global::WindowsPOS.Properties.Resources.buscar_grilla;
            this.btnBusquedaProveedores.Location = new System.Drawing.Point(681, 26);
            this.btnBusquedaProveedores.Name = "btnBusquedaProveedores";
            this.btnBusquedaProveedores.Size = new System.Drawing.Size(35, 33);
            this.btnBusquedaProveedores.TabIndex = 14;
            this.btnBusquedaProveedores.UseVisualStyleBackColor = false;
            this.btnBusquedaProveedores.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(435, 30);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(246, 29);
            this.txtBusqueda.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Busqueda de Proveedores";
            // 
            // GrillaProducto
            // 
            this.GrillaProducto.AllowUserToAddRows = false;
            this.GrillaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.id,
            this.nombre,
            this.direccion,
            this.contacto});
            this.GrillaProducto.Location = new System.Drawing.Point(17, 76);
            this.GrillaProducto.Name = "GrillaProducto";
            this.GrillaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaProducto.Size = new System.Drawing.Size(699, 310);
            this.GrillaProducto.TabIndex = 1;
            this.GrillaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaProducto_CellClick);
           
            // 
            // Seleccion
            // 
            this.Seleccion.FillWeight = 30F;
            this.Seleccion.HeaderText = "Seleccionar";
            this.Seleccion.Image = global::WindowsPOS.Properties.Resources.lupa;
            this.Seleccion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccion.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "dirección";
            this.direccion.Name = "direccion";
            this.direccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.direccion.Width = 250;
            // 
            // contacto
            // 
            this.contacto.DataPropertyName = "contacto";
            this.contacto.HeaderText = "contacto";
            this.contacto.Name = "contacto";
            // 
            // FrmDialogProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 400);
            this.Controls.Add(this.GrillaProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBusquedaProveedores);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBusqueda);
            this.Name = "FrmDialogProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscador de Proveedores";
            this.Load += new System.EventHandler(this.FrmDialogProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusquedaProveedores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView GrillaProducto;
        private System.Windows.Forms.DataGridViewImageColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
    }
}