namespace HCSoft.POS.WinApp
{
    partial class FrmVentas
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pnlInventario
            // 
            this.pnlInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInventario.Location = new System.Drawing.Point(12, 101);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(1049, 605);
            this.pnlInventario.TabIndex = 9;
            this.pnlInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInventario_Paint);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1079, 40);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepcionarToolStripMenuItem,
            this.moverToolStripMenuItem,
            this.devolverToolStripMenuItem});
            this.inventarioToolStripMenuItem.Image = global::WindowsPOS.Properties.Resources.inventario2;
            this.inventarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.inventarioToolStripMenuItem.Text = "Ventas";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // recepcionarToolStripMenuItem
            // 
            this.recepcionarToolStripMenuItem.Name = "recepcionarToolStripMenuItem";
            this.recepcionarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.recepcionarToolStripMenuItem.Text = "Buscar";
            this.recepcionarToolStripMenuItem.Click += new System.EventHandler(this.recepcionarToolStripMenuItem_Click);
            // 
            // moverToolStripMenuItem
            // 
            this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
            this.moverToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.moverToolStripMenuItem.Text = "Mover";
            this.moverToolStripMenuItem.Click += new System.EventHandler(this.moverToolStripMenuItem_Click);
            // 
            // devolverToolStripMenuItem
            // 
            this.devolverToolStripMenuItem.Name = "devolverToolStripMenuItem";
            this.devolverToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.devolverToolStripMenuItem.Text = "Devolver";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Image = global::WindowsPOS.Properties.Resources.reporte;
            this.reporteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.reporteToolStripMenuItem.Text = "Reportes";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(955, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ventas";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 721);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlInventario);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem recepcionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
    }
}