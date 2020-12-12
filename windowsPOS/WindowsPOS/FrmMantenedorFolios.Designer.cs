namespace HCSoft.POS.WinApp
{
    partial class FrmFolios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridfolios = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioSiguiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridfolios)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridfolios
            // 
            this.datagridfolios.AllowUserToAddRows = false;
            this.datagridfolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridfolios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.nombreCaja,
            this.tipoDocumento,
            this.folioInicial,
            this.folioSiguiente,
            this.folioTermino,
            this.id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridfolios.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridfolios.Location = new System.Drawing.Point(83, 98);
            this.datagridfolios.Name = "datagridfolios";
            this.datagridfolios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridfolios.Size = new System.Drawing.Size(746, 367);
            this.datagridfolios.TabIndex = 22;
            this.datagridfolios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridfolios_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(21, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Folios";
            // 
            // button1
            // 
            this.button1.Image = global::WindowsPOS.Properties.Resources.icons8_cancel_40;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(362, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 43;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::WindowsPOS.Properties.Resources.icons8_restart_48;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(523, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 47);
            this.button3.TabIndex = 42;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = global::WindowsPOS.Properties.Resources.icons8_add_new_40;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(679, 33);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(150, 47);
            this.btn_nuevo.TabIndex = 41;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Image = global::WindowsPOS.Properties.Resources.buscar_grilla;
            this.Select.Name = "Select";
            this.Select.Width = 50;
            // 
            // nombreCaja
            // 
            this.nombreCaja.DataPropertyName = "nombreCaja";
            this.nombreCaja.HeaderText = "Nombre Caja";
            this.nombreCaja.Name = "nombreCaja";
            this.nombreCaja.Width = 250;
            // 
            // tipoDocumento
            // 
            this.tipoDocumento.DataPropertyName = "tipoDocumento";
            this.tipoDocumento.HeaderText = "TIpo Documento";
            this.tipoDocumento.Name = "tipoDocumento";
            // 
            // folioInicial
            // 
            this.folioInicial.DataPropertyName = "folioInicial";
            this.folioInicial.HeaderText = "Folio Inicial";
            this.folioInicial.Name = "folioInicial";
            // 
            // folioSiguiente
            // 
            this.folioSiguiente.DataPropertyName = "folioSiguiente";
            this.folioSiguiente.HeaderText = "Folio Siguiente";
            this.folioSiguiente.Name = "folioSiguiente";
            // 
            // folioTermino
            // 
            this.folioTermino.DataPropertyName = "folioTermino";
            this.folioTermino.HeaderText = "Folio Termino";
            this.folioTermino.Name = "folioTermino";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // FrmFolios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datagridfolios);
            this.Name = "FrmFolios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmFolios";
            this.Load += new System.EventHandler(this.FrmFolios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridfolios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datagridfolios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioSiguiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioTermino;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}